Public Class frmNewOpp
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmNewAccount.Show()
    End Sub

    Private Sub frmNewOpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click
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
End Class