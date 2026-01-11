Imports System.Data.Odbc
Imports System.Runtime.InteropServices
Imports System.Runtime.Intrinsics

Public Class FrmMain
    Private _CurrentOpplocalPath As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        SetuplvOppFolder()

    End Sub
    Private Sub LoadOppsintoCombo()


        cboOpps.DataSource = Nothing
        cboOpps.Items.Clear()
        Dim query As String = "SELECT Opportunity_ID, Name, LOCAL_FOLDER, STAGE, CLOSE_DATE, AMOUNT FROM OPPORTUNITIES ORDER BY Name"
        Dim dt As New DataTable()

        Try
            Using da As New OdbcDataAdapter(query, Db2ConnectionManager.Connection)
                da.Fill(dt)
            End Using

            cboOpps.DataSource = dt
            cboOpps.DisplayMember = "Name"
            cboOpps.ValueMember = "Opportunity_ID"
            SetuplvOppFolder()
        Catch ex As Exception
            MessageBox.Show("Error loading opportunities: " & ex.Message)
        End Try
    End Sub

    Private Sub SetuplvOppFolder()
        lvOppFolder.Columns.Add("Name", 200, HorizontalAlignment.Left)
        lvOppFolder.Columns.Add("Size", 80, HorizontalAlignment.Right)
        lvOppFolder.Columns.Add("Date Modified", 150, HorizontalAlignment.Left)
        lvOppFolder.Columns.Add("Type", 120, HorizontalAlignment.Left)


    End Sub

    Private Sub cboOpps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpps.SelectedIndexChanged
        GetOppDataandFiles()

    End Sub



    Private Sub cboCriteriaList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCriteriaList.SelectedIndexChanged
        Dim drv As DataRowView = TryCast(cboCriteriaList.SelectedItem, DataRowView)
        If drv IsNot Nothing Then
            Dim accountId As Integer = CInt(drv("ACCOUNT_ID"))
            LoadOpportunitiesForAccount(accountId)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNewOpp.Click
        frmNewOpp.Show()
    End Sub

    Private Sub LoadOpportunitiesForAccount(accountId As Integer)
        cboOpps.DataSource = Nothing
        cboOpps.Items.Clear()

        Using cmd As New Odbc.OdbcCommand("
        SELECT OPPORTUNITY_ID, NAME , LOCAL_FOLDER
        FROM OPPORTUNITIES
        WHERE ACCOUNT_ID = ?
        ORDER BY NAME", Db2ConnectionManager.Connection)
            cmd.Parameters.AddWithValue("@accountId", accountId)

            Using da As New Odbc.OdbcDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                cboOpps.DataSource = dt
                cboOpps.DisplayMember = "NAME"       ' visible text
                cboOpps.ValueMember = "OPPORTUNITY_ID"      ' hidden key
            End Using
        End Using
    End Sub



    Private Sub btnOpenLocalFolder_Click(sender As Object, e As EventArgs) Handles btnOpenLocalFolder.Click
        If IO.Directory.Exists(_CurrentOpplocalPath) Then
            Process.Start("explorer.exe", _CurrentOpplocalPath)
        Else
            MessageBox.Show("The folder path is invalid or does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cboCriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCriteria.SelectedIndexChanged
        'cboCriteriaList.Items.Clear()

        Select Case cboCriteria.SelectedItem.ToString()
            Case "Customers"
                LoadAccountsIntoCombo()
            Case "Prospects"
            ' TODO: load prospects from your PROSPECTS table or query
            Case "Active"
            ' TODO: load active opportunities
            Case "Closed"
            ' TODO: load closed opportunities
            Case "Won"
                ' TODO: load won opportunities
        End Select

    End Sub
    Private Sub LoadAccountsIntoCombo()
        cboCriteriaList.DataSource = Nothing
        cboCriteriaList.Items.Clear()

        Using cmd As New Odbc.OdbcCommand("
        SELECT ACCOUNT_ID, NAME 
        FROM ACCOUNTS
        ORDER BY NAME", Db2ConnectionManager.Connection)

            Using da As New Odbc.OdbcDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                cboCriteriaList.DataSource = dt
                cboCriteriaList.DisplayMember = "NAME"        ' visible text
                cboCriteriaList.ValueMember = "ACCOUNT_ID"    ' hidden key
            End Using
        End Using

    End Sub
    Private Sub GetOppDataandFiles()
        Dim drv As DataRowView = TryCast(cboOpps.SelectedItem, DataRowView)
        If drv Is Nothing Then Exit Sub

        Dim id As Integer = CInt(drv("OPPORTUNITY_ID"))
        Dim OppName As String = CStr(drv("NAME"))
        'Dim desc As String = drv("DESCRIPTION").ToString()
        'Dim stage As String = If(IsDBNull(drv("STAGE")), String.Empty, drv("STAGE").ToString())
        'Dim amount As Decimal = If(IsDBNull(drv("AMOUNT")), 0D, CDec(drv("AMOUNT")))
        'Dim closeDate As Date = If(IsDBNull(drv("CLOSE_DATE")), Date.MinValue, CDate(drv("CLOSE_DATE")))

        _CurrentOpplocalPath = drv("LOCAL_FOLDER").ToString()
        'Load Files from local path
        If String.IsNullOrEmpty(_CurrentOpplocalPath) OrElse Not IO.Directory.Exists(_CurrentOpplocalPath) Then
            MessageBox.Show("Local folder not found: " & _CurrentOpplocalPath)
            Exit Sub
        End If

        ' Clear previous items
        lvOppFolder.Items.Clear()
        ilFileIcons.Images.Clear()
        lvOppFolder.View = View.Details


        Try
            ' Load files
            ' Load files and icons in a single pass
            ' Assign your ImageList for small icons
            lvOppFolder.SmallImageList = ilFileIcons
            For Each filePath As String In IO.Directory.GetFiles(_CurrentOpplocalPath)
                Dim fi As New IO.FileInfo(filePath)

                ' Extract the icon once per file
                Dim icon As Icon = Icon.ExtractAssociatedIcon(filePath)
                ilFileIcons.Images.Add(filePath, icon)

                ' Create the ListViewItem
                Dim item As New ListViewItem(fi.Name)
                item.ImageKey = filePath   ' link to the icon in ilFileIcons

                ' Size in KB
                item.SubItems.Add((fi.Length \ 1024).ToString() & " KB")

                ' Date modified
                item.SubItems.Add(fi.LastWriteTime.ToString("dd-MMM-yyyy HH:mm"))

                ' Type (extension)
                item.SubItems.Add(fi.Extension & " File")

                ' Add to ListView
                lvOppFolder.Items.Add(item)
            Next
            Application.DoEvents()

            ' Optionally load subfolders too
            For Each dirPath As String In IO.Directory.GetDirectories(_CurrentOpplocalPath)
                Dim di As New IO.DirectoryInfo(dirPath)

                ' Get folder icon
                Dim shinfo As New NativeMethods.SHFILEINFO()
                NativeMethods.SHGetFileInfo(dirPath, 0, shinfo, CUInt(Marshal.SizeOf(shinfo)), NativeMethods.SHGFI_ICON Or NativeMethods.SHGFI_SMALLICON)

                If shinfo.hIcon <> IntPtr.Zero Then
                    Using folderIcon As Icon = Icon.FromHandle(shinfo.hIcon)
                        ' Add once to ImageList
                        If Not ilFileIcons.Images.ContainsKey("folder") Then
                            ilFileIcons.Images.Add("folder", CType(folderIcon.Clone(), Icon))
                        End If
                    End Using
                    ' Free the unmanaged icon handle
                    NativeMethods.DestroyIcon(shinfo.hIcon)
                End If



                ' Create ListViewItem
                Dim item As New ListViewItem(di.Name)
                item.ImageKey = "folder"
                item.SubItems.Add("") ' no size
                item.SubItems.Add(di.LastWriteTime.ToString("dd-MMM-yyyy HH:mm"))
                item.SubItems.Add("Folder")

                lvOppFolder.Items.Add(item)


            Next

        Catch ex As Exception
            MessageBox.Show("Error loading folder contents: " & ex.Message)
        End Try

        'MessageBox.Show($"Selected Opp: {id} | {desc} | {stage} | {amount} | {closeDate:d}")
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        frmNewOpp.IsEditMode = True
        frmNewOpp.OpportunityId = cboOpps.SelectedValue.ToString()
        frmNewOpp.Show()
    End Sub
End Class
