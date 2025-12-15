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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        cboCountries = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 0
        Label1.Text = "Account Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(129, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(499, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(129, 56)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(499, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 2
        Label2.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 4
        Label3.Text = "Country"
        ' 
        ' cboCountries
        ' 
        cboCountries.FormattingEnabled = True
        cboCountries.Location = New Point(129, 90)
        cboCountries.Name = "cboCountries"
        cboCountries.Size = New Size(315, 23)
        cboCountries.TabIndex = 5
        ' 
        ' frmNewAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cboCountries)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "frmNewAccount"
        Text = "New Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCountries As ComboBox
End Class
