Public Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Public oForm As SAPbouiCOM.Form
    Dim bFirstTime As Boolean
    Dim oMatrix As SAPbouiCOM.Matrix
    Dim oColumns As SAPbouiCOM.Columns

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        SetApplication()

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
    Friend WithEvents BMatrixForm As System.Windows.Forms.Button
    Friend WithEvents SwitchGrid As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SwitchGrid = New System.Windows.Forms.Button
        Me.BMatrixForm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'SwitchGrid
        '
        Me.SwitchGrid.Enabled = False
        Me.SwitchGrid.Location = New System.Drawing.Point(48, 80)
        Me.SwitchGrid.Name = "SwitchGrid"
        Me.SwitchGrid.Size = New System.Drawing.Size(152, 24)
        Me.SwitchGrid.TabIndex = 2
        Me.SwitchGrid.Text = "SwitchGrid"
        '
        'BMatrixForm
        '
        Me.BMatrixForm.Location = New System.Drawing.Point(48, 24)
        Me.BMatrixForm.Name = "BMatrixForm"
        Me.BMatrixForm.Size = New System.Drawing.Size(152, 24)
        Me.BMatrixForm.TabIndex = 0
        Me.BMatrixForm.Text = "MatrixForm"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 148)
        Me.Controls.Add(Me.BMatrixForm)
        Me.Controls.Add(Me.SwitchGrid)
        Me.Name = "Form1"
        Me.Text = "UserFormSettingsTester"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TabOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CreateFormCP()
        oForm.Freeze(True)
        Try


            Dim EditName As String
            Dim lLeft As Long
            EditName = "Edit"
            lLeft = 400

            AddEdit(EditName & lLeft, lLeft)
            lLeft = lLeft - 100

            AddEdit(EditName & lLeft, lLeft)
            lLeft = lLeft - 100

            AddEdit(EditName & lLeft, lLeft)
            lLeft = lLeft - 100

            AddEdit(EditName & lLeft, lLeft)
            lLeft = lLeft - 100
            AddLables()
        Catch
            MsgBox(Err.Description)

        End Try
        oForm.Freeze(False)
    End Sub

    Private Sub SetApplication()

        '*******************************************************************
        '// Use an SboGuiApi object to establish connection
        '// with the SAP Business One application and return an
        '// initialized appliction object
        '*******************************************************************

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi

        '// by following the steps specified above, the following
        '// statment should be suficient for either development or run mode

        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

        '// connect to a running SBO Application

        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()
        bFirstTime = True
    End Sub
    Private Sub CreateFormCP()
        '////////////////////////////////////////
        Dim oFormCreaP As SAPbouiCOM.FormCreationParams
        oFormCreaP = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
        oFormCreaP.UniqueID = "MeiravForm"
        oFormCreaP.FormType = "MeiravFormType"
        oFormCreaP.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Sizable
        oForm = SBO_Application.Forms.AddEx(oFormCreaP)
        oForm.Visible = True
    End Sub
    Private Sub AddLables()

        'left       = 400,300,200,100
        ' tabOrder  = 4,2,1,3
        AddNumberLabel("Index1 ", 400)
        AddNumberLabel("Index2 ", 300)
        AddNumberLabel("Index3 ", 200)
        AddNumberLabel("Index4 ", 100)

        AddOrderLabel("Order4 ", 400)
        AddOrderLabel("Order2 ", 300)
        AddOrderLabel("Order1", 200)
        AddOrderLabel("Order3", 100)


    End Sub
    Private Sub AddNumberLabel(ByVal LableName As String, ByVal lLeft As Long)

        Dim oItem As SAPbouiCOM.Item
        oItem = oForm.Items.Add(LableName, SAPbouiCOM.BoFormItemTypes.it_STATIC)
        SetItemRect(oItem, lLeft, 65, 50, 19)

        Dim oLba As SAPbouiCOM.StaticText
        oLba = oItem.Specific
        oLba.Caption = LableName
    End Sub
    Private Sub AddOrderLabel(ByVal LableName As String, ByVal lLeft As Long)

        Dim oItem As SAPbouiCOM.Item
        oItem = oForm.Items.Add(LableName, SAPbouiCOM.BoFormItemTypes.it_STATIC)
        SetItemRect(oItem, lLeft, 65, 100, 19)
        Dim oLba As SAPbouiCOM.StaticText
        oLba = oItem.Specific
        oLba.Caption = LableName
    End Sub
    Private Sub AddEdit(ByVal EditName As String, ByVal lLeft As Long)

        Dim oItem As SAPbouiCOM.Item
        oItem = oForm.Items.Add(EditName, SAPbouiCOM.BoFormItemTypes.it_EDIT)

        SetItemRect(oItem, lLeft, 65, 150, 19)
        Dim oEdit As SAPbouiCOM.EditText


    End Sub


    Private Sub SetItemRect(ByRef oItem As SAPbouiCOM.Item, ByVal oLeft As Long, ByVal Width As Long, ByVal Top As Long, ByVal Height As Long)
        oItem.Left = oLeft
        oItem.Width = Width
        oItem.Top = Top
        oItem.Height = Height

    End Sub



    Private Sub BMatrixForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMatrixForm.Click
        'Creates a form with 2 matrixes
        CreateVisFormWithMatrix1()
        SwitchGrid.Enabled = True
        BMatrixForm.Enabled = False

    End Sub
    Private Sub CreateVisFormWithMatrix1()
        'The Default matrix setting will appear for the first matrix added to the form
        CreateVisFormWithMatrix3()
        AddMatrixToForm1("Matrix1")
        AddColumnsToMatrix(oMatrix)
        SetMatrix(oMatrix)
        AddMatrixToForm1("Matrix2")
        AddColumnsToMatrix(oMatrix)
        SetMatrix(oMatrix)
        Dim oDBDS As SAPbouiCOM.DBDataSource
        oForm.Settings.Enabled = True
        SwitchGrid.Enabled = True
        'oDBDS = oForm.DataSources.DBDataSources.Item("OCRD")
        'oDBDS.Query()
        'oMatrix.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_Auto
        ''oColumns = oMatrix.Columns
        ''Dim oEditText As SAPbouiCOM.EditText
        ''oEditText = oColumns.Item(1).Cells.Item(2).Specific()
        ''oEditText.String = "Test"
    End Sub
    Private Sub CreateVisFormWithMatrix3()

        Dim oDBDS As SAPbouiCOM.DBDataSource
        '// add a new form
        '// The following object is needed to create our form
        Dim creationPackage As SAPbouiCOM.FormCreationParams
        creationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
        creationPackage.UniqueID = "UidFrmMatrix"
        creationPackage.FormType = "TypeFrmMatrix"

        '// Add our form to the SBO application
        oForm = SBO_Application.Forms.AddEx(creationPackage)


        '// set the form properties
        oForm.Title = "Matrix and Cells"
        oForm.Left = 336
        oForm.Width = 2000
        oForm.Top = 44
        oForm.Height = 250
        oForm.ClientHeight = 200
        oForm.ClientWidth = 600
        oForm.Visible = True
        oForm.PaneLevel = 0

        '//*****************************************
        '// Adding Items to the form
        '// and setting their properties
        '//*****************************************

        '/**********************
        '// Adding an Ok button
        '//*********************

        '// We get automatic event handling for
        '// the Ok and Cancel Buttons by setting
        '// their UIDs to 1 and 2 respectively

        Dim oItem As SAPbouiCOM.Item
        oItem = oForm.Items.Add("1", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 5
        oItem.Width = 65
        oItem.Top = 150
        oItem.Height = 19

        Dim oButton As SAPbouiCOM.Button
        oButton = oItem.Specific
        oButton.Caption = "Ok"

        '//************************
        '// Adding a Cancel button
        '//***********************

        oItem = oForm.Items.Add("2", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 75
        oItem.Width = 65
        oItem.Top = 150
        oItem.Height = 19

        oButton = oItem.Specific

        oButton.Caption = "Cancel"
        Dim oStaticText As SAPbouiCOM.StaticText
        Dim oEditText15 As SAPbouiCOM.EditText
        Dim oEditText As SAPbouiCOM.EditText

        AddFormDataSources()
    End Sub
    Private Sub AddFormDataSources()
        '//***********************************
        '// Adding Culomn items to the matrix
        '//***********************************
        'oForm.DataSources.DBDataSources.Add("@MUDTMD")
        With oForm.DataSources.UserDataSources
            .Add("TabDS1", SAPbouiCOM.BoDataType.dt_SHORT_NUMBER.dt_SHORT_NUMBER)
            .Add("EditDS1", SAPbouiCOM.BoDataType.dt_SHORT_NUMBER.dt_SHORT_TEXT)
            .Add("EditDS2", SAPbouiCOM.BoDataType.dt_SHORT_NUMBER.dt_SHORT_TEXT)
            .Add("EditDS3", SAPbouiCOM.BoDataType.dt_SHORT_NUMBER.dt_SHORT_TEXT)
            .Add("CheckDS2", SAPbouiCOM.BoDataType.dt_SHORT_NUMBER.dt_SHORT_TEXT, 1)
            .Add("ComboDS1", SAPbouiCOM.BoDataType.dt_SHORT_NUMBER.dt_SHORT_TEXT)
            .Add("LinkDS1", SAPbouiCOM.BoDataType.dt_SHORT_NUMBER.dt_SHORT_TEXT)
            .Add("PicDS1", SAPbouiCOM.BoDataType.dt_SHORT_NUMBER.dt_SHORT_TEXT)
        End With
    End Sub
    Private Sub AddMatrixToForm1(ByVal mName As String)
        Dim oItem As SAPbouiCOM.Item

        oItem = oForm.Items.Add(mName, SAPbouiCOM.BoFormItemTypes.it_MATRIX)
        If (mName.IndexOf(1) < 0) Then

            oItem.Left = 5
            oItem.Width = 200
            oItem.Top = 5
            oItem.Height = 130
        Else
            oItem.Left = 400
            oItem.Width = 300
            oItem.Top = 5
            oItem.Height = 100
        End If


        oMatrix = oItem.Specific
        oMatrix.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_Auto
        oColumns = oMatrix.Columns

    End Sub
    Public Sub AddColumnsToMatrix(ByRef oMatrix As SAPbouiCOM.Matrix)
        Dim i As Integer
        Dim oColumn As SAPbouiCOM.Column
        Dim oLinkedButton As SAPbouiCOM.LinkedButton

        oColumn = oMatrix.Columns.Add("col" & 0, SAPbouiCOM.BoFormItemTypes.it_EDIT)
        ' oColumn.Width = 15
        oColumn.TitleObject.Caption = "#"
        oColumn.Editable = False

        ' add edit column
        oColumn = oMatrix.Columns.Add("col" & 1, SAPbouiCOM.BoFormItemTypes.it_LINKED_BUTTON)
        oColumn.Width = 40
        'oColumn.DataBind.SetBound(True, "@MYUDT", "Code")
        oColumn.TitleObject.Caption = "LINK_choose"
        oColumn.BackColor = 255064
        oColumn.ForeColor = 640255
        oColumn.TextStyle = 8
        oColumn.FontSize = 12
        oLinkedButton = oColumn.ExtendedObject
        ' oLinkedButton.LinkedObject = SAPbouiCOM.BoLinkedObject.lf_CorrectionInvoice
        oLinkedButton.LinkedObject = SAPbouiCOM.BoLinkedObject.lf_BusinessPartner
        ' 

        ' add combo column
        oColumn = oMatrix.Columns.Add("col" & 2, SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oColumn.Width = 40
        oColumn.DataBind.SetBound(True, "", "ComboDS1")
        oColumn.TitleObject.Caption = "Combo"
        oColumn.ForeColor = 255064
        oColumn.BackColor = 640255

        For i = 0 To 3
            oColumn.ValidValues.Add("val" & i, "desc" & i)
        Next i

        ' add checkbox column
        oColumn = oMatrix.Columns.Add("col" & 3, SAPbouiCOM.BoFormItemTypes.it_CHECK_BOX)
        oColumn.Width = 40
        oColumn.DataBind.SetBound(True, "", "CheckDS2")
        oColumn.TitleObject.Caption = "Check"

        ' add picture column
        oColumn = oMatrix.Columns.Add("col" & 4, SAPbouiCOM.BoFormItemTypes.it_PICTURE)
        oColumn.Editable = False
        oColumn.Width = 40
        oColumn.DataBind.SetBound(True, "", "PicDS1")
        oColumn.TitleObject.Caption = "Picture"

    End Sub
    Public Sub SetMatrix(ByRef oMatrix As SAPbouiCOM.Matrix)

        Dim i As Integer '// to be used as counter
        Dim CurDS As Integer
        ' oMatrix.Clear()
        oMatrix.AddRow(5)






    End Sub

    Private Sub ActiveFormToXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveActiveForm()

    End Sub

    Private Sub LoadFromXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        I_LoadFromXML("ActiveForm.xml")

    End Sub

    Private Sub ShowXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveActiveForm()
        Process.Start("explorer", "C:\Program Files\SAP Manage\XML\ActiveForm.xml")

    End Sub
    Private Sub I_LoadFromXML(ByVal FileName As String)
        '//**********************************************************************
        '// Loading from XML:
        '//---------------------------------------------------------------------
        '//
        '// Add a directory  named "XML" under "C:\Program Files\SAP Manage\"
        '//
        '//**********************************************************************
        Try


            Dim oXMLDoc1 As MSXML2.DOMDocument

            oXMLDoc1 = New MSXML2.DOMDocument

            '// load the content of the XML File
            oXMLDoc1.load("C:\Program Files\SAP Manage\XML\" + FileName)
            Dim XMLStr As String
            '// load the form to the SBO application in one batch
            SBO_Application.LoadBatchActions(oXMLDoc1.xml)
            ' GetBatchRes()
        Catch Exc As Exception
            MsgBox("Load Form XML " & Exc.Message)
            MsgBox("Load Form XML " & Exc.ToString())
        End Try
    End Sub
    Private Sub SaveActiveForm()

        Dim oForm As SAPbouiCOM.Form
        oForm = SBO_Application.Forms.ActiveForm()

        Dim oXMLDoc As MSXML2.DOMDocument
        Dim sXMLString As String

        oXMLDoc = New MSXML2.DOMDocument
        sXMLString = oForm.GetAsXML

        '// load the form's XML string to the
        '// XML document object
        oXMLDoc.loadXML(sXMLString)

        '// save the XML Document
        oXMLDoc.save("C:\Program Files\SAP Manage\XML\ActiveForm.xml")

    End Sub



    Private Sub SwitchGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchGrid.Click
        Dim oForm As SAPbouiCOM.Form
        oForm = SBO_Application.Forms.ActiveForm
        Dim fSettings As SAPbouiCOM.FormSettings
        fSettings = oForm.Settings
        If fSettings.MatrixUID = "Matrix1" Then
            fSettings.MatrixUID = "Matrix2"
        Else
            fSettings.MatrixUID = "Matrix1"
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
