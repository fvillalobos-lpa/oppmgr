Imports System.Data.Odbc
Imports IBM.Data.DB2

Public Class frmNewAccount
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCountries()
    End Sub
    Private Sub LoadCountries()
        ' This function would load countries into ComboBox1
        ' Example:
        ' ComboBox1.Items.Add("USA")
        ' ComboBox1.Items.Add("Canada")
        Dim countries As String() = {"Peru", "Ecuador", "Colombia",
            "Antigua and Barbuda", "Argentina", "Bahamas", "Barbados", "Belize",
            "Bolivia", "Brazil", "Canada", "Chile",
            "Costa Rica", "Cuba", "Dominica", "Dominican Republic",
            "El Salvador", "Grenada", "Guatemala", "Guyana", "Haiti",
            "Honduras", "Jamaica", "Mexico", "Nicaragua", "Panama",
            "Paraguay", "Saint Kitts and Nevis", "Saint Lucia",
            "Saint Vincent and the Grenadines", "Suriname", "Trinidad and Tobago",
            "United States", "Uruguay", "Venezuela"
        }

        ' Fill the ComboBox
        cboCountries.Items.AddRange(countries)

    End Sub

    Private Sub cboCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountries.SelectedIndexChanged

    End Sub

    Private Sub SaveNewAccount_Click(sender As Object, e As EventArgs) Handles SaveNewAccount.Click
        Using conn As OdbcConnection = Db2ConnectionManager.GetConnection()
            Dim sql As String = "INSERT INTO ACCOUNTS (NAME, COUNTRY) VALUES (?, ?)"
            Using cmd As New OdbcCommand(sql, conn)
                cmd.Parameters.AddWithValue("@accountName", txtAccountName.Text)
                cmd.Parameters.AddWithValue("@country", cboCountries.SelectedItem.ToString())
                cmd.ExecuteNonQuery()
            End Using

            Using idCmd As New OdbcCommand("VALUES IDENTITY_VAL_LOCAL()", conn)
                Dim newId As Integer = Convert.ToInt32(idCmd.ExecuteScalar())
                txtAccountID.Text = newId.ToString()
            End Using
        End Using
    End Sub


End Class