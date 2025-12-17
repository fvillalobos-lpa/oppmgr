<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtAccountName = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        cboCountries = New ComboBox()
        SaveNewAccount = New Button()
        txtAccountID = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 0
        Label1.Text = "Account Name"
        ' 
        ' txtAccountName
        ' 
        txtAccountName.Location = New Point(126, 53)
        txtAccountName.Name = "txtAccountName"
        txtAccountName.Size = New Size(499, 23)
        txtAccountName.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(126, 83)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(499, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 2
        Label2.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 4
        Label3.Text = "Country"
        ' 
        ' cboCountries
        ' 
        cboCountries.FormattingEnabled = True
        cboCountries.Location = New Point(126, 117)
        cboCountries.Name = "cboCountries"
        cboCountries.Size = New Size(315, 23)
        cboCountries.TabIndex = 5
        ' 
        ' SaveNewAccount
        ' 
        SaveNewAccount.Location = New Point(631, 408)
        SaveNewAccount.Name = "SaveNewAccount"
        SaveNewAccount.Size = New Size(143, 25)
        SaveNewAccount.TabIndex = 6
        SaveNewAccount.Text = "Save New Account"
        SaveNewAccount.UseVisualStyleBackColor = True
        ' 
        ' txtAccountID
        ' 
        txtAccountID.Enabled = False
        txtAccountID.Location = New Point(126, 24)
        txtAccountID.Name = "txtAccountID"
        txtAccountID.Size = New Size(499, 23)
        txtAccountID.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(54, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 15)
        Label5.TabIndex = 9
        Label5.Text = "Account ID"
        ' 
        ' frmNewAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 450)
        Controls.Add(Label5)
        Controls.Add(txtAccountID)
        Controls.Add(Label4)
        Controls.Add(SaveNewAccount)
        Controls.Add(cboCountries)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(txtAccountName)
        Controls.Add(Label1)
        Name = "frmNewAccount"
        Text = "New Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCountries As ComboBox
    Friend WithEvents SaveNewAccount As Button
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
