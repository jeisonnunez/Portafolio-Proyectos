
'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:     ItemCycleCountForm.vb
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
' Add an existing Cycle Count to an existing item
'
'****************************************************************************


Imports SAPbobsCOM
Public Class ItemCycleCountForm
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
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCycleCode As System.Windows.Forms.TextBox
    Friend WithEvents lblUserCode As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboWareHouse As System.Windows.Forms.ComboBox
    Friend WithEvents chkAlert As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkAlert = New System.Windows.Forms.CheckBox
        Me.txtUserCode = New System.Windows.Forms.TextBox
        Me.txtCycleCode = New System.Windows.Forms.TextBox
        Me.lblUserCode = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboWareHouse = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(200, 288)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(80, 24)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Code"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(128, 16)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(104, 20)
        Me.txtItemCode.TabIndex = 6
        Me.txtItemCode.Text = "X0003"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAlert)
        Me.GroupBox1.Controls.Add(Me.txtUserCode)
        Me.GroupBox1.Controls.Add(Me.txtCycleCode)
        Me.GroupBox1.Controls.Add(Me.lblUserCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 136)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cycle Count "
        '
        'chkAlert
        '
        Me.chkAlert.Checked = True
        Me.chkAlert.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlert.Location = New System.Drawing.Point(16, 96)
        Me.chkAlert.Name = "chkAlert"
        Me.chkAlert.Size = New System.Drawing.Size(96, 24)
        Me.chkAlert.TabIndex = 17
        Me.chkAlert.Text = "Alert"
        '
        'txtUserCode
        '
        Me.txtUserCode.Location = New System.Drawing.Point(120, 64)
        Me.txtUserCode.Name = "txtUserCode"
        Me.txtUserCode.Size = New System.Drawing.Size(104, 20)
        Me.txtUserCode.TabIndex = 15
        Me.txtUserCode.Text = "1"
        '
        'txtCycleCode
        '
        Me.txtCycleCode.Location = New System.Drawing.Point(120, 32)
        Me.txtCycleCode.Name = "txtCycleCode"
        Me.txtCycleCode.Size = New System.Drawing.Size(104, 20)
        Me.txtCycleCode.TabIndex = 14
        Me.txtCycleCode.Text = "1"
        '
        'lblUserCode
        '
        Me.lblUserCode.Location = New System.Drawing.Point(16, 65)
        Me.lblUserCode.Name = "lblUserCode"
        Me.lblUserCode.Size = New System.Drawing.Size(104, 18)
        Me.lblUserCode.TabIndex = 13
        Me.lblUserCode.Text = "User Code"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cycle Code"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Item WareHouse"
        '
        'cboWareHouse
        '
        Me.cboWareHouse.Items.AddRange(New Object() {"01", "02", "03", "04"})
        Me.cboWareHouse.Location = New System.Drawing.Point(128, 56)
        Me.cboWareHouse.Name = "cboWareHouse"
        Me.cboWareHouse.Size = New System.Drawing.Size(104, 21)
        Me.cboWareHouse.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 40)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Before adding an item cycle count make sure you have an item and a cycle count"
        '
        'ItemCycleCountForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 325)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboWareHouse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAdd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ItemCycleCountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Cycle Count"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ItemCycleCountForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'select the first warehouse
        cboWareHouse.SelectedIndex = 0

    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try

            Dim oAlertTemplate As SAPbobsCOM.ItemCycleCount
            Dim oItem As Items
            Dim oWhareHouse As ItemWarehouseInfo

            oItem = oCompany.GetBusinessObject(BoObjectTypes.oItems)

            'get item
            oItem.GetByKey(txtItemCode.Text)

            'get the selected wharehouse
            oWhareHouse = GetWareHouse(cboWareHouse.SelectedItem, oItem)

            'an existind cycle count (e.g CycleCode=1 : CycleName:"Weekly on Tuesday" ,OCYC table)
            oWhareHouse.ItemCycleCount.CycleCode = txtCycleCode.Text

            'set alert
            oWhareHouse.ItemCycleCount.Alert = IIf(chkAlert.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO)

            'set user 
            oWhareHouse.ItemCycleCount.DestinationUser = txtUserCode.Text

            'update item with new Cycle Count
            oItem.Update()

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message())

        End Try
    End Sub

    'return the the selected warehouse
    Private Function GetWareHouse(ByVal sWarehouse As String, ByVal oItem As Items) As ItemWarehouseInfo

        Try

            Select Case sWarehouse
                Case "01"

                    Return (oItem.WhsInfo)

                Case "02"
                    oItem.WhsInfo.SetCurrentLine(1)
                    Return (oItem.WhsInfo)

                Case "03"
                    oItem.WhsInfo.SetCurrentLine(2)
                    Return (oItem.WhsInfo)

                Case "04"
                    oItem.WhsInfo.SetCurrentLine(3)
                    Return (oItem.WhsInfo)

            End Select


        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function



End Class
