Public Class frmNewAccount
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCountries()
    End Sub
    Private Sub LoadCountries()
        ' This function would load countries into ComboBox1
        ' Example:
        ' ComboBox1.Items.Add("USA")
        ' ComboBox1.Items.Add("Canada")
        Dim countries As String() = {
            "Antigua and Barbuda", "Argentina", "Bahamas", "Barbados", "Belize",
            "Bolivia", "Brazil", "Canada", "Chile", "Colombia",
            "Costa Rica", "Cuba", "Dominica", "Dominican Republic", "Ecuador",
            "El Salvador", "Grenada", "Guatemala", "Guyana", "Haiti",
            "Honduras", "Jamaica", "Mexico", "Nicaragua", "Panama",
            "Paraguay", "Peru", "Saint Kitts and Nevis", "Saint Lucia",
            "Saint Vincent and the Grenadines", "Suriname", "Trinidad and Tobago",
            "United States", "Uruguay", "Venezuela"
        }

        ' Fill the ComboBox
        cboCountries.Items.AddRange(countries)

    End Sub

    Private Sub cboCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountries.SelectedIndexChanged

    End Sub
End Class