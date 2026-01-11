Imports System.Data.Odbc
Imports IBM.Data.DB2

Public Class frmNewOpp

    Public Property IsEditMode As Boolean
    Public Property OpportunityId As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmNewAccount.Show()
        LoadAccountsCombo()
    End Sub

    Private Sub frmNewOpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsEditMode Then
            Dim sql As String = "SELECT * FROM OPPORTUNITIES WHERE OPPORTUNITY_ID = ?"
            Using cmd As New OdbcCommand(sql, Db2ConnectionManager.Connection)
                cmd.Parameters.Add("?", OdbcType.Int).Value = OpportunityId
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtOppName.Text = reader("NAME").ToString()
                        cboAccounts.SelectedValue = reader("ACCOUNT_ID")
                        txtFolderPath.Text = reader("LOCAL_FOLDER").ToString()
                        txtCRMurl.Text = reader("CRM_URL").ToString()
                        dtpOppCreationDate.Value = CDate(reader("CREATION_DATE"))
                        dpOppEstCloseDate.Value = CDate(reader("CLOSE_DATE"))
                        cboOppStage.SelectedItem = reader("STAGE").ToString()
                        txtOppAmount.Text = reader("AMOUNT").ToString()
                        txtOppID.Text = OpportunityId.ToString()
                    End If
                End Using
            End Using
        End If


        LoadAccountsCombo()
        dtpOppCreationDate.Value = DateTime.Now
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBrowseforFolder.Click, btnGotoURL.Click
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

    Private Sub btnCreaterOpp_Click(sender As Object, e As EventArgs) Handles btnCreaterOpp.Click
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
          "SET NAME=?, ACCOUNT_ID=?, LOCAL_FOLDER=?, CRM_URL=?, CREATION_DATE=?, CLOSE_DATE=?, STAGE=?, AMOUNT=?, OWNER_ID=? " &
          "WHERE OPPORTUNITY_ID=?"
            Else
                sql = "INSERT INTO OPPORTUNITIES " &
          "(NAME, ACCOUNT_ID, LOCAL_FOLDER, CRM_URL, CREATION_DATE, CLOSE_DATE, STAGE, AMOUNT, OWNER_ID) " &
          "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
            End If



            Using cmd As New OdbcCommand(sql, Db2ConnectionManager.Connection)
                ' Map parameters to form controls
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtOppName.Text.Trim()
                Dim strAccountID = cboAccounts.SelectedValue.ToString()
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = cboAccounts.SelectedValue.ToString()
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtFolderPath.Text.Trim()
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtCRMurl.Text.Trim()
                cmd.Parameters.Add("?", OdbcType.Date).Value = dtpOppCreationDate.Value.Date
                cmd.Parameters.Add("?", OdbcType.Date).Value = dpOppEstCloseDate.Value.Date
                cmd.Parameters.Add("?", OdbcType.VarChar).Value =
                If(cboOppStage.SelectedItem Is Nothing, "", cboOppStage.SelectedItem.ToString())
                cmd.Parameters.Add("?", OdbcType.Decimal).Value = Decimal.Parse(txtOppAmount.Text)
                'OwnerID hardcoded to FVV 
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = "1"
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    ' Retrieve the last identity value generated in this session
                    Using idCmd As New OdbcCommand("SELECT IDENTITY_VAL_LOCAL() FROM OPPORTUNITIES", Db2ConnectionManager.Connection)
                        Dim result = idCmd.ExecuteScalar()
                        If result IsNot Nothing Then
                            txtOppID.Text = result.ToString()
                        End If
                    End Using

                    MessageBox.Show("New opportunity created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No records were inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating opportunity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

End Class