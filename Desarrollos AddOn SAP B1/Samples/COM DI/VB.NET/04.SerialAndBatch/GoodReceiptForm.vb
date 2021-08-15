Public Class GoodR
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PriceText As System.Windows.Forms.TextBox
    Friend WithEvents Price As System.Windows.Forms.Label
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    Friend WithEvents InventoryGenEntry As System.Windows.Forms.GroupBox
    Friend WithEvents Quantity As System.Windows.Forms.Label
    Friend WithEvents QuantityText As System.Windows.Forms.TextBox
    Friend WithEvents Currency As System.Windows.Forms.Label
    Friend WithEvents CurrencyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Discount As System.Windows.Forms.Label
    Friend WithEvents DiscountText As System.Windows.Forms.TextBox
    Friend WithEvents MsgBoxLabel As System.Windows.Forms.Label
    Friend WithEvents TotalItemsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalPrice As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PriceText = New System.Windows.Forms.TextBox
        Me.InventoryGenEntry = New System.Windows.Forms.GroupBox
        Me.TotalPrice = New System.Windows.Forms.Label
        Me.TotalItemsLabel = New System.Windows.Forms.Label
        Me.CurrencyComboBox = New System.Windows.Forms.ComboBox
        Me.Currency = New System.Windows.Forms.Label
        Me.Discount = New System.Windows.Forms.Label
        Me.DiscountText = New System.Windows.Forms.TextBox
        Me.Quantity = New System.Windows.Forms.Label
        Me.QuantityText = New System.Windows.Forms.TextBox
        Me.Price = New System.Windows.Forms.Label
        Me.addButton = New System.Windows.Forms.Button
        Me.CancelButton1 = New System.Windows.Forms.Button
        Me.MsgBoxLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.InventoryGenEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item ID:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(128, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(128, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 96)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'PriceText
        '
        Me.PriceText.BackColor = System.Drawing.SystemColors.Window
        Me.PriceText.Location = New System.Drawing.Point(120, 56)
        Me.PriceText.Name = "PriceText"
        Me.PriceText.Size = New System.Drawing.Size(88, 20)
        Me.PriceText.TabIndex = 7
        Me.PriceText.Text = ""
        '
        'InventoryGenEntry
        '
        Me.InventoryGenEntry.BackColor = System.Drawing.SystemColors.Control
        Me.InventoryGenEntry.Controls.Add(Me.TotalPrice)
        Me.InventoryGenEntry.Controls.Add(Me.TotalItemsLabel)
        Me.InventoryGenEntry.Controls.Add(Me.CurrencyComboBox)
        Me.InventoryGenEntry.Controls.Add(Me.Currency)
        Me.InventoryGenEntry.Controls.Add(Me.Discount)
        Me.InventoryGenEntry.Controls.Add(Me.DiscountText)
        Me.InventoryGenEntry.Controls.Add(Me.Quantity)
        Me.InventoryGenEntry.Controls.Add(Me.QuantityText)
        Me.InventoryGenEntry.Controls.Add(Me.Price)
        Me.InventoryGenEntry.Controls.Add(Me.PriceText)
        Me.InventoryGenEntry.Location = New System.Drawing.Point(16, 128)
        Me.InventoryGenEntry.Name = "InventoryGenEntry"
        Me.InventoryGenEntry.Size = New System.Drawing.Size(480, 160)
        Me.InventoryGenEntry.TabIndex = 6
        Me.InventoryGenEntry.TabStop = False
        Me.InventoryGenEntry.Text = "InventoryGenEntry"
        '
        'TotalPrice
        '
        Me.TotalPrice.BackColor = System.Drawing.SystemColors.Control
        Me.TotalPrice.Location = New System.Drawing.Point(368, 24)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(80, 16)
        Me.TotalPrice.TabIndex = 15
        '
        'TotalItemsLabel
        '
        Me.TotalItemsLabel.BackColor = System.Drawing.SystemColors.Control
        Me.TotalItemsLabel.Location = New System.Drawing.Point(272, 24)
        Me.TotalItemsLabel.Name = "TotalItemsLabel"
        Me.TotalItemsLabel.Size = New System.Drawing.Size(80, 16)
        Me.TotalItemsLabel.TabIndex = 14
        Me.TotalItemsLabel.Text = "Total Price:"
        '
        'CurrencyComboBox
        '
        Me.CurrencyComboBox.BackColor = System.Drawing.SystemColors.Window
        Me.CurrencyComboBox.Location = New System.Drawing.Point(120, 120)
        Me.CurrencyComboBox.Name = "CurrencyComboBox"
        Me.CurrencyComboBox.Size = New System.Drawing.Size(88, 21)
        Me.CurrencyComboBox.TabIndex = 13
        '
        'Currency
        '
        Me.Currency.BackColor = System.Drawing.SystemColors.Control
        Me.Currency.Location = New System.Drawing.Point(16, 120)
        Me.Currency.Name = "Currency"
        Me.Currency.Size = New System.Drawing.Size(80, 16)
        Me.Currency.TabIndex = 12
        Me.Currency.Text = "Currency:"
        '
        'Discount
        '
        Me.Discount.BackColor = System.Drawing.SystemColors.Control
        Me.Discount.Location = New System.Drawing.Point(16, 88)
        Me.Discount.Name = "Discount"
        Me.Discount.Size = New System.Drawing.Size(80, 16)
        Me.Discount.TabIndex = 10
        Me.Discount.Text = "Discount %:"
        '
        'DiscountText
        '
        Me.DiscountText.BackColor = System.Drawing.SystemColors.Window
        Me.DiscountText.Location = New System.Drawing.Point(120, 88)
        Me.DiscountText.Name = "DiscountText"
        Me.DiscountText.Size = New System.Drawing.Size(88, 20)
        Me.DiscountText.TabIndex = 9
        Me.DiscountText.Text = ""
        '
        'Quantity
        '
        Me.Quantity.BackColor = System.Drawing.SystemColors.Control
        Me.Quantity.Location = New System.Drawing.Point(16, 24)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(80, 16)
        Me.Quantity.TabIndex = 8
        Me.Quantity.Text = "Quantity:"
        '
        'QuantityText
        '
        Me.QuantityText.BackColor = System.Drawing.SystemColors.Window
        Me.QuantityText.Location = New System.Drawing.Point(120, 24)
        Me.QuantityText.Name = "QuantityText"
        Me.QuantityText.Size = New System.Drawing.Size(88, 20)
        Me.QuantityText.TabIndex = 5
        Me.QuantityText.Text = ""
        '
        'Price
        '
        Me.Price.BackColor = System.Drawing.SystemColors.Control
        Me.Price.Location = New System.Drawing.Point(16, 56)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(80, 16)
        Me.Price.TabIndex = 6
        Me.Price.Text = "Price:"
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.SystemColors.Control
        Me.addButton.Location = New System.Drawing.Point(24, 336)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(72, 32)
        Me.addButton.TabIndex = 7
        Me.addButton.Text = "Add"
        '
        'CancelButton1
        '
        Me.CancelButton1.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton1.Location = New System.Drawing.Point(120, 336)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(64, 32)
        Me.CancelButton1.TabIndex = 8
        Me.CancelButton1.Text = "Cancel"
        '
        'MsgBoxLabel
        '
        Me.MsgBoxLabel.BackColor = System.Drawing.SystemColors.Control
        Me.MsgBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MsgBoxLabel.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.MsgBoxLabel.Location = New System.Drawing.Point(336, 304)
        Me.MsgBoxLabel.Name = "MsgBoxLabel"
        Me.MsgBoxLabel.Size = New System.Drawing.Size(160, 72)
        Me.MsgBoxLabel.TabIndex = 23
        '
        'GoodR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(552, 413)
        Me.Controls.Add(Me.MsgBoxLabel)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.InventoryGenEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GoodR"
        Me.Text = "Good Receipt Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.InventoryGenEntry.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '//  SAP MANAGE DI API 2007 SDK Sample
    '//****************************************************************************
    '//
    '//  File:      GoodReceiptForm.vb
    '//
    '//  Copyright (c) SAP MANAGE
    '//
    '// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
    '// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
    '// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
    '// PARTICULAR PURPOSE.
    '//
    '//****************************************************************************

    Private Sub GoodR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = oItems.ItemCode
        Label4.Text = oItems.ItemName
        '   fill the combo box with the currency group, when the dialog box is being loading
        CurrencyComboBox.Items.Add("USD")
        CurrencyComboBox.Items.Add("CAN")
        CurrencyComboBox.Items.Add("EUR")
        CurrencyComboBox.SelectedIndex = 0
        DiscountText.Text = "0"
        PriceText.Text = "0"
        QuantityText.Text = "1"
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        '   the quantity has to be greater than 0
        If CDbl(QuantityText.Text) <= 0 Then
            MsgBoxLabel.Text = "quantity number is invalid - the quantity is less than 1"
            Return
        End If
        '   the price has to be greater than 0
        If CDbl(PriceText.Text) <= 0 Then
            MsgBoxLabel.Text = "price number is invalid - the price is less than 0"
            Return
        End If

        TotalPrice.Text = CStr(CDbl(PriceText.Text) * CDbl(QuantityText.Text))
        oInvGenEntry = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry)
        Dim i As Integer
        If flagBatch Then
            ' check if the item is being manage with batch numbers.
            ' in the good receipt both kind (force & not force), behave the same 
            Dim manageBatch As New manageBatch()
            manBatchNumber = "xyz"
            totalNumber = CDbl(QuantityText.Text)
            manageBatch.ShowDialog()
            '   fill the BatchNumbers object with the data which was inserted in the dialog.
            '   BatchNumbers is a business object that represents the batch 
            '   numbers of an item in the Inventory and Production module of 
            '   the SAP Business One application.
            For i = 0 To totalNumber - 1
                oInvGenEntry.Lines.BatchNumbers.Quantity = 1
                oInvGenEntry.Lines.BatchNumbers.ManufacturerSerialNumber = CStr(manBatchNumber)
                oInvGenEntry.Lines.BatchNumbers.InternalSerialNumber = CStr(interSerNumber)
                '    BatchNumber must be unique
                oInvGenEntry.Lines.BatchNumbers.BatchNumber = CStr(batchNum) + CStr(i)
                oInvGenEntry.Lines.BatchNumbers.SetCurrentLine(i)
                oInvGenEntry.Lines.BatchNumbers.Add()
            Next
        Else
            If flag Then
                '   Only if it is a "MH" item, popup the manage serial numbers.
                '   fill the SerialNumbers object with the data which was inserted
                '   SerialNumbers is a business object that represents the the serial
                '   numbers and additional tracking information of items
                Dim manageSerial As New ManageSerial()
                manSerialNumber = "xyz"
                totalNumber = CDbl(QuantityText.Text)
                manageSerial.ShowDialog()
                For i = 0 To totalNumber - 1
                    oInvGenEntry.Lines.SerialNumbers.SystemSerialNumber = CStr(i + 1)
                    oInvGenEntry.Lines.SerialNumbers.ManufacturerSerialNumber = manSerialNumber + "_" + CStr(i)
                    oInvGenEntry.Lines.SerialNumbers.InternalSerialNumber = i + 3
                    oInvGenEntry.Lines.SerialNumbers.SetCurrentLine(i)
                    oInvGenEntry.Lines.SerialNumbers.Add()
                Next
            End If
        End If
        '   fill the other data into the oInventoryGenEntry object
        oInvGenEntry.Lines.ItemCode = oItems.ItemCode
        oInvGenEntry.Lines.ItemDescription = oItems.ItemName
        oInvGenEntry.Lines.Currency = CurrencyComboBox.SelectedItem
        oInvGenEntry.Lines.Price = CDbl(PriceText.Text)
        oInvGenEntry.Lines.ShipDate = Now
        oInvGenEntry.Lines.Quantity = CDbl(QuantityText.Text)
        oInvGenEntry.Lines.DiscountPercent = CDbl(DiscountText.Text)
        oInvGenEntry.PaymentGroupCode = -1
        RetVal = oInvGenEntry.Add()
        oCompany.GetNewObjectCode(tempStr)
        If RetVal <> 0 Then
            oCompany.GetLastError(ErrCode, ErrMsg)
            MsgBoxLabel.Text = ErrCode & " " & ErrMsg
        Else
            MsgBoxLabel.Text = "The document of: " + oItems.ItemCode + " with Quantity=" + QuantityText.Text + " , price=" + PriceText.Text + " was added successfully"
        End If
    End Sub

    Private Sub CancelButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton1.Click
        ActiveForm.Dispose()
    End Sub


    Private Sub PriceText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PriceText.Leave
        TotalPrice.Text = CStr(CDbl(PriceText.Text) * CDbl(QuantityText.Text))
    End Sub

    Private Sub QuantityText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuantityText.Leave
        TotalPrice.Text = CStr(CDbl(PriceText.Text) * CDbl(QuantityText.Text))
    End Sub
End Class
