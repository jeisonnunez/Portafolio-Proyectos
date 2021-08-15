'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:     ApprovalStagesForm.vb
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
' Add a new Approval Stage
'
'****************************************************************************

Imports SAPbobsCOM

Public Class ApprovalStagesForm
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
    Friend WithEvents txtStageName As System.Windows.Forms.TextBox
    Friend WithEvents txtStageDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtNumOfReqApprovals As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtSecondUser As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstUser As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.txtStageName = New System.Windows.Forms.TextBox
        Me.txtStageDescription = New System.Windows.Forms.TextBox
        Me.txtNumOfReqApprovals = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.label = New System.Windows.Forms.Label
        Me.txtSecondUser = New System.Windows.Forms.TextBox
        Me.txtFirstUser = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(192, 248)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(80, 24)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add "
        '
        'txtStageName
        '
        Me.txtStageName.Location = New System.Drawing.Point(136, 16)
        Me.txtStageName.Name = "txtStageName"
        Me.txtStageName.Size = New System.Drawing.Size(120, 20)
        Me.txtStageName.TabIndex = 1
        Me.txtStageName.Text = "My Approval "
        '
        'txtStageDescription
        '
        Me.txtStageDescription.Location = New System.Drawing.Point(136, 56)
        Me.txtStageDescription.Name = "txtStageDescription"
        Me.txtStageDescription.Size = New System.Drawing.Size(120, 20)
        Me.txtStageDescription.TabIndex = 2
        Me.txtStageDescription.Text = "My Description"
        '
        'txtNumOfReqApprovals
        '
        Me.txtNumOfReqApprovals.Location = New System.Drawing.Point(136, 96)
        Me.txtNumOfReqApprovals.Name = "txtNumOfReqApprovals"
        Me.txtNumOfReqApprovals.Size = New System.Drawing.Size(120, 20)
        Me.txtNumOfReqApprovals.TabIndex = 3
        Me.txtNumOfReqApprovals.Text = "1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Stage Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Stage Description"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Number Of Req Approvals"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.txtSecondUser)
        Me.GroupBox1.Controls.Add(Me.txtFirstUser)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 96)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Approvers"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Second User"
        '
        'label
        '
        Me.label.Location = New System.Drawing.Point(8, 26)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(96, 16)
        Me.label.TabIndex = 14
        Me.label.Text = "First User"
        '
        'txtSecondUser
        '
        Me.txtSecondUser.Location = New System.Drawing.Point(112, 56)
        Me.txtSecondUser.Name = "txtSecondUser"
        Me.txtSecondUser.Size = New System.Drawing.Size(120, 20)
        Me.txtSecondUser.TabIndex = 13
        Me.txtSecondUser.Text = "2"
        '
        'txtFirstUser
        '
        Me.txtFirstUser.Location = New System.Drawing.Point(112, 24)
        Me.txtFirstUser.Name = "txtFirstUser"
        Me.txtFirstUser.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstUser.TabIndex = 12
        Me.txtFirstUser.Text = "1"
        '
        'ApprovalStagesForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 287)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumOfReqApprovals)
        Me.Controls.Add(Me.txtStageDescription)
        Me.Controls.Add(Me.txtStageName)
        Me.Controls.Add(Me.cmdAdd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ApprovalStagesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Stages"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim oApprovalStagesService As ApprovalStagesService


    Private Sub ApprovalStagesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitService()

    End Sub

    Private Sub InitService()

        Try
            Call initCompanyService()

            'get Approval Stages Service 
            oApprovalStagesService = oCmpSrv.GetBusinessService(ServiceTypes.ApprovalStagesService)

        Catch ex As Exception

            MsgBox(ex.Message())

        End Try

    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Dim oApprovalStage As ApprovalStage
        Dim oApprovalStageApprovers As ApprovalStageApprovers
        Dim oFirstApprover As ApprovalStageApprover
        Dim oSecondApprover As ApprovalStageApprover
        Dim oApprovalStageParams As ApprovalStageParams


        Try

            'get new Approval Stage
            oApprovalStage = oApprovalStagesService.GetDataInterface(ApprovalStagesServiceDataInterfaces.assdiApprovalStage)

            'set the name
            oApprovalStage.Name = txtStageName.Text

            oApprovalStage.Remarks = txtStageDescription.Text

            'get ApprovalStageApprovers collection
            oApprovalStageApprovers = oApprovalStage.ApprovalStageApprovers

            'add new Approver
            oFirstApprover = oApprovalStageApprovers.Add

            'set the approver id(manager)
            oFirstApprover.UserID = txtFirstUser.Text

            'add new Approver
            oSecondApprover = oApprovalStageApprovers.Add

            'set the approver id
            oSecondApprover.UserID = txtSecondUser.Text

            'set the number of required approvers
            oApprovalStage.NoOfApproversRequired = txtNumOfReqApprovals.Text

            'add Approval Stage
            oApprovalStageParams = oApprovalStagesService.AddApprovalStage(oApprovalStage)

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub
End Class
