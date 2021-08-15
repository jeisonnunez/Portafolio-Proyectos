
'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      SendMsgForm.vb
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
' Send message to a recipient
'
'****************************************************************************

Imports SAPbobsCOM

Public Class SendMsgForm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdSendMessage As System.Windows.Forms.Button
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents txtRecipient As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstColumn As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstLine As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObjectKey As System.Windows.Forms.TextBox
    Friend WithEvents txtObjectType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.txtText = New System.Windows.Forms.TextBox
        Me.txtRecipient = New System.Windows.Forms.TextBox
        Me.txtFirstColumn = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFirstLine = New System.Windows.Forms.TextBox
        Me.cmdSendMessage = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtObjectKey = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtObjectType = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(128, 32)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(120, 20)
        Me.txtSubject.TabIndex = 0
        Me.txtSubject.Text = "My Subject"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(128, 64)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(120, 20)
        Me.txtText.TabIndex = 1
        Me.txtText.Text = "My Text"
        '
        'txtRecipient
        '
        Me.txtRecipient.Location = New System.Drawing.Point(128, 96)
        Me.txtRecipient.Name = "txtRecipient"
        Me.txtRecipient.Size = New System.Drawing.Size(120, 20)
        Me.txtRecipient.TabIndex = 2
        Me.txtRecipient.Text = "Bill Johnson"
        '
        'txtFirstColumn
        '
        Me.txtFirstColumn.Location = New System.Drawing.Point(128, 128)
        Me.txtFirstColumn.Name = "txtFirstColumn"
        Me.txtFirstColumn.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstColumn.TabIndex = 3
        Me.txtFirstColumn.Text = "Bp Code"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Text"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Recipient Name"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "First Column Name"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "First Line Value"
        '
        'txtFirstLine
        '
        Me.txtFirstLine.Location = New System.Drawing.Point(128, 160)
        Me.txtFirstLine.Name = "txtFirstLine"
        Me.txtFirstLine.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstLine.TabIndex = 9
        Me.txtFirstLine.Text = "HU1003"
        '
        'cmdSendMessage
        '
        Me.cmdSendMessage.Location = New System.Drawing.Point(168, 312)
        Me.cmdSendMessage.Name = "cmdSendMessage"
        Me.cmdSendMessage.Size = New System.Drawing.Size(104, 24)
        Me.cmdSendMessage.TabIndex = 10
        Me.cmdSendMessage.Text = "Send Message"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtObjectKey)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtObjectType)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 104)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Link Line To Object"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(112, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "(e.g. Bp Type=2)"
        '
        'txtObjectKey
        '
        Me.txtObjectKey.Location = New System.Drawing.Point(112, 72)
        Me.txtObjectKey.Name = "txtObjectKey"
        Me.txtObjectKey.Size = New System.Drawing.Size(120, 20)
        Me.txtObjectKey.TabIndex = 18
        Me.txtObjectKey.Text = "HU1003"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Object Key"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 14)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Object Type       "
        '
        'txtObjectType
        '
        Me.txtObjectType.Location = New System.Drawing.Point(112, 32)
        Me.txtObjectType.Name = "txtObjectType"
        Me.txtObjectType.Size = New System.Drawing.Size(120, 20)
        Me.txtObjectType.TabIndex = 15
        Me.txtObjectType.Text = "2"
        '
        'SendMsgForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(288, 349)
        Me.Controls.Add(Me.cmdSendMessage)
        Me.Controls.Add(Me.txtFirstLine)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstColumn)
        Me.Controls.Add(Me.txtRecipient)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SendMsgForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Message "
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sErrMsg As String
    Dim lErrCode As Long

    Private Sub SendMsgForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    'The function sends internal message to a recipient
    Private Sub cmdSendMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendMessage.Click


        Dim oMessage As Message
        Dim pMessageDataColumns As MessageDataColumns
        Dim pMessageDataColumn As MessageDataColumn
        Dim oLines As MessageDataLines
        Dim oLine As MessageDataLine
        Dim oRecipientCollection As RecipientCollection

        Try

        'get the data interface for the new message
        oMessage = oMessageService.GetDataInterface(MessagesServiceDataInterfaces.msdiMessage)

        'fill subject
        oMessage.Subject = txtSubject.Text

        oMessage.Text = txtText.Text

        'Add Recipient 
        oRecipientCollection = oMessage.RecipientCollection

        oRecipientCollection.Add()

        'send internal message
        oRecipientCollection.Item(0).SendInternal = BoYesNoEnum.tYES

        'add existing user name
        oRecipientCollection.Item(0).UserCode = GetUserCode(txtRecipient.Text)

        'get columns data
        pMessageDataColumns = oMessage.MessageDataColumns
        'get column
        pMessageDataColumn = pMessageDataColumns.Add()
        'set column name
        pMessageDataColumn.ColumnName = txtFirstColumn.Text

        'set link to a real object in the application
        pMessageDataColumn.Link = BoYesNoEnum.tYES

        'get lines
        oLines = pMessageDataColumn.MessageDataLines()
        'add new line
        oLine = oLines.Add()
        'set the line value
        oLine.Value = txtFirstLine.Text

        'set the link to BusinessPartner (the object type for Bp is 2)
        oLine.Object = txtObjectType.Text
        'set the Bp code
        oLine.ObjectKey = txtObjectKey.Text

        'send the message
        oMessageService.SendMessage(oMessage)

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try



    End Sub

    'The function is using the user name to return the user code  
    Private Function GetUserCode(ByVal sUserName As String) As String

        Dim oUsers As Users
        Dim oRecordSet As SAPbobsCOM.Recordset

        Try
            'get users object
            oUsers = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers)

            ' Get a new Recordset object
            oRecordSet = oCompany.GetBusinessObject(BoObjectTypes.BoRecordset)

            ' Perform the SELECT statement.
            ' The query result will be loaded
            ' into the Recordset object
            oRecordSet.DoQuery("Select USER_CODE from OUSR")

            ' Asign (link) the Recordset object
            ' to the Browser.Recordset property
            oUsers.Browser.Recordset = oRecordSet

            'find the username 
            While (oUsers.Browser.EoF = False)
                If oUsers.UserName = sUserName Then
                    Exit While
                End If
                oUsers.Browser.MoveNext()
            End While

            'return the User Code 
            Return oUsers.UserCode

        Catch ex As Exception

            MsgBox(ex.Message())

        End Try

    End Function

End Class
