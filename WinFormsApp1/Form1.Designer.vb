<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(60, 59)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(709, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 20)
        Label1.TabIndex = 1
        Label1.Text = "Opp"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Customers", "Prospects", "Active ", "Closed ", "Won"})
        ComboBox2.Location = New Point(60, 23)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(212, 28)
        ComboBox2.TabIndex = 2
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(278, 23)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(491, 28)
        ComboBox3.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 4
        Label2.Text = "Filter"
        ' 
        ' btnDetails
        ' 
        btnDetails.Location = New Point(775, 60)
        btnDetails.Name = "btnDetails"
        btnDetails.Size = New Size(114, 27)
        btnDetails.TabIndex = 5
        btnDetails.Text = "Details..."
        btnDetails.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(21, 115)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1171, 353)
        ListView1.TabIndex = 6
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(895, 60)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 27)
        Button2.TabIndex = 7
        Button2.Text = "New..."
        Button2.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1206, 478)
        Controls.Add(Button2)
        Controls.Add(ListView1)
        Controls.Add(btnDetails)
        Controls.Add(Label2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
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

End Class
