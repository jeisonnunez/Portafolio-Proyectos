'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      MessageForm.vb
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
' Display all messages : Inbox , Outbox, SentMessages
'
'****************************************************************************


Imports System.IO
Imports SAPbobsCOM
Public Class MessageForm
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
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lsvInbox As System.Windows.Forms.ListView
    Friend WithEvents Subject As System.Windows.Forms.ColumnHeader
    Friend WithEvents MsgDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents From As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents Attachment As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LsvSendbox As System.Windows.Forms.TabControl
    Friend WithEvents LsvOutbox As System.Windows.Forms.ListView
    Friend WithEvents LsvSendMsg As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdSendMsg As System.Windows.Forms.Button
    Friend WithEvents lswInboxDetails As System.Windows.Forms.ListView
    Friend WithEvents BPCODE As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContactPerson As System.Windows.Forms.ColumnHeader
    Friend WithEvents Telephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Remarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents lswOutboxDetails As System.Windows.Forms.ListView
    Friend WithEvents ToName As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvDetailsSent As System.Windows.Forms.ListView
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LsvSendbox = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lswInboxDetails = New System.Windows.Forms.ListView
        Me.BPCODE = New System.Windows.Forms.ColumnHeader
        Me.ContactPerson = New System.Windows.Forms.ColumnHeader
        Me.Telephone = New System.Windows.Forms.ColumnHeader
        Me.Remarks = New System.Windows.Forms.ColumnHeader
        Me.lsvInbox = New System.Windows.Forms.ListView
        Me.Subject = New System.Windows.Forms.ColumnHeader
        Me.MsgDate = New System.Windows.Forms.ColumnHeader
        Me.From = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.Attachment = New System.Windows.Forms.ColumnHeader
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lswOutboxDetails = New System.Windows.Forms.ListView
        Me.ToName = New System.Windows.Forms.ColumnHeader
        Me.DateEmail = New System.Windows.Forms.ColumnHeader
        Me.TimeEmail = New System.Windows.Forms.ColumnHeader
        Me.LsvOutbox = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.lsvDetailsSent = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.LsvSendMsg = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.cmdSendMsg = New System.Windows.Forms.Button
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.LsvSendbox.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvSendbox
        '
        Me.LsvSendbox.Controls.Add(Me.TabPage1)
        Me.LsvSendbox.Controls.Add(Me.TabPage2)
        Me.LsvSendbox.Controls.Add(Me.TabPage3)
        Me.LsvSendbox.Location = New System.Drawing.Point(16, 16)
        Me.LsvSendbox.Name = "LsvSendbox"
        Me.LsvSendbox.SelectedIndex = 0
        Me.LsvSendbox.Size = New System.Drawing.Size(408, 344)
        Me.LsvSendbox.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lswInboxDetails)
        Me.TabPage1.Controls.Add(Me.lsvInbox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(400, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inbox"
        '
        'lswInboxDetails
        '
        Me.lswInboxDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BPCODE, Me.ContactPerson, Me.Telephone, Me.Remarks})
        Me.lswInboxDetails.GridLines = True
        Me.lswInboxDetails.Location = New System.Drawing.Point(16, 168)
        Me.lswInboxDetails.Name = "lswInboxDetails"
        Me.lswInboxDetails.Size = New System.Drawing.Size(360, 120)
        Me.lswInboxDetails.TabIndex = 1
        Me.lswInboxDetails.View = System.Windows.Forms.View.Details
        '
        'BPCODE
        '
        Me.BPCODE.Text = "BP CODE"
        Me.BPCODE.Width = 80
        '
        'ContactPerson
        '
        Me.ContactPerson.Text = "Contact Person"
        Me.ContactPerson.Width = 90
        '
        'Telephone
        '
        Me.Telephone.Text = "Telephone"
        Me.Telephone.Width = 77
        '
        'Remarks
        '
        Me.Remarks.Text = "Remarks"
        Me.Remarks.Width = 80
        '
        'lsvInbox
        '
        Me.lsvInbox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Subject, Me.MsgDate, Me.From, Me.Status, Me.Attachment})
        Me.lsvInbox.FullRowSelect = True
        Me.lsvInbox.GridLines = True
        Me.lsvInbox.Location = New System.Drawing.Point(16, 16)
        Me.lsvInbox.Name = "lsvInbox"
        Me.lsvInbox.Size = New System.Drawing.Size(360, 120)
        Me.lsvInbox.TabIndex = 0
        Me.lsvInbox.View = System.Windows.Forms.View.Details
        '
        'Subject
        '
        Me.Subject.Text = "Subject"
        Me.Subject.Width = 80
        '
        'MsgDate
        '
        Me.MsgDate.Text = "Date"
        '
        'From
        '
        Me.From.Text = "From"
        '
        'Status
        '
        Me.Status.Text = "Status"
        '
        'Attachment
        '
        Me.Attachment.Text = "Attachment"
        Me.Attachment.Width = 80
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lswOutboxDetails)
        Me.TabPage2.Controls.Add(Me.LsvOutbox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(400, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OutBox"
        '
        'lswOutboxDetails
        '
        Me.lswOutboxDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ToName, Me.DateEmail, Me.TimeEmail})
        Me.lswOutboxDetails.GridLines = True
        Me.lswOutboxDetails.Location = New System.Drawing.Point(16, 176)
        Me.lswOutboxDetails.Name = "lswOutboxDetails"
        Me.lswOutboxDetails.Size = New System.Drawing.Size(360, 120)
        Me.lswOutboxDetails.TabIndex = 2
        Me.lswOutboxDetails.View = System.Windows.Forms.View.Details
        '
        'ToName
        '
        Me.ToName.Text = "To"
        Me.ToName.Width = 80
        '
        'DateEmail
        '
        Me.DateEmail.Text = "Date"
        '
        'TimeEmail
        '
        Me.TimeEmail.Text = "Time"
        Me.TimeEmail.Width = 80
        '
        'LsvOutbox
        '
        Me.LsvOutbox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LsvOutbox.GridLines = True
        Me.LsvOutbox.Location = New System.Drawing.Point(8, 16)
        Me.LsvOutbox.Name = "LsvOutbox"
        Me.LsvOutbox.Size = New System.Drawing.Size(360, 120)
        Me.LsvOutbox.TabIndex = 1
        Me.LsvOutbox.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Attachment"
        Me.ColumnHeader4.Width = 80
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lsvDetailsSent)
        Me.TabPage3.Controls.Add(Me.LsvSendMsg)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(400, 318)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sent Messages"
        '
        'lsvDetailsSent
        '
        Me.lsvDetailsSent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lsvDetailsSent.GridLines = True
        Me.lsvDetailsSent.Location = New System.Drawing.Point(16, 168)
        Me.lsvDetailsSent.Name = "lsvDetailsSent"
        Me.lsvDetailsSent.Size = New System.Drawing.Size(360, 120)
        Me.lsvDetailsSent.TabIndex = 3
        Me.lsvDetailsSent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "To"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Date"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Time"
        Me.ColumnHeader12.Width = 80
        '
        'LsvSendMsg
        '
        Me.LsvSendMsg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.LsvSendMsg.FullRowSelect = True
        Me.LsvSendMsg.GridLines = True
        Me.LsvSendMsg.Location = New System.Drawing.Point(8, 16)
        Me.LsvSendMsg.Name = "LsvSendMsg"
        Me.LsvSendMsg.Size = New System.Drawing.Size(368, 120)
        Me.LsvSendMsg.TabIndex = 1
        Me.LsvSendMsg.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Subject"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Date"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Time"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Attachment"
        Me.ColumnHeader9.Width = 80
        '
        'cmdSendMsg
        '
        Me.cmdSendMsg.Location = New System.Drawing.Point(312, 384)
        Me.cmdSendMsg.Name = "cmdSendMsg"
        Me.cmdSendMsg.Size = New System.Drawing.Size(112, 24)
        Me.cmdSendMsg.TabIndex = 1
        Me.cmdSendMsg.Text = "Send Massage"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(192, 384)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(112, 24)
        Me.cmdRefresh.TabIndex = 2
        Me.cmdRefresh.Text = "Refresh"
        '
        'MessageForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 429)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdSendMsg)
        Me.Controls.Add(Me.LsvSendbox)
        Me.Name = "MessageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message "
        Me.LsvSendbox.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub MessageForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitService()

        Call FillAllViews()

    End Sub

    Private Sub FillAllViews()

        'fill inbox
        Call FillInboxView()

        'fill outbox
        Call FillOutboxView()

        'fill sent messages
        Call FillSendMsgView()

    End Sub

    'fill Sent Messages 
    Private Sub FillSendMsgView()

        Dim oCmpSrv As SAPbobsCOM.CompanyService
        Dim oMessageService As MessagesService
        Dim oUserSendMsg As MessageHeaders
        Dim oMessageHeader As MessageHeader
        Dim oMessage As Message
        Dim iAttachment As Integer
        Dim sAttachmentPath As String
        Dim i As Integer

        Try

        
        'get company service
        oCmpSrv = oCompany.GetCompanyService

        'get msg service
        oMessageService = oCmpSrv.GetBusinessService(ServiceTypes.MessagesService)

        'get Sent Messages
        oUserSendMsg = oMessageService.GetSentMessages

        For i = 0 To oUserSendMsg.Count - 1

            'get first message header
            oMessageHeader = oUserSendMsg.Item(i)

            'get the first message
            oMessage = oMessageService.GetMessage(oMessageHeader)

            Dim pItem As New ListViewItem(oMessage.Subject)

            'insert date
            pItem.SubItems.Add(oMessageHeader.SentDate.ToShortDateString)

            'insert time
            pItem.SubItems.Add(oMessageHeader.SentTime.ToShortTimeString)

            'get attachement 
            iAttachment = oMessage.Attachment

            'add attachment
            If iAttachment = 0 Then
                'no attachment
                pItem.SubItems.Add("No Attachment")
            Else
                'get attachment path    
                sAttachmentPath = GetAttachmentPath(iAttachment)
                'add the attachment path 
                pItem.SubItems.Add(sAttachmentPath)
            End If

            LsvSendMsg.Items.Add(pItem)

        Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'fill the message inbox
    Private Sub FillInboxView()

        Dim oUserInbox As MessageHeaders
        Dim oMessageHeader As MessageHeader
        Dim oMessage As Message
        Dim sUserName As String
        Dim iAttachment As Integer
        Dim i As Integer
        Dim sAttachmentPath As String

        Try

        
        'get inbox
        oUserInbox = oMessageService.GetInbox

        For i = 0 To oUserInbox.Count - 1

            'get first message header
            oMessageHeader = oUserInbox.Item(i)

            'get the first message
            oMessage = oMessageService.GetMessage(oMessageHeader)

            'insert subject
            Dim pItem As New ListViewItem(oMessage.Subject)

            'insert Date
            pItem.SubItems.Add(oMessageHeader.ReceivedDate)

            'get the user's name
            sUserName = GetUserName(oMessage.User)

            'insert user name
            pItem.SubItems.Add(sUserName)

            'insert email status (opened/not opened)
            If oMessageHeader.Read = BoYesNoEnum.tYES Then
                pItem.SubItems.Add("Opened")
            Else
                pItem.SubItems.Add("Not Opened")
            End If

            'get attachement 
            iAttachment = oMessage.Attachment

            'add attachment
            If iAttachment = 0 Then
                'no attachment
                pItem.SubItems.Add("No Attachment")
            Else
                'get attachment path    
                sAttachmentPath = GetAttachmentPath(iAttachment)
                'add the attachment path 
                pItem.SubItems.Add(sAttachmentPath)
            End If

            'add the message to the inbox list view
            lsvInbox.Items.Add(pItem)

        Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'The function return the user name
    Private Function GetUserName(ByVal iAttachment As Integer) As String

        Dim oUsers As Users
        Dim sUserName As String

        Try

            'get users 
        oUsers = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers)

        Dim bGetByKey As Boolean

        'get the user 
        bGetByKey = oUsers.GetByKey(iAttachment)

        'get user name
        sUserName = oUsers.UserName

        Return sUserName

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function


    'The function return the path of the attachment file  
    Private Function GetAttachmentPath(ByVal iAttachment As Integer) As String

        Dim oAttachment As Attachments2

        Try

        
        'get attachment object
        oAttachment = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oAttachments2)

        Dim bGetByKey As Boolean

        'get the specific attachmnet
        bGetByKey = oAttachment.GetByKey(iAttachment)

        Dim sAttachment As String

        'get the path to the attachment
        sAttachment = oAttachment.Lines.SourcePath & "\" & oAttachment.Lines.FileName & "." & oAttachment.Lines.FileExtension

        Return sAttachment

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    'fill outbox view
    Private Sub FillOutboxView()

        Dim oUserOutbox As MessageHeaders
        Dim oMessageHeader As MessageHeader
        Dim oMessage As Message
        Dim iAttachment As Integer
        Dim sAttachmentPath As String
        Dim i As Integer

        Try

        
        'get inbox
        oUserOutbox = oMessageService.GetOutbox


        'insert all messages to the inbox view
        For i = 0 To oUserOutbox.Count - 1

            'get first message header
            oMessageHeader = oUserOutbox.Item(i)

            'get the first message
            oMessage = oMessageService.GetMessage(oMessageHeader)

            'insert subject
            Dim pItem As New ListViewItem(oMessage.Subject)

            'insert date
            pItem.SubItems.Add(oMessageHeader.SentDate.ToShortDateString)

            'insert time
            pItem.SubItems.Add(oMessageHeader.SentTime.ToShortTimeString)

            'get attachement 
            iAttachment = oMessage.Attachment

            'add attachment
            If iAttachment = 0 Then
                'no attachment
                pItem.SubItems.Add("No Attachment")
            Else
                'get attachment path    
                sAttachmentPath = GetAttachmentPath(iAttachment)
                'add the attachment path 
                pItem.SubItems.Add(sAttachmentPath)
            End If

            LsvOutbox.Items.Add(pItem)

        Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'open send dialog
    Private Sub cmdSendMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendMsg.Click

        Dim pSendMsgForm As New SendMsgForm

        pSendMsgForm.ShowDialog()


    End Sub

    'show the inbox details according to the message that was clicked
    Private Sub lsvInbox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvInbox.Click


        Dim oMessageHeader As MessageHeader
        Dim oMessage As Message
        Dim oUserInbox As MessageHeaders
        Dim oMessageDataColumns As MessageDataColumns
        Dim oLvwSelectedItems As ListView.SelectedListViewItemCollection
        Dim oMessageDataLines As MessageDataLines
        Dim oMessageDataLine As MessageDataLine
        Dim oMessageDataColumn As MessageDataColumn
        Dim iIndex As Integer
        Dim j As Integer
        Dim i As Integer

        Try

        
        oLvwSelectedItems = lsvInbox.SelectedItems

        'get selected item from list view
        iIndex = oLvwSelectedItems.Item(0).Index

        'get inbox
        oUserInbox = oMessageService.GetInbox

        'get message by index
        oMessageHeader = oUserInbox.Item(iIndex)

        'get the first message
        oMessage = oMessageService.GetMessage(oMessageHeader)

        'get all columns data
        oMessageDataColumns = oMessage.MessageDataColumns()

        'clear all items in details view
        lswInboxDetails.Items.Clear()

        'insert data to all columns
        'the insert is by columns and not by rows
        For i = 0 To oMessageDataColumns.Count - 1
            'get column
            oMessageDataColumn = oMessageDataColumns.Item(i)
            'get all column lines(getting all column data and not row)
            oMessageDataLines = oMessageDataColumn.MessageDataLines()

            For j = 0 To oMessageDataLines.Count - 1

                If i = 0 Then
                    'get column data line
                    oMessageDataLine = oMessageDataLines.Item(j)
                    'insert data to the first column
                    lswInboxDetails.Items.Add(oMessageDataLine.Value)
                Else
                    'get column data line
                    oMessageDataLine = oMessageDataLines.Item(j)

                    If oMessageDataLine.Value <> "" Then
                        Dim pItem As ListViewItem
                        'get item from list view
                        pItem = lswInboxDetails.Items(j)
                        'insert data
                        pItem.SubItems.Add(oMessageDataLine.Value)
                    End If

                End If
            Next j

        Next i


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    'show the Sent Massages details according to the message that was clicked
    Private Sub LsvSendMsg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LsvSendMsg.Click


        Dim oMessageHeader As MessageHeader
        Dim oMessage As Message
        Dim oUserSentMsg As MessageHeaders
        Dim oLvwSelectedItems As ListView.SelectedListViewItemCollection
        Dim iIndex As Integer
        Dim iAttachment As Integer
        Dim sRecipientName As String
        Dim pListItem As ListViewItem

        Try

        
        oLvwSelectedItems = LsvSendMsg.SelectedItems

        'get selected item from list view
        iIndex = oLvwSelectedItems.Item(0).Index

        'get inbox
        oUserSentMsg = oMessageService.GetSentMessages

        'get message by index
        oMessageHeader = oUserSentMsg.Item(iIndex)

        'get the first message
        oMessage = oMessageService.GetMessage(oMessageHeader)

        'clear all items in details view
        lsvDetailsSent.Items.Clear()

        'get the recipient name(TO)
        Dim oRecipientCollection As RecipientCollection

        'get Recipient collection
        oRecipientCollection = oMessage.RecipientCollection

        'get name
        sRecipientName = oRecipientCollection.Item(0).NameTo()

        'add Recipient Name to list
        pListItem = lsvDetailsSent.Items.Add(sRecipientName)

        'add Received Date 
        pListItem.SubItems.Add(oMessageHeader.ReceivedDate.ToShortDateString)

        'add Received Time 
        pListItem.SubItems.Add(oMessageHeader.ReceivedTime.ToShortTimeString)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    'show the Outbox details according to the message that was clicked
    Private Sub LsvOutbox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LsvOutbox.Click


        Dim oMessageHeader As MessageHeader
        Dim oMessage As Message
        Dim oOutBoxMsg As MessageHeaders
        Dim oLvwSelectedItems As ListView.SelectedListViewItemCollection
        Dim iIndex As Integer
        Dim iAttachment As Integer
        Dim sRecipientName As String
        Dim pListItem As ListViewItem

        Try

        
        oLvwSelectedItems = LsvOutbox.SelectedItems

        'get selected item from list view
        iIndex = oLvwSelectedItems.Item(0).Index

        'get inbox
        oOutBoxMsg = oMessageService.GetSentMessages

        'get message by index
        oMessageHeader = oOutBoxMsg.Item(iIndex)

        'get the first message
        oMessage = oMessageService.GetMessage(oMessageHeader)

        'clear all items in details view
        lswOutboxDetails.Items.Clear()

        'get the recipient name(TO)
        Dim oRecipientCollection As RecipientCollection

        'get Recipient collection
        oRecipientCollection = oMessage.RecipientCollection

        'get name
        sRecipientName = oRecipientCollection.Item(0).NameTo()

        'add Recipient Name to list
        pListItem = lswOutboxDetails.Items.Add(sRecipientName)

        'add Received Date
        pListItem.SubItems.Add(oMessageHeader.ReceivedDate.ToShortDateString)

        'add Received Time
        pListItem.SubItems.Add(oMessageHeader.ReceivedTime.ToShortTimeString)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub lswInboxDetails_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lswInboxDetails.SelectedIndexChanged

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click

        Try

        'clear all items in views
        lsvInbox.Items.Clear()
        LsvOutbox.Items.Clear()
        LsvSendMsg.Items.Clear()

        'refresh the list views: inbox , outbox ,sentmessages
        Call FillAllViews()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class
