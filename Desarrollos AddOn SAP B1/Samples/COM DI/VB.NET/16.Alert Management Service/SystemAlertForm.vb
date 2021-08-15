'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:     SystemAlertForm.vb
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
' Update System Alert 
'
'****************************************************************************
Imports SAPbobsCOM
Public Class SystemAlertForm

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
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSendInternal As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUserCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDocument As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConditions As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cboPriority = New System.Windows.Forms.ComboBox
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkSendInternal = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtUserCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboDocument = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtConditions = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(168, 312)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(120, 24)
        Me.cmdUpdate.TabIndex = 2
        Me.cmdUpdate.Text = "Update System Alert"
        '
        'cboPriority
        '
        Me.cboPriority.Items.AddRange(New Object() {"High", "Low", "Normal"})
        Me.cboPriority.Location = New System.Drawing.Point(132, 79)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(148, 21)
        Me.cboPriority.TabIndex = 29
        '
        'chkActive
        '
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Location = New System.Drawing.Point(24, 287)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(80, 16)
        Me.chkActive.TabIndex = 28
        Me.chkActive.Text = "Active  "
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(28, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Priority "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSendInternal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtUserCode)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 88)
        Me.GroupBox1.TabIndex = 26
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
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "User Code"
        '
        'txtUserCode
        '
        Me.txtUserCode.Location = New System.Drawing.Point(104, 24)
        Me.txtUserCode.Name = "txtUserCode"
        Me.txtUserCode.Size = New System.Drawing.Size(148, 20)
        Me.txtUserCode.TabIndex = 14
        Me.txtUserCode.Text = "1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Alert Code"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCode.Location = New System.Drawing.Point(132, 47)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(148, 20)
        Me.txtCode.TabIndex = 24
        Me.txtCode.Text = "-5"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Alert Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(132, 15)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 20)
        Me.txtName.TabIndex = 22
        Me.txtName.Text = "Deviation from Discount (in %)"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Document"
        '
        'cboDocument
        '
        Me.cboDocument.Items.AddRange(New Object() {"Sales Quotations", "Sales Orders", "Deliveries", "Returns", "A/R Invoices", "A/R Credit Memos"})
        Me.cboDocument.Location = New System.Drawing.Point(132, 112)
        Me.cboDocument.Name = "cboDocument"
        Me.cboDocument.Size = New System.Drawing.Size(148, 21)
        Me.cboDocument.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(28, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Discount %"
        '
        'txtConditions
        '
        Me.txtConditions.Location = New System.Drawing.Point(132, 152)
        Me.txtConditions.Name = "txtConditions"
        Me.txtConditions.Size = New System.Drawing.Size(148, 20)
        Me.txtConditions.TabIndex = 33
        Me.txtConditions.Text = "15"
        '
        'SystemAlertForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 343)
        Me.Controls.Add(Me.txtConditions)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboDocument)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPriority)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdUpdate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SystemAlertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Alert"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oAlertTemplatesService As AlertManagementService
    Private Sub SystemAlertForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitService()

        Call InitCtrls()

    End Sub

    Private Sub InitCtrls()

        cboPriority.SelectedIndex = 1

        cboDocument.SelectedIndex = 1

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

    'return the document type
    Private Function GetDocumentType(ByVal sDocument As String) As AlertManagementDocumentEnum

        Try

            Select Case sDocument
                Case "Sales Quotations"

                    Return (AlertManagementDocumentEnum.atd_Quotations)

                Case "Sales Orders"

                    Return (AlertManagementDocumentEnum.atd_Orders)

                Case "Deliveries"

                    Return (AlertManagementDocumentEnum.atd_DeliveryNotes)

                Case "Returns"

                    Return (AlertManagementDocumentEnum.atd_Returns)

                Case "A/R Invoices"

                    Return (AlertManagementDocumentEnum.atd_Invoices)

                Case "A/R Credit Memos"

                    Return (AlertManagementDocumentEnum.atd_RevertInvoice)

            End Select


        Catch ex As Exception

            MsgBox(ex.Message())

        End Try

    End Function

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try

            Dim oAlertTemplate As AlertManagement
            Dim oAlertTemplateParams As AlertManagementParams
            Dim oAlertTemplateRecipients As AlertManagementRecipients
            Dim oAlertRecipient As AlertManagementRecipient
            Dim j As Integer

            'get alert template params
            oAlertTemplateParams = oAlertTemplatesService.GetDataInterface(AlertManagementServiceDataInterfaces.atsdiAlertManagementParams)

            'set system alert code
            oAlertTemplateParams.Code = txtCode.Text

            'get alert template
            oAlertTemplate = oAlertTemplatesService.GetAlertManagement(oAlertTemplateParams)

            'set alert name
            oAlertTemplate.Name = txtName.Text

            oAlertTemplate.Active = IIf(chkActive.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO)

            'set % Discount
            oAlertTemplate.Param = txtConditions.Text

            'set priority
            oAlertTemplate.Priority = GetPriority(cboPriority.SelectedItem)

            'update selected document
            For j = 0 To oAlertTemplate.AlertManagementDocuments.Count - 1
                If oAlertTemplate.AlertManagementDocuments.Item(j).Document = GetDocumentType(cboDocument.SelectedItem) Then
                    oAlertTemplate.AlertManagementDocuments.Item(j).Active = BoYesNoEnum.tYES
                    Exit For
                End If
            Next j

            'get recipient collection
            oAlertTemplateRecipients = oAlertTemplate.AlertManagementRecipients

            'add recipient
            oAlertRecipient = oAlertTemplateRecipients.Add()

            'set recipient code(manager=1)
            oAlertRecipient.UserCode = txtUserCode.Text

            'set internal message
            oAlertRecipient.SendInternal = IIf(chkSendInternal.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO)

            'update alert
            Call oAlertTemplatesService.UpdateAlertManagement(oAlertTemplate)





            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub
End Class
