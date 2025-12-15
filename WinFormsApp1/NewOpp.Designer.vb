<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewOpp
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 0
        Label1.Text = "Account"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(115, 35)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(536, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(657, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 28)
        Button1.TabIndex = 2
        Button1.Text = "New Account..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(943, 490)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "New Opp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
