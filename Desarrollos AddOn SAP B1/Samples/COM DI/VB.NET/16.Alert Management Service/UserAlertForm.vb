'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:     UserAlertForm.vb
'
'  Copyright (c) SAP 
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************
'****************************************************************************
'
' Description:
' ------------
' Add a new User Alert 
'
'****************************************************************************

Imports SAPbobsCOM
Public Class UserAlertForm
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents cmdAddAlert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents txtUserCode As System.Windows.Forms.TextBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents cboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents chkSendInternal As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFreqType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFreqIntrvls As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAddAlert = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtQuery = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkSendInternal = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtUserCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.cboPriority = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFreqIntrvls = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboFreqType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAddAlert
        '
        Me.cmdAddAlert.Location = New System.Drawing.Point(192, 320)
        Me.cmdAddAlert.Name = "cmdAddAlert"
        Me.cmdAddAlert.Size = New System.Drawing.Size(88, 24)
        Me.cmdAddAlert.TabIndex = 0
        Me.cmdAddAlert.Text = "Add "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(120, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(128, 20)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = "Alert 1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alert Name"
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(120, 56)
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(128, 20)
        Me.txtQuery.TabIndex = 4
        Me.txtQuery.Text = "34"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Query ID  "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSendInternal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtUserCode)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 88)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recipients "
        '
        'chkSendInternal
        '
        Me.chkSendInternal.Checked = True
        Me.chkSendInternal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSendInternal.Location = New System.Drawing.Point(8, 56)
        Me.chkSendInternal.Name = "chkSendInternal"
        Me.chkSendInternal.Size = New System.Drawing.Size(96, 16)
        Me.chkSendInternal.TabIndex = 17
        Me.chkSendInternal.Text = "Send Internal"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "User Code"
        '
        'txtUserCode
        '
        Me.txtUserCode.Location = New System.Drawing.Point(104, 24)
        Me.txtUserCode.Name = "txtUserCode"
        Me.txtUserCode.Size = New System.Drawing.Size(128, 20)
        Me.txtUserCode.TabIndex = 14
        Me.txtUserCode.Text = "1"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Priority "
        '
        'chkActive
        '
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Location = New System.Drawing.Point(24, 296)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(80, 16)
        Me.chkActive.TabIndex = 19
        Me.chkActive.Text = "Active  "
        '
        'cboPriority
        '
        Me.cboPriority.Items.AddRange(New Object() {"High", "Low", "Normal"})
        Me.cboPriority.Location = New System.Drawing.Point(120, 88)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(128, 21)
        Me.cboPriority.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFreqIntrvls)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboFreqType)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Frequency"
        '
        'txtFreqIntrvls
        '
        Me.txtFreqIntrvls.Location = New System.Drawing.Point(64, 24)
        Me.txtFreqIntrvls.Name = "txtFreqIntrvls"
        Me.txtFreqIntrvls.Size = New System.Drawing.Size(32, 20)
        Me.txtFreqIntrvls.TabIndex = 23
        Me.txtFreqIntrvls.Text = "1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Every"
        '
        'cboFreqType
        '
        Me.cboFreqType.Items.AddRange(New Object() {"Hours", "Minutes"})
        Me.cboFreqType.Location = New System.Drawing.Point(104, 24)
        Me.cboFreqType.Name = "cboFreqType"
        Me.cboFreqType.Size = New System.Drawing.Size(128, 21)
        Me.cboFreqType.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Query ID (add a user query in order to use this sample)"
        '
        'UserAlertForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 351)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cboPriority)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdAddAlert)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserAlertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alert Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim oAlertTemplatesService As AlertManagementService
    Private Sub ApprovalTemplateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitService()

        Call InitCtrls()

    End Sub

    Private Sub InitCtrls()

        cboPriority.SelectedIndex = 1

        cboFreqType.SelectedIndex = 1

    End Sub

    Private Sub AddAlert()

        Try

            Dim oAlertTemplate As AlertManagement
            Dim oAlertTemplateParams As AlertManagementParams
            Dim oAlertTemplateRecipients As AlertManagementRecipients
            Dim oAlertRecipient As AlertManagementRecipient


            'get alert template
            oAlertTemplate = oAlertTemplatesService.GetDataInterface(AlertManagementServiceDataInterfaces.atsdiAlertManagement)

            'set alert name
            oAlertTemplate.Name = txtName.Text

            'set query
            oAlertTemplate.QueryID = txtQuery.Text

            oAlertTemplate.Active = IIf(chkActive.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO)

            'set priority
            oAlertTemplate.Priority = GetPriority(cboPriority.SelectedItem)

            'set the FrequencyType (minutes,hours...)
            oAlertTemplate.FrequencyType = GetFrequencyType(cboFreqType.SelectedItem)

            'set intervals
            oAlertTemplate.FrequencyInterval = txtFreqIntrvls.Text

            'get Recipients collection 
            oAlertTemplateRecipients = oAlertTemplate.AlertManagementRecipients

            'add recipient
            oAlertRecipient = oAlertTemplateRecipients.Add()

            'set recipient code(manager=1)
            oAlertRecipient.UserCode = txtUserCode.Text

            'set internal message
            oAlertRecipient.SendInternal = IIf(chkSendInternal.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO)

            'add alert template
            oAlertTemplateParams = oAlertTemplatesService.AddAlertManagement(oAlertTemplate)

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    'return the Frequency type
    Private Function GetFrequencyType(ByVal sFrequencyType As String) As AlertManagementFrequencyType

        Try

            Select Case sFrequencyType
                Case "Minutes"
                    Return (AlertManagementFrequencyType.atfi_Minutes)
                Case "Hours"
                    Return (AlertManagementFrequencyType.atfi_Hours)
            End Select


        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    'return the priority type
    Private Function GetPriority(ByVal sPriority As String) As AlertManagementPriorityEnum

        Try

            Select Case sPriority
                Case "High"

                    Return (AlertManagementPriorityEnum.atp_High)

                Case "Low"

                    Return (AlertManagementPriorityEnum.atp_Low)

                Case "Normal"

                    Return (AlertManagementPriorityEnum.atp_Normal)

            End Select


        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    Private Sub cmdAddAlert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAlert.Click

        Call AddAlert()

    End Sub
    Private Sub InitService()

        Try
            Call initCompanyService()

            'get Approval Stages Service 
            oAlertTemplatesService = oCmpSrv.GetBusinessService(ServiceTypes.AlertManagementService)

        Catch ex As Exception

            MsgBox(ex.Message())

        End Try

    End Sub


End Class
