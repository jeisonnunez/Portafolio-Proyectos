'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:     ApprovalTemplateForm.vb
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
' Add a new Approval Template
'
'****************************************************************************

Imports SAPbobsCOM


Public Class ApprovalTemplateForm
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
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkQuotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkReturns As System.Windows.Forms.CheckBox
    Friend WithEvents chkArInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents chkPurchase As System.Windows.Forms.CheckBox
    Friend WithEvents chkGoodsReturn As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents chkArCredit As System.Windows.Forms.CheckBox
    Friend WithEvents chkGoodsRecPo As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalesOrder As System.Windows.Forms.CheckBox
    Friend WithEvents chkApInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreditMemo As System.Windows.Forms.CheckBox
    Friend WithEvents gbDocuments As System.Windows.Forms.GroupBox
    Friend WithEvents chkIncludeTerms As System.Windows.Forms.CheckBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserCode As System.Windows.Forms.TextBox
    Friend WithEvents txtStageCode As System.Windows.Forms.TextBox
    Friend WithEvents txtTermValue As System.Windows.Forms.TextBox
    Friend WithEvents cboConditions As System.Windows.Forms.ComboBox
    Friend WithEvents cboOperation As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtUserCode = New System.Windows.Forms.TextBox
        Me.txtStageCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.gbDocuments = New System.Windows.Forms.GroupBox
        Me.chkCreditMemo = New System.Windows.Forms.CheckBox
        Me.chkApInvoice = New System.Windows.Forms.CheckBox
        Me.chkSalesOrder = New System.Windows.Forms.CheckBox
        Me.chkGoodsRecPo = New System.Windows.Forms.CheckBox
        Me.chkArCredit = New System.Windows.Forms.CheckBox
        Me.ChkDelivery = New System.Windows.Forms.CheckBox
        Me.chkGoodsReturn = New System.Windows.Forms.CheckBox
        Me.chkPurchase = New System.Windows.Forms.CheckBox
        Me.chkArInvoice = New System.Windows.Forms.CheckBox
        Me.chkReturns = New System.Windows.Forms.CheckBox
        Me.chkQuotation = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTermValue = New System.Windows.Forms.TextBox
        Me.cboOperation = New System.Windows.Forms.ComboBox
        Me.cboConditions = New System.Windows.Forms.ComboBox
        Me.chkIncludeTerms = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.gbDocuments.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(344, 424)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(104, 24)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(144, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(144, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "My Template"
        '
        'txtUserCode
        '
        Me.txtUserCode.Location = New System.Drawing.Point(144, 48)
        Me.txtUserCode.Name = "txtUserCode"
        Me.txtUserCode.Size = New System.Drawing.Size(144, 20)
        Me.txtUserCode.TabIndex = 2
        Me.txtUserCode.Text = "2"
        '
        'txtStageCode
        '
        Me.txtStageCode.Location = New System.Drawing.Point(152, 216)
        Me.txtStageCode.Name = "txtStageCode"
        Me.txtStageCode.Size = New System.Drawing.Size(144, 20)
        Me.txtStageCode.TabIndex = 5
        Me.txtStageCode.Text = "1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Template Name"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Approval Stage Code"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "User Code"
        '
        'gbDocuments
        '
        Me.gbDocuments.Controls.Add(Me.chkCreditMemo)
        Me.gbDocuments.Controls.Add(Me.chkApInvoice)
        Me.gbDocuments.Controls.Add(Me.chkSalesOrder)
        Me.gbDocuments.Controls.Add(Me.chkGoodsRecPo)
        Me.gbDocuments.Controls.Add(Me.chkArCredit)
        Me.gbDocuments.Controls.Add(Me.ChkDelivery)
        Me.gbDocuments.Controls.Add(Me.chkGoodsReturn)
        Me.gbDocuments.Controls.Add(Me.chkPurchase)
        Me.gbDocuments.Controls.Add(Me.chkArInvoice)
        Me.gbDocuments.Controls.Add(Me.chkReturns)
        Me.gbDocuments.Controls.Add(Me.chkQuotation)
        Me.gbDocuments.Location = New System.Drawing.Point(8, 88)
        Me.gbDocuments.Name = "gbDocuments"
        Me.gbDocuments.Size = New System.Drawing.Size(440, 120)
        Me.gbDocuments.TabIndex = 17
        Me.gbDocuments.TabStop = False
        Me.gbDocuments.Text = "Documents"
        '
        'chkCreditMemo
        '
        Me.chkCreditMemo.Location = New System.Drawing.Point(328, 56)
        Me.chkCreditMemo.Name = "chkCreditMemo"
        Me.chkCreditMemo.Size = New System.Drawing.Size(96, 16)
        Me.chkCreditMemo.TabIndex = 12
        Me.chkCreditMemo.Text = "A/P Credit Memo"
        '
        'chkApInvoice
        '
        Me.chkApInvoice.Checked = True
        Me.chkApInvoice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkApInvoice.Location = New System.Drawing.Point(328, 32)
        Me.chkApInvoice.Name = "chkApInvoice"
        Me.chkApInvoice.Size = New System.Drawing.Size(88, 16)
        Me.chkApInvoice.TabIndex = 11
        Me.chkApInvoice.Text = "A/P Invoice"
        '
        'chkSalesOrder
        '
        Me.chkSalesOrder.Location = New System.Drawing.Point(8, 56)
        Me.chkSalesOrder.Name = "chkSalesOrder"
        Me.chkSalesOrder.Size = New System.Drawing.Size(96, 16)
        Me.chkSalesOrder.TabIndex = 10
        Me.chkSalesOrder.Text = "Sales Order"
        '
        'chkGoodsRecPo
        '
        Me.chkGoodsRecPo.Location = New System.Drawing.Point(208, 56)
        Me.chkGoodsRecPo.Name = "chkGoodsRecPo"
        Me.chkGoodsRecPo.Size = New System.Drawing.Size(120, 16)
        Me.chkGoodsRecPo.TabIndex = 8
        Me.chkGoodsRecPo.Text = "Goods Receipt PO"
        '
        'chkArCredit
        '
        Me.chkArCredit.Location = New System.Drawing.Point(112, 80)
        Me.chkArCredit.Name = "chkArCredit"
        Me.chkArCredit.Size = New System.Drawing.Size(80, 16)
        Me.chkArCredit.TabIndex = 7
        Me.chkArCredit.Text = "A/R Credit Memo"
        '
        'ChkDelivery
        '
        Me.ChkDelivery.Location = New System.Drawing.Point(8, 80)
        Me.ChkDelivery.Name = "ChkDelivery"
        Me.ChkDelivery.Size = New System.Drawing.Size(72, 16)
        Me.ChkDelivery.TabIndex = 6
        Me.ChkDelivery.Text = "Delivery"
        '
        'chkGoodsReturn
        '
        Me.chkGoodsReturn.Location = New System.Drawing.Point(208, 80)
        Me.chkGoodsReturn.Name = "chkGoodsReturn"
        Me.chkGoodsReturn.Size = New System.Drawing.Size(96, 16)
        Me.chkGoodsReturn.TabIndex = 5
        Me.chkGoodsReturn.Text = "Goods Returns"
        '
        'chkPurchase
        '
        Me.chkPurchase.Checked = True
        Me.chkPurchase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPurchase.Location = New System.Drawing.Point(208, 32)
        Me.chkPurchase.Name = "chkPurchase"
        Me.chkPurchase.Size = New System.Drawing.Size(72, 16)
        Me.chkPurchase.TabIndex = 4
        Me.chkPurchase.Text = "Purchase Order"
        '
        'chkArInvoice
        '
        Me.chkArInvoice.Location = New System.Drawing.Point(112, 56)
        Me.chkArInvoice.Name = "chkArInvoice"
        Me.chkArInvoice.Size = New System.Drawing.Size(88, 16)
        Me.chkArInvoice.TabIndex = 3
        Me.chkArInvoice.Text = "A/R Invoice"
        '
        'chkReturns
        '
        Me.chkReturns.Checked = True
        Me.chkReturns.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReturns.Location = New System.Drawing.Point(112, 32)
        Me.chkReturns.Name = "chkReturns"
        Me.chkReturns.Size = New System.Drawing.Size(72, 16)
        Me.chkReturns.TabIndex = 1
        Me.chkReturns.Text = "Returns"
        '
        'chkQuotation
        '
        Me.chkQuotation.Checked = True
        Me.chkQuotation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQuotation.Location = New System.Drawing.Point(8, 32)
        Me.chkQuotation.Name = "chkQuotation"
        Me.chkQuotation.Size = New System.Drawing.Size(104, 16)
        Me.chkQuotation.TabIndex = 0
        Me.chkQuotation.Text = "Sales Quotation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTermValue)
        Me.GroupBox2.Controls.Add(Me.cboOperation)
        Me.GroupBox2.Controls.Add(Me.cboConditions)
        Me.GroupBox2.Controls.Add(Me.chkIncludeTerms)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 160)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Approval Template Terms"
        '
        'txtTermValue
        '
        Me.txtTermValue.Location = New System.Drawing.Point(136, 128)
        Me.txtTermValue.Name = "txtTermValue"
        Me.txtTermValue.Size = New System.Drawing.Size(144, 20)
        Me.txtTermValue.TabIndex = 26
        Me.txtTermValue.Text = "30"
        '
        'cboOperation
        '
        Me.cboOperation.Items.AddRange(New Object() {"Greater than", "Greateror Equal", "Less than", "Less or Equel", "Equel", "Does not Equel", "In Range", "Not in Range"})
        Me.cboOperation.Location = New System.Drawing.Point(136, 96)
        Me.cboOperation.Name = "cboOperation"
        Me.cboOperation.Size = New System.Drawing.Size(144, 21)
        Me.cboOperation.TabIndex = 25
        '
        'cboConditions
        '
        Me.cboConditions.Items.AddRange(New Object() {"Deviation from Credit Limit", "Deviation from Commitment", "Gross Profit %", "Discount %", "Deviation from Budget", "Total Document"})
        Me.cboConditions.Location = New System.Drawing.Point(136, 64)
        Me.cboConditions.Name = "cboConditions"
        Me.cboConditions.Size = New System.Drawing.Size(144, 21)
        Me.cboConditions.TabIndex = 24
        '
        'chkIncludeTerms
        '
        Me.chkIncludeTerms.Checked = True
        Me.chkIncludeTerms.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeTerms.Location = New System.Drawing.Point(8, 24)
        Me.chkIncludeTerms.Name = "chkIncludeTerms"
        Me.chkIncludeTerms.Size = New System.Drawing.Size(128, 16)
        Me.chkIncludeTerms.TabIndex = 23
        Me.chkIncludeTerms.Text = "Include Terms"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Condition Type"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Value"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "OperationType"
        '
        'ApprovalTemplateForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 455)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbDocuments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStageCode)
        Me.Controls.Add(Me.txtUserCode)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ApprovalTemplateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Template "
        Me.gbDocuments.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim oApprovalTemplateService As ApprovalTemplatesService

    Private Sub ApprovalTemplateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
        
            Call InitService()

            Call InitCtrls()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    'init combo 
    Private Sub InitCtrls()
        Try

        'default condition 
        cboConditions.SelectedIndex = 3

        'default operation
        cboOperation.SelectedIndex = 0

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
    'add checked documents
    Private Sub AddCheckedDocumnets(ByVal oApprovalTemplate As ApprovalTemplate)

        Try
            Dim oControl As Control
            Dim oCheckBox As CheckBox

            For Each oControl In gbDocuments.Controls

                If TypeName(oControl) = "CheckBox" Then

                    oCheckBox = oControl

                    If oCheckBox.Checked = True Then Call AddDocumnetTypeToTemplate(oCheckBox.Text, oApprovalTemplate)

                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ' add document type to Template
    Private Function AddDocumnetTypeToTemplate(ByVal sDocument As String, ByVal oApprovalTemplate As ApprovalTemplate) As ApprovalTemplatesDocumentTypeEnum

        Try

            Select Case sDocument
                Case "Sales Quotation"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtQuotation

                Case "Sales Order"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtOrder

                Case "Delivery"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtDelivery

                Case "Returns"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtReturns

                Case "A/R Invoice"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtArInvoice

                Case "A/R Credit Memo"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtArCreditMemo

                Case "Purchase Order"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtPurchaseOrder

                Case "Goods Receipt PO"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtGoodsReceiptPO

                Case "Goods Returns"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtGoodsReturns

                Case "A/P Invoice"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtApInvoice

                Case "A/P Credit Memo"

                    oApprovalTemplate.ApprovalTemplateDocuments.Add.DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtApCreditMemo

            End Select


        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    'return the Condition type
    Private Function GetCondition(ByVal sCondition As String) As ApprovalTemplateConditionTypeEnum

        Try

            Select Case sCondition
                Case "Deviation from Credit Limit"

                    Return (ApprovalTemplateConditionTypeEnum.atctDeviationFromCreditLine)

                Case "Deviation from Commitment"

                    Return (ApprovalTemplateConditionTypeEnum.atctDeviationFromObligo)

                Case "Gross Profit %"

                    Return (ApprovalTemplateConditionTypeEnum.atctGrossProfitPercent)

                Case "Discount %"

                    Return (ApprovalTemplateConditionTypeEnum.atctDiscountPercent)

                Case "Deviation from Budget"

                    Return (ApprovalTemplateConditionTypeEnum.atctDeviationFromBudget)

                Case "Total Document"

                    Return (ApprovalTemplateConditionTypeEnum.atctTotalDocument)

            End Select


        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    'return the Operation type
    Private Function GetOperation(ByVal sOperation As String) As ApprovalTemplateOperationTypeEnum


        Try

            Select Case sOperation
                Case "Greater than"

                    Return (ApprovalTemplateOperationTypeEnum.opcodeGreaterThan)

                Case "Greater or Equal"

                    Return (ApprovalTemplateOperationTypeEnum.opcodeGreaterOrEqual)

                Case "Less than"

                    Return (ApprovalTemplateOperationTypeEnum.opcodeLessThan)

                Case "Less or Equel"

                    Return (ApprovalTemplateOperationTypeEnum.opcodeLessOrEqual)

                Case "Equel"

                    Return (ApprovalTemplateOperationTypeEnum.opcodeEqual)

                Case "Does not Equel"

                    Return (ApprovalTemplateOperationTypeEnum.opcodeDoesNotEqual)

                Case "In Range"

                    Return (ApprovalTemplateOperationTypeEnum.opcodeInRange)

                Case "Not in Range"

                    Return (ApprovalTemplateOperationTypeEnum.opcodeNotInRange)

            End Select


        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function
    'initialize the services
    Private Sub InitService()

        Try
            Call initCompanyService()

            'get Approval Stages Service 
            oApprovalTemplateService = oCmpSrv.GetBusinessService(ServiceTypes.ApprovalTemplatesService)

        Catch ex As Exception

            MsgBox(ex.Message())

        End Try

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Dim oApprovalTemplateStage As ApprovalTemplateStage
        Dim oApprovalTemplate As ApprovalTemplate
        Dim oApprovalTemplateParams As ApprovalTemplateParams
        Dim oApprovalTemplateTerm As ApprovalTemplateTerm


        Try

            'get new Approval Stage
            oApprovalTemplate = oApprovalTemplateService.GetDataInterface(ApprovalTemplatesServiceDataInterfaces.atsdiApprovalTemplate)

            'set the name of the Approval Template
            oApprovalTemplate.Name = txtName.Text

            'add the user that need the approval(userId=3 is "Fred")
            oApprovalTemplate.ApprovalTemplateUsers.Add.UserID = txtUserCode.Text

            'Add the checked documnets  
            Call AddCheckedDocumnets(oApprovalTemplate)

            'get Approval Stages
            oApprovalTemplateStage = oApprovalTemplate.ApprovalTemplateStages.Add

            'set the code of an existing stage(e.g code=1 the stage name is Accounting)
            oApprovalTemplateStage.ApprovalStageCode = CInt(txtStageCode.Text)

            'include terms in the template 
            oApprovalTemplate.UseTerms = IIf(chkIncludeTerms.Checked = True, BoYesNoEnum.tYES, BoYesNoEnum.tNO)

            'add new term
            oApprovalTemplateTerm = oApprovalTemplate.ApprovalTemplateTerms.Add

            'set the condition
            oApprovalTemplateTerm.ConditionType = GetCondition(cboConditions.SelectedItem)

            'set the Operation Type
            oApprovalTemplateTerm.OperationType = GetOperation(cboOperation.SelectedItem)

            'set the value
            oApprovalTemplateTerm.Value = txtTermValue.Text

            'add Approval Template
            oApprovalTemplateParams = oApprovalTemplateService.AddApprovalTemplate(oApprovalTemplate)


            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

End Class
