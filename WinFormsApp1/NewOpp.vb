Imports System.Data.Odbc

Public Class frmNewOpp
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmNewAccount.Show()
    End Sub

    Private Sub frmNewOpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountsCombo()
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


End Class