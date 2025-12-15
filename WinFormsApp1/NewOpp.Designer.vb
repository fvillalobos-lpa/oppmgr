<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOpp
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
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtFolderPath = New TextBox()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Button3 = New Button()
        Label5 = New Label()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 0
        Label1.Text = "Account"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(141, 27)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(554, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(701, 29)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 21)
        Button1.TabIndex = 2
        Button1.Text = "New Account..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 15)
        Label3.TabIndex = 4
        Label3.Text = "Shared Folder Path"
        ' 
        ' txtFolderPath
        ' 
        txtFolderPath.Location = New Point(140, 83)
        txtFolderPath.Name = "txtFolderPath"
        txtFolderPath.Size = New Size(753, 23)
        txtFolderPath.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(899, 86)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 21)
        Button2.TabIndex = 6
        Button2.Text = "Browse..."
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(140, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(556, 23)
        TextBox1.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(77, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 8
        Label4.Text = "CRM URL"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(140, 116)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(753, 23)
        TextBox2.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(899, 116)
        Button3.Name = "Button3"
        Button3.Size = New Size(111, 21)
        Button3.TabIndex = 6
        Button3.Text = "Go to URL"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(827, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 15)
        Label5.TabIndex = 10
        Label5.Text = "Account ID"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(899, 29)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(236, 23)
        TextBox3.TabIndex = 11
        ' 
        ' frmNewOpp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 368)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(txtFolderPath)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmNewOpp"
        Text = "New Opp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFolderPath As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
