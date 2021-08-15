Public Class ItemManagement
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents goodsReceipt As System.Windows.Forms.Button
    Friend WithEvents GoodsIssue As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MsgBoxLabel As System.Windows.Forms.Label
    Friend WithEvents MsgBoxLabel_1 As System.Windows.Forms.Label
    Friend WithEvents addItemButton As System.Windows.Forms.Button
    Friend WithEvents getItemButton As System.Windows.Forms.Button
    Friend WithEvents deleteItemButton As System.Windows.Forms.Button
    Friend WithEvents NoneRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents manSerRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents manBatchRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OnReleaseOnly As System.Windows.Forms.CheckBox
    Friend WithEvents forceSerial As System.Windows.Forms.CheckBox
    Friend WithEvents ItemIDText As System.Windows.Forms.TextBox
    Friend WithEvents ItemNameText As System.Windows.Forms.TextBox
    Friend WithEvents itemKind As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ItemIDText = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.addItemButton = New System.Windows.Forms.Button
        Me.getItemButton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ItemNameText = New System.Windows.Forms.TextBox
        Me.manSerRadioButton = New System.Windows.Forms.RadioButton
        Me.deleteItemButton = New System.Windows.Forms.Button
        Me.OnReleaseOnly = New System.Windows.Forms.CheckBox
        Me.forceSerial = New System.Windows.Forms.CheckBox
        Me.itemKind = New System.Windows.Forms.Label
        Me.goodsReceipt = New System.Windows.Forms.Button
        Me.GoodsIssue = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NoneRadioButton = New System.Windows.Forms.RadioButton
        Me.manBatchRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MsgBoxLabel = New System.Windows.Forms.Label
        Me.MsgBoxLabel_1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemIDText
        '
        Me.ItemIDText.Location = New System.Drawing.Point(120, 24)
        Me.ItemIDText.Name = "ItemIDText"
        Me.ItemIDText.Size = New System.Drawing.Size(160, 20)
        Me.ItemIDText.TabIndex = 0
        Me.ItemIDText.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item ID:"
        '
        'addItemButton
        '
        Me.addItemButton.Location = New System.Drawing.Point(24, 32)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Size = New System.Drawing.Size(72, 30)
        Me.addItemButton.TabIndex = 2
        Me.addItemButton.Text = "add Item"
        '
        'getItemButton
        '
        Me.getItemButton.Location = New System.Drawing.Point(24, 72)
        Me.getItemButton.Name = "getItemButton"
        Me.getItemButton.Size = New System.Drawing.Size(72, 30)
        Me.getItemButton.TabIndex = 3
        Me.getItemButton.Text = "get Item"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Item Name:"
        '
        'ItemNameText
        '
        Me.ItemNameText.Location = New System.Drawing.Point(120, 56)
        Me.ItemNameText.Name = "ItemNameText"
        Me.ItemNameText.Size = New System.Drawing.Size(160, 20)
        Me.ItemNameText.TabIndex = 7
        Me.ItemNameText.Text = ""
        '
        'manSerRadioButton
        '
        Me.manSerRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manSerRadioButton.Location = New System.Drawing.Point(24, 48)
        Me.manSerRadioButton.Name = "manSerRadioButton"
        Me.manSerRadioButton.Size = New System.Drawing.Size(152, 18)
        Me.manSerRadioButton.TabIndex = 10
        Me.manSerRadioButton.Text = "Manage Serial Numbers"
        '
        'deleteItemButton
        '
        Me.deleteItemButton.Location = New System.Drawing.Point(24, 112)
        Me.deleteItemButton.Name = "deleteItemButton"
        Me.deleteItemButton.Size = New System.Drawing.Size(72, 30)
        Me.deleteItemButton.TabIndex = 12
        Me.deleteItemButton.Text = "delete Item"
        '
        'OnReleaseOnly
        '
        Me.OnReleaseOnly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnReleaseOnly.Location = New System.Drawing.Point(56, 72)
        Me.OnReleaseOnly.Name = "OnReleaseOnly"
        Me.OnReleaseOnly.Size = New System.Drawing.Size(176, 18)
        Me.OnReleaseOnly.TabIndex = 13
        Me.OnReleaseOnly.Text = "Manage On Release Only "
        '
        'forceSerial
        '
        Me.forceSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forceSerial.Location = New System.Drawing.Point(24, 136)
        Me.forceSerial.Name = "forceSerial"
        Me.forceSerial.Size = New System.Drawing.Size(280, 18)
        Me.forceSerial.TabIndex = 14
        Me.forceSerial.Text = "Force Serial/Batch Numbers Selection on Release"
        '
        'itemKind
        '
        Me.itemKind.BackColor = System.Drawing.SystemColors.Control
        Me.itemKind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.itemKind.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemKind.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.itemKind.Location = New System.Drawing.Point(144, 24)
        Me.itemKind.Name = "itemKind"
        Me.itemKind.Size = New System.Drawing.Size(168, 16)
        Me.itemKind.TabIndex = 15
        Me.itemKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'goodsReceipt
        '
        Me.goodsReceipt.Location = New System.Drawing.Point(16, 16)
        Me.goodsReceipt.Name = "goodsReceipt"
        Me.goodsReceipt.Size = New System.Drawing.Size(96, 24)
        Me.goodsReceipt.TabIndex = 16
        Me.goodsReceipt.Text = "Goods Receipt"
        '
        'GoodsIssue
        '
        Me.GoodsIssue.Location = New System.Drawing.Point(16, 56)
        Me.GoodsIssue.Name = "GoodsIssue"
        Me.GoodsIssue.Size = New System.Drawing.Size(96, 24)
        Me.GoodsIssue.TabIndex = 17
        Me.GoodsIssue.Text = "Goods Issue"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(48, 368)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(72, 30)
        Me.ExitButton.TabIndex = 18
        Me.ExitButton.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NoneRadioButton)
        Me.GroupBox1.Controls.Add(Me.manBatchRadioButton)
        Me.GroupBox1.Controls.Add(Me.manSerRadioButton)
        Me.GroupBox1.Controls.Add(Me.OnReleaseOnly)
        Me.GroupBox1.Controls.Add(Me.forceSerial)
        Me.GroupBox1.Controls.Add(Me.itemKind)
        Me.GroupBox1.Location = New System.Drawing.Point(328, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 208)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial and Batch numbers"
        '
        'NoneRadioButton
        '
        Me.NoneRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoneRadioButton.Location = New System.Drawing.Point(24, 24)
        Me.NoneRadioButton.Name = "NoneRadioButton"
        Me.NoneRadioButton.Size = New System.Drawing.Size(72, 18)
        Me.NoneRadioButton.TabIndex = 17
        Me.NoneRadioButton.Text = "None"
        '
        'manBatchRadioButton
        '
        Me.manBatchRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manBatchRadioButton.Location = New System.Drawing.Point(24, 104)
        Me.manBatchRadioButton.Name = "manBatchRadioButton"
        Me.manBatchRadioButton.Size = New System.Drawing.Size(152, 18)
        Me.manBatchRadioButton.TabIndex = 16
        Me.manBatchRadioButton.Text = "Manage Batch Numbers"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.getItemButton)
        Me.GroupBox2.Controls.Add(Me.addItemButton)
        Me.GroupBox2.Controls.Add(Me.deleteItemButton)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox2.Location = New System.Drawing.Point(24, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 168)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.GoodsIssue)
        Me.GroupBox3.Controls.Add(Me.goodsReceipt)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(328, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 96)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "(Inventory Gen Exit)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "(Inventory Gen Entry)"
        '
        'MsgBoxLabel
        '
        Me.MsgBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MsgBoxLabel.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.MsgBoxLabel.Location = New System.Drawing.Point(168, 360)
        Me.MsgBoxLabel.Name = "MsgBoxLabel"
        Me.MsgBoxLabel.Size = New System.Drawing.Size(432, 56)
        Me.MsgBoxLabel.TabIndex = 22
        '
        'MsgBoxLabel_1
        '
        Me.MsgBoxLabel_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MsgBoxLabel_1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.MsgBoxLabel_1.Location = New System.Drawing.Point(168, 432)
        Me.MsgBoxLabel_1.Name = "MsgBoxLabel_1"
        Me.MsgBoxLabel_1.Size = New System.Drawing.Size(432, 56)
        Me.MsgBoxLabel_1.TabIndex = 23
        '
        'ItemManagement
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(712, 509)
        Me.Controls.Add(Me.MsgBoxLabel_1)
        Me.Controls.Add(Me.MsgBoxLabel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ItemNameText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ItemIDText)
        Me.Name = "ItemManagement"
        Me.Text = "Item Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '//  SAP MANAGE DI API 2007 SDK Sample
    '//****************************************************************************
    '//
    '//  File:      ItemManagement.vb
    '//
    '//  Copyright (c) SAP MANAGE
    '//
    '// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
    '// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
    '// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
    '// PARTICULAR PURPOSE.
    '//
    '//****************************************************************************

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim frm As New LogInForm

        'show log in dialog
        frm.ShowDialog()

        If oCompany.Connected = False Then
            End
        End If

        oItems = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
        NoneRadioButton.Checked = True

    End Sub

    Private Sub addItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addItemButton.Click
        MsgBoxLabel.Text = ""
        MsgBoxLabel_1.Text = ""
        oItems.ItemCode = ItemIDText.Text
        oItems.ItemName = ItemNameText.Text
        oItems.ManageSerialNumbersOnReleaseOnly = SAPbobsCOM.BoYesNoEnum.tNO
        oItems.ManageSerialNumbers = SAPbobsCOM.BoYesNoEnum.tNO
        oItems.ForceSelectionOfSerialNumber = SAPbobsCOM.BoYesNoEnum.tNO
        oItems.ManageBatchNumbers = SAPbobsCOM.BoYesNoEnum.tNO
        '   ManageSerialNumbers cannot be set to 1 when 
        '   ManageBatchNumbers is set to 1.
        If manSerRadioButton.Checked = True Then
            oItems.ManageSerialNumbers = SAPbobsCOM.BoYesNoEnum.tYES
            If OnReleaseOnly.Checked = True Then
                oItems.ManageSerialNumbersOnReleaseOnly = SAPbobsCOM.BoYesNoEnum.tYES
            End If
        Else
            '   Batch numbers are usually used for items joined
            '   under a single mantle of unique properties, such as medicines
            If manBatchRadioButton.Checked = True Then
                oItems.ManageBatchNumbers = SAPbobsCOM.BoYesNoEnum.tYES
            End If
        End If
        If forceSerial.Checked = True Then
            oItems.ForceSelectionOfSerialNumber = SAPbobsCOM.BoYesNoEnum.tYES
        End If
        '   add the item record to the object table in SAP Business One company database
        RetVal = oItems.Add
        If RetVal <> 0 Then
            oCompany.GetLastError(ErrCode, ErrMsg)
            MsgBoxLabel.Text = ErrCode & " " & ErrMsg
        Else
            MsgBoxLabel.Text = "The Item: " + oItems.ItemCode + " was added successfully"
        End If
    End Sub

    Private Sub getItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getItemButton.Click
        flagManage = False
        flagRelease = False
        flagForce = False
        flagBatch = False
        ItemNameText.Text = ""
        itemKind.Text = ""
        manSerRadioButton.Checked = False
        OnReleaseOnly.Checked = False
        forceSerial.Checked = False
        '   Retrieve an item by its key
        If retrieve_item() = False Then
            Return
        End If
        ItemNameText.Text = oItems.ItemName
        '   mapping the item's kind
        RetBool = oItems.ManageSerialNumbers
        If RetBool = SAPbobsCOM.BoYesNoEnum.tYES Then
            manSerRadioButton.Checked = True
            flagManage = True
        Else
            RetBool = oItems.ManageBatchNumbers
            If RetBool = SAPbobsCOM.BoYesNoEnum.tYES Then
                manBatchRadioButton.Checked = True
                flagBatch = True
            Else
                NoneRadioButton.Checked = True
            End If
        End If
        If flagManage = True Then
            RetBool = oItems.ManageSerialNumbersOnReleaseOnly
            If RetBool = SAPbobsCOM.BoYesNoEnum.tYES Then
                OnReleaseOnly.Checked = True
                flagRelease = True
            Else
                OnReleaseOnly.Checked = False
            End If
        End If
        RetBool = oItems.ForceSelectionOfSerialNumber
        If RetBool = SAPbobsCOM.BoYesNoEnum.tYES Then
            forceSerial.Checked = True
            flagForce = True
        Else
            forceSerial.Checked = False
        End If
        set_label_with_desc()
    End Sub

    Private Sub deleteItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteItemButton.Click
        '   before deleting the item we need to retrieve it by its key. (oItems object)
        If retrieve_item() = False Then
            Return
        End If
        '   delete the item from the object table. 
        RetVal = oItems.Remove
        If RetVal <> 0 Then
            oCompany.GetLastError(ErrCode, ErrMsg)
            MsgBoxLabel.Text = ErrCode & " " & ErrMsg
        Else
            MsgBoxLabel.Text = "The Item: " + oItems.ItemCode + " was removed successfully"
        End If
    End Sub

    Function retrieve_item() As Boolean

        MsgBoxLabel.Text = ""
        MsgBoxLabel_1.Text = ""
        ItemNameText.Enabled = False
        '   retrieve the item by absolute key from SAP Business One database.                                                               
        ErrCode = 0
        ErrMsg = ""
        RetVal = oItems.GetByKey(ItemIDText.Text)
        If RetVal <> True Then
            oCompany.GetLastError(ErrCode, ErrMsg)
            MsgBoxLabel.Text = "Failed to Retrieve the item " & ErrCode & " " & ErrMsg
            Return False
        End If
        Return True

    End Function

    Private Sub goodsReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goodsReceipt.Click
        If (ItemIDText.Text) = "" Then
            Return
        End If
        '   In order to manage serial numbers for items, a relevant definition
        '   should be made in the item card, 
        '   flagManage  & flagForce --> "MH"
        If itemKind.Text = "(MH)" Then
            flag = True '   "good receipt" - to know when to activate the manageSerial dialog box 
        End If
        '   show the good receipt dialog box
        Dim goodsReceipt As New GoodR
        goodsReceipt.ShowDialog()
        '   reset the flag of the item kind
        flag = False
    End Sub

    Private Sub GoodsIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodsIssue.Click
        If (ItemIDText.Text) = "" Then
            Return
        End If
        '   in good issue, we need to popup also when the item is MMH
        If itemKind.Text = "(MH)" Or itemKind.Text = "(MMH)" Then
            flag = True '   "good issue" - to know when to activate the manageSerial dialog box 
        End If
        Dim goodsIssue As New GoodI
        '   show the good issue dialog box
        goodsIssue.ShowDialog()
        '   reset the flag of the item kind
        flag = False
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub manSerRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manSerRadioButton.CheckedChanged
        If manSerRadioButton.Checked = True Then
            OnReleaseOnly.Checked = False
            forceSerial.Checked = False
            OnReleaseOnly.Visible = True
            forceSerial.Visible = True
        End If
        '   refresh the GUI according the user's choise
        get_type()
    End Sub

    Private Sub OnReleaseOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnReleaseOnly.CheckedChanged
        '   refresh the GUI according the user's choise
        get_type()
    End Sub

    Private Sub forceSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forceSerial.CheckedChanged
        '   refresh the GUI according the user's choise
        get_type()
    End Sub

    Function get_type()
        '   refresh the GUI according the user's choise
        MsgBoxLabel.Text = ""
        MsgBoxLabel_1.Text = ""
        flagManage = False
        flagRelease = False
        flagForce = False
        flagBatch = False
        itemKind.Text = ""
        If manSerRadioButton.Checked = True Then
            flagManage = True
        Else
            If manBatchRadioButton.Checked = True Then
                flagBatch = True
            End If
        End If
        If OnReleaseOnly.Checked = True Then
            MsgBoxLabel.Text = "Manage On Release Only – " + Chr(10) + Chr(13) + "if you check this box the Serial Numbers Reception window will not open automatically for this item in AP documents and other stock entry documents. Instead, the system will create successive serial numbers. - (Inventory Gen Entry)"
            flagRelease = True
        Else
            MsgBoxLabel.Text = ""
        End If
        If forceSerial.Checked = True Then
            MsgBoxLabel_1.Text = "Force Serial/Batch Numbers on Release - " + Chr(10) + Chr(13) + "check this box to block the generation of release documents, containing items with serial numbers management, for which serial numbers were not chosen. - (Inventory Gen Exit)"
            flagForce = True
        End If
        set_label_with_desc()
    End Function

    Function set_label_with_desc()
        itemKind.Text = ""
        If flagBatch Then
            If flagForce Then
                itemKind.Text = "(Batch with force)"
            Else
                itemKind.Text = "(Batch without force)"
            End If
        End If
        If flagManage Then
            If flagForce Then
                If flagRelease Then
                    '   flagManage & flagRelease & flagForce --> "MH"
                    itemKind.Text = "(MMH)"
                Else
                    '   flagManage & flagForce --> "MH"
                    itemKind.Text = "(MH)"
                End If
            Else
                '   flagManage & flagRelease --> "MM"
                If flagRelease Then
                    itemKind.Text = "(MM)"
                End If
            End If
        End If
    End Function

    Private Sub ItemIDText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemIDText.TextChanged
        ItemNameText.Enabled = True
    End Sub

    Private Sub NoneRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneRadioButton.CheckedChanged
        If NoneRadioButton.Checked = True Then
            OnReleaseOnly.Checked = False
            forceSerial.Checked = False
            OnReleaseOnly.Visible = False
            forceSerial.Visible = False
        End If
    End Sub

    Private Sub manBatchRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manBatchRadioButton.CheckedChanged
        If manBatchRadioButton.Checked = True Then
            OnReleaseOnly.Checked = False
            forceSerial.Checked = False
            OnReleaseOnly.Visible = False
            forceSerial.Visible = True
        End If
    End Sub
End Class
