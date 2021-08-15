Public Class FrmMain
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
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnAddFields As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents CmdAddRecord As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnConnect = New System.Windows.Forms.Button
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnAddFields = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnExit = New System.Windows.Forms.Button
        Me.CmdAddRecord = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(24, 24)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(128, 32)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect to DB"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(24, 64)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(128, 32)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Create User Table"
        '
        'btnAddFields
        '
        Me.btnAddFields.Location = New System.Drawing.Point(24, 104)
        Me.btnAddFields.Name = "btnAddFields"
        Me.btnAddFields.Size = New System.Drawing.Size(128, 32)
        Me.btnAddFields.TabIndex = 2
        Me.btnAddFields.Text = "Add User Fields"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdAddRecord)
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 232)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add MetaData"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(16, 184)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(128, 32)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        '
        'CmdAddRecord
        '
        Me.CmdAddRecord.Location = New System.Drawing.Point(16, 144)
        Me.CmdAddRecord.Name = "CmdAddRecord"
        Me.CmdAddRecord.Size = New System.Drawing.Size(128, 32)
        Me.CmdAddRecord.TabIndex = 1
        Me.CmdAddRecord.Text = "Add Records"
        '
        'FrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(176, 245)
        Me.Controls.Add(Me.btnAddFields)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmMain"
        Me.Text = "Video Rent - Create User Tables"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public oCompany As SAPbobsCOM.Company


    ' Error handling variables
    Public sErrMsg As String
    Public lErrCode As Long
    Public lRetCode As Long

    Private Sub ConnectToCompany()

        ' Initialize the Company Object.
        ' Create a new company object
        oCompany = New SAPbobsCOM.Company

        ' Set the mandatory properties for the connection to the database.
        ' To use a remote Db Server enter his name instead of the string "(local)"
        ' This string is used to work on a DB installed on your local machine

        oCompany.Server = "(local)"
        oCompany.CompanyDB = "SBODemo_US"
        oCompany.UserName = "manager"
        oCompany.Password = "manager"
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
        oCompany.DbUserName = "sa"
        oCompany.DbPassword = ""

        oCompany.Connect()

        ' Check for errors during connect
        oCompany.GetLastError(lErrCode, sErrMsg)
        If lErrCode <> 0 Then
            MsgBox(sErrMsg)
        Else
            MsgBox("Connection Established", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        ConnectToCompany()
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        ' User tables MetaData object
        Dim oUserTablesMD As SAPbobsCOM.UserTablesMD

        ' Init the MetaData object
        oUserTablesMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)

        ' set the 2 mandatory fields
        oUserTablesMD.TableName = "VIDS"
        oUserTablesMD.TableDescription = "Video Managment"
        lRetCode = oUserTablesMD.Add

        '// check for errors in the process
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            MsgBox("Table: " & oUserTablesMD.TableName & " was added successfully")
        End If

    End Sub

    Private Sub btnAddFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFields.Click
        ' A User Fields object
        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD

        ' Remember to free occupied resources
        GC.Collect()

        ' Init the user fields object
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '******************************
        ' Adding the "SHELF" field
        '******************************
        ' Setting the Field's mandatory properties
        oUserFieldsMD.TableName = "@VIDS"
        oUserFieldsMD.Name = "SHELF"
        oUserFieldsMD.Description = "Shelf Number"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.EditSize = 2
        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '******************************
        ' Adding the "SPACE" field
        '******************************
        ' Setting the Field's mandatory properties
        oUserFieldsMD.TableName = "@VIDS"
        oUserFieldsMD.Name = "SPACE"
        oUserFieldsMD.Description = "SPACE Number"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.EditSize = 3
        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '******************************
        ' Adding the "RENTED" field
        '******************************
        ' Setting the Field's mandatory properties
        oUserFieldsMD.TableName = "@VIDS"
        oUserFieldsMD.Name = "RENTED"
        oUserFieldsMD.Description = "Rented/Available"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 1
        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
        '******************************
        ' Adding the "CARDCODE" field
        '******************************
        ' Setting the Field's mandatory properties
        oUserFieldsMD.TableName = "@VIDS"
        oUserFieldsMD.Name = "CARDCODE"
        oUserFieldsMD.Description = "Card Code"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 15
        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        oCompany.Disconnect()
        oCompany = Nothing
        GC.Collect()
        End
    End Sub

    Private Sub CmdAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAddRecord.Click
        Dim oUserTable As SAPbobsCOM.UserTable

        '// set the object with the requested table
        oUserTable = oCompany.UserTables.Item("VIDS")

        '// set the two default fields 
        oUserTable.Code = 15
        oUserTable.Name = "Speed 1"

        '// set the user fields
        'Shelf Number
        oUserTable.UserFields.Fields.Item("U_SHELF").Value = 5
        'Space Number
        oUserTable.UserFields.Fields.Item("U_SPACE").Value = 2
        'Rented
        oUserTable.UserFields.Fields.Item("U_RENTED").Value = "Y"
        'CardCode
        oUserTable.UserFields.Fields.Item("U_CARDCODE").Value = "C50003"

        '// add the data to the Data base
        oUserTable.Add()

        '// Check for errors
        oCompany.GetLastError(lErrCode, sErrMsg)
        If lErrCode <> 0 Then
            MsgBox(sErrMsg)
        Else
            MsgBox("Record saved in DB successfuly")
        End If

        oUserTable = Nothing
        System.GC.Collect()

    End Sub
End Class
