Public Class frmMain
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
    Friend WithEvents cmdGetBPList As System.Windows.Forms.Button
    Friend WithEvents lstBP As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDataBaseServer As System.Windows.Forms.TextBox
    Friend WithEvents txtDataBaseName As System.Windows.Forms.TextBox
    Friend WithEvents txtDataBaseUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtDataBasePassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLanguage As System.Windows.Forms.TextBox
    Friend WithEvents txtLicenseServer As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogIn As System.Windows.Forms.Button
    Friend WithEvents txtSessID As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddBP As System.Windows.Forms.Button
    Friend WithEvents txtBPName As System.Windows.Forms.TextBox
    Friend WithEvents txtBPCode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTmp As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDataBaseType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdGetBPList = New System.Windows.Forms.Button
        Me.lstBP = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDataBaseServer = New System.Windows.Forms.TextBox
        Me.txtDataBaseName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDataBaseUserName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDataBasePassword = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCompanyUserName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCompanyPassword = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtLanguage = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtLicenseServer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdLogIn = New System.Windows.Forms.Button
        Me.txtSessID = New System.Windows.Forms.TextBox
        Me.txtBPName = New System.Windows.Forms.TextBox
        Me.cmdAddBP = New System.Windows.Forms.Button
        Me.txtBPCode = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTmp = New System.Windows.Forms.TextBox
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDataBaseType = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmdGetBPList
        '
        Me.cmdGetBPList.Location = New System.Drawing.Point(8, 192)
        Me.cmdGetBPList.Name = "cmdGetBPList"
        Me.cmdGetBPList.TabIndex = 0
        Me.cmdGetBPList.Text = "Get BP List"
        '
        'lstBP
        '
        Me.lstBP.HorizontalScrollbar = True
        Me.lstBP.Location = New System.Drawing.Point(96, 192)
        Me.lstBP.Name = "lstBP"
        Me.lstBP.Size = New System.Drawing.Size(120, 160)
        Me.lstBP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DataBase Server:"
        '
        'txtDataBaseServer
        '
        Me.txtDataBaseServer.Location = New System.Drawing.Point(128, 8)
        Me.txtDataBaseServer.Name = "txtDataBaseServer"
        Me.txtDataBaseServer.TabIndex = 3
        Me.txtDataBaseServer.Text = "localhost"
        '
        'txtDataBaseName
        '
        Me.txtDataBaseName.Location = New System.Drawing.Point(128, 32)
        Me.txtDataBaseName.Name = "txtDataBaseName"
        Me.txtDataBaseName.TabIndex = 5
        Me.txtDataBaseName.Text = "SBODemo_US"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DataBase Name"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DataBase Type"
        '
        'txtDataBaseUserName
        '
        Me.txtDataBaseUserName.Location = New System.Drawing.Point(128, 80)
        Me.txtDataBaseUserName.Name = "txtDataBaseUserName"
        Me.txtDataBaseUserName.TabIndex = 9
        Me.txtDataBaseUserName.Text = "sa"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DataBase UserName"
        '
        'txtDataBasePassword
        '
        Me.txtDataBasePassword.Location = New System.Drawing.Point(128, 104)
        Me.txtDataBasePassword.Name = "txtDataBasePassword"
        Me.txtDataBasePassword.TabIndex = 11
        Me.txtDataBasePassword.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DataBase Password"
        '
        'txtCompanyUserName
        '
        Me.txtCompanyUserName.Location = New System.Drawing.Point(352, 8)
        Me.txtCompanyUserName.Name = "txtCompanyUserName"
        Me.txtCompanyUserName.TabIndex = 13
        Me.txtCompanyUserName.Text = "manager"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(240, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Company UserName"
        '
        'txtCompanyPassword
        '
        Me.txtCompanyPassword.Location = New System.Drawing.Point(352, 32)
        Me.txtCompanyPassword.Name = "txtCompanyPassword"
        Me.txtCompanyPassword.TabIndex = 15
        Me.txtCompanyPassword.Text = "manager"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(240, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Company Password"
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(352, 56)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.TabIndex = 17
        Me.txtLanguage.Text = "ln_English"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(240, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Language"
        '
        'txtLicenseServer
        '
        Me.txtLicenseServer.Location = New System.Drawing.Point(352, 80)
        Me.txtLicenseServer.Name = "txtLicenseServer"
        Me.txtLicenseServer.TabIndex = 19
        Me.txtLicenseServer.Text = "ILTLVH25"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(240, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "License Server"
        '
        'cmdLogIn
        '
        Me.cmdLogIn.Location = New System.Drawing.Point(8, 144)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.TabIndex = 20
        Me.cmdLogIn.Text = "Log In"
        '
        'txtSessID
        '
        Me.txtSessID.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtSessID.Location = New System.Drawing.Point(96, 144)
        Me.txtSessID.Name = "txtSessID"
        Me.txtSessID.ReadOnly = True
        Me.txtSessID.Size = New System.Drawing.Size(264, 20)
        Me.txtSessID.TabIndex = 21
        Me.txtSessID.Text = ""
        '
        'txtBPName
        '
        Me.txtBPName.Location = New System.Drawing.Point(296, 184)
        Me.txtBPName.Name = "txtBPName"
        Me.txtBPName.Size = New System.Drawing.Size(120, 20)
        Me.txtBPName.TabIndex = 22
        Me.txtBPName.Text = ""
        '
        'cmdAddBP
        '
        Me.cmdAddBP.Location = New System.Drawing.Point(432, 184)
        Me.cmdAddBP.Name = "cmdAddBP"
        Me.cmdAddBP.TabIndex = 23
        Me.cmdAddBP.Text = "Add BP"
        '
        'txtBPCode
        '
        Me.txtBPCode.Location = New System.Drawing.Point(296, 216)
        Me.txtBPCode.Name = "txtBPCode"
        Me.txtBPCode.Size = New System.Drawing.Size(120, 20)
        Me.txtBPCode.TabIndex = 24
        Me.txtBPCode.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(232, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "BP Name"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(232, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "BP Code"
        '
        'txtTmp
        '
        Me.txtTmp.Location = New System.Drawing.Point(240, 256)
        Me.txtTmp.Multiline = True
        Me.txtTmp.Name = "txtTmp"
        Me.txtTmp.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTmp.Size = New System.Drawing.Size(264, 96)
        Me.txtTmp.TabIndex = 27
        Me.txtTmp.Text = ""
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(352, 104)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.TabIndex = 29
        Me.txtPort.Text = "30000"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(240, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Port"
        '
        'txtDataBaseType
        '
        Me.txtDataBaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDataBaseType.Items.AddRange(New Object() {"dst_MSSQL", "dst_DB_2", "dst_SYBASE", "dst_MSSQL2005", "dst_MAXDB"})
        Me.txtDataBaseType.Location = New System.Drawing.Point(128, 56)
        Me.txtDataBaseType.Name = "txtDataBaseType"
        Me.txtDataBaseType.Size = New System.Drawing.Size(104, 21)
        Me.txtDataBaseType.TabIndex = 30
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 365)
        Me.Controls.Add(Me.txtDataBaseType)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTmp)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBPCode)
        Me.Controls.Add(Me.cmdAddBP)
        Me.Controls.Add(Me.txtBPName)
        Me.Controls.Add(Me.txtSessID)
        Me.Controls.Add(Me.cmdLogIn)
        Me.Controls.Add(Me.txtLicenseServer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCompanyPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCompanyUserName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDataBasePassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDataBaseUserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDataBaseName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDataBaseServer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBP)
        Me.Controls.Add(Me.cmdGetBPList)
        Me.Name = "frmMain"
        Me.Text = "Web Service Client"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public DIS As localhost.Sample
    Dim SessionID As String

    Private Sub cmdLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click
        DIS = New localhost.Sample
        SessionID = DIS.Login(txtDataBaseServer.Text, txtDataBaseName.Text, txtDataBaseType.Text, _
        txtDataBaseUserName.Text, txtDataBasePassword.Text, txtCompanyUserName.Text, _
        txtCompanyPassword.Text, txtLanguage.Text, txtLicenseServer.Text, txtPort.Text)
        txtSessID.Text = SessionID
    End Sub

    Private Sub cmdGetBPList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetBPList.Click
        Dim xmlE As Xml.XmlElement
        Dim bpName As Xml.XmlNodeList
        Dim bpCode As Xml.XmlNodeList

        xmlE = DIS.GetBPList(SessionID, "")
        bpName = xmlE.SelectNodes("//CardName")
        bpCode = xmlE.SelectNodes("//CardCode")

        Dim i As Integer
        lstBP.Items.Clear()
        For i = 0 To bpName.Count - 1
            lstBP.Items.Add(bpCode.Item(i).InnerText + "  " + bpName.Item(i).InnerText)
        Next
    End Sub

    Private Sub cmdAddBP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBP.Click
        Dim xmlE As Xml.XmlElement
        Dim bpCode As Xml.XmlNodeList
        Dim bpName As Xml.XmlNode


        xmlE = DIS.GetEmptyBPXml(SessionID)

        bpCode = xmlE.SelectNodes("//CardCode")
        bpName = xmlE.SelectSingleNode("//CardName")
        bpCode.Item(0).InnerText = txtBPCode.Text
        bpCode.Item(1).InnerText = txtBPCode.Text
        bpName.InnerText = txtBPName.Text

        txtTmp.Text = xmlE.OuterXml

        DIS.AddBP(SessionID, xmlE.OuterXml)
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDataBaseType.Text = "dst_MSSQL2005"
    End Sub
End Class
