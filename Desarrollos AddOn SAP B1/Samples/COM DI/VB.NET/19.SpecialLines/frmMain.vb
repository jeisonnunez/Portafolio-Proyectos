
'****************************************************************************
'  SAP MANAGE DI API 2007 SDK Sample
'****************************************************************************
'
'  Copyright (c) SAP MANAGE
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************

Option Explicit On 

Public Class frmMain

    Inherits System.Windows.Forms.Form
    Public oCompany As SAPbobsCOM.Company ' The company object

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents grpSample As System.Windows.Forms.GroupBox
    Friend WithEvents lblExplenation As System.Windows.Forms.Label
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents txtQnum As System.Windows.Forms.TextBox
    Friend WithEvents lblQ As System.Windows.Forms.Label
    Friend WithEvents GrpSpecialLineDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblLineNum As System.Windows.Forms.Label
    Friend WithEvents NumAfterLine As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtSpecial As System.Windows.Forms.TextBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents RadText As System.Windows.Forms.RadioButton
    Friend WithEvents RadSubTotal As System.Windows.Forms.RadioButton
    Friend WithEvents cmdAddSpecialLine As System.Windows.Forms.Button
    Friend WithEvents grpConn As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGetCompanyList As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDBType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUSer As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents txtDBPass As System.Windows.Forms.TextBox
    Friend WithEvents txtDBUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpSample = New System.Windows.Forms.GroupBox
        Me.GrpSpecialLineDetails = New System.Windows.Forms.GroupBox
        Me.cmdAddSpecialLine = New System.Windows.Forms.Button
        Me.lblLineNum = New System.Windows.Forms.Label
        Me.NumAfterLine = New System.Windows.Forms.NumericUpDown
        Me.txtSpecial = New System.Windows.Forms.TextBox
        Me.lblType = New System.Windows.Forms.Label
        Me.RadText = New System.Windows.Forms.RadioButton
        Me.RadSubTotal = New System.Windows.Forms.RadioButton
        Me.lblQ = New System.Windows.Forms.Label
        Me.txtQnum = New System.Windows.Forms.TextBox
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.lblExplenation = New System.Windows.Forms.Label
        Me.grpConn = New System.Windows.Forms.GroupBox
        Me.cmdGetCompanyList = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbDBType = New System.Windows.Forms.ComboBox
        Me.cmdConnect = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUSer = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.lblCompany = New System.Windows.Forms.Label
        Me.txtDBPass = New System.Windows.Forms.TextBox
        Me.txtDBUser = New System.Windows.Forms.TextBox
        Me.lblPass = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpSample.SuspendLayout()
        Me.GrpSpecialLineDetails.SuspendLayout()
        CType(Me.NumAfterLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConn.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSample
        '
        Me.grpSample.Controls.Add(Me.GrpSpecialLineDetails)
        Me.grpSample.Controls.Add(Me.lblQ)
        Me.grpSample.Controls.Add(Me.txtQnum)
        Me.grpSample.Controls.Add(Me.cmdLoad)
        Me.grpSample.Controls.Add(Me.lblExplenation)
        Me.grpSample.Enabled = False
        Me.grpSample.Location = New System.Drawing.Point(8, 144)
        Me.grpSample.Name = "grpSample"
        Me.grpSample.Size = New System.Drawing.Size(648, 392)
        Me.grpSample.TabIndex = 15
        Me.grpSample.TabStop = False
        Me.grpSample.Text = "Sample"
        '
        'GrpSpecialLineDetails
        '
        Me.GrpSpecialLineDetails.Controls.Add(Me.cmdAddSpecialLine)
        Me.GrpSpecialLineDetails.Controls.Add(Me.lblLineNum)
        Me.GrpSpecialLineDetails.Controls.Add(Me.NumAfterLine)
        Me.GrpSpecialLineDetails.Controls.Add(Me.txtSpecial)
        Me.GrpSpecialLineDetails.Controls.Add(Me.lblType)
        Me.GrpSpecialLineDetails.Controls.Add(Me.RadText)
        Me.GrpSpecialLineDetails.Controls.Add(Me.RadSubTotal)
        Me.GrpSpecialLineDetails.Enabled = False
        Me.GrpSpecialLineDetails.Location = New System.Drawing.Point(24, 128)
        Me.GrpSpecialLineDetails.Name = "GrpSpecialLineDetails"
        Me.GrpSpecialLineDetails.Size = New System.Drawing.Size(592, 232)
        Me.GrpSpecialLineDetails.TabIndex = 18
        Me.GrpSpecialLineDetails.TabStop = False
        Me.GrpSpecialLineDetails.Text = "Special Line Details"
        '
        'cmdAddSpecialLine
        '
        Me.cmdAddSpecialLine.Location = New System.Drawing.Point(32, 152)
        Me.cmdAddSpecialLine.Name = "cmdAddSpecialLine"
        Me.cmdAddSpecialLine.Size = New System.Drawing.Size(136, 23)
        Me.cmdAddSpecialLine.TabIndex = 32
        Me.cmdAddSpecialLine.Text = "Add Special Line"
        '
        'lblLineNum
        '
        Me.lblLineNum.Location = New System.Drawing.Point(32, 104)
        Me.lblLineNum.Name = "lblLineNum"
        Me.lblLineNum.Size = New System.Drawing.Size(64, 23)
        Me.lblLineNum.TabIndex = 31
        Me.lblLineNum.Text = "After Line"
        '
        'NumAfterLine
        '
        Me.NumAfterLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.NumAfterLine.Location = New System.Drawing.Point(112, 104)
        Me.NumAfterLine.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumAfterLine.Name = "NumAfterLine"
        Me.NumAfterLine.Size = New System.Drawing.Size(48, 29)
        Me.NumAfterLine.TabIndex = 30
        Me.NumAfterLine.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtSpecial
        '
        Me.txtSpecial.Enabled = False
        Me.txtSpecial.Location = New System.Drawing.Point(168, 64)
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.Size = New System.Drawing.Size(392, 20)
        Me.txtSpecial.TabIndex = 28
        Me.txtSpecial.Text = "Type here the text that will appear in the special line"
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(32, 32)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(72, 23)
        Me.lblType.TabIndex = 27
        Me.lblType.Text = "Line Type"
        '
        'RadText
        '
        Me.RadText.Location = New System.Drawing.Point(112, 64)
        Me.RadText.Name = "RadText"
        Me.RadText.Size = New System.Drawing.Size(48, 24)
        Me.RadText.TabIndex = 26
        Me.RadText.Text = "Text"
        '
        'RadSubTotal
        '
        Me.RadSubTotal.Checked = True
        Me.RadSubTotal.Location = New System.Drawing.Point(112, 32)
        Me.RadSubTotal.Name = "RadSubTotal"
        Me.RadSubTotal.TabIndex = 25
        Me.RadSubTotal.TabStop = True
        Me.RadSubTotal.Text = "SubTotal"
        '
        'lblQ
        '
        Me.lblQ.Location = New System.Drawing.Point(16, 80)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.TabIndex = 17
        Me.lblQ.Text = "Quotation Number"
        '
        'txtQnum
        '
        Me.txtQnum.Location = New System.Drawing.Point(120, 80)
        Me.txtQnum.Name = "txtQnum"
        Me.txtQnum.TabIndex = 16
        Me.txtQnum.Text = ""
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(232, 80)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(112, 23)
        Me.cmdLoad.TabIndex = 15
        Me.cmdLoad.Text = "Load Quotation"
        '
        'lblExplenation
        '
        Me.lblExplenation.Location = New System.Drawing.Point(24, 24)
        Me.lblExplenation.Name = "lblExplenation"
        Me.lblExplenation.Size = New System.Drawing.Size(600, 40)
        Me.lblExplenation.TabIndex = 14
        Me.lblExplenation.Text = "This sample demonstrates how to use Special Lines via the DI API. In order to wor" & _
        "k with it you need to provide a quotation number of a quotation with lines. Afte" & _
        "r loading a quotation you can add Special Lines."
        '
        'grpConn
        '
        Me.grpConn.Controls.Add(Me.txtDBPass)
        Me.grpConn.Controls.Add(Me.txtDBUser)
        Me.grpConn.Controls.Add(Me.lblPass)
        Me.grpConn.Controls.Add(Me.Label4)
        Me.grpConn.Controls.Add(Me.cmdGetCompanyList)
        Me.grpConn.Controls.Add(Me.Label2)
        Me.grpConn.Controls.Add(Me.cmbDBType)
        Me.grpConn.Controls.Add(Me.cmdConnect)
        Me.grpConn.Controls.Add(Me.txtPassword)
        Me.grpConn.Controls.Add(Me.txtUSer)
        Me.grpConn.Controls.Add(Me.lblPassword)
        Me.grpConn.Controls.Add(Me.lblUser)
        Me.grpConn.Controls.Add(Me.cmbCompany)
        Me.grpConn.Controls.Add(Me.lblCompany)
        Me.grpConn.Location = New System.Drawing.Point(8, 8)
        Me.grpConn.Name = "grpConn"
        Me.grpConn.Size = New System.Drawing.Size(592, 128)
        Me.grpConn.TabIndex = 16
        Me.grpConn.TabStop = False
        Me.grpConn.Text = "Connection Properties"
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(456, 24)
        Me.cmdGetCompanyList.Name = "cmdGetCompanyList"
        Me.cmdGetCompanyList.Size = New System.Drawing.Size(112, 24)
        Me.cmdGetCompanyList.TabIndex = 15
        Me.cmdGetCompanyList.Text = "Get Company List"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Database Type"
        '
        'cmbDBType
        '
        Me.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDBType.Items.AddRange(New Object() {"MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB"})
        Me.cmbDBType.Location = New System.Drawing.Point(120, 24)
        Me.cmbDBType.Name = "cmbDBType"
        Me.cmbDBType.Size = New System.Drawing.Size(121, 21)
        Me.cmbDBType.TabIndex = 13
        '
        'cmdConnect
        '
        Me.cmdConnect.Enabled = False
        Me.cmdConnect.Location = New System.Drawing.Point(472, 88)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(88, 24)
        Me.cmdConnect.TabIndex = 12
        Me.cmdConnect.Text = "Connect"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(312, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(88, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(312, 72)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(88, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(248, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(248, 72)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 23)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "User Name"
        '
        'cmbCompany
        '
        Me.cmbCompany.Enabled = False
        Me.cmbCompany.Location = New System.Drawing.Point(120, 88)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompany.TabIndex = 7
        '
        'lblCompany
        '
        Me.lblCompany.Location = New System.Drawing.Point(8, 88)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(104, 23)
        Me.lblCompany.TabIndex = 6
        Me.lblCompany.Text = "Company Database"
        '
        'txtDBPass
        '
        Me.txtDBPass.Location = New System.Drawing.Point(336, 40)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(72, 20)
        Me.txtDBPass.TabIndex = 41
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(336, 16)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(72, 20)
        Me.txtDBUser.TabIndex = 39
        Me.txtDBUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(256, 40)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 16)
        Me.lblPass.TabIndex = 42
        Me.lblPass.Text = "DB Password"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(256, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "DB Username"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 551)
        Me.Controls.Add(Me.grpConn)
        Me.Controls.Add(Me.grpSample)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimumSize = New System.Drawing.Size(570, 470)
        Me.Name = "frmMain"
        Me.Text = "SAP Database Interface Sample"
        Me.grpSample.ResumeLayout(False)
        Me.GrpSpecialLineDetails.ResumeLayout(False)
        CType(Me.NumAfterLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Error handling variables
    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer
    Public Qut As SAPbobsCOM.Documents


    '****************************************************************************
    ' This function is called when the form is loaded.
    ' It performs various initialization procedures.
    '****************************************************************************
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3
    End Sub
    '****************************************************************************
    ' This function connects to the database
    '****************************************************************************
    Private Sub Connect()
        Cursor = System.Windows.Forms.Cursors.WaitCursor 'Change mouse cursor

        ' Set connection properties
        oCompany.CompanyDB = cmbCompany.Text
        oCompany.UserName = txtUSer.Text
        oCompany.Password = txtPassword.Text

        'Try to connect
        lRetCode = oCompany.Connect()

        If lRetCode <> 0 Then ' if the connection failed
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox("Connection Failed - " & sErrMsg, MsgBoxStyle.Exclamation, "Default Connection Failed")
        End If
        If oCompany.Connected Then ' if connected
            Me.Text = Me.Text & " - Connected to " & oCompany.CompanyDB
            grpConn.Enabled = False
            grpSample.Enabled = True
        End If

        Cursor = System.Windows.Forms.Cursors.Default 'Change mouse cursor
    End Sub

    '****************************************************************************
    ' This function is called when the "Connect" button is called
    '****************************************************************************
    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        Connect()
    End Sub
    '****************************************************************************
    ' This function loads a Quotation
    '****************************************************************************
    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        Qut = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oQuotations)

        If Qut.GetByKey(txtQnum.Text) Then
            If (Qut.Lines.Count <> 0) Then

                MsgBox("Quotation Loaded, " & Qut.Lines.Count.ToString & " lines found.")
                cmdLoad.Enabled = False
                txtQnum.Enabled = False

                GrpSpecialLineDetails.Enabled = True
                NumAfterLine.Minimum = 0
                NumAfterLine.Maximum = Qut.Lines.Count - 1
            Else
                MsgBox("This Quotation doesn't contain lines, Please load a quotation with lines")
            End If
        Else
            MsgBox("Invalid Quotation Number")
        End If
    End Sub
    '****************************************************************************
    ' This function adds a special Line
    '****************************************************************************
    Private Sub cmdAddSpecialLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSpecialLine.Click
        If RadSubTotal.Checked = True Then
            Qut.SpecialLines.LineType = SAPbobsCOM.BoDocSpecialLineType.dslt_Subtotal
        Else
            Qut.SpecialLines.LineType = SAPbobsCOM.BoDocSpecialLineType.dslt_Text
            Qut.SpecialLines.LineText = txtSpecial.Text
        End If

        Qut.SpecialLines.AfterLineNumber = NumAfterLine.Value

        lRetCode = Qut.Update()
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(lErrCode & " " & sErrMsg)  ' Display error message
        Else
            MsgBox("Special Lines Added")
        End If
    End Sub

    Private Sub RadText_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadText.CheckedChanged
        If RadText.Checked = True Then
            txtSpecial.Enabled = True
        Else
            txtSpecial.Enabled = False
        End If
    End Sub

    Private Sub cmdGetCompanyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetCompanyList.Click
        oCompany = New SAPbobsCOM.Company

        Dim oRecordset As SAPbobsCOM.Recordset

        ' Init Connection Properties
        oCompany.DbServerType = cmbDBType.SelectedIndex + 1
        oCompany.Server = "localhost" ' change to your company server
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English ' change to your language
        oCompany.UseTrusted = False
        oCompany.DbUserName = txtDBUser.Text
        oCompany.DbPassword = txtDBPass.Text

        'Me.Show() ' shows the form while it's loaded...

        'Create a list of companies...
        Try
            oRecordset = oCompany.GetCompanyList ' get the company list
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        oCompany.GetLastError(lErrCode, sErrMsg)

        If lErrCode <> 0 Then
            MsgBox(sErrMsg)
        Else
            Do Until oRecordset.EoF = True
                cmbCompany.Items.Add(oRecordset.Fields.Item(0).Value)
                oRecordset.MoveNext()
            Loop

            'Disable Controls
            cmdGetCompanyList.Enabled = False
            cmbDBType.Enabled = False

            'Enable Controls
            txtUSer.Enabled = True
            txtPassword.Enabled = True
            cmdConnect.Enabled = True
            cmbCompany.Enabled = True

        End If

        'Select the first company as default
        If cmbCompany.Items.Count > 0 Then
            cmbCompany.SelectedIndex = 0
        Else
            MsgBox("There was no Database Found...", , "Database not found...")
            End ' Terminate Application...
        End If

        If oCompany.Connected Then ' if already connected
            Me.Text = Me.Text & ": Connected"
            ' Remove the following 2 remark lines if you want to try to connect automatically
            'Else
            'Connect()
        End If

    End Sub

End Class
