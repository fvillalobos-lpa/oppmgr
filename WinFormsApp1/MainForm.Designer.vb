<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label2 = New Label()
        btnDetails = New Button()
        ListView1 = New ListView()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(52, 44)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(621, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 1
        Label1.Text = "Opp"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Customers", "Prospects", "Active ", "Closed ", "Won"})
        ComboBox2.Location = New Point(52, 17)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(186, 23)
        ComboBox2.TabIndex = 2
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(243, 17)
        ComboBox3.Margin = New Padding(3, 2, 3, 2)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(430, 23)
        ComboBox3.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 15)
        Label2.TabIndex = 4
        Label2.Text = "Filter"
        ' 
        ' btnDetails
        ' 
        btnDetails.Location = New Point(678, 45)
        btnDetails.Margin = New Padding(3, 2, 3, 2)
        btnDetails.Name = "btnDetails"
        btnDetails.Size = New Size(100, 20)
        btnDetails.TabIndex = 5
        btnDetails.Text = "Details..."
        btnDetails.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(18, 106)
        ListView1.Margin = New Padding(3, 2, 3, 2)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1025, 246)
        ListView1.TabIndex = 6
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(783, 45)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 20)
        Button2.TabIndex = 7
        Button2.Text = "New..."
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(18, 75)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 26)
        Button1.TabIndex = 8
        Button1.Text = "Open Local Folder"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(163, 75)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 26)
        Button3.TabIndex = 9
        Button3.Text = "Go to CRM URL"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1055, 358)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(ListView1)
        Controls.Add(btnDetails)
        Controls.Add(Label2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmMain"
        Text = "LPA Opportunity Mgr"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDetails As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button

End Class
