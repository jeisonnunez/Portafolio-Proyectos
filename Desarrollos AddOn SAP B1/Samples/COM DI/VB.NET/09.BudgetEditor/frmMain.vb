
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
    Public BGT As SAPbobsCOM.Budget ' The budget object we will update
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
    Friend WithEvents chkAuto As System.Windows.Forms.CheckBox
    Friend WithEvents numSum As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents lblMonths As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRealSum As System.Windows.Forms.Label
    Friend WithEvents cmbAccounts As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdLoadBudget As System.Windows.Forms.Button
    Friend WithEvents grpConn As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGetCompanyList As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbAccounts = New System.Windows.Forms.ComboBox
        Me.lblRealSum = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSum = New System.Windows.Forms.Label
        Me.numSum = New System.Windows.Forms.NumericUpDown
        Me.chkAuto = New System.Windows.Forms.CheckBox
        Me.lblMonths = New System.Windows.Forms.Label
        Me.cmdLoadBudget = New System.Windows.Forms.Button
        Me.grpConn = New System.Windows.Forms.GroupBox
        Me.cmdGetCompanyList = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
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
        CType(Me.numSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConn.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSample
        '
        Me.grpSample.Controls.Add(Me.cmdUpdate)
        Me.grpSample.Controls.Add(Me.Label2)
        Me.grpSample.Controls.Add(Me.cmbAccounts)
        Me.grpSample.Controls.Add(Me.lblRealSum)
        Me.grpSample.Controls.Add(Me.Label1)
        Me.grpSample.Controls.Add(Me.lblSum)
        Me.grpSample.Controls.Add(Me.numSum)
        Me.grpSample.Controls.Add(Me.chkAuto)
        Me.grpSample.Controls.Add(Me.lblMonths)
        Me.grpSample.Controls.Add(Me.cmdLoadBudget)
        Me.grpSample.Enabled = False
        Me.grpSample.Location = New System.Drawing.Point(8, 144)
        Me.grpSample.Name = "grpSample"
        Me.grpSample.Size = New System.Drawing.Size(648, 400)
        Me.grpSample.TabIndex = 15
        Me.grpSample.TabStop = False
        Me.grpSample.Text = "Sample"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(16, 360)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(104, 23)
        Me.cmdUpdate.TabIndex = 26
        Me.cmdUpdate.Text = "Update Budget"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Change Budget"
        '
        'cmbAccounts
        '
        Me.cmbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccounts.Location = New System.Drawing.Point(112, 320)
        Me.cmbAccounts.Name = "cmbAccounts"
        Me.cmbAccounts.Size = New System.Drawing.Size(408, 21)
        Me.cmbAccounts.TabIndex = 24
        '
        'lblRealSum
        '
        Me.lblRealSum.Location = New System.Drawing.Point(192, 360)
        Me.lblRealSum.Name = "lblRealSum"
        Me.lblRealSum.Size = New System.Drawing.Size(104, 16)
        Me.lblRealSum.TabIndex = 23
        Me.lblRealSum.Text = "12000"
        Me.lblRealSum.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(152, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Sum:"
        Me.Label1.Visible = False
        '
        'lblSum
        '
        Me.lblSum.Location = New System.Drawing.Point(192, 32)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(72, 23)
        Me.lblSum.TabIndex = 21
        Me.lblSum.Text = "Budget Sum"
        '
        'numSum
        '
        Me.numSum.Enabled = False
        Me.numSum.Location = New System.Drawing.Point(264, 32)
        Me.numSum.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numSum.Minimum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numSum.Name = "numSum"
        Me.numSum.TabIndex = 20
        Me.numSum.Value = New Decimal(New Integer() {12000, 0, 0, 0})
        '
        'chkAuto
        '
        Me.chkAuto.Checked = True
        Me.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAuto.Location = New System.Drawing.Point(408, 32)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.TabIndex = 19
        Me.chkAuto.Text = "Auto Correct"
        '
        'lblMonths
        '
        Me.lblMonths.Location = New System.Drawing.Point(8, 72)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(624, 16)
        Me.lblMonths.TabIndex = 18
        Me.lblMonths.Text = "January    February   March       April         May          June        July    " & _
        "     August  September  October  November  December "
        '
        'cmdLoadBudget
        '
        Me.cmdLoadBudget.Location = New System.Drawing.Point(528, 320)
        Me.cmdLoadBudget.Name = "cmdLoadBudget"
        Me.cmdLoadBudget.Size = New System.Drawing.Size(104, 24)
        Me.cmdLoadBudget.TabIndex = 17
        Me.cmdLoadBudget.Text = "Load Budget"
        '
        'grpConn
        '
        Me.grpConn.Controls.Add(Me.txtDBPass)
        Me.grpConn.Controls.Add(Me.txtDBUser)
        Me.grpConn.Controls.Add(Me.lblPass)
        Me.grpConn.Controls.Add(Me.Label4)
        Me.grpConn.Controls.Add(Me.cmdGetCompanyList)
        Me.grpConn.Controls.Add(Me.Label3)
        Me.grpConn.Controls.Add(Me.cmbDBType)
        Me.grpConn.Controls.Add(Me.cmdConnect)
        Me.grpConn.Controls.Add(Me.txtPassword)
        Me.grpConn.Controls.Add(Me.txtUSer)
        Me.grpConn.Controls.Add(Me.lblPassword)
        Me.grpConn.Controls.Add(Me.lblUser)
        Me.grpConn.Controls.Add(Me.cmbCompany)
        Me.grpConn.Controls.Add(Me.lblCompany)
        Me.grpConn.Location = New System.Drawing.Point(8, 0)
        Me.grpConn.Name = "grpConn"
        Me.grpConn.Size = New System.Drawing.Size(648, 128)
        Me.grpConn.TabIndex = 16
        Me.grpConn.TabStop = False
        Me.grpConn.Text = "Connection Properties"
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(424, 24)
        Me.cmdGetCompanyList.Name = "cmdGetCompanyList"
        Me.cmdGetCompanyList.Size = New System.Drawing.Size(112, 24)
        Me.cmdGetCompanyList.TabIndex = 15
        Me.cmdGetCompanyList.Text = "Get Company List"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Database Type"
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
        Me.cmdConnect.Location = New System.Drawing.Point(424, 80)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(88, 24)
        Me.cmdConnect.TabIndex = 12
        Me.cmdConnect.Text = "Connect"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(320, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(88, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(320, 72)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(88, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(256, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(256, 72)
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
        Me.txtDBPass.Location = New System.Drawing.Point(328, 48)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(72, 20)
        Me.txtDBPass.TabIndex = 45
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(328, 24)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(72, 20)
        Me.txtDBUser.TabIndex = 43
        Me.txtDBUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(248, 48)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 16)
        Me.lblPass.TabIndex = 46
        Me.lblPass.Text = "DB Password"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "DB Username"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 559)
        Me.Controls.Add(Me.grpConn)
        Me.Controls.Add(Me.grpSample)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimumSize = New System.Drawing.Size(570, 470)
        Me.Name = "frmMain"
        Me.Text = "SAP Database Interface Sample"
        Me.grpSample.ResumeLayout(False)
        CType(Me.numSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Error handling variables
    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer

    Private TB(12) As TrackBar ' 12 track bars for each month
    Private txtMonth(12) As Label ' 12 labels for monthly budget

    '****************************************************************************
    ' This function is called when the form is loaded.
    ' It performs various initialization procedures.
    '****************************************************************************
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3

        'oCompany = New SAPbobsCOM.Company

        '' Init Connection Properties
        'oCompany.Server = "localhost" ' change to your company server
        'oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English ' change to your language
        'oCompany.UseTrusted = True

        'Me.Show() ' shows the form while it's loaded...

        ''Create a list of companies...
        'oRecordSet = oCompany.GetCompanyList ' get the company list

        'oCompany.GetLastError(lErrCode, sErrMsg)

        'If lErrCode <> 0 Then
        '    MsgBox(sErrMsg)
        'Else
        '    Do Until oRecordSet.EoF = True
        '        cmbCompany.Items.Add(oRecordSet.Fields.Item(0).Value)
        '        oRecordSet.MoveNext()
        '    Loop
        'End If

        ''Select the first company as default
        'If cmbCompany.Items.Count > 0 Then
        '    cmbCompany.SelectedIndex = 0
        'Else
        '    MsgBox("There was no Database Found...", , "Database not found...")
        '    End ' Terminate Application...
        'End If

        'If oCompany.Connected Then ' if already connected
        '    Me.Text = Me.Text & ": Connected"
        '    ' Remove the following 2 remark lines if you want to try to connect automatically
        '    'Else
        '    'Connect()
        'End If

        CreateTrackBars()
    End Sub

    '****************************************************************************
    ' This sub creates all the track bars and sets their defaults
    '****************************************************************************
    Private Sub CreateTrackBars()
        Dim i As Integer ' Just a counter to iterate the months

        For i = 0 To 11
            TB(i) = New TrackBar

            TB(i).Parent = grpSample
            TB(i).Orientation = Orientation.Vertical
            TB(i).Width = 60
            TB(i).Height = 200

            TB(i).Left = 5 + ((TB(i).Width + 10) * i)
            TB(i).Top = lblMonths.Top + lblMonths.Height
            TB(i).LargeChange = 1
            TB(i).SmallChange = 1
            TB(i).TickFrequency = 12
            TB(i).Maximum = 120
            TB(i).Minimum = 0
            TB(i).Name = i
            TB(i).Value = 11
            TB(i).Tag = 11

            ' Add the event handler
            AddHandler TB(i).Scroll, AddressOf ProcessScroll

            ' Add label to each track bar
            txtMonth(i) = New Label
            txtMonth(i).Left = TB(i).Left
            txtMonth(i).Width = TB(i).Width + 10
            txtMonth(i).Top = TB(i).Top + TB(i).Height
            txtMonth(i).Tag = 1000
            txtMonth(i).Text = txtMonth(i).Tag
            txtMonth(i).Parent = grpSample
            txtMonth(i).Visible = True
        Next i
    End Sub

    '****************************************************************************
    ' This sub responds to any scrolling of the track bars
    '****************************************************************************
    Sub ProcessScroll(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim MyTrackBar As TrackBar
        Dim delta, Change As Double
        Dim ChangeAble As Integer

        ' Get the changed track bar
        MyTrackBar = DirectCast(sender, TrackBar)

        delta = TB(MyTrackBar.Name).Value - TB(MyTrackBar.Name).Tag
        TB(MyTrackBar.Name).Tag += delta
        TB(MyTrackBar.Name).Value = TB(MyTrackBar.Name).Tag

        Change = delta / 11
        ChangeAble = 0
        Dim i As Integer
        For i = 0 To 11
            If MyTrackBar.Name <> i.ToString And (TB(i).Value - Change <= TB(i).Maximum) And (TB(i).Value - Change >= TB(i).Minimum) Then
                ChangeAble += 1
            End If
        Next i

        Change = delta / ChangeAble
        For i = 0 To 11
            If MyTrackBar.Name <> i.ToString And chkAuto.Checked Then
                TB(i).Tag -= Change
                If Int(TB(i).Tag - Change) >= 0 And (Int(TB(i).Tag - Change) <= TB(i).Maximum) Then
                    TB(i).Value = Int(TB(i).Tag - Change)
                Else
                    TB(i).Tag = TB(i).Value
                End If
            End If
        Next i

        ' Make a sum
        Dim Sum As Double
        Dim PresentedSum As Double
        Dim tmp As Double
        Sum = 0
        For i = 0 To 11
            Sum += TB(i).Value
        Next
        If Sum <> 0 Then
            For i = 0 To 11
                tmp = (numSum.Value * (TB(i).Value / Sum))
                txtMonth(i).Text = CInt(tmp * 100) / 100
            Next

            'Correct slight calculations
            Dim MySum = 0
            For i = 0 To 11
                MySum += CDbl(txtMonth(i).Text)
            Next
            lblRealSum.Text = MySum.ToString
            Dim Dif As Double

            Dif = numSum.Value - CDbl(lblRealSum.Text)
            If Dif <> 0 Then
                Dim j As Integer
                For j = 0 To 11
                    If (CDbl(txtMonth(j).Text) > 0) And (CDbl(TB(j).Value) < TB(j).Maximum) Then
                        txtMonth(j).Text = CInt((CDbl(txtMonth(j).Text) + Dif) * 100) / 100
                        Dif = 0
                    End If
                Next j
            End If

        Else
            MessageBox.Show("This Budget is not possible")
        End If
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
        Else
            LoadData()
            LoadBudget()
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
    ' This function loads a selected budget
    '****************************************************************************
    Sub LoadBudget()
        Dim ACC As SAPbobsCOM.ChartOfAccounts
        Dim bFreeBudget As Boolean
        Dim r As SAPbobsCOM.Recordset

        r = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        ACC = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oChartOfAccounts)

        BGT = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBudget)

        Try
            r.DoQuery("SELECT * FROM OBGT")
            BGT.Browser.Recordset = r
            BGT.Browser.MoveFirst()

            While BGT.Numerator <> (cmbAccounts.SelectedIndex + 1)
                BGT.Browser.MoveNext()
            End While

            numSum.Value = BGT.TotalAnnualBudgetDebitSys + BGT.TotalAnnualBudgetCreditSys
            Dim i As Integer

            For i = 0 To 11
                Dim tmp As Double
                BGT.Lines.SetCurrentLine(i)
                txtMonth(i).Text = BGT.Lines.BudgetTotCredit + BGT.Lines.BudgetTotDebit

                tmp = BGT.Lines.BudgetTotCredit + BGT.Lines.BudgetTotDebit
                TB(i).Tag = (tmp / numSum.Value) * TB(i).Maximum
                TB(i).Value = TB(i).Tag
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '****************************************************************************
    ' This sub loads the accounts data into a combo box
    '****************************************************************************
    Sub LoadData()
        Dim r As SAPbobsCOM.Recordset
        Dim rAcc As SAPbobsCOM.Recordset
        Dim BGT As SAPbobsCOM.Budget

        BGT = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBudget)
        r = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        rAcc = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        Try
            r.DoQuery("SELECT * FROM OBGT")
            BGT.Browser.Recordset = r

            BGT.Browser.MoveFirst()

            While Not BGT.Browser.EoF
                rAcc.DoQuery("SELECT AcctName FROM OACT WHERE AcctCode = '" & BGT.AccountCode & "'")
                rAcc.MoveFirst()
                cmbAccounts.Items.Add(rAcc.Fields.Item(0).Value)
                BGT.Browser.MoveNext()
            End While
            cmbAccounts.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '****************************************************************************
    ' This sub updates the selected budget
    '****************************************************************************
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim j As Int16
        Dim i As Integer

        BGT.Browser.MoveFirst()
        While BGT.Numerator <> (cmbAccounts.SelectedIndex + 1)
            BGT.Browser.MoveNext()
        End While

        For i = 0 To 11
            Dim tmp As Double
            BGT.Lines.SetCurrentLine(i)
            BGT.Lines.BudgetTotDebit = CDbl(txtMonth(i).Text)
        Next
        Dim s As String

        oCompany.GetLastError(i, s)

        i = BGT.Update()

        If i <> 0 Then
            oCompany.GetLastError(i, s)
            MessageBox.Show(s)
        Else
            MessageBox.Show("Budget Updated")
        End If

    End Sub
    '****************************************************************************
    ' This sub responds to the click event on the "load budget" button
    '****************************************************************************
    Private Sub cmdLoadBudget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadBudget.Click
        LoadBudget()
    End Sub

    Private Sub cmdGetCompanyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetCompanyList.Click
        oCompany = New SAPbobsCOM.Company

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
            oRecordSet = oCompany.GetCompanyList ' get the company list
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        oCompany.GetLastError(lErrCode, sErrMsg)

        If lErrCode <> 0 Then
            MsgBox(sErrMsg)
        Else
            Do Until oRecordSet.EoF = True
                cmbCompany.Items.Add(oRecordSet.Fields.Item(0).Value)
                oRecordSet.MoveNext()
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
