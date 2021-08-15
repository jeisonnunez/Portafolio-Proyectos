Public Class frmUDO
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
    Friend WithEvents grpConnection As System.Windows.Forms.GroupBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents btnGetCompanyList As System.Windows.Forms.Button
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents grpUDO As System.Windows.Forms.GroupBox
    Friend WithEvents chkUDOAfter As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnAddFields As System.Windows.Forms.Button
    Friend WithEvents btnAddUDO As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents cmbDBType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddRecord As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdUpdateRecord As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteRecord As System.Windows.Forms.Button
    Friend WithEvents cmdGetRecord As System.Windows.Forms.Button
    Friend WithEvents lstMainDish As System.Windows.Forms.ListBox
    Friend WithEvents lstSideDish As System.Windows.Forms.ListBox
    Friend WithEvents lstDrink As System.Windows.Forms.ListBox
    Friend WithEvents txtMaindish As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSideDish As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDrink As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdAddchild As System.Windows.Forms.Button
    Friend WithEvents cmdRemovechild As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSBOPass As System.Windows.Forms.TextBox
    Friend WithEvents txtSBOUser As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents grpChild As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadOldForm As System.Windows.Forms.RadioButton
    Friend WithEvents RadNewForm As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCreateDefaultForm As System.Windows.Forms.CheckBox
    Friend WithEvents txtFatherMenuID As System.Windows.Forms.TextBox
    Friend WithEvents lblFatherMenuID As System.Windows.Forms.Label
    Friend WithEvents chkCreateMenu As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUDO))
        Me.grpConnection = New System.Windows.Forms.GroupBox
        Me.txtSBOPass = New System.Windows.Forms.TextBox
        Me.txtSBOUser = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbDBType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.btnGetCompanyList = New System.Windows.Forms.Button
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.lblPass = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnConnect = New System.Windows.Forms.Button
        Me.grpUDO = New System.Windows.Forms.GroupBox
        Me.btnAddFields = New System.Windows.Forms.Button
        Me.chkUDOAfter = New System.Windows.Forms.CheckedListBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnAddUDO = New System.Windows.Forms.Button
        Me.grpRecords = New System.Windows.Forms.GroupBox
        Me.grpChild = New System.Windows.Forms.GroupBox
        Me.txtMaindish = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDrink = New System.Windows.Forms.TextBox
        Me.txtSideDish = New System.Windows.Forms.TextBox
        Me.cmdAddchild = New System.Windows.Forms.Button
        Me.cmdRemovechild = New System.Windows.Forms.Button
        Me.lstMainDish = New System.Windows.Forms.ListBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lstDrink = New System.Windows.Forms.ListBox
        Me.lstSideDish = New System.Windows.Forms.ListBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdGetRecord = New System.Windows.Forms.Button
        Me.cmdDeleteRecord = New System.Windows.Forms.Button
        Me.cmdUpdateRecord = New System.Windows.Forms.Button
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdAddRecord = New System.Windows.Forms.Button
        Me.txtRoom = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtFatherMenuID = New System.Windows.Forms.TextBox
        Me.lblFatherMenuID = New System.Windows.Forms.Label
        Me.chkCreateMenu = New System.Windows.Forms.CheckBox
        Me.RadOldForm = New System.Windows.Forms.RadioButton
        Me.RadNewForm = New System.Windows.Forms.RadioButton
        Me.ChkCreateDefaultForm = New System.Windows.Forms.CheckBox
        Me.grpConnection.SuspendLayout()
        Me.grpUDO.SuspendLayout()
        Me.grpRecords.SuspendLayout()
        Me.grpChild.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConnection
        '
        Me.grpConnection.Controls.Add(Me.txtSBOPass)
        Me.grpConnection.Controls.Add(Me.txtSBOUser)
        Me.grpConnection.Controls.Add(Me.Label13)
        Me.grpConnection.Controls.Add(Me.Label14)
        Me.grpConnection.Controls.Add(Me.cmbDBType)
        Me.grpConnection.Controls.Add(Me.Label2)
        Me.grpConnection.Controls.Add(Me.lblCompany)
        Me.grpConnection.Controls.Add(Me.txtServer)
        Me.grpConnection.Controls.Add(Me.cmbCompany)
        Me.grpConnection.Controls.Add(Me.btnGetCompanyList)
        Me.grpConnection.Controls.Add(Me.txtPass)
        Me.grpConnection.Controls.Add(Me.txtUser)
        Me.grpConnection.Controls.Add(Me.lblPass)
        Me.grpConnection.Controls.Add(Me.lblUser)
        Me.grpConnection.Controls.Add(Me.Label1)
        Me.grpConnection.Controls.Add(Me.btnConnect)
        Me.grpConnection.Location = New System.Drawing.Point(8, 8)
        Me.grpConnection.Name = "grpConnection"
        Me.grpConnection.Size = New System.Drawing.Size(624, 112)
        Me.grpConnection.TabIndex = 18
        Me.grpConnection.TabStop = False
        Me.grpConnection.Text = "Connection"
        '
        'txtSBOPass
        '
        Me.txtSBOPass.Location = New System.Drawing.Point(464, 72)
        Me.txtSBOPass.Name = "txtSBOPass"
        Me.txtSBOPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSBOPass.Size = New System.Drawing.Size(64, 20)
        Me.txtSBOPass.TabIndex = 33
        '
        'txtSBOUser
        '
        Me.txtSBOUser.Location = New System.Drawing.Point(464, 48)
        Me.txtSBOUser.Name = "txtSBOUser"
        Me.txtSBOUser.Size = New System.Drawing.Size(64, 20)
        Me.txtSBOUser.TabIndex = 31
        Me.txtSBOUser.Text = "manager"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(376, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "SBO Password"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(376, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "SBO Username"
        '
        'cmbDBType
        '
        Me.cmbDBType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDBType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDBType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDBType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDBType.Items.AddRange(New Object() {"MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB"})
        Me.cmbDBType.Location = New System.Drawing.Point(112, 16)
        Me.cmbDBType.Name = "cmbDBType"
        Me.cmbDBType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDBType.Size = New System.Drawing.Size(137, 22)
        Me.cmbDBType.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Database Type"
        '
        'lblCompany
        '
        Me.lblCompany.Location = New System.Drawing.Point(216, 80)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(56, 16)
        Me.lblCompany.TabIndex = 27
        Me.lblCompany.Text = "Company"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(360, 16)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 20)
        Me.txtServer.TabIndex = 18
        Me.txtServer.Text = "(local)"
        '
        'cmbCompany
        '
        Me.cmbCompany.Location = New System.Drawing.Point(272, 80)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(96, 21)
        Me.cmbCompany.TabIndex = 21
        Me.cmbCompany.Text = "SBODemo_US"
        '
        'btnGetCompanyList
        '
        Me.btnGetCompanyList.Location = New System.Drawing.Point(216, 48)
        Me.btnGetCompanyList.Name = "btnGetCompanyList"
        Me.btnGetCompanyList.Size = New System.Drawing.Size(112, 23)
        Me.btnGetCompanyList.TabIndex = 19
        Me.btnGetCompanyList.Text = "Get Company List"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(136, 80)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(72, 20)
        Me.txtPass.TabIndex = 24
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(136, 48)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(72, 20)
        Me.txtUser.TabIndex = 22
        Me.txtUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(16, 80)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(112, 16)
        Me.lblPass.TabIndex = 26
        Me.lblPass.Text = "Database Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(16, 48)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(112, 16)
        Me.lblUser.TabIndex = 23
        Me.lblUser.Text = "Database Username"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(264, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Database Server"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(536, 72)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 25
        Me.btnConnect.Text = "Connect"
        '
        'grpUDO
        '
        Me.grpUDO.Controls.Add(Me.btnAddFields)
        Me.grpUDO.Controls.Add(Me.chkUDOAfter)
        Me.grpUDO.Controls.Add(Me.btnAdd)
        Me.grpUDO.Enabled = False
        Me.grpUDO.Location = New System.Drawing.Point(8, 128)
        Me.grpUDO.Name = "grpUDO"
        Me.grpUDO.Size = New System.Drawing.Size(280, 184)
        Me.grpUDO.TabIndex = 22
        Me.grpUDO.TabStop = False
        Me.grpUDO.Text = "Part 1: User-Defined Tables, Fields and Objects"
        '
        'btnAddFields
        '
        Me.btnAddFields.Location = New System.Drawing.Point(24, 72)
        Me.btnAddFields.Name = "btnAddFields"
        Me.btnAddFields.Size = New System.Drawing.Size(80, 23)
        Me.btnAddFields.TabIndex = 4
        Me.btnAddFields.Text = "Add Fields"
        '
        'chkUDOAfter
        '
        Me.chkUDOAfter.Items.AddRange(New Object() {"SM_OMOR table", "... Name Field", "... Room Field", "... Price Field", "SM_MOR1 Table", "... Line Type", "... MainDish Field", "... SideDish Field", "... Drink Field", "... Line Price", "SM_MOR Object"})
        Me.chkUDOAfter.Location = New System.Drawing.Point(120, 32)
        Me.chkUDOAfter.Name = "chkUDOAfter"
        Me.chkUDOAfter.Size = New System.Drawing.Size(136, 139)
        Me.chkUDOAfter.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Tables"
        '
        'btnAddUDO
        '
        Me.btnAddUDO.Location = New System.Drawing.Point(505, 37)
        Me.btnAddUDO.Name = "btnAddUDO"
        Me.btnAddUDO.Size = New System.Drawing.Size(80, 23)
        Me.btnAddUDO.TabIndex = 6
        Me.btnAddUDO.Text = "Add UDO"
        '
        'grpRecords
        '
        Me.grpRecords.Controls.Add(Me.grpChild)
        Me.grpRecords.Controls.Add(Me.cmdGetRecord)
        Me.grpRecords.Controls.Add(Me.cmdDeleteRecord)
        Me.grpRecords.Controls.Add(Me.cmdUpdateRecord)
        Me.grpRecords.Controls.Add(Me.txtCode)
        Me.grpRecords.Controls.Add(Me.Label6)
        Me.grpRecords.Controls.Add(Me.cmdAddRecord)
        Me.grpRecords.Controls.Add(Me.txtRoom)
        Me.grpRecords.Controls.Add(Me.txtPrice)
        Me.grpRecords.Controls.Add(Me.txtName)
        Me.grpRecords.Controls.Add(Me.Label5)
        Me.grpRecords.Controls.Add(Me.Label4)
        Me.grpRecords.Controls.Add(Me.Label3)
        Me.grpRecords.Controls.Add(Me.TextBox2)
        Me.grpRecords.Enabled = False
        Me.grpRecords.Location = New System.Drawing.Point(8, 410)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Size = New System.Drawing.Size(648, 312)
        Me.grpRecords.TabIndex = 31
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "Part 3: UDO Records"
        '
        'grpChild
        '
        Me.grpChild.Controls.Add(Me.txtMaindish)
        Me.grpChild.Controls.Add(Me.Label7)
        Me.grpChild.Controls.Add(Me.Label9)
        Me.grpChild.Controls.Add(Me.Label8)
        Me.grpChild.Controls.Add(Me.txtDrink)
        Me.grpChild.Controls.Add(Me.txtSideDish)
        Me.grpChild.Controls.Add(Me.cmdAddchild)
        Me.grpChild.Controls.Add(Me.cmdRemovechild)
        Me.grpChild.Controls.Add(Me.lstMainDish)
        Me.grpChild.Controls.Add(Me.Label10)
        Me.grpChild.Controls.Add(Me.lstDrink)
        Me.grpChild.Controls.Add(Me.lstSideDish)
        Me.grpChild.Controls.Add(Me.Label11)
        Me.grpChild.Location = New System.Drawing.Point(8, 72)
        Me.grpChild.Name = "grpChild"
        Me.grpChild.Size = New System.Drawing.Size(328, 232)
        Me.grpChild.TabIndex = 53
        Me.grpChild.TabStop = False
        Me.grpChild.Text = "Child Records"
        '
        'txtMaindish
        '
        Me.txtMaindish.Location = New System.Drawing.Point(64, 24)
        Me.txtMaindish.Name = "txtMaindish"
        Me.txtMaindish.Size = New System.Drawing.Size(88, 20)
        Me.txtMaindish.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Main Dish"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Drink"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(160, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Side Dish"
        '
        'txtDrink
        '
        Me.txtDrink.Location = New System.Drawing.Point(64, 48)
        Me.txtDrink.Name = "txtDrink"
        Me.txtDrink.Size = New System.Drawing.Size(88, 20)
        Me.txtDrink.TabIndex = 46
        '
        'txtSideDish
        '
        Me.txtSideDish.Location = New System.Drawing.Point(216, 24)
        Me.txtSideDish.Name = "txtSideDish"
        Me.txtSideDish.Size = New System.Drawing.Size(88, 20)
        Me.txtSideDish.TabIndex = 44
        '
        'cmdAddchild
        '
        Me.cmdAddchild.Location = New System.Drawing.Point(160, 48)
        Me.cmdAddchild.Name = "cmdAddchild"
        Me.cmdAddchild.Size = New System.Drawing.Size(64, 23)
        Me.cmdAddchild.TabIndex = 49
        Me.cmdAddchild.Text = "Add Child"
        '
        'cmdRemovechild
        '
        Me.cmdRemovechild.Location = New System.Drawing.Point(232, 48)
        Me.cmdRemovechild.Name = "cmdRemovechild"
        Me.cmdRemovechild.Size = New System.Drawing.Size(88, 23)
        Me.cmdRemovechild.TabIndex = 50
        Me.cmdRemovechild.Text = "Remove Child"
        '
        'lstMainDish
        '
        Me.lstMainDish.Enabled = False
        Me.lstMainDish.Location = New System.Drawing.Point(8, 96)
        Me.lstMainDish.Name = "lstMainDish"
        Me.lstMainDish.Size = New System.Drawing.Size(72, 82)
        Me.lstMainDish.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 16)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Main Dish           Side Dish           Drink"
        '
        'lstDrink
        '
        Me.lstDrink.Enabled = False
        Me.lstDrink.Location = New System.Drawing.Point(168, 96)
        Me.lstDrink.Name = "lstDrink"
        Me.lstDrink.Size = New System.Drawing.Size(72, 82)
        Me.lstDrink.TabIndex = 41
        '
        'lstSideDish
        '
        Me.lstSideDish.Enabled = False
        Me.lstSideDish.Location = New System.Drawing.Point(88, 96)
        Me.lstSideDish.Name = "lstSideDish"
        Me.lstSideDish.Size = New System.Drawing.Size(72, 82)
        Me.lstSideDish.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(248, 40)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "The Add/Remove Child buttons affects the data locally; the data is only relevant " & _
            "when adding or getting a UDO record."
        '
        'cmdGetRecord
        '
        Me.cmdGetRecord.Location = New System.Drawing.Point(440, 48)
        Me.cmdGetRecord.Name = "cmdGetRecord"
        Me.cmdGetRecord.Size = New System.Drawing.Size(96, 23)
        Me.cmdGetRecord.TabIndex = 38
        Me.cmdGetRecord.Text = "Get Record"
        '
        'cmdDeleteRecord
        '
        Me.cmdDeleteRecord.Location = New System.Drawing.Point(440, 16)
        Me.cmdDeleteRecord.Name = "cmdDeleteRecord"
        Me.cmdDeleteRecord.Size = New System.Drawing.Size(96, 23)
        Me.cmdDeleteRecord.TabIndex = 37
        Me.cmdDeleteRecord.Text = "Delete Record"
        '
        'cmdUpdateRecord
        '
        Me.cmdUpdateRecord.Location = New System.Drawing.Point(336, 48)
        Me.cmdUpdateRecord.Name = "cmdUpdateRecord"
        Me.cmdUpdateRecord.Size = New System.Drawing.Size(96, 23)
        Me.cmdUpdateRecord.TabIndex = 36
        Me.cmdUpdateRecord.Text = "UpdateRecord"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Code"
        '
        'cmdAddRecord
        '
        Me.cmdAddRecord.Location = New System.Drawing.Point(336, 16)
        Me.cmdAddRecord.Name = "cmdAddRecord"
        Me.cmdAddRecord.Size = New System.Drawing.Size(96, 23)
        Me.cmdAddRecord.TabIndex = 33
        Me.cmdAddRecord.Text = "Add Record"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(64, 48)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(100, 20)
        Me.txtRoom.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(224, 48)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(224, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(176, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(176, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(344, 80)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(296, 224)
        Me.TextBox2.TabIndex = 58
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(296, 136)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(336, 176)
        Me.TextBox1.TabIndex = 54
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtFatherMenuID)
        Me.GroupBox1.Controls.Add(Me.lblFatherMenuID)
        Me.GroupBox1.Controls.Add(Me.chkCreateMenu)
        Me.GroupBox1.Controls.Add(Me.RadOldForm)
        Me.GroupBox1.Controls.Add(Me.RadNewForm)
        Me.GroupBox1.Controls.Add(Me.ChkCreateDefaultForm)
        Me.GroupBox1.Controls.Add(Me.btnAddUDO)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 86)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Part 2: Register UDO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Location = New System.Drawing.Point(222, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(253, 13)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "43535 for example is the Business Partners Menu ID"
        '
        'txtFatherMenuID
        '
        Me.txtFatherMenuID.Enabled = False
        Me.txtFatherMenuID.Location = New System.Drawing.Point(308, 42)
        Me.txtFatherMenuID.Name = "txtFatherMenuID"
        Me.txtFatherMenuID.Size = New System.Drawing.Size(68, 20)
        Me.txtFatherMenuID.TabIndex = 60
        Me.txtFatherMenuID.Text = "43535"
        '
        'lblFatherMenuID
        '
        Me.lblFatherMenuID.AutoSize = True
        Me.lblFatherMenuID.Enabled = False
        Me.lblFatherMenuID.Location = New System.Drawing.Point(221, 47)
        Me.lblFatherMenuID.Name = "lblFatherMenuID"
        Me.lblFatherMenuID.Size = New System.Drawing.Size(81, 13)
        Me.lblFatherMenuID.TabIndex = 59
        Me.lblFatherMenuID.Text = "Father Menu ID"
        '
        'chkCreateMenu
        '
        Me.chkCreateMenu.AutoSize = True
        Me.chkCreateMenu.Location = New System.Drawing.Point(225, 19)
        Me.chkCreateMenu.Name = "chkCreateMenu"
        Me.chkCreateMenu.Size = New System.Drawing.Size(87, 17)
        Me.chkCreateMenu.TabIndex = 58
        Me.chkCreateMenu.Text = "Create Menu"
        Me.chkCreateMenu.UseVisualStyleBackColor = True
        '
        'RadOldForm
        '
        Me.RadOldForm.AutoSize = True
        Me.RadOldForm.Enabled = False
        Me.RadOldForm.Location = New System.Drawing.Point(58, 63)
        Me.RadOldForm.Name = "RadOldForm"
        Me.RadOldForm.Size = New System.Drawing.Size(104, 17)
        Me.RadOldForm.TabIndex = 57
        Me.RadOldForm.Text = "Old Default Form"
        Me.RadOldForm.UseVisualStyleBackColor = True
        '
        'RadNewForm
        '
        Me.RadNewForm.AutoSize = True
        Me.RadNewForm.Checked = True
        Me.RadNewForm.Enabled = False
        Me.RadNewForm.Location = New System.Drawing.Point(58, 43)
        Me.RadNewForm.Name = "RadNewForm"
        Me.RadNewForm.Size = New System.Drawing.Size(110, 17)
        Me.RadNewForm.TabIndex = 56
        Me.RadNewForm.TabStop = True
        Me.RadNewForm.Text = "New Default Form"
        Me.RadNewForm.UseVisualStyleBackColor = True
        '
        'ChkCreateDefaultForm
        '
        Me.ChkCreateDefaultForm.AutoSize = True
        Me.ChkCreateDefaultForm.Location = New System.Drawing.Point(19, 19)
        Me.ChkCreateDefaultForm.Name = "ChkCreateDefaultForm"
        Me.ChkCreateDefaultForm.Size = New System.Drawing.Size(120, 17)
        Me.ChkCreateDefaultForm.TabIndex = 7
        Me.ChkCreateDefaultForm.Text = "Create Default Form"
        Me.ChkCreateDefaultForm.UseVisualStyleBackColor = True
        '
        'frmUDO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 734)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.grpUDO)
        Me.Controls.Add(Me.grpConnection)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmUDO"
        Me.Text = "UDO registration"
        Me.grpConnection.ResumeLayout(False)
        Me.grpConnection.PerformLayout()
        Me.grpUDO.ResumeLayout(False)
        Me.grpRecords.ResumeLayout(False)
        Me.grpRecords.PerformLayout()
        Me.grpChild.ResumeLayout(False)
        Me.grpChild.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public oCompany As SAPbobsCOM.Company

    ' Error handling variables
    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer

    Private Sub frmUDO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDBType.Text = "MSSQL2005"
        oCompany = New SAPbobsCOM.Company

        '// once the Server property of the Company is set
        '// we may query for a list of companies to choos from
        '// this method returns a Recordset object

        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English


    End Sub

    Private Sub btnGetCompanyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetCompanyList.Click

        Dim oRecordSet As SAPbobsCOM.Recordset
        Try

            oCompany.UseTrusted = False
            oCompany.Server = txtServer.Text
            oCompany.DbUserName = txtUser.Text
            oCompany.DbPassword = txtPass.Text

            oCompany.DbServerType = CInt(cmbDBType.SelectedIndex + 1)
            oRecordSet = oCompany.GetCompanyList

            '// Use GetLastError method directly after a function
            '// which doesn't have a return code
            '// you may also use the On Error GoTo.
            '// functions with no return codes throws exceptions

            oCompany.GetLastError(lErrCode, sErrMsg)

            If lErrCode <> 0 Then
                MsgBox(sErrMsg)
            Else
                '// Load the available company DB names to the combo box
                '// the returned Recordset containds 4 fields:
                '// dbName - represents the database name
                '// cmpName - represents the company name
                '// versStr - represents the version number of the company database
                '// dbUser - represents the database owner
                '// we are interested in the first filed (mandatory property)

                '// Go through the Recordset and extract the dbname
                cmbCompany.Items.Clear()
                Do Until oRecordSet.EoF = True
                    '// add the value of the first field of the Recordset
                    cmbCompany.Items.Add(oRecordSet.Fields.Item(0).Value)
                    '// move the record pointer to the next row
                    oRecordSet.MoveNext()
                Loop
                If cmbCompany.Items.Count > 0 Then
                    cmbCompany.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private WithEvents SBO_Application As SAPbouiCOM.Application



    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        ' Set the connection parameters
        oCompany.Server = txtServer.Text
        oCompany.CompanyDB = cmbCompany.Text
        oCompany.UserName = txtSBOUser.Text
        oCompany.Password = txtSBOPass.Text
        oCompany.DbServerType = CInt(cmbDBType.SelectedIndex + 1)

        lRetCode = oCompany.Connect

        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            grpConnection.Enabled = False
            grpUDO.Enabled = True
            grpRecords.Enabled = True
            MsgBox("Connected to " & oCompany.CompanyName, MsgBoxStyle.Information, "Now Connected")
        End If

    End Sub
    Private Sub AddUserTable(ByVal Name As String, ByVal Description As String, _
        ByVal Type As SAPbobsCOM.BoUTBTableType)
        '//****************************************************************************
        '// The UserTablesMD represents a meta-data object which allows us
        '// to add\remove tables, change a table name etc.
        '//****************************************************************************

        Dim oUserTablesMD As SAPbobsCOM.UserTablesMD

        '//****************************************************************************
        '// In any meta-data operation there should be no other object "alive"
        '// but the meta-data object, otherwise the operation will fail.
        '// This restriction is intended to prevent a collisions
        '//****************************************************************************

        '// the meta-data object needs to be initialized with a
        '// regular UserTables object
        oUserTablesMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)

        '//**************************************************
        '// when adding user tables or fields to the SBO DB
        '// use a prefix identifying your partner name space
        '// this will prevent collisions between different
        '// partners add-ons
        '//
        '// SAP's name space prefix is "BE_"
        '//**************************************************		

        '// set the table parameters
        oUserTablesMD.TableName = Name
        oUserTablesMD.TableDescription = Description
        oUserTablesMD.TableType = Type

        '// Add the table
        '// This action add an empty table with 2 default fields
        '// 'Code' and 'Name' which serve as the key
        '// in order to add your own User Fields
        '// see the AddUserFields.frm in this project
        '// a privat, user defined, key may be added
        '// see AddPrivateKey.frm in this project

        lRetCode = oUserTablesMD.Add
        '// check for errors in the process
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            MsgBox("Table: " & oUserTablesMD.TableName & " was added successfully")
        End If

        oUserTablesMD = Nothing

        GC.Collect() 'Release the handle to the table
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddUserTable("SM_OMOR", "Meal Order", SAPbobsCOM.BoUTBTableType.bott_Document)
        chkUDOAfter.SetItemChecked(0, True)
        AddUserTable("SM_MOR1", "Meal Lines", SAPbobsCOM.BoUTBTableType.bott_DocumentLines)
        chkUDOAfter.SetItemChecked(4, True)
    End Sub
    Private Function Add_SM_OMOR_Fields()

        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '************************************
        ' Adding "Name" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OMOR"
        oUserFieldsMD.Name = "Name"
        oUserFieldsMD.Description = "Name"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(1, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(1, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '************************************
        ' Adding "Room" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OMOR"
        oUserFieldsMD.Name = "Room"
        oUserFieldsMD.Description = "Room"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(2, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(2, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '************************************
        ' Adding "Price" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OMOR"
        oUserFieldsMD.Name = "Price"
        oUserFieldsMD.Description = "Price"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(3, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(3, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        GC.Collect() 'Release the handle to the User Fields
    End Function

    Private Function Add_SM_MOR1_Fields()

        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)


        '************************************
        ' Adding "Line Type" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "LineType"
        oUserFieldsMD.Description = "Line Type"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 200

        ' Add Line type valid values - P, R, T, S
        oUserFieldsMD.ValidValues.Value = "P"
        oUserFieldsMD.ValidValues.Description = "C:\\Bitmap\\Smile.bmp"
        oUserFieldsMD.ValidValues.Add()

        oUserFieldsMD.ValidValues.Value = "R"
        oUserFieldsMD.ValidValues.Description = "Regular"
        oUserFieldsMD.ValidValues.Add()

        oUserFieldsMD.ValidValues.Value = "T"
        oUserFieldsMD.ValidValues.Description = "Text"
        oUserFieldsMD.ValidValues.Add()

        oUserFieldsMD.ValidValues.Value = "S"
        oUserFieldsMD.ValidValues.Description = "SubTotal"
        oUserFieldsMD.ValidValues.Add()

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(5, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(5, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        ' Restart User Fields object
        oUserFieldsMD = Nothing
        GC.Collect()
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)


        '************************************
        ' Adding "Main Dish" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "MainDish"
        oUserFieldsMD.Description = "Main Dish"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 200

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(6, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(6, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '************************************
        ' Adding "SideDish" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "SideDish"
        oUserFieldsMD.Description = "Side Dish"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(7, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(7, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '************************************
        ' Adding "Drink" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "Drink"
        oUserFieldsMD.Description = "Drink"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(8, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(8, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        ' Restart User Fields object
        oUserFieldsMD = Nothing
        GC.Collect()
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '************************************
        ' Adding "Price" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "Price"
        oUserFieldsMD.Description = "Price"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_Price

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(9, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(9, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        GC.Collect() 'Release the handle to the User Fields
    End Function

    Private Function TableExist(ByVal TableName As String) As Boolean
        Dim oUserTablesMD As SAPbobsCOM.UserTablesMD
        Dim bool As Boolean
        oUserTablesMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)

        bool = oUserTablesMD.GetByKey(TableName)
        Return (bool)
    End Function

    Private Sub btnAddFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFields.Click
        Add_SM_OMOR_Fields()
        Add_SM_MOR1_Fields()
    End Sub
    Private Sub AddUDO()


        Dim oUserObjectMD As SAPbobsCOM.UserObjectsMD

        oUserObjectMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD)

        oUserObjectMD.CanCancel = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanClose = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tNO
        oUserObjectMD.CanDelete = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanFind = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanYearTransfer = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.ChildTables.TableName = "SM_MOR1"
        oUserObjectMD.Code = "SM_MOR"
        oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.Name = "SM_Meal_Order"
        oUserObjectMD.ObjectType = SAPbobsCOM.BoUDOObjType.boud_Document
        oUserObjectMD.TableName = "SM_OMOR"

        ' Handle UDO Form
        If ChkCreateDefaultForm.Checked = True Then
            oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tYES

            oUserObjectMD.FormColumns.FormColumnAlias = "DocEntry"
            oUserObjectMD.FormColumns.FormColumnDescription = "DocEntry"
            oUserObjectMD.FormColumns.Add()

            oUserObjectMD.FormColumns.FormColumnAlias = "U_Name"
            oUserObjectMD.FormColumns.FormColumnDescription = "Name"
            oUserObjectMD.FormColumns.Add()

            oUserObjectMD.FormColumns.FormColumnAlias = "U_Room"
            oUserObjectMD.FormColumns.FormColumnDescription = "Room"
            oUserObjectMD.FormColumns.Add()

            oUserObjectMD.FormColumns.FormColumnAlias = "U_Price"
            oUserObjectMD.FormColumns.FormColumnDescription = "Price"
            oUserObjectMD.FormColumns.Add()

            If RadNewForm.Checked = True Then
                oUserObjectMD.EnableEnhancedForm = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.RebuildEnhancedForm = SAPbobsCOM.BoYesNoEnum.tYES

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_LineType"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Line Type"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 1
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_MainDish"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Main Dish"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 2
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_SideDish"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Side Dish"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 3
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_Drink"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Drink"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 4
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_Price"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Price"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 5
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

            ElseIf RadOldForm.Checked = True Then
                oUserObjectMD.EnableEnhancedForm = SAPbobsCOM.BoYesNoEnum.tNO
            End If
        End If


        ' Handle Menu
        If chkCreateMenu.Checked Then
            oUserObjectMD.MenuItem = SAPbobsCOM.BoYesNoEnum.tYES
            oUserObjectMD.MenuUID = "MealID"
            oUserObjectMD.MenuCaption = "Meal Order"
            oUserObjectMD.Position = 1
            oUserObjectMD.FatherMenuID = txtFatherMenuID.Text

        End If

        lRetCode = oUserObjectMD.Add()

        '// check for errors in the process
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(10, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            MsgBox("UDO: " & oUserObjectMD.Name & " was added successfully")
            chkUDOAfter.SetItemChecked(9, True)
        End If

        oUserObjectMD = Nothing

        GC.Collect() 'Release the handle to the table
    End Sub

    Sub AddUDORecord()

        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralData As SAPbobsCOM.GeneralData
        Dim oChild As SAPbobsCOM.GeneralData
        Dim oChildren As SAPbobsCOM.GeneralDataCollection
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams
        Dim oCompanyService As SAPbobsCOM.CompanyService

        Try

            oCompanyService = oCompany.GetCompanyService

            'Get GeneralService (oCmpSrv is the CompanyService)
            oGeneralService = oCompanyService.GetGeneralService("SM_MOR")

            'Create data for new row in main UDO
            oGeneralData = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData)
            oGeneralData.SetProperty("U_Name", txtName.Text)
            oGeneralData.SetProperty("U_Room", txtRoom.Text)
            oGeneralData.SetProperty("U_Price", txtPrice.Text)

            ' Handle child rows
            oChildren = oGeneralData.Child("SM_MOR1")

            Dim i As Integer
            For i = 1 To lstMainDish.Items.Count
                'Create data for rows in the child table
                oChild = oChildren.Add
                oChild.SetProperty("U_MainDish", lstMainDish.Items.Item(i - 1))
                oChild.SetProperty("U_SideDish", lstSideDish.Items.Item(i - 1))
                oChild.SetProperty("U_Drink", lstDrink.Items.Item(i - 1))
            Next

            'Add the new row, including children, to database
            oGeneralParams = oGeneralService.Add(oGeneralData)

            txtCode.Text = oGeneralParams.GetProperty("DocEntry")

            MsgBox("Record added")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Sub GetUDORecord()

        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralData As SAPbobsCOM.GeneralData
        Dim oChild As SAPbobsCOM.GeneralData
        Dim oChildren As SAPbobsCOM.GeneralDataCollection
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams
        Dim oCompanyService As SAPbobsCOM.CompanyService

        oCompanyService = oCompany.GetCompanyService

        Try

            'Get GeneralService (oCmpSrv is the CompanyService)
            oGeneralService = oCompanyService.GetGeneralService("SM_MOR")

            oGeneralParams = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams)
            oGeneralParams.SetProperty("DocEntry", txtCode.Text)
            oGeneralData = oGeneralService.GetByParams(oGeneralParams)

            'Create data for a row in the child table
            oChildren = oGeneralData.Child("SM_MOR1")

            'Empty child record lists
            lstMainDish.Items.Clear()
            lstSideDish.Items.Clear()
            lstDrink.Items.Clear()

            ' Handle child rows
            oChildren = oGeneralData.Child("SM_MOR1")
            Dim i As Integer
            MsgBox("going to add sons: " & oChildren.Count.ToString)
            For i = 1 To oChildren.Count
                oChild = oChildren.Item(i - 1)

                lstMainDish.Items.Add(oChild.GetProperty("U_MainDish"))
                lstSideDish.Items.Add(oChild.GetProperty("U_SideDish"))
                lstDrink.Items.Add(oChild.GetProperty("U_Drink"))

            Next

            'Add the new row, including children, to database
            txtName.Text = oGeneralData.GetProperty("U_Name")
            txtRoom.Text = oGeneralData.GetProperty("U_Room")
            txtPrice.Text = oGeneralData.GetProperty("U_Price")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        MsgBox("Record loaded")

    End Sub

    Sub UpdateUDORecord()
        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralData As SAPbobsCOM.GeneralData
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams

        Dim sCmp As SAPbobsCOM.CompanyService
        sCmp = oCompany.GetCompanyService

        ' This function updates only parent record.
        ' Child records remain as is.

        Try
            'Get a handle to the SM_MOR UDO
            oGeneralService = sCmp.GetGeneralService("SM_MOR")

            'Get UDO record
            oGeneralParams = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams)
            oGeneralParams.SetProperty("DocEntry", txtCode.Text)
            oGeneralData = oGeneralService.GetByParams(oGeneralParams)

            'Update UDO record
            oGeneralData.SetProperty("U_Room", txtRoom.Text)
            oGeneralData.SetProperty("U_Price", txtPrice.Text)
            oGeneralData.SetProperty("U_Name", txtName.Text)
            oGeneralService.Update(oGeneralData)

            MsgBox("Updated")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub DeleteUDORecord()
        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams

        Dim sCmp As SAPbobsCOM.CompanyService
        sCmp = oCompany.GetCompanyService

        Try
            'Get a handle to the SM_MOR UDO
            oGeneralService = sCmp.GetGeneralService("SM_MOR")

            'Delete UDO record
            oGeneralParams = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams)
            oGeneralParams.SetProperty("DocEntry", txtCode.Text)
            oGeneralService.Delete(oGeneralParams)

            MsgBox("Deleted")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub AddChildRecord()
        If txtMaindish.Text = "" Then
            MsgBox("Main Dish is empty")
        ElseIf txtSideDish.Text = "" Then
            MsgBox("Side Dish is empty")
        ElseIf txtDrink.Text = "" Then
            MsgBox("Drink is empty")
        Else
            ' If all fields are full, add the child record
            lstMainDish.Items.Add(txtMaindish.Text)
            lstSideDish.Items.Add(txtSideDish.Text)
            lstDrink.Items.Add(txtDrink.Text)
        End If

    End Sub

    Sub RomoveChildRecord()

        If lstMainDish.Items.Count() > 0 Then
            lstMainDish.Items.Remove(lstMainDish.Items.Item(lstMainDish.Items.Count() - 1))
            lstSideDish.Items.Remove(lstSideDish.Items.Item(lstSideDish.Items.Count() - 1))
            lstDrink.Items.Remove(lstDrink.Items.Item(lstDrink.Items.Count() - 1))
        End If

    End Sub

    Private Sub btnAddUDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUDO.Click
        AddUDO()
    End Sub

    Private Sub cmdAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddRecord.Click
        AddUDORecord()
    End Sub

    Private Sub cmdUpdateRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateRecord.Click
        UpdateUDORecord()
    End Sub

    Private Sub cmdGetRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetRecord.Click
        GetUDORecord()
    End Sub

    Private Sub cmdDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteRecord.Click
        DeleteUDORecord()
    End Sub

    Private Sub cmdAddchild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddchild.Click
        AddChildRecord()
    End Sub

    Private Sub cmdRemovechild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemovechild.Click
        RomoveChildRecord()
    End Sub

    Private Sub ChkCreateDefaultForm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCreateDefaultForm.CheckedChanged
        RadNewForm.Enabled = ChkCreateDefaultForm.Checked
        RadOldForm.Enabled = ChkCreateDefaultForm.Checked
    End Sub

    Private Sub chkCreateMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCreateMenu.CheckedChanged
        txtFatherMenuID.Enabled = chkCreateMenu.Checked
        lblFatherMenuID.Enabled = chkCreateMenu.Checked
    End Sub

End Class
