Imports System.Data.Odbc
Imports IBM.Data.DB2
Imports System.ComponentModel

Public Class frmNewOpp

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property IsEditMode As Boolean

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property OpportunityId As Integer

    ' Optional initial account selection when creating a new opportunity
    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property SelectedAccountId As Integer = 0



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmNewAccount.Show()
        LoadAccountsCombo()
    End Sub

    Private Sub frmNewOpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStagesCombo()
        LoadAccountsCombo()
        ' If an initial account was provided, select it (only when not editing)
        If Not IsEditMode AndAlso SelectedAccountId > 0 Then
            Try
                cboAccounts.SelectedValue = SelectedAccountId
            Catch
                ' ignore if value not found
            End Try
        End If
        If IsEditMode Then
            Dim sql As String = "SELECT * FROM OPPORTUNITIES WHERE OPPORTUNITY_ID = ?"
            Using cmd As New OdbcCommand(sql, Db2ConnectionManager.Connection)
                cmd.Parameters.Add("?", OdbcType.Int).Value = OpportunityId
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtOppName.Text = reader("NAME").ToString()
                        If Not IsDBNull(reader("ACCOUNT_ID")) Then
                            cboAccounts.SelectedValue = CInt(reader("ACCOUNT_ID"))
                        Else
                            cboAccounts.SelectedIndex = -1   ' no selection
                        End If
                        txtFolderPath.Text = reader("LOCAL_FOLDER").ToString()
                        txtCRMurl.Text = reader("CRM_URL").ToString()
                        dtpOppCreationDate.Value = CDate(reader("CREATION_DATE"))
                        dpOppEstCloseDate.Value = CDate(reader("CLOSE_DATE"))
                        If Not IsDBNull(reader("CURRENT_STAGE_ID")) Then
                            cboOppStage.SelectedValue = CInt(reader("CURRENT_STAGE_ID"))
                        Else
                            cboOppStage.SelectedIndex = -1   ' no selection
                        End If
                        txtOppAmount.Text = reader("AMOUNT").ToString()
                        txtOppID.Text = OpportunityId.ToString()
                    End If
                End Using
            End Using
        End If


        dtpOppCreationDate.Value = DateTime.Now
        btnCreateOpp.Text = "Save"

    End Sub
    Private Sub LoadStagesCombo()
        Dim sql As String = "SELECT STAGE_ID, STAGE_NAME FROM OPPORTUNITY_STAGES ORDER BY STAGE_ORDER"
        Using cmd As New OdbcCommand(sql, Db2ConnectionManager.Connection)
            Using reader = cmd.ExecuteReader()
                Dim dt As New DataTable()
                dt.Load(reader)

                cboOppStage.DataSource = dt
                cboOppStage.DisplayMember = "STAGE_NAME"
                cboOppStage.ValueMember = "STAGE_ID"
            End Using
        End Using
    End Sub
    Private Sub btnBrowseforFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseforFolder.Click, btnGotoURL.Click
        ' Create the dialog
        Using fbd As New FolderBrowserDialog
            fbd.Description = "Select a folder"
            fbd.ShowNewFolderButton = True

            ' Show the dialog and check result
            If fbd.ShowDialog = DialogResult.OK Then
                ' Display the selected path (for example in a TextBox or Label)
                txtFolderPath.Text = fbd.SelectedPath
            End If
        End Using

    End Sub
    Private Sub LoadAccountsCombo()
        ' Get the shared connection
        Dim conn As OdbcConnection = Db2ConnectionManager.Connection

        ' Query all accounts
        Dim sql As String = "SELECT ACCOUNT_ID, NAME FROM ACCOUNTS ORDER BY NAME"
        Dim adapter As New OdbcDataAdapter(sql, conn)
        Dim dt As New DataTable()

        adapter.Fill(dt)

        ' Bind the DataTable to the ComboBox
        cboAccounts.DataSource = dt
        cboAccounts.DisplayMember = "NAME"   ' what the user sees
        cboAccounts.ValueMember = "ACCOUNT_ID"               ' hidden ID value
    End Sub

    Private Sub btnCreateOpp_Click(sender As Object, e As EventArgs) Handles btnCreateOpp.Click
        Dim sql As String
        ' Validate minimal inputs (optional but recommended)
        If String.IsNullOrWhiteSpace(txtOppName.Text) Then
            MessageBox.Show("Opportunity name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If cboAccounts.SelectedValue Is Nothing Then
            MessageBox.Show("Please select an account.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim amountValue As Decimal
        If Not Decimal.TryParse(txtOppAmount.Text, amountValue) Then
            MessageBox.Show("Amount must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            ' INSERT without OPP_ID (Db2 generates it as IDENTITY)
            If IsEditMode Then
                sql = "UPDATE OPPORTUNITIES " &
          "SET NAME=?, ACCOUNT_ID=?, LOCAL_FOLDER=?, CRM_URL=?, CREATION_DATE=?, CLOSE_DATE=?, CURRENT_STAGE_ID=?, AMOUNT=?, OWNER_ID=? " &
          "WHERE OPPORTUNITY_ID=?"
            Else
                sql = "INSERT INTO OPPORTUNITIES " &
          "(NAME, ACCOUNT_ID, LOCAL_FOLDER, CRM_URL, CREATION_DATE, CLOSE_DATE, CURRENT_STAGE_ID, AMOUNT, OWNER_ID) " &
          "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
            End If



            Using cmd As New OdbcCommand(sql, Db2ConnectionManager.Connection)
                ' Map parameters to form controls
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtOppName.Text.Trim()
                cmd.Parameters.Add("?", OdbcType.Int).Value = CInt(cboAccounts.SelectedValue)
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtFolderPath.Text.Trim()
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtCRMurl.Text.Trim()
                cmd.Parameters.Add("?", OdbcType.Date).Value = dtpOppCreationDate.Value.Date
                cmd.Parameters.Add("?", OdbcType.Date).Value = dpOppEstCloseDate.Value.Date
                cmd.Parameters.Add("?", OdbcType.Int).Value =
                If(cboOppStage.SelectedValue Is Nothing, DBNull.Value, CInt(cboOppStage.SelectedValue))
                cmd.Parameters.Add("?", OdbcType.Decimal).Value = Decimal.Parse(txtOppAmount.Text)
                cmd.Parameters.Add("?", OdbcType.Int).Value = 1   ' OwnerID hardcoded

                If IsEditMode Then
                    cmd.Parameters.Add("?", OdbcType.Int).Value = OpportunityId
                End If
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    If Not IsEditMode Then
                        Using idCmd As New OdbcCommand("SELECT IDENTITY_VAL_LOCAL() FROM OPPORTUNITIES", Db2ConnectionManager.Connection)
                            Dim result = idCmd.ExecuteScalar()
                            If result IsNot Nothing Then
                                txtOppID.Text = result.ToString()
                            End If
                        End Using
                        MessageBox.Show("New opportunity created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btnCreateOpp.Enabled = False
                    Else
                        MessageBox.Show("Opportunity details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("No records were inserted or updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating opportunity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

End Class