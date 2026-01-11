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
        components = New ComponentModel.Container()
        cboOpps = New ComboBox()
        Label1 = New Label()
        cboCriteria = New ComboBox()
        cboCriteriaList = New ComboBox()
        Label2 = New Label()
        btnDetails = New Button()
        lvOppFolder = New ListView()
        btnNewOpp = New Button()
        btnOpenLocalFolder = New Button()
        Button3 = New Button()
        ilFileIcons = New ImageList(components)
        SuspendLayout()
        ' 
        ' cboOpps
        ' 
        cboOpps.FormattingEnabled = True
        cboOpps.Location = New Point(59, 59)
        cboOpps.Name = "cboOpps"
        cboOpps.Size = New Size(709, 28)
        cboOpps.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 20)
        Label1.TabIndex = 1
        Label1.Text = "Opp"
        ' 
        ' cboCriteria
        ' 
        cboCriteria.FormattingEnabled = True
        cboCriteria.Items.AddRange(New Object() {"Customers", "Prospects", "Active ", "Closed ", "Won"})
        cboCriteria.Location = New Point(59, 23)
        cboCriteria.Name = "cboCriteria"
        cboCriteria.Size = New Size(212, 28)
        cboCriteria.TabIndex = 2
        ' 
        ' cboCriteriaList
        ' 
        cboCriteriaList.FormattingEnabled = True
        cboCriteriaList.Location = New Point(278, 23)
        cboCriteriaList.Name = "cboCriteriaList"
        cboCriteriaList.Size = New Size(491, 28)
        cboCriteriaList.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 23)
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
        ' lvOppFolder
        ' 
        lvOppFolder.Location = New Point(21, 141)
        lvOppFolder.Name = "lvOppFolder"
        lvOppFolder.Size = New Size(1171, 327)
        lvOppFolder.TabIndex = 6
        lvOppFolder.UseCompatibleStateImageBehavior = False
        ' 
        ' btnNewOpp
        ' 
        btnNewOpp.Location = New Point(895, 60)
        btnNewOpp.Name = "btnNewOpp"
        btnNewOpp.Size = New Size(114, 27)
        btnNewOpp.TabIndex = 7
        btnNewOpp.Text = "New..."
        btnNewOpp.UseVisualStyleBackColor = True
        ' 
        ' btnOpenLocalFolder
        ' 
        btnOpenLocalFolder.Location = New Point(21, 100)
        btnOpenLocalFolder.Margin = New Padding(3, 4, 3, 4)
        btnOpenLocalFolder.Name = "btnOpenLocalFolder"
        btnOpenLocalFolder.Size = New Size(159, 35)
        btnOpenLocalFolder.TabIndex = 8
        btnOpenLocalFolder.Text = "Open Local Folder"
        btnOpenLocalFolder.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(186, 100)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(159, 35)
        Button3.TabIndex = 9
        Button3.Text = "Go to CRM URL"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ilFileIcons
        ' 
        ilFileIcons.ColorDepth = ColorDepth.Depth32Bit
        ilFileIcons.ImageSize = New Size(16, 16)
        ilFileIcons.TransparentColor = Color.Transparent
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1206, 477)
        Controls.Add(Button3)
        Controls.Add(btnOpenLocalFolder)
        Controls.Add(btnNewOpp)
        Controls.Add(lvOppFolder)
        Controls.Add(btnDetails)
        Controls.Add(Label2)
        Controls.Add(cboCriteriaList)
        Controls.Add(cboCriteria)
        Controls.Add(Label1)
        Controls.Add(cboOpps)
        Name = "FrmMain"
        Text = "LPA Opportunity Mgr"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboOpps As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCriteria As ComboBox
    Friend WithEvents cboCriteriaList As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDetails As Button
    Friend WithEvents lvOppFolder As ListView
    Friend WithEvents btnNewOpp As Button
    Friend WithEvents btnOpenLocalFolder As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ilFileIcons As ImageList

End Class
