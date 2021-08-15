Public Class Vids

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oCompany As SAPbobsCOM.Company
    Private DBDSVids As SAPbouiCOM.DBDataSource
    Private frmMoviesToShelfs As SAPbouiCOM.Form
    Private sPath As String


    Public Sub New()
        Try
            SetApplication()
            ' Set The Connection Context
            If Not SetConnectionContext() = 0 Then
                SBO_Application.MessageBox("Failed setting a connection to DI API")
                End ' Terminating the Add-On Application
            End If


            If Not ConnectToCompany() = 0 Then
                SBO_Application.MessageBox("Failed connecting to the company's Data Base")
                End ' Terminating the Add-On Application
            End If

            SBO_Application.MessageBox("DI Connected To: " & oCompany.CompanyName)

        Catch
            System.Windows.Forms.MessageBox.Show("SBO application not found")
        End Try
        AddMenuItems()
    End Sub
    Private Function ConnectToCompany() As Integer

        '// Make sure you're not already connected.
        If oCompany.Connected = True Then
            oCompany.Disconnect()
        End If

        '// Establish the connection to the company database.
        ConnectToCompany = oCompany.Connect

    End Function

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

        sConnectionString = Command()

        '// connect to a running SBO Application

        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

    End Sub
    Private Sub AddMenuItems()
        '//******************************************************************
        '// Let's add a pop-up menu item and 3 sub menu items
        '//******************************************************************

        Dim oMenus As SAPbouiCOM.Menus
        Dim oMenuItem As SAPbouiCOM.MenuItem

        '// Get the menus collection from the application
        oMenus = SBO_Application.Menus

        Dim oCreationPackage As SAPbouiCOM.MenuCreationParams

        oCreationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)
        oMenuItem = SBO_Application.Menus.Item("43520") 'moudles'


        sPath = System.Windows.Forms.Application.StartupPath()
        sPath = sPath.Remove(sPath.Length - 3, 3)

        ' Creation parameters
        oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP
        oCreationPackage.UniqueID = "SM_VID"
        oCreationPackage.String = "Video Store"
        oCreationPackage.Image = sPath & "VID.bmp"
        ' we add our menu at the buttom of the list
        oCreationPackage.Position = oMenuItem.SubMenus.Count + 1

        oMenus = oMenuItem.SubMenus

        Try ' If the manu already exists this code will fail
            oMenus.AddEx(oCreationPackage)

            ' Get the menu collection of the newly added pop-up item
            oMenuItem = SBO_Application.Menus.Item("SM_VID")
            oMenus = oMenuItem.SubMenus

            ' Add 4 Sub Menu Items
            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
            oCreationPackage.UniqueID = "SM_VID_F1"
            oCreationPackage.String = "Movies On Shelf"
            oCreationPackage.Image = sPath & "v1.bmp"
            oMenus.AddEx(oCreationPackage)

            oCreationPackage.UniqueID = "SM_VID_F2"
            oCreationPackage.String = "Movies Location"
            oCreationPackage.Image = sPath & "v2.bmp"
            oMenus.AddEx(oCreationPackage)

            oCreationPackage.UniqueID = "SM_VID_F3"
            oCreationPackage.String = "Add Movie"
            oCreationPackage.Image = sPath & "v3.bmp"
            oMenus.AddEx(oCreationPackage)

            oCreationPackage.UniqueID = "SM_VID_F4"
            oCreationPackage.String = "Rent / Return Movie"
            oCreationPackage.Image = sPath & "v4.bmp"
            oMenus.AddEx(oCreationPackage)

        Catch er As Exception ' Error Handling
            SBO_Application.MessageBox(er.Message)
        End Try

    End Sub

    Private Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent
        If pVal.BeforeAction = False Then
            Select Case pVal.MenuUID
                Case "SM_VID_F1"
                    MoviesToShelf()
                Case "SM_VID_F2"
                    FindMovie()
                Case "SM_VID_F3"
                    AddMovie()
                Case "SM_VID_F4"
                    RentMovie()
            End Select
        End If
    End Sub
    Private Sub AddMovie()

        Dim oForm As SAPbouiCOM.Form

        Try
            oForm = SBO_Application.Forms.Item("vids_3")
            SBO_Application.MessageBox("Form Already Open")
        Catch ex As Exception
            Dim fcp As SAPbouiCOM.FormCreationParams
            fcp = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
            fcp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
            fcp.FormType = "Vids3"
            fcp.UniqueID = "vids_3"

            oForm = SBO_Application.Forms.AddEx(fcp)
            oForm.AutoManaged = False

            DrawAddForm(oForm)

        End Try

        oForm.Visible = True

    End Sub
    Private Sub DrawAddForm(ByVal oForm As SAPbouiCOM.Form)
        Dim oItem As SAPbouiCOM.Item
        Dim oLabel As SAPbouiCOM.StaticText
        Dim oEdit As SAPbouiCOM.EditText
        Dim oButton As SAPbouiCOM.Button
        Dim oLinked As SAPbouiCOM.LinkedButton

        oForm.Top = 150
        oForm.Left = 330
        oForm.ClientWidth = 200
        oForm.ClientHeight = 170
        oForm.Title = "Add Movie"

        'Adding a datasource to the form
        DBDSVids = oForm.DataSources.DBDataSources.Add("@VIDS")

        ' Adding 4 Static Texts
        ' Movie Code
        oItem = oForm.Items.Add("lblCode", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Movie Code"

        ' Name
        oItem = oForm.Items.Add("lblName", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Movie Name"

        ' Shelf
        oItem = oForm.Items.Add("lblShelf", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 70
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Shelf"

        ' Space
        oItem = oForm.Items.Add("lblSpace", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 100
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Space"

        ' Add 3 Edit Texts
        ' Movie Code
        oItem = oForm.Items.Add("txtCode", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 100
        oItem.Top = 10
        oItem.AffectsFormMode = False

        ' Name
        oItem = oForm.Items.Add("txtName", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 100
        oItem.Top = 40
        oItem.AffectsFormMode = False

        ' Shelf
        oItem = oForm.Items.Add("txtShelf", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 100
        oItem.Top = 70
        oItem.AffectsFormMode = False

        ' Space
        oItem = oForm.Items.Add("txtSpace", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 100
        oItem.Top = 100
        oItem.AffectsFormMode = False

        ' Adding "Add Movie" button
        oItem = oForm.Items.Add("btnAdd", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 10
        oItem.Top = 130
        oItem.AffectsFormMode = False
        oButton = oItem.Specific
        oButton.Caption = "Add Movie"

    End Sub
    Private Sub FindMovie()

        Dim oForm As SAPbouiCOM.Form

        Try
            oForm = SBO_Application.Forms.Item("vids_2")
            SBO_Application.MessageBox("Form Already Open")
        Catch ex As Exception
            Dim fcp As SAPbouiCOM.FormCreationParams
            fcp = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
            fcp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
            fcp.FormType = "Vids2"
            fcp.UniqueID = "vids_2"

            oForm = SBO_Application.Forms.AddEx(fcp)
            oForm.AutoManaged = False

            DrawFindForm(oForm)

        End Try

        oForm.Visible = True

    End Sub
    'Here we will create a UI form by code and not by Loading XML
    Private Sub DrawFindForm(ByVal oForm As SAPbouiCOM.Form)
        Dim oItem As SAPbouiCOM.Item
        Dim oStat As SAPbouiCOM.StaticText
        Dim oEdit As SAPbouiCOM.EditText
        Dim oButton As SAPbouiCOM.Button
        Dim oLinked As SAPbouiCOM.LinkedButton

        oForm.Top = 150
        oForm.Left = 330
        oForm.ClientWidth = 200
        oForm.ClientHeight = 170
        oForm.Title = "Find Movie Location"

        'Adding a datasource to the form
        DBDSVids = oForm.DataSources.DBDataSources.Add("@VIDS")

        ' Adding 4 Static Texts
        ' Movie Code
        oItem = oForm.Items.Add("lblCode", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oStat = oItem.Specific
        oStat.Caption = "Movie Code"

        ' Shelf
        oItem = oForm.Items.Add("lblShelf", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 70
        oItem.AffectsFormMode = False
        oStat = oItem.Specific
        oStat.Caption = "Shelf"

        ' Space
        oItem = oForm.Items.Add("lblSpace", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 90
        oItem.AffectsFormMode = False
        oStat = oItem.Specific
        oStat.Caption = "Space"

        ' Space
        oItem = oForm.Items.Add("lblBP", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 110
        oItem.AffectsFormMode = False
        oStat = oItem.Specific
        oStat.Caption = "Rented by"

        ' Add 3 Edit Texts
        ' Movie Code
        oItem = oForm.Items.Add("txtCode", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 100
        oItem.Top = 10
        oItem.AffectsFormMode = False
        ' Shelf
        oItem = oForm.Items.Add("txtShelf", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 100
        oItem.Top = 70
        oItem.AffectsFormMode = False
        oItem.Enabled = False

        ' Shelf
        oItem = oForm.Items.Add("txtSpace", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 100
        oItem.Top = 90
        oItem.AffectsFormMode = False
        oItem.Enabled = False

        ' Adding a rectangle
        oItem = oForm.Items.Add("rec", SAPbouiCOM.BoFormItemTypes.it_RECTANGLE)
        oItem.Left = 5
        oItem.Top = 60
        oItem.Width = 180
        oItem.Height = 80
        oItem.AffectsFormMode = False

        Dim oCombo As SAPbouiCOM.ComboBox
        ' Adding a Linked Button Combobox
        oItem = oForm.Items.Add("BPLink", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oItem.Left = 100
        oItem.Top = 110
        oItem.AffectsFormMode = False
        oItem.LinkTo = "Linked"
        oItem.Enabled = False

        ' Adding a Linked Button
        oItem = oForm.Items.Add("Linked", SAPbouiCOM.BoFormItemTypes.it_LINKED_BUTTON)
        oItem.Left = 80
        oItem.Top = 110
        'oItem.AffectsFormMode = False
        oItem.LinkTo = "BPLink"
        oLinked = oItem.Specific

        oLinked.LinkedObject = SAPbouiCOM.BoLinkedObject.lf_BusinessPartner

        ' Adding "Find Movie" button
        oItem = oForm.Items.Add("btnFind", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 10
        oItem.Top = 35
        oItem.AffectsFormMode = False
        oButton = oItem.Specific
        oButton.Type = SAPbouiCOM.BoButtonTypes.bt_Image
        oButton.Image = sPath & "search.bmp"
    End Sub
    Private Sub MoviesToShelf()

        Dim oForm As SAPbouiCOM.Form

        Try
            oForm = SBO_Application.Forms.Item("vids_1")
            SBO_Application.MessageBox("Form Already Open")
        Catch ex As Exception
            Dim fcp As SAPbouiCOM.FormCreationParams
            fcp = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
            fcp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
            fcp.FormType = "Vids"
            fcp.UniqueID = "vids_1"
            fcp.XmlData = LoadFromXML("MoviesToShelf.xml")

            oForm = SBO_Application.Forms.AddEx(fcp)

            'This is a bug, The XML property of AffectsFormMode is ignored.
            Dim i As SAPbouiCOM.Item
            i = oForm.Items.Item("cmb_shelfs")
            Dim m As SAPbouiCOM.ComboBox
            m = i.Specific
            i.AffectsFormMode = False

            GetDataFromDataSource(oForm)
        End Try

        oForm.Top = 150
        oForm.Left = 330
        oForm.Visible = True
    End Sub
    Public Sub BindDataToForm(ByVal oColumns As SAPbouiCOM.Columns)

        Dim oColumn As SAPbouiCOM.Column

        '// getting the matrix column by the UID

        oColumn = oColumns.Item("ItemCode")
        oColumn.DataBind.SetBound(True, "@VIDS", "Code")

        oColumn = oColumns.Item("MovieName")
        oColumn.DataBind.SetBound(True, "@VIDS", "Name")

        oColumn = oColumns.Item("CardCode")
        oColumn.DataBind.SetBound(True, "@VIDS", "U_CARDCODE")

        oColumn = oColumns.Item("Shelf")
        oColumn.DataBind.SetBound(True, "@VIDS", "U_SHELF")

        oColumn = oColumns.Item("Space")
        oColumn.DataBind.SetBound(True, "@VIDS", "U_SPACE")

        oColumn = oColumns.Item("Rented")
        oColumn.DataBind.SetBound(True, "@VIDS", "U_RENTED")

    End Sub
    Public Sub GetDataFromDataSource(ByVal oForm As SAPbouiCOM.Form)

        Dim oMatrix As SAPbouiCOM.Matrix
        Dim oItem As SAPbouiCOM.Item

        oItem = oForm.Items.Item("mat")
        oMatrix = oItem.Specific

        'Set The Form Binding
        DBDSVids = oForm.DataSources.DBDataSources.Add("@VIDS")
        BindDataToForm(oMatrix.Columns)

        '// Ready Matrix to populate data
        oMatrix.Clear()
        oMatrix.AutoResizeColumns()

        '// Querying the DB Data source
        DBDSVids.Query()

        oMatrix.LoadFromDataSource()

    End Sub
    Private Sub RentMovie()

        Dim oForm As SAPbouiCOM.Form

        Try
            oForm = SBO_Application.Forms.Item("vids_4")
            SBO_Application.MessageBox("Form Already Open")
        Catch ex As Exception
            Dim fcp As SAPbouiCOM.FormCreationParams
            fcp = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
            fcp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
            fcp.FormType = "Vids4"
            fcp.UniqueID = "vids_4"

            oForm = SBO_Application.Forms.AddEx(fcp)
            oForm.AutoManaged = False

            DrawRentForm(oForm)

        End Try

        oForm.Visible = True

    End Sub
    Private Sub DrawRentForm(ByVal oForm As SAPbouiCOM.Form)
        Dim oItem As SAPbouiCOM.Item
        Dim oLabel As SAPbouiCOM.StaticText
        Dim oEdit As SAPbouiCOM.EditText
        Dim oButton As SAPbouiCOM.Button
        Dim oLinked As SAPbouiCOM.LinkedButton
        Dim oCombCard As SAPbouiCOM.ComboBox
        Dim oCombMovie As SAPbouiCOM.ComboBox

        oForm.Top = 150
        oForm.Left = 330
        oForm.ClientWidth = 200
        oForm.ClientHeight = 130
        oForm.Title = "Rent/Return Movie"

        'Adding a datasource to the form
        DBDSVids = oForm.DataSources.DBDataSources.Add("@VIDS")

        ' Adding 3 Static Texts
        ' Movie Code
        oItem = oForm.Items.Add("lblCode", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Movie"

        ' CardCode
        oItem = oForm.Items.Add("lblShelf", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Client Code"

        ' Add Movie Code Combo Box
        oItem = oForm.Items.Add("CombCode", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oItem.Left = 100
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oItem.DisplayDesc = True
        oCombCard = oItem.Specific

        ' Add Movie Code Combo Box
        oItem = oForm.Items.Add("CombCard", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oItem.Left = 100
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oItem.DisplayDesc = True
        oCombMovie = oItem.Specific

        ' Adding "Rent Movie" button
        oItem = oForm.Items.Add("btnRent", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 10
        oItem.Top = 90
        oItem.AffectsFormMode = False
        oButton = oItem.Specific
        oButton.Caption = "Rent Movie"

        ' Adding "Return Movie" button
        oItem = oForm.Items.Add("btnRet", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 90
        oItem.Top = 90
        oItem.AffectsFormMode = False
        oButton = oItem.Specific
        oButton.Caption = "Return Movie"

        LoadMoviesCodeComboVals(oCombCard)
        LoadCardCodeComboVals(oCombMovie)

    End Sub

    Private Sub LoadMoviesCodeComboVals(ByVal oCombo As SAPbouiCOM.ComboBox)
        Dim RecSet As SAPbobsCOM.Recordset
        Dim QryStr As String
        Dim RecCount As Long
        Dim RecIndex As Long

        RecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        QryStr = "Select Code, Name from [@VIDS]"
        RecSet.DoQuery(QryStr)
        RecCount = RecSet.RecordCount
        RecSet.MoveFirst()

        'Add the default value
        oCombo.ValidValues.Add("0", "Select Movie")

        For RecIndex = 0 To RecCount - 1
            oCombo.ValidValues.Add(RecSet.Fields.Item(0).Value, RecSet.Fields.Item(1).Value)
            RecSet.MoveNext()
        Next RecIndex

        oCombo.Select("0")

        RecSet = Nothing
        System.GC.Collect()

    End Sub
    Private Sub LoadCardCodeComboVals(ByVal oCombo As SAPbouiCOM.ComboBox)
        Dim RecSet As SAPbobsCOM.Recordset
        Dim QryStr As String
        Dim RecCount As Long
        Dim RecIndex As Long

        RecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        QryStr = "Select CardCode from OCRD where CardType = 'C'"
        RecSet.DoQuery(QryStr)
        RecCount = RecSet.RecordCount
        RecSet.MoveFirst()

        'Add the default value
        oCombo.ValidValues.Add("0", "Select Client")

        For RecIndex = 0 To RecCount - 1
            oCombo.ValidValues.Add(RecIndex + 1, RecSet.Fields.Item(0).Value)
            RecSet.MoveNext()
        Next RecIndex

        oCombo.Select("0")

        RecSet = Nothing
        System.GC.Collect()

    End Sub
    Private Sub SBO_Application_AppEvent(ByVal EventType As SAPbouiCOM.BoAppEventTypes) Handles SBO_Application.AppEvent
        ' Terminate our addon when the application shuts down
        If EventType = SAPbouiCOM.BoAppEventTypes.aet_ShutDown Then
            SBO_Application.MessageBox("Vids Addon will now terminate")
            System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Private Function LoadFromXML(ByRef FileName As String) As String

        Dim oXmlDoc As Xml.XmlDocument
        Dim sPath As String

        oXmlDoc = New Xml.XmlDocument

        '// load the content of the XML File

        sPath = System.Windows.Forms.Application.StartupPath
        sPath = sPath.Remove(sPath.Length - 3, 3)

        oXmlDoc.Load(sPath & FileName)

        '// load the form to the SBO application in one batch
        Return (oXmlDoc.InnerXml)

    End Function
    Private Sub ShowMoviesByShelf()

        Dim oMatrix As SAPbouiCOM.Matrix
        Dim oItem, ShelfItem, RentedItem As SAPbouiCOM.Item
        Dim oForm As SAPbouiCOM.Form
        Dim cmbShelf, cmbRented As SAPbouiCOM.ComboBox
        Dim ShelfNum As Integer
        Dim Rented As String

        oForm = SBO_Application.Forms.ActiveForm

        oItem = oForm.Items.Item("mat")
        oMatrix = oItem.Specific
        ShelfItem = oForm.Items.Item("cmb_shelfs")
        cmbShelf = ShelfItem.Specific

        RentedItem = oForm.Items.Item("cmb_rented")
        cmbRented = RentedItem.Specific

        If IsNothing(cmbRented.Selected) Then
            Rented = "A"
        Else
            Select Case cmbRented.Selected.Value
                Case "Rented"
                    Rented = "Y"
                Case "Available"
                    Rented = "N"
                Case "All"
                    Rented = "A"
            End Select
        End If

        'Fill the DB Datasource
        DBDSVids = oForm.DataSources.DBDataSources.Item("@VIDS")
        DBDSVids.Query()

        If IsNumeric(cmbShelf.Selected.Value) Then ' Incase it's all
            ShelfNum = CInt(cmbShelf.Selected.Value)
        End If

        Dim i As Integer

        i = 0
        While i < DBDSVids.Size
            If (DBDSVids.GetValue("U_SHELF", i) <> (ShelfNum.ToString) And (cmbShelf.Selected.Value <> "All")) Then
                DBDSVids.RemoveRecord(i)
                i = i - 1
            ElseIf (DBDSVids.GetValue("U_RENTED", i) <> Rented) And Rented <> "A" Then
                DBDSVids.RemoveRecord(i)
                i = i - 1
            End If
            i = i + 1
        End While

        oMatrix.LoadFromDataSource()
    End Sub
    Private Sub DoAddMovie()

        Dim oEdit As SAPbouiCOM.EditText
        Dim oItemBP, oItem, ShelfItem, RentedItem As SAPbouiCOM.Item
        Dim oForm As SAPbouiCOM.Form
        Dim strFind As String
        Dim isFound As Boolean

        isFound = False

        oForm = SBO_Application.Forms.ActiveForm

        oItem = oForm.Items.Item("txtCode")
        oEdit = oItem.Specific
        strFind = oEdit.String

        DBDSVids.Query()

        Dim i As Integer
        If ((strFind <> "") And (strFind <> Nothing)) Then
            For i = 0 To DBDSVids.Size - 1
                If (DBDSVids.GetValue("Code", i).Trim(" ") = strFind) Then
                    isFound = True
                    Exit For
                End If
            Next i
            If Not isFound Then
                Dim Shelf, space As Integer
                Dim Name As String
                'Name
                oItem = oForm.Items.Item("txtName")
                oEdit = oItem.Specific
                Name = (oEdit.String)
                'Shelf
                oItem = oForm.Items.Item("txtShelf")
                oEdit = oItem.Specific
                Shelf = CInt(oEdit.String)
                'Space
                oItem = oForm.Items.Item("txtSpace")
                oEdit = oItem.Specific
                space = CInt(oEdit.String)

                'Start DI code here
                'Public oOrder As SAPbobsCOM.Documents ' Order object
                If AddMovieToDatabase(strFind, Name, Shelf, space) Then
                    SBO_Application.MessageBox("Movie Added")
                End If

            Else
                SBO_Application.MessageBox("Movie with this code already exists")
            End If
        Else
            SBO_Application.MessageBox("You must type the movie code")
        End If
    End Sub
    Private Function AddMovieToDatabase(ByVal Code As String, ByVal Name As String, ByVal Shelf As Integer, ByVal Space As Integer) As Boolean
        Dim oUsrTbl As SAPbobsCOM.UserTable
        Dim Res As Integer

        AddMovieToDatabase = False

        oUsrTbl = oCompany.UserTables.Item("VIDS")

        oUsrTbl.Code = CInt(Code)
        oUsrTbl.Name = Name
        oUsrTbl.UserFields.Fields.Item("U_SHELF").Value = Shelf
        oUsrTbl.UserFields.Fields.Item("U_SPACE").Value = Space
        Res = oUsrTbl.Add()


        If Res = 0 Then
            AddMovieToDatabase = True
        Else
            SBO_Application.MessageBox("Error, failed to add movie")
        End If
    End Function
    Private Sub DoRentMovie()
        Dim RecSet As SAPbobsCOM.Recordset
        Dim oForm As SAPbouiCOM.Form
        Dim oMovieCombo As SAPbouiCOM.ComboBox
        Dim oCardCombo As SAPbouiCOM.ComboBox
        Dim MovieStr As String
        Dim CardStr As String
        Dim QryStr As String
        Dim QryAns As String

        RecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oForm = SBO_Application.Forms.ActiveForm
        oMovieCombo = oForm.Items.Item("CombCode").Specific
        oCardCombo = oForm.Items.Item("CombCard").Specific
        MovieStr = oMovieCombo.Selected.Value
        CardStr = oCardCombo.Selected.Description

        QryStr = "select U_RENTED from [@VIDS] where Code = '" & MovieStr & "'"
        RecSet.DoQuery(QryStr)
        QryAns = RecSet.Fields.Item(0).Value

        If (QryAns = "Y") Then
            SBO_Application.MessageBox("Movie already rented, Please choose a different one")
        Else
            QryStr = "update [@VIDS] set U_RENTED = 'Y', U_CARDCODE = '" & CardStr & "' where Code = '" & MovieStr & "'"
            RecSet.DoQuery(QryStr)
            SBO_Application.MessageBox("Movie Rented Successfully")
        End If
        oMovieCombo.Select("0")
        oCardCombo.Select("0")
    End Sub

    Private Sub DoReturnMovie()
        Dim RecSet As SAPbobsCOM.Recordset
        Dim oForm As SAPbouiCOM.Form
        Dim oMovieCombo As SAPbouiCOM.ComboBox
        Dim oCardCombo As SAPbouiCOM.ComboBox
        Dim MovieStr As String
        Dim CardStr As String
        Dim QryStr As String
        Dim QryAns As String

        RecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oForm = SBO_Application.Forms.ActiveForm
        oMovieCombo = oForm.Items.Item("CombCode").Specific
        MovieStr = oMovieCombo.Selected.Value

        QryStr = "select U_RENTED from [@VIDS] where Code = '" & MovieStr & "'"
        RecSet.DoQuery(QryStr)
        QryAns = RecSet.Fields.Item(0).Value

        If (QryAns = "N") Then
            SBO_Application.MessageBox("Movie isn't rented, Please choose a different one")
        Else
            QryStr = "update [@VIDS] set U_RENTED = 'N', U_CARDCODE = '' where Code = '" & MovieStr & "'"
            RecSet.DoQuery(QryStr)
            SBO_Application.MessageBox("Movie Returned Successfully")
        End If
        oMovieCombo.Select("0")
    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        If pVal.BeforeAction = False Then
            Select Case FormUID
                Case "vids_1"
                    If ((pVal.ItemUID = "cmb_shelfs") Or (pVal.ItemUID = "cmb_rented")) And pVal.EventType = SAPbouiCOM.BoEventTypes.et_COMBO_SELECT Then
                        ShowMoviesByShelf()
                    End If
                    If ((pVal.ItemUID = "btnAdd") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED)) Then
                        SBO_Application.ActivateMenuItem("SM_VID_F3")
                    End If
                Case "vids_2"
                    If ((pVal.ItemUID = "btnFind") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED)) Then
                        DoMovieFind()
                    End If
                Case "vids_3"
                    If ((pVal.ItemUID = "btnAdd") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED)) Then
                        DoAddMovie()
                    End If
                Case "vids_4"
                    If ((pVal.ItemUID = "btnRent") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED)) Then
                        DoRentMovie()
                    End If
                    If ((pVal.ItemUID = "btnRet") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED)) Then
                        DoReturnMovie()
                    End If
            End Select
        End If
    End Sub
    Private Sub DoMovieFind()

        Dim oEdit As SAPbouiCOM.EditText
        Dim oItemBP, oItem, ShelfItem, RentedItem As SAPbouiCOM.Item
        Dim oForm As SAPbouiCOM.Form
        Dim strFind As String
        Dim isFound As Boolean

        isFound = False

        oForm = SBO_Application.Forms.ActiveForm

        oItem = oForm.Items.Item("txtCode")
        oEdit = oItem.Specific
        strFind = oEdit.String

        DBDSVids.Query()

        Dim i As Integer

        For i = 0 To DBDSVids.Size - 1
            If (DBDSVids.GetValue("Code", i).Trim(" ") = strFind) Then
                isFound = True
                oItem = oForm.Items.Item("txtShelf")
                oEdit = oItem.Specific
                oEdit.String = DBDSVids.GetValue("U_Shelf", i).Trim(" ")
                oItem = oForm.Items.Item("txtSpace")
                oEdit = oItem.Specific
                oEdit.String = DBDSVids.GetValue("U_Space", i).Trim(" ")

                ' Adding the returned BP to the Combo Box
                Dim oCombo As SAPbouiCOM.ComboBox
                Dim BP As String
                oItemBP = oForm.Items.Item("BPLink")
                oCombo = oItemBP.Specific
                BP = DBDSVids.GetValue("U_CardCode", i).Trim(" ")
                oCombo.ValidValues.Add(BP, "")
                oCombo.Select(BP)
            End If
        Next i
        If Not isFound Then
            SBO_Application.MessageBox("Movie Code " & strFind & " was not found")
        End If
    End Sub
    Private Function SetConnectionContext() As Integer

        Dim sCookie As String
        Dim sConnectionContext As String
        Dim lRetCode As Integer

        '// First initialize the Company object

        oCompany = New SAPbobsCOM.Company

        '// Acquire the connection context cookie from the DI API.
        sCookie = oCompany.GetContextCookie

        '// Retrieve the connection context string from the UI API using the
        '// acquired cookie.
        sConnectionContext = SBO_Application.Company.GetConnectionContext(sCookie)

        '// before setting the SBO Login Context make sure the company is not
        '// connected

        If oCompany.Connected = True Then
            oCompany.Disconnect()
        End If

        '// Set the connection context information to the DI API.
        SetConnectionContext = oCompany.SetSboLoginContext(sConnectionContext)

    End Function
End Class
