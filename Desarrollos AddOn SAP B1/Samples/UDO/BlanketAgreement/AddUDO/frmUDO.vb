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
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents grpUDO As System.Windows.Forms.GroupBox
    Friend WithEvents chkUDOAfter As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnAddFields As System.Windows.Forms.Button
    Friend WithEvents btnAddUDO As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents cmbDBType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpConnection = New System.Windows.Forms.GroupBox
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
        Me.lblIntro = New System.Windows.Forms.Label
        Me.grpUDO = New System.Windows.Forms.GroupBox
        Me.btnAddUDO = New System.Windows.Forms.Button
        Me.btnAddFields = New System.Windows.Forms.Button
        Me.chkUDOAfter = New System.Windows.Forms.CheckedListBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmbDBType = New System.Windows.Forms.ComboBox
        Me.grpConnection.SuspendLayout()
        Me.grpUDO.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConnection
        '
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
        Me.grpConnection.Location = New System.Drawing.Point(8, 56)
        Me.grpConnection.Name = "grpConnection"
        Me.grpConnection.Size = New System.Drawing.Size(544, 160)
        Me.grpConnection.TabIndex = 18
        Me.grpConnection.TabStop = False
        Me.grpConnection.Text = "Connection"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Database Type"
        '
        'lblCompany
        '
        Me.lblCompany.Location = New System.Drawing.Point(360, 64)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(56, 16)
        Me.lblCompany.TabIndex = 27
        Me.lblCompany.Text = "Company"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(112, 64)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.TabIndex = 18
        Me.txtServer.Text = "(local)"
        '
        'cmbCompany
        '
        Me.cmbCompany.Location = New System.Drawing.Point(416, 64)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompany.TabIndex = 21
        Me.cmbCompany.Text = "SBODemo_US"
        '
        'btnGetCompanyList
        '
        Me.btnGetCompanyList.Location = New System.Drawing.Point(224, 64)
        Me.btnGetCompanyList.Name = "btnGetCompanyList"
        Me.btnGetCompanyList.Size = New System.Drawing.Size(128, 23)
        Me.btnGetCompanyList.TabIndex = 19
        Me.btnGetCompanyList.Text = "Get Company List"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(136, 120)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.TabIndex = 24
        Me.txtPass.Text = "manager"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(136, 96)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.TabIndex = 22
        Me.txtUser.Text = "manager"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(16, 120)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(112, 16)
        Me.lblPass.TabIndex = 26
        Me.lblPass.Text = "Database Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(16, 96)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(112, 16)
        Me.lblUser.TabIndex = 23
        Me.lblUser.Text = "Database Username"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Database Server"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(248, 120)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.TabIndex = 25
        Me.btnConnect.Text = "Connect"
        '
        'lblIntro
        '
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(16, 8)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(536, 40)
        Me.lblIntro.TabIndex = 19
        Me.lblIntro.Text = "This project is part of a bigger UDO (User Defined Objects) sample. It creates th" & _
        "e user tables, adds user fields and registers a UDO object."
        '
        'grpUDO
        '
        Me.grpUDO.Controls.Add(Me.btnAddUDO)
        Me.grpUDO.Controls.Add(Me.btnAddFields)
        Me.grpUDO.Controls.Add(Me.chkUDOAfter)
        Me.grpUDO.Controls.Add(Me.btnAdd)
        Me.grpUDO.Enabled = False
        Me.grpUDO.Location = New System.Drawing.Point(8, 232)
        Me.grpUDO.Name = "grpUDO"
        Me.grpUDO.Size = New System.Drawing.Size(320, 264)
        Me.grpUDO.TabIndex = 22
        Me.grpUDO.TabStop = False
        Me.grpUDO.Text = "User Defined Tables,Fields and Objects"
        '
        'btnAddUDO
        '
        Me.btnAddUDO.Location = New System.Drawing.Point(24, 112)
        Me.btnAddUDO.Name = "btnAddUDO"
        Me.btnAddUDO.Size = New System.Drawing.Size(80, 23)
        Me.btnAddUDO.TabIndex = 6
        Me.btnAddUDO.Text = "Add UDO"
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
        Me.chkUDOAfter.Items.AddRange(New Object() {"OBLK Table", "... BPCode Field", "... BPName Field", "... Status Field", "... Start Date", "... End Date", "... Total Price", "BLK1 Table", "... Item Code Field", "... Item Name Field", "... Item Price Field", "... Quantity", "... Total", "... InitQuan", "SM_BLK Object"})
        Me.chkUDOAfter.Location = New System.Drawing.Point(120, 24)
        Me.chkUDOAfter.Name = "chkUDOAfter"
        Me.chkUDOAfter.Size = New System.Drawing.Size(136, 229)
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
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(472, 464)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        '
        'cmbDBType
        '
        Me.cmbDBType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDBType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDBType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDBType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDBType.Items.AddRange(New Object() {"MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB"})
        Me.cmbDBType.Location = New System.Drawing.Point(112, 32)
        Me.cmbDBType.Name = "cmbDBType"
        Me.cmbDBType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDBType.Size = New System.Drawing.Size(137, 22)
        Me.cmbDBType.TabIndex = 30
        '
        'frmUDO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 509)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpUDO)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.grpConnection)
        Me.Name = "frmUDO"
        Me.Text = "UDO registration"
        Me.grpConnection.ResumeLayout(False)
        Me.grpUDO.ResumeLayout(False)
        Me.ResumeLayout(False)

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
        oCompany.UseTrusted = True

    End Sub

    Private Sub btnGetCompanyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetCompanyList.Click

        Dim oRecordSet As SAPbobsCOM.Recordset
        oCompany.Server = txtServer.Text
        oCompany.DbServerType = CInt(cmbDBType.SelectedIndex + 1)
        Try

        
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

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        ' Set the connection parameters
        oCompany.Server = txtServer.Text

        oCompany.DbServerType = CInt(cmbDBType.SelectedIndex + 1)
        oCompany.CompanyDB = cmbCompany.Text
        oCompany.UserName = txtUser.Text
        oCompany.Password = txtPass.Text

        lErrCode = oCompany.Connect

        If lErrCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            grpConnection.Enabled = False
            grpUDO.Enabled = True
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
        AddUserTable("SM_OBLK", "Blanket Agreement", SAPbobsCOM.BoUTBTableType.bott_Document)
        chkUDOAfter.SetItemChecked(0, True)
        AddUserTable("SM_BLK1", "Blanket Agreemen lines", SAPbobsCOM.BoUTBTableType.bott_DocumentLines)
        chkUDOAfter.SetItemChecked(7, True)

    End Sub
    Private Function AddOBLKFields()

        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '************************************
        ' Adding "BPCode" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OBLK"
        oUserFieldsMD.Name = "BPCode"
        oUserFieldsMD.Description = "BP Code"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 15

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(1, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '************************************
        ' Adding "BP Name" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OBLK"
        oUserFieldsMD.Name = "BPName"
        oUserFieldsMD.Description = "BP Name"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 100

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(2, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '************************************
        ' Adding "Status" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OBLK"
        oUserFieldsMD.Name = "Status"
        oUserFieldsMD.Description = "Status"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20
        'oUserFieldsMD.ValidValues.Value = "Active"
        'oUserFieldsMD.ValidValues.Description = "Active"
        'oUserFieldsMD.ValidValues.Add()
        'oUserFieldsMD.ValidValues.Value = "Inactive"
        'oUserFieldsMD.ValidValues.Description = "Inactive"
        'oUserFieldsMD.ValidValues.Add()

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(3, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '************************************
        ' Adding "StartDate" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OBLK"
        oUserFieldsMD.Name = "StartDT"
        oUserFieldsMD.Description = "Start Date"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date
        oUserFieldsMD.EditSize = 10

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(4, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '************************************
        ' Adding "EndDate" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OBLK"
        oUserFieldsMD.Name = "EndDT"
        oUserFieldsMD.Description = "End Date"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date
        oUserFieldsMD.EditSize = 10

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(5, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '************************************
        ' Adding "Total" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OBLK"
        oUserFieldsMD.Name = "Total"
        oUserFieldsMD.Description = "Total"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.EditSize = 11

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(6, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        GC.Collect() 'Release the handle to the User Fields
    End Function

    Private Function AddBLK1Fields()

        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '************************************
        ' Adding "ItemCode" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "SM_BLK1"
        oUserFieldsMD.Name = "ItemCode"
        oUserFieldsMD.Description = "Item Code"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(8, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '************************************
        ' Adding "Item Name" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_BLK1"
        oUserFieldsMD.Name = "ItemName"
        oUserFieldsMD.Description = "Item Name"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 100

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(9, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '************************************
        ' Adding "Price" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_BLK1"
        oUserFieldsMD.Name = "Price"
        oUserFieldsMD.Description = "Price"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.EditSize = 11

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(10, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '************************************
        ' Adding "Quantity" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_BLK1"
        oUserFieldsMD.Name = "Quan"
        oUserFieldsMD.Description = "Quantity"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.EditSize = 10

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(11, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '************************************
        ' Adding "Total" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_BLK1"
        oUserFieldsMD.Name = "Total"
        oUserFieldsMD.Description = "Total"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.EditSize = 11

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(12, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '************************************
        ' Adding "Total" field
        '************************************
        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_BLK1"
        oUserFieldsMD.Name = "InitQuan"
        oUserFieldsMD.Description = "Initial Quantity"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.EditSize = 11

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lRetCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            chkUDOAfter.SetItemChecked(13, True)
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
    Private Function FieldExist()

    End Function
    Private Sub btnAddFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFields.Click
        AddOBLKFields()
        AddBLK1Fields()
    End Sub
    Private Sub AddUDO()

        Dim oUserObjectMD As SAPbobsCOM.UserObjectsMD

        oUserObjectMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD)

        oUserObjectMD.CanCancel = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanClose = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanDelete = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanFind = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanLog = SAPbobsCOM.BoYesNoEnum.tNO
        oUserObjectMD.CanYearTransfer = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.ChildTables.TableName = "SM_BLK1"
        oUserObjectMD.Code = "SM_BLK"
        oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tNO
        oUserObjectMD.Name = "SM_BLANKET"
        oUserObjectMD.ObjectType = SAPbobsCOM.BoUDOObjType.boud_Document
        oUserObjectMD.TableName = "SM_OBLK"

        lRetCode = oUserObjectMD.Add()

        '// check for errors in the process
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(12, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            MsgBox("UDO: " & oUserObjectMD.Name & " was added successfully")
            chkUDOAfter.SetItemChecked(14, True)
        End If

        oUserObjectMD = Nothing

        GC.Collect() 'Release the handle to the table
    End Sub
    Private Sub btnAddUDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUDO.Click
        AddUDO()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
