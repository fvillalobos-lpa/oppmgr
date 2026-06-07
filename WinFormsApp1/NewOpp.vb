Imports System.Data.Odbc
Imports IBM.Data.DB2

Public Class frmNewOpp

    Public Property IsEditMode As Boolean
    Public Property OpportunityId As Integer




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        frmNewAccount.Show()
        Using conn As OdbcConnection = Db2ConnectionManager.GetConnection()
            LoadAccountsCombo(conn)
        End Using
    End Sub


    Private Sub frmNewOpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As OdbcConnection = Db2ConnectionManager.GetConnection()
            LoadStagesCombo(conn)
            LoadAccountsCombo(conn)

            If IsEditMode Then
                MessageBox.Show("IsEditMode: " & IsEditMode.ToString() & " | OpportunityId: " & OpportunityId.ToString())
                Dim sql As String = "SELECT * FROM OPPORTUNITIES WHERE OPPORTUNITY_ID = ?"
                Using cmd As New OdbcCommand(sql, conn)
                    cmd.Parameters.Add("?", OdbcType.Int).Value = OpportunityId
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtOppName.Text = reader("NAME").ToString()
                            If Not IsDBNull(reader("ACCOUNT_ID")) Then
                                cboAccounts.SelectedValue = CInt(reader("ACCOUNT_ID"))
                            Else
                                cboAccounts.SelectedIndex = -1
                            End If
                            txtFolderPath.Text = reader("LOCAL_FOLDER").ToString()
                            txtCRMurl.Text = reader("CRM_URL").ToString()
                            dtpOppCreationDate.Value = CDate(reader("CREATION_DATE"))
                            dpOppEstCloseDate.Value = CDate(reader("CLOSE_DATE"))
                            If Not IsDBNull(reader("CURRENT_STAGE_ID")) Then
                                cboOppStage.SelectedValue = CInt(reader("CURRENT_STAGE_ID"))
                            Else
                                cboOppStage.SelectedIndex = -1
                            End If
                            txtOppAmount.Text = reader("AMOUNT").ToString()
                            txtOppID.Text = OpportunityId.ToString()
                        End If
                    End Using
                End Using
                btnCreateOpp.Text = "Save"
            Else
                dtpOppCreationDate.Value = DateTime.Now
                btnCreateOpp.Text = "Create Opportunity"
            End If
        End Using
    End Sub


    Private Sub LoadStagesCombo(conn As OdbcConnection)
        Dim sql As String = "SELECT STAGE_ID, STAGE_NAME FROM OPPORTUNITY_STAGES ORDER BY STAGE_ORDER"
        Dim dt As New DataTable()
        Using da As New OdbcDataAdapter(sql, conn)
            da.Fill(dt)
        End Using
        cboOppStage.DataSource = dt
        cboOppStage.DisplayMember = "STAGE_NAME"
        cboOppStage.ValueMember = "STAGE_ID"
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
    Private Sub LoadAccountsCombo(conn As OdbcConnection)
        Dim sql As String = "SELECT ACCOUNT_ID, NAME FROM ACCOUNTS ORDER BY NAME"
        Dim dt As New DataTable()
        Using da As New OdbcDataAdapter(sql, conn)
            da.Fill(dt)
        End Using
        cboAccounts.DataSource = dt
        cboAccounts.DisplayMember = "NAME"
        cboAccounts.ValueMember = "ACCOUNT_ID"
    End Sub

    Private Sub btnCreateOpp_Click(sender As Object, e As EventArgs) Handles btnCreateOpp.Click
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
            Dim sql As String
            If IsEditMode Then
                sql = "UPDATE OPPORTUNITIES " &
                  "SET NAME=?, ACCOUNT_ID=?, LOCAL_FOLDER=?, CRM_URL=?, CREATION_DATE=?, CLOSE_DATE=?, CURRENT_STAGE_ID=?, AMOUNT=?, OWNER_ID=? " &
                  "WHERE OPPORTUNITY_ID=?"
            Else
                sql = "INSERT INTO OPPORTUNITIES " &
                  "(NAME, ACCOUNT_ID, LOCAL_FOLDER, CRM_URL, CREATION_DATE, CLOSE_DATE, CURRENT_STAGE_ID, AMOUNT, OWNER_ID) " &
                  "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
            End If

            Using conn As OdbcConnection = Db2ConnectionManager.GetConnection()
                Using cmd As New OdbcCommand(sql, conn)
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtOppName.Text.Trim()
                    cmd.Parameters.Add("?", OdbcType.Int).Value = CInt(cboAccounts.SelectedValue)
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtFolderPath.Text.Trim()
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtCRMurl.Text.Trim()
                    cmd.Parameters.Add("?", OdbcType.Date).Value = dtpOppCreationDate.Value.Date
                    cmd.Parameters.Add("?", OdbcType.Date).Value = dpOppEstCloseDate.Value.Date
                    cmd.Parameters.Add("?", OdbcType.Int).Value =
                    If(cboOppStage.SelectedValue Is Nothing, DBNull.Value, CInt(cboOppStage.SelectedValue))
                    cmd.Parameters.Add("?", OdbcType.Decimal).Value = amountValue
                    cmd.Parameters.Add("?", OdbcType.Int).Value = 1  ' OwnerID hardcoded

                    If IsEditMode Then
                        cmd.Parameters.Add("?", OdbcType.Int).Value = OpportunityId
                    End If

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        If Not IsEditMode Then
                            Using idCmd As New OdbcCommand("VALUES IDENTITY_VAL_LOCAL()", conn)
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
            End Using

        Catch ex As Exception
            MessageBox.Show("Error saving opportunity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class