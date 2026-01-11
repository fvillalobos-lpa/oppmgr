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
        cboAccounts = New ComboBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtFolderPath = New TextBox()
        btnBrowseforFolder = New Button()
        txtOppName = New TextBox()
        Label4 = New Label()
        txtCRMurl = New TextBox()
        btnGotoURL = New Button()
        Label5 = New Label()
        txtOppID = New TextBox()
        btnCreaterOpp = New Button()
        Label6 = New Label()
        dtpOppCreationDate = New DateTimePicker()
        Label7 = New Label()
        cboOppStage = New ComboBox()
        Label8 = New Label()
        txtOppAmount = New TextBox()
        dpOppEstCloseDate = New DateTimePicker()
        Label9 = New Label()
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
        ' cboAccounts
        ' 
        cboAccounts.FormattingEnabled = True
        cboAccounts.Location = New Point(141, 27)
        cboAccounts.Margin = New Padding(3, 2, 3, 2)
        cboAccounts.Name = "cboAccounts"
        cboAccounts.Size = New Size(554, 23)
        cboAccounts.TabIndex = 1
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
        Label2.Location = New Point(70, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 15)
        Label2.TabIndex = 3
        Label2.Text = "Opp Name"
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
        ' btnBrowseforFolder
        ' 
        btnBrowseforFolder.Location = New Point(899, 86)
        btnBrowseforFolder.Name = "btnBrowseforFolder"
        btnBrowseforFolder.Size = New Size(111, 21)
        btnBrowseforFolder.TabIndex = 6
        btnBrowseforFolder.Text = "Browse..."
        btnBrowseforFolder.UseVisualStyleBackColor = True
        ' 
        ' txtOppName
        ' 
        txtOppName.Location = New Point(140, 55)
        txtOppName.Name = "txtOppName"
        txtOppName.Size = New Size(556, 23)
        txtOppName.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(77, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 8
        Label4.Text = "CRM URL"
        ' 
        ' txtCRMurl
        ' 
        txtCRMurl.Location = New Point(140, 111)
        txtCRMurl.Name = "txtCRMurl"
        txtCRMurl.Size = New Size(753, 23)
        txtCRMurl.TabIndex = 9
        ' 
        ' btnGotoURL
        ' 
        btnGotoURL.Location = New Point(899, 116)
        btnGotoURL.Name = "btnGotoURL"
        btnGotoURL.Size = New Size(111, 21)
        btnGotoURL.TabIndex = 6
        btnGotoURL.Text = "Go to URL"
        btnGotoURL.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(827, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 15)
        Label5.TabIndex = 10
        Label5.Text = "Opp ID"
        ' 
        ' txtOppID
        ' 
        txtOppID.Location = New Point(899, 29)
        txtOppID.Name = "txtOppID"
        txtOppID.Size = New Size(236, 23)
        txtOppID.TabIndex = 11
        ' 
        ' btnCreaterOpp
        ' 
        btnCreaterOpp.Location = New Point(994, 329)
        btnCreaterOpp.Name = "btnCreaterOpp"
        btnCreaterOpp.Size = New Size(127, 27)
        btnCreaterOpp.TabIndex = 12
        btnCreaterOpp.Text = "Create New Opp"
        btnCreaterOpp.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(56, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 15)
        Label6.TabIndex = 13
        Label6.Text = "Creation Date"
        ' 
        ' dtpOppCreationDate
        ' 
        dtpOppCreationDate.Location = New Point(141, 140)
        dtpOppCreationDate.Name = "dtpOppCreationDate"
        dtpOppCreationDate.Size = New Size(200, 23)
        dtpOppCreationDate.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(99, 171)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 16
        Label7.Text = "Stage"
        ' 
        ' cboOppStage
        ' 
        cboOppStage.FormattingEnabled = True
        cboOppStage.Location = New Point(140, 168)
        cboOppStage.Margin = New Padding(3, 2, 3, 2)
        cboOppStage.Name = "cboOppStage"
        cboOppStage.Size = New Size(262, 23)
        cboOppStage.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(56, 196)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 15)
        Label8.TabIndex = 18
        Label8.Text = "Amount (USD)"
        ' 
        ' txtOppAmount
        ' 
        txtOppAmount.Location = New Point(141, 196)
        txtOppAmount.Name = "txtOppAmount"
        txtOppAmount.Size = New Size(261, 23)
        txtOppAmount.TabIndex = 19
        ' 
        ' dpOppEstCloseDate
        ' 
        dpOppEstCloseDate.Location = New Point(516, 140)
        dpOppEstCloseDate.Name = "dpOppEstCloseDate"
        dpOppEstCloseDate.Size = New Size(200, 23)
        dpOppEstCloseDate.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(431, 143)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 15)
        Label9.TabIndex = 20
        Label9.Text = "Est. Close Date"
        ' 
        ' frmNewOpp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 368)
        Controls.Add(dpOppEstCloseDate)
        Controls.Add(Label9)
        Controls.Add(txtOppAmount)
        Controls.Add(Label8)
        Controls.Add(cboOppStage)
        Controls.Add(Label7)
        Controls.Add(dtpOppCreationDate)
        Controls.Add(Label6)
        Controls.Add(btnCreaterOpp)
        Controls.Add(txtOppID)
        Controls.Add(Label5)
        Controls.Add(txtCRMurl)
        Controls.Add(Label4)
        Controls.Add(txtOppName)
        Controls.Add(btnGotoURL)
        Controls.Add(btnBrowseforFolder)
        Controls.Add(txtFolderPath)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(cboAccounts)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmNewOpp"
        Text = "New Opp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboAccounts As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFolderPath As TextBox
    Friend WithEvents btnBrowseforFolder As Button
    Friend WithEvents txtOppName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCRMurl As TextBox
    Friend WithEvents btnGotoURL As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOppID As TextBox
    Friend WithEvents btnCreaterOpp As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpOppCreationDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cboOppStage As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOppAmount As TextBox
    Friend WithEvents dpOppEstCloseDate As DateTimePicker
    Friend WithEvents Label9 As Label
End Class
