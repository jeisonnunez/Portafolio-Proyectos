using Microsoft.VisualBasic;
using System;
namespace VidsSamp {
    public class Vids  { 
        
        private /* TRANSINFO: WithEvents */ SAPbouiCOM.Application SBO_Application; 
        private SAPbobsCOM.Company oCompany; 
        private SAPbouiCOM.DBDataSource DBDSVids; 
        private SAPbouiCOM.Form frmMoviesToShelfs; 
        private string sPath; 
        
        
        public Vids() { 
            try { 
                SetApplication(); 
                //  Set The Connection Context
                if ( !( SetConnectionContext() == 0 ) ) { 
                    SBO_Application.MessageBox( "Failed setting a connection to DI API", 1, "Ok", "", "" ); 
                    System.Environment.Exit( 0 ); //  Terminating the Add-On Application
                } 
                
                
                if ( !( ConnectToCompany() == 0 ) ) { 
                    SBO_Application.MessageBox( "Failed connecting to the company's Data Base", 1, "Ok", "", "" ); 
                    System.Environment.Exit( 0 ); //  Terminating the Add-On Application
                } 
                
                SBO_Application.MessageBox( "DI Connected To: " + oCompany.CompanyName, 1, "Ok", "", "" ); 
                
            } 
            catch  { 
                System.Windows.Forms.MessageBox.Show( "SBO application not found" ); 
            } 
            AddMenuItems(); 
            // events handled by SBO_Application_MenuEvent
            /* TRANSWARNING: check EventHandler assignment */ 
			bool tmpBool = true;
			//SAPbouiCOM.MenuEvent tmpEvent = SBO_Application_MenuEvent;

			SBO_Application.MenuEvent += new SAPbouiCOM._IApplicationEvents_MenuEventEventHandler( SBO_Application_MenuEvent); 
			// events handled by SBO_Application_AppEvent
            /* TRANSWARNING: check EventHandler assignment */ 
            SBO_Application.AppEvent += new SAPbouiCOM._IApplicationEvents_AppEventEventHandler( SBO_Application_AppEvent);
        
            // events handled by SBO_Application_ItemEvent
            /* TRANSWARNING: check EventHandler assignment */ 
            SBO_Application.ItemEvent += new SAPbouiCOM._IApplicationEvents_ItemEventEventHandler( SBO_Application_ItemEvent ); 
        } 
        private int ConnectToCompany() { 
            int connectToCompanyReturn = 0;
            
            // // Make sure you're not already connected.
            if ( oCompany.Connected == true ) { 
                oCompany.Disconnect(); 
            } 
            
            // // Establish the connection to the company database.
            connectToCompanyReturn = oCompany.Connect(); 
            
            return connectToCompanyReturn;
        } 
        
        
        private void SetApplication() { 
            
            // *******************************************************************
            // // Use an SboGuiApi object to establish connection
            // // with the SAP Business One application and return an
            // // initialized appliction object
            // *******************************************************************
            
            SAPbouiCOM.SboGuiApi SboGuiApi = null; 
            string sConnectionString = null; 
            
            SboGuiApi = new SAPbouiCOM.SboGuiApi(); 
            
            // // by following the steps specified above, the following
            // // statment should be suficient for either development or run mode
            
            sConnectionString = Interaction.Command(); 
            
            // // connect to a running SBO Application
            
            SboGuiApi.Connect( sConnectionString ); 
            
            // // get an initialized application object
            
            SBO_Application = SboGuiApi.GetApplication( -1 ); 
            
        } 
        
        private void AddMenuItems() { 
            // //******************************************************************
            // // Let's add a pop-up menu item and 3 sub menu items
            // //******************************************************************
            
            SAPbouiCOM.Menus oMenus = null; 
            SAPbouiCOM.MenuItem oMenuItem = null; 
            
            // // Get the menus collection from the application
            oMenus = SBO_Application.Menus; 
            
            SAPbouiCOM.MenuCreationParams oCreationPackage = null; 
            
            oCreationPackage = ( ( SAPbouiCOM.MenuCreationParams )( SBO_Application.CreateObject( SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams ) ) ); 
            oMenuItem = SBO_Application.Menus.Item( "43520" ); // moudles'
            
            
            sPath = System.Windows.Forms.Application.StartupPath; 
            sPath = sPath.Remove( sPath.Length - 3, 3 ); 
            
            //  Creation parameters
            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP; 
            oCreationPackage.UniqueID = "SM_VID"; 
            oCreationPackage.String = "Video Store"; 
            oCreationPackage.Image = sPath + "VID.bmp"; 
            //  we add our menu at the buttom of the list
            oCreationPackage.Position = oMenuItem.SubMenus.Count + 1; 
            
            oMenus = oMenuItem.SubMenus; 
            
            try { 
                //  If the manu already exists this code will failoMenus.AddEx( oCreationPackage ); 
                
                //  Get the menu collection of the newly added pop-up item
                oMenuItem = SBO_Application.Menus.Item( "SM_VID" ); 
                oMenus = oMenuItem.SubMenus; 
                
                //  Add 4 Sub Menu Items
                oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING; 
                oCreationPackage.UniqueID = "SM_VID_F1"; 
                oCreationPackage.String = "Movies On Shelf"; 
                oCreationPackage.Image = sPath + "v1.bmp"; 
                oMenus.AddEx( oCreationPackage ); 
                
                oCreationPackage.UniqueID = "SM_VID_F2"; 
                oCreationPackage.String = "Movies Location"; 
                oCreationPackage.Image = sPath + "v2.bmp"; 
                oMenus.AddEx( oCreationPackage ); 
                
                oCreationPackage.UniqueID = "SM_VID_F3"; 
                oCreationPackage.String = "Add Movie"; 
                oCreationPackage.Image = sPath + "v3.bmp"; 
                oMenus.AddEx( oCreationPackage ); 
                
                oCreationPackage.UniqueID = "SM_VID_F4"; 
                oCreationPackage.String = "Rent / Return Movie"; 
                oCreationPackage.Image = sPath + "v4.bmp"; 
                oMenus.AddEx( oCreationPackage ); 
                
            } 
            catch ( Exception er ) { //  Error Handling
                SBO_Application.MessageBox( er.Message, 1, "Ok", "", "" ); 
            } 
            
        } 
        
		private void SBO_Application_MenuEvent( ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent ) 
		{ 
			BubbleEvent = false;
            if ( pVal.BeforeAction == false ) { 
                switch ( pVal.MenuUID ) {
                    case "SM_VID_F1":
                        MoviesToShelf(); 
                        break;
                    case "SM_VID_F2":
                        FindMovie(); 
                        break;
                    case "SM_VID_F3":
                        AddMovie(); 
                        break;
                    case "SM_VID_F4":
                        RentMovie(); 
                        break;
                }
                
            } 
        } 
        
        private void AddMovie() { 
            
            SAPbouiCOM.Form oForm = null; 
            
            try { 
                oForm = SBO_Application.Forms.Item( "vids_3" ); 
                SBO_Application.MessageBox( "Form Already Open", 1, "Ok", "", "" ); 
            } 
            catch ( Exception ex ) { 
                SAPbouiCOM.FormCreationParams fcp = null; 
                fcp = ( ( SAPbouiCOM.FormCreationParams )( SBO_Application.CreateObject( SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams ) ) ); 
                fcp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed; 
                fcp.FormType = "Vids3"; 
                fcp.UniqueID = "vids_3"; 
                
                oForm = SBO_Application.Forms.AddEx( fcp ); 
                oForm.AutoManaged = false; 
                
                DrawAddForm( oForm ); 
                
            } 
            
            oForm.Visible = true; 
            
        } 
        
        private void DrawAddForm( SAPbouiCOM.Form oForm ) { 
            SAPbouiCOM.Item oItem = null; 
            SAPbouiCOM.StaticText oLabel = null; 
            SAPbouiCOM.EditText oEdit = null; 
            SAPbouiCOM.Button oButton = null; 
            SAPbouiCOM.LinkedButton oLinked = null; 
            
            oForm.Top = 150; 
            oForm.Left = 330; 
            oForm.ClientWidth = 200; 
            oForm.ClientHeight = 170; 
            oForm.Title = "Add Movie"; 
            
            // Adding a datasource to the form
            DBDSVids = oForm.DataSources.DBDataSources.Add( "@VIDS" ); 
            
            //  Adding 4 Static Texts
            //  Movie Code
            oItem = oForm.Items.Add( "lblCode", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 10; 
            oItem.AffectsFormMode = false; 
            oLabel = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oLabel.Caption = "Movie Code"; 
            
            //  Name
            oItem = oForm.Items.Add( "lblName", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 40; 
            oItem.AffectsFormMode = false; 
            oLabel = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oLabel.Caption = "Movie Name"; 
            
            //  Shelf
            oItem = oForm.Items.Add( "lblShelf", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 70; 
            oItem.AffectsFormMode = false; 
            oLabel = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oLabel.Caption = "Shelf"; 
            
            //  Space
            oItem = oForm.Items.Add( "lblSpace", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 100; 
            oItem.AffectsFormMode = false; 
            oLabel = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oLabel.Caption = "Space"; 
            
            //  Add 3 Edit Texts
            //  Movie Code
            oItem = oForm.Items.Add( "txtCode", SAPbouiCOM.BoFormItemTypes.it_EDIT ); 
            oItem.Left = 100; 
            oItem.Top = 10; 
            oItem.AffectsFormMode = false; 
            
            //  Name
            oItem = oForm.Items.Add( "txtName", SAPbouiCOM.BoFormItemTypes.it_EDIT ); 
            oItem.Left = 100; 
            oItem.Top = 40; 
            oItem.AffectsFormMode = false; 
            
            //  Shelf
            oItem = oForm.Items.Add( "txtShelf", SAPbouiCOM.BoFormItemTypes.it_EDIT ); 
            oItem.Left = 100; 
            oItem.Top = 70; 
            oItem.AffectsFormMode = false; 
            
            //  Space
            oItem = oForm.Items.Add( "txtSpace", SAPbouiCOM.BoFormItemTypes.it_EDIT ); 
            oItem.Left = 100; 
            oItem.Top = 100; 
            oItem.AffectsFormMode = false; 
            
            //  Adding "Add Movie" button
            oItem = oForm.Items.Add( "btnAdd", SAPbouiCOM.BoFormItemTypes.it_BUTTON ); 
            oItem.Left = 10; 
            oItem.Top = 130; 
            oItem.AffectsFormMode = false; 
            oButton = ( ( SAPbouiCOM.Button )( oItem.Specific ) ); 
            oButton.Caption = "Add Movie"; 
            
        } 
        
        private void FindMovie() { 
            
            SAPbouiCOM.Form oForm = null; 
            
            try { 
                oForm = SBO_Application.Forms.Item( "vids_2" ); 
                SBO_Application.MessageBox( "Form Already Open", 1, "Ok", "", "" ); 
            } 
            catch ( Exception ex ) { 
                SAPbouiCOM.FormCreationParams fcp = null; 
                fcp = ( ( SAPbouiCOM.FormCreationParams )( SBO_Application.CreateObject( SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams ) ) ); 
                fcp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed; 
                fcp.FormType = "Vids2"; 
                fcp.UniqueID = "vids_2"; 
                
                oForm = SBO_Application.Forms.AddEx( fcp ); 
                oForm.AutoManaged = false; 
                
                DrawFindForm( oForm ); 
                
            } 
            
            oForm.Visible = true; 
            
        } 
        
        // Here we will create a UI form by code and not by Loading XML
        private void DrawFindForm( SAPbouiCOM.Form oForm ) { 
            SAPbouiCOM.Item oItem = null; 
            SAPbouiCOM.StaticText oStat = null; 
            SAPbouiCOM.EditText oEdit = null; 
            SAPbouiCOM.Button oButton = null; 
            SAPbouiCOM.LinkedButton oLinked = null; 
            
            oForm.Top = 150; 
            oForm.Left = 330; 
            oForm.ClientWidth = 200; 
            oForm.ClientHeight = 170; 
            oForm.Title = "Find Movie Location"; 
            
            // Adding a datasource to the form
            DBDSVids = oForm.DataSources.DBDataSources.Add( "@VIDS" ); 
            
            //  Adding 4 Static Texts
            //  Movie Code
            oItem = oForm.Items.Add( "lblCode", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 10; 
            oItem.AffectsFormMode = false; 
            oStat = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oStat.Caption = "Movie Code"; 
            
            //  Shelf
            oItem = oForm.Items.Add( "lblShelf", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 70; 
            oItem.AffectsFormMode = false; 
            oStat = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oStat.Caption = "Shelf"; 
            
            //  Space
            oItem = oForm.Items.Add( "lblSpace", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 90; 
            oItem.AffectsFormMode = false; 
            oStat = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oStat.Caption = "Space"; 
            
            //  Space
            oItem = oForm.Items.Add( "lblBP", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 110; 
            oItem.AffectsFormMode = false; 
            oStat = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oStat.Caption = "Rented by"; 
            
            //  Add 3 Edit Texts
            //  Movie Code
            oItem = oForm.Items.Add( "txtCode", SAPbouiCOM.BoFormItemTypes.it_EDIT ); 
            oItem.Left = 100; 
            oItem.Top = 10; 
            oItem.AffectsFormMode = false; 
            //  Shelf
            oItem = oForm.Items.Add( "txtShelf", SAPbouiCOM.BoFormItemTypes.it_EDIT ); 
            oItem.Left = 100; 
            oItem.Top = 70; 
            oItem.AffectsFormMode = false; 
            oItem.Enabled = false; 
            
            //  Shelf
            oItem = oForm.Items.Add( "txtSpace", SAPbouiCOM.BoFormItemTypes.it_EDIT ); 
            oItem.Left = 100; 
            oItem.Top = 90; 
            oItem.AffectsFormMode = false; 
            oItem.Enabled = false; 
            
            //  Adding a rectangle
            oItem = oForm.Items.Add( "rec", SAPbouiCOM.BoFormItemTypes.it_RECTANGLE ); 
            oItem.Left = 5; 
            oItem.Top = 60; 
            oItem.Width = 180; 
            oItem.Height = 80; 
            oItem.AffectsFormMode = false; 
            
            SAPbouiCOM.ComboBox oCombo = null; 
            //  Adding a Linked Button Combobox
            oItem = oForm.Items.Add( "BPLink", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX ); 
            oItem.Left = 100; 
            oItem.Top = 110; 
            oItem.AffectsFormMode = false; 
            oItem.LinkTo = "Linked"; 
            oItem.Enabled = false; 
            
            //  Adding a Linked Button
            oItem = oForm.Items.Add( "Linked", SAPbouiCOM.BoFormItemTypes.it_LINKED_BUTTON ); 
            oItem.Left = 80; 
            oItem.Top = 110; 
            // oItem.AffectsFormMode = False
            oItem.LinkTo = "BPLink"; 
            oLinked = ( ( SAPbouiCOM.LinkedButton )( oItem.Specific ) ); 
            
            oLinked.LinkedObject = SAPbouiCOM.BoLinkedObject.lf_BusinessPartner; 
            
            //  Adding "Find Movie" button
            oItem = oForm.Items.Add( "btnFind", SAPbouiCOM.BoFormItemTypes.it_BUTTON ); 
            oItem.Left = 10; 
            oItem.Top = 35; 
            oItem.AffectsFormMode = false; 
            oButton = ( ( SAPbouiCOM.Button )( oItem.Specific ) ); 
            oButton.Type = SAPbouiCOM.BoButtonTypes.bt_Image; 
            oButton.Image = sPath + "search.bmp"; 
        } 
        
        private void MoviesToShelf() { 
            
            SAPbouiCOM.Form oForm = null; 
            
            try { 
                oForm = SBO_Application.Forms.Item( "vids_1" ); 
                SBO_Application.MessageBox( "Form Already Open", 1, "Ok", "", "" ); 
            } 
            catch ( Exception ex ) { 
                SAPbouiCOM.FormCreationParams fcp = null; 
                fcp = ( ( SAPbouiCOM.FormCreationParams )( SBO_Application.CreateObject( SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams ) ) ); 
                fcp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed; 
                fcp.FormType = "Vids"; 
                fcp.UniqueID = "vids_1"; 
                string transTemp0 = "MoviesToShelf.xml"; 
                fcp.XmlData = LoadFromXML( ref transTemp0 ); 
                
                oForm = SBO_Application.Forms.AddEx( fcp ); 
                
                // This is a bug, The XML property of AffectsFormMode is ignored.
                SAPbouiCOM.Item i = null; 
                i = oForm.Items.Item( "cmb_shelfs" ); 
                SAPbouiCOM.ComboBox m = null; 
                m = ( ( SAPbouiCOM.ComboBox )( i.Specific ) ); 
                i.AffectsFormMode = false; 
                
                GetDataFromDataSource( oForm ); 
            } 
            
            oForm.Top = 150; 
            oForm.Left = 330; 
            oForm.Visible = true; 
        } 
        
        public void BindDataToForm( SAPbouiCOM.Columns oColumns ) { 
            
            SAPbouiCOM.Column oColumn = null; 
            
            // // getting the matrix column by the UID
            
            oColumn = oColumns.Item( "ItemCode" ); 
            oColumn.DataBind.SetBound( true, "@VIDS", "Code" ); 
            
            oColumn = oColumns.Item( "MovieName" ); 
            oColumn.DataBind.SetBound( true, "@VIDS", "Name" ); 
            
            oColumn = oColumns.Item( "CardCode" ); 
            oColumn.DataBind.SetBound( true, "@VIDS", "U_CARDCODE" ); 
            
            oColumn = oColumns.Item( "Shelf" ); 
            oColumn.DataBind.SetBound( true, "@VIDS", "U_SHELF" ); 
            
            oColumn = oColumns.Item( "Space" ); 
            oColumn.DataBind.SetBound( true, "@VIDS", "U_SPACE" ); 
            
            oColumn = oColumns.Item( "Rented" ); 
            oColumn.DataBind.SetBound( true, "@VIDS", "U_RENTED" ); 
            
        } 
        
        public void GetDataFromDataSource( SAPbouiCOM.Form oForm ) { 
            
            SAPbouiCOM.Matrix oMatrix = null; 
            SAPbouiCOM.Item oItem = null; 
            
            oItem = oForm.Items.Item( "mat" ); 
            oMatrix = ( ( SAPbouiCOM.Matrix )( oItem.Specific ) ); 
            
            // Set The Form Binding
            DBDSVids = oForm.DataSources.DBDataSources.Add( "@VIDS" ); 
            BindDataToForm( oMatrix.Columns ); 
            
            // // Ready Matrix to populate data
            oMatrix.Clear(); 
            oMatrix.AutoResizeColumns(); 
            
            // // Querying the DB Data source
            DBDSVids.Query( null ); 
            
            oMatrix.LoadFromDataSource(); 
            
        } 
        
        private void RentMovie() { 
            
            SAPbouiCOM.Form oForm = null; 
            
            try { 
                oForm = SBO_Application.Forms.Item( "vids_4" ); 
                SBO_Application.MessageBox( "Form Already Open", 1, "Ok", "", "" ); 
            } 
            catch ( Exception ex ) { 
                SAPbouiCOM.FormCreationParams fcp = null; 
                fcp = ( ( SAPbouiCOM.FormCreationParams )( SBO_Application.CreateObject( SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams ) ) ); 
                fcp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed; 
                fcp.FormType = "Vids4"; 
                fcp.UniqueID = "vids_4"; 
                
                oForm = SBO_Application.Forms.AddEx( fcp ); 
                oForm.AutoManaged = false; 
                
                DrawRentForm( oForm ); 
                
            } 
            
            oForm.Visible = true; 
            
        } 
        
        private void DrawRentForm( SAPbouiCOM.Form oForm ) { 
            SAPbouiCOM.Item oItem = null; 
            SAPbouiCOM.StaticText oLabel = null; 
            SAPbouiCOM.EditText oEdit = null; 
            SAPbouiCOM.Button oButton = null; 
            SAPbouiCOM.LinkedButton oLinked = null; 
            SAPbouiCOM.ComboBox oCombCard = null; 
            SAPbouiCOM.ComboBox oCombMovie = null; 
            
            oForm.Top = 150; 
            oForm.Left = 330; 
            oForm.ClientWidth = 200; 
            oForm.ClientHeight = 130; 
            oForm.Title = "Rent/Return Movie"; 
            
            // Adding a datasource to the form
            DBDSVids = oForm.DataSources.DBDataSources.Add( "@VIDS" ); 
            
            //  Adding 3 Static Texts
            //  Movie Code
            oItem = oForm.Items.Add( "lblCode", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 10; 
            oItem.AffectsFormMode = false; 
            oLabel = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oLabel.Caption = "Movie"; 
            
            //  CardCode
            oItem = oForm.Items.Add( "lblShelf", SAPbouiCOM.BoFormItemTypes.it_STATIC ); 
            oItem.Left = 10; 
            oItem.Top = 40; 
            oItem.AffectsFormMode = false; 
            oLabel = ( ( SAPbouiCOM.StaticText )( oItem.Specific ) ); 
            oLabel.Caption = "Client Code"; 
            
            //  Add Movie Code Combo Box
            oItem = oForm.Items.Add( "CombCode", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX ); 
            oItem.Left = 100; 
            oItem.Top = 10; 
            oItem.AffectsFormMode = false; 
            oItem.DisplayDesc = true; 
            oCombCard = ( ( SAPbouiCOM.ComboBox )( oItem.Specific ) ); 
            
            //  Add Movie Code Combo Box
            oItem = oForm.Items.Add( "CombCard", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX ); 
            oItem.Left = 100; 
            oItem.Top = 40; 
            oItem.AffectsFormMode = false; 
            oItem.DisplayDesc = true; 
            oCombMovie = ( ( SAPbouiCOM.ComboBox )( oItem.Specific ) ); 
            
            //  Adding "Rent Movie" button
            oItem = oForm.Items.Add( "btnRent", SAPbouiCOM.BoFormItemTypes.it_BUTTON ); 
            oItem.Left = 10; 
            oItem.Top = 90; 
            oItem.AffectsFormMode = false; 
            oButton = ( ( SAPbouiCOM.Button )( oItem.Specific ) ); 
            oButton.Caption = "Rent Movie"; 
            
            //  Adding "Return Movie" button
            oItem = oForm.Items.Add( "btnRet", SAPbouiCOM.BoFormItemTypes.it_BUTTON ); 
            oItem.Left = 90; 
            oItem.Top = 90; 
            oItem.AffectsFormMode = false; 
            oButton = ( ( SAPbouiCOM.Button )( oItem.Specific ) ); 
            oButton.Caption = "Return Movie"; 
            
            LoadMoviesCodeComboVals( oCombCard ); 
            LoadCardCodeComboVals( oCombMovie ); 
            
        } 
        
        
        private void LoadMoviesCodeComboVals( SAPbouiCOM.ComboBox oCombo ) { 
            SAPbobsCOM.Recordset RecSet = null; 
            string QryStr = null; 
            long RecCount = 0; 
            long RecIndex = 0; 
            
            RecSet = ( ( SAPbobsCOM.Recordset )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.BoRecordset ) ) ); 
            QryStr = "Select Code, Name from [@VIDS]"; 
            RecSet.DoQuery( QryStr ); 
            RecCount = RecSet.RecordCount; 
            RecSet.MoveFirst(); 
            
            // Add the default value
            oCombo.ValidValues.Add( "0", "Select Movie" ); 
            
            for ( RecIndex=0; RecIndex<=RecCount - 1; RecIndex++ ) { 
                oCombo.ValidValues.Add( System.Convert.ToString( RecSet.Fields.Item( 0 ).Value ), System.Convert.ToString( RecSet.Fields.Item( 1 ).Value ) ); 
                RecSet.MoveNext(); 
            } 
            
            oCombo.Select( "0", (SAPbouiCOM.BoSearchKey)(0) ); 
            
            RecSet = null; 
            System.GC.Collect(); 
            
        } 
        
        private void LoadCardCodeComboVals( SAPbouiCOM.ComboBox oCombo ) { 
            SAPbobsCOM.Recordset RecSet = null; 
            string QryStr = null; 
            long RecCount = 0; 
            long RecIndex = 0; 
            
            RecSet = ( ( SAPbobsCOM.Recordset )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.BoRecordset ) ) ); 
            QryStr = "Select CardCode from OCRD where CardType = 'C'"; 
            RecSet.DoQuery( QryStr ); 
            RecCount = RecSet.RecordCount; 
            RecSet.MoveFirst(); 
            
            // Add the default value
            oCombo.ValidValues.Add( "0", "Select Client" ); 
            
            for ( RecIndex=0; RecIndex<=RecCount - 1; RecIndex++ ) { 
                oCombo.ValidValues.Add( RecIndex + 1, RecSet.Fields.Item( 0 ).Value ); 
                RecSet.MoveNext(); 
            } 
            
            oCombo.Select( "0", (SAPbouiCOM.BoSearchKey)(0) ); 
            
            RecSet = null; 
            System.GC.Collect(); 
            
        } 
        
        private void SBO_Application_AppEvent( SAPbouiCOM.BoAppEventTypes EventType ) { 
            //  Terminate our addon when the application shuts down
            if ( EventType == SAPbouiCOM.BoAppEventTypes.aet_ShutDown ) { 
                SBO_Application.MessageBox( "Vids Addon will now terminate", 1, "Ok", "", "" ); 
                System.Windows.Forms.Application.Exit(); 
            } 
        } 
        
        
        private string LoadFromXML( ref string FileName ) { 
            
            System.Xml.XmlDocument oXmlDoc = null; 
            string sPath = null; 
            
            oXmlDoc = new System.Xml.XmlDocument(); 
            
            // // load the content of the XML File
            
            sPath = System.Windows.Forms.Application.StartupPath; 
            sPath = sPath.Remove( sPath.Length - 3, 3 ); 
            
            oXmlDoc.Load( sPath + FileName ); 
            
            // // load the form to the SBO application in one batch
            return ( oXmlDoc.InnerXml ); 
            
        } 
        
        private void ShowMoviesByShelf() { 
            
            SAPbouiCOM.Matrix oMatrix = null; 
            SAPbouiCOM.Item oItem = null, ShelfItem = null, RentedItem = null; 
            SAPbouiCOM.Form oForm = null; 
            SAPbouiCOM.ComboBox cmbShelf = null, cmbRented = null; 
            int ShelfNum = 0; 
            string Rented = null; 
            
            oForm = SBO_Application.Forms.ActiveForm; 
            
            oItem = oForm.Items.Item( "mat" ); 
            oMatrix = ( ( SAPbouiCOM.Matrix )( oItem.Specific ) ); 
            ShelfItem = oForm.Items.Item( "cmb_shelfs" ); 
            cmbShelf = ( ( SAPbouiCOM.ComboBox )( ShelfItem.Specific ) ); 
            
            RentedItem = oForm.Items.Item( "cmb_rented" ); 
            cmbRented = ( ( SAPbouiCOM.ComboBox )( RentedItem.Specific ) ); 
            
            if ( Information.IsNothing( cmbRented.Selected ) ) { 
                Rented = "A"; 
            } 
            else { 
                switch ( cmbRented.Selected.Value ) {
                    case "Rented":
                        Rented = "Y"; 
                        break;
                    case "Available":
                        Rented = "N"; 
                        break;
                    case "All":
                        Rented = "A"; 
                        break;
                }
                
            } 
            
            // Fill the DB Datasource
            DBDSVids = oForm.DataSources.DBDataSources.Item( "@VIDS" ); 
            DBDSVids.Query( null ); 
            
            if ( Information.IsNumeric( cmbShelf.Selected.Value ) ) { //  Incase it's all
                ShelfNum = int.Parse( cmbShelf.Selected.Value ); 
            } 
            
            int i = 0; 
            
            i = 0; 
            while ( i < DBDSVids.Size ) { 
                if ( ( DBDSVids.GetValue( "U_SHELF", i ) != ( ShelfNum.ToString() ) & ( cmbShelf.Selected.Value != "All" ) ) ) { 
                    DBDSVids.RemoveRecord( i ); 
                    i = i - 1; 
                } 
                else if ( ( DBDSVids.GetValue( "U_RENTED", i ) != Rented ) & Rented != "A" ) { 
                    DBDSVids.RemoveRecord( i ); 
                    i = i - 1; 
                } 
                i = i + 1; 
            } 
            
            oMatrix.LoadFromDataSource(); 
        } 
        
        private void DoAddMovie() { 
            
            SAPbouiCOM.EditText oEdit = null; 
            SAPbouiCOM.Item oItemBP = null, oItem = null, ShelfItem = null, RentedItem = null; 
            SAPbouiCOM.Form oForm = null; 
            string strFind = null; 
            bool isFound = false; 
            
            isFound = false; 
            
            oForm = SBO_Application.Forms.ActiveForm; 
            
            oItem = oForm.Items.Item( "txtCode" ); 
            oEdit = ( ( SAPbouiCOM.EditText )( oItem.Specific ) ); 
            strFind = oEdit.String; 
            
            DBDSVids.Query( null ); 
            
            int i = 0; 
            if ( ( ( strFind != "" ) & ( strFind != null ) ) ) { 
                for ( i=0; i<=DBDSVids.Size - 1; i++ ) { 
                    if ( ( DBDSVids.GetValue( "Code", i ).Trim( char.Parse( " " ) ) == strFind ) ) { 
                        isFound = true; 
                        break; /* TRANSWARNING: check that break is in correct scope */ 
                    } 
                } 
                if ( !( isFound ) ) { 
                    int Shelf = 0, space = 0; 
                    string Name = null; 
                    // Name
                    oItem = oForm.Items.Item( "txtName" ); 
                    oEdit = ( ( SAPbouiCOM.EditText )( oItem.Specific ) ); 
                    Name = ( oEdit.String ); 
                    // Shelf
                    oItem = oForm.Items.Item( "txtShelf" ); 
                    oEdit = ( ( SAPbouiCOM.EditText )( oItem.Specific ) ); 
                    Shelf = int.Parse( oEdit.String ); 
                    // Space
                    oItem = oForm.Items.Item( "txtSpace" ); 
                    oEdit = ( ( SAPbouiCOM.EditText )( oItem.Specific ) ); 
                    space = int.Parse( oEdit.String ); 
                    
                    // Start DI code here
                    // Public oOrder As SAPbobsCOM.Documents ' Order object
                    if ( AddMovieToDatabase( strFind, Name, Shelf, space ) ) { 
                        SBO_Application.MessageBox( "Movie Added", 1, "Ok", "", "" ); 
                    } 
                    
                } 
                else { 
                    SBO_Application.MessageBox( "Movie with this code already exists", 1, "Ok", "", "" ); 
                } 
            } 
            else { 
                SBO_Application.MessageBox( "You must type the movie code", 1, "Ok", "", "" ); 
            } 
        } 
        
        private bool AddMovieToDatabase( string Code, string Name, int Shelf, int Space ) { 
            bool addMovieToDatabaseReturn = false;
            SAPbobsCOM.UserTable oUsrTbl = null; 
            int Res = 0; 
            
            addMovieToDatabaseReturn = false; 
            
            oUsrTbl = oCompany.UserTables.Item( "VIDS" ); 
            
            oUsrTbl.Code = System.Convert.ToString( int.Parse( Code ) ); 
            oUsrTbl.Name = Name; 
            oUsrTbl.UserFields.Fields.Item( "U_SHELF" ).Value = Shelf; 
            oUsrTbl.UserFields.Fields.Item( "U_SPACE" ).Value = Space; 
            Res = oUsrTbl.Add(); 
            
            
            if ( Res == 0 ) { 
                addMovieToDatabaseReturn = true; 
            } 
            else { 
                SBO_Application.MessageBox( "Error, failed to add movie", 1, "Ok", "", "" ); 
            } 
            return addMovieToDatabaseReturn;
        } 
        
        private void DoRentMovie() { 
            SAPbobsCOM.Recordset RecSet = null; 
            SAPbouiCOM.Form oForm = null; 
            SAPbouiCOM.ComboBox oMovieCombo = null; 
            SAPbouiCOM.ComboBox oCardCombo = null; 
            string MovieStr = null; 
            string CardStr = null; 
            string QryStr = null; 
            string QryAns = null; 
            
            RecSet = ( ( SAPbobsCOM.Recordset )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.BoRecordset ) ) ); 
            oForm = SBO_Application.Forms.ActiveForm; 
            oMovieCombo = ( ( SAPbouiCOM.ComboBox )( oForm.Items.Item( "CombCode" ).Specific ) ); 
            oCardCombo = ( ( SAPbouiCOM.ComboBox )( oForm.Items.Item( "CombCard" ).Specific ) ); 
            MovieStr = oMovieCombo.Selected.Value; 
            CardStr = oCardCombo.Selected.Description; 
            
            QryStr = "select U_RENTED from [@VIDS] where Code = '" + MovieStr + "'"; 
            RecSet.DoQuery( QryStr ); 
            QryAns = System.Convert.ToString( RecSet.Fields.Item( 0 ).Value ); 
            
            if ( ( QryAns == "Y" ) ) { 
                SBO_Application.MessageBox( "Movie already rented, Please choose a different one", 1, "Ok", "", "" ); 
            } 
            else { 
                QryStr = "update [@VIDS] set U_RENTED = 'Y', U_CARDCODE = '" + CardStr + "' where Code = '" + MovieStr + "'"; 
                RecSet.DoQuery( QryStr ); 
                SBO_Application.MessageBox( "Movie Rented Successfully", 1, "Ok", "", "" ); 
            } 
            oMovieCombo.Select( "0", (SAPbouiCOM.BoSearchKey)(0) ); 
            oCardCombo.Select( "0", (SAPbouiCOM.BoSearchKey)(0) ); 
        } 
        
        
        private void DoReturnMovie() { 
            SAPbobsCOM.Recordset RecSet = null; 
            SAPbouiCOM.Form oForm = null; 
            SAPbouiCOM.ComboBox oMovieCombo = null; 
            SAPbouiCOM.ComboBox oCardCombo = null; 
            string MovieStr = null; 
            string CardStr = null; 
            string QryStr = null; 
            string QryAns = null; 
            
            RecSet = ( ( SAPbobsCOM.Recordset )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.BoRecordset ) ) ); 
            oForm = SBO_Application.Forms.ActiveForm; 
            oMovieCombo = ( ( SAPbouiCOM.ComboBox )( oForm.Items.Item( "CombCode" ).Specific ) ); 
            MovieStr = oMovieCombo.Selected.Value; 
            
            QryStr = "select U_RENTED from [@VIDS] where Code = '" + MovieStr + "'"; 
            RecSet.DoQuery( QryStr ); 
            QryAns = System.Convert.ToString( RecSet.Fields.Item( 0 ).Value ); 
            
            if ( ( QryAns == "N" ) ) { 
                SBO_Application.MessageBox( "Movie isn't rented, Please choose a different one", 1, "Ok", "", "" ); 
            } 
            else { 
                QryStr = "update [@VIDS] set U_RENTED = 'N', U_CARDCODE = '' where Code = '" + MovieStr + "'"; 
                RecSet.DoQuery( QryStr ); 
                SBO_Application.MessageBox( "Movie Returned Successfully", 1, "Ok", "", "" ); 
            } 
            oMovieCombo.Select( "0", (SAPbouiCOM.BoSearchKey)(0) ); 
        } 
        
        
        private void SBO_Application_ItemEvent( string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent ) { 
            if ( pVal.BeforeAction == false ) { 
                switch ( FormUID ) {
                    case "vids_1":
                        if ( ( ( pVal.ItemUID == "cmb_shelfs" ) | ( pVal.ItemUID == "cmb_rented" ) ) & pVal.EventType == SAPbouiCOM.BoEventTypes.et_COMBO_SELECT ) { 
                            ShowMoviesByShelf(); 
                        } 
                        if ( ( ( pVal.ItemUID == "btnAdd" ) & ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED ) ) ) { 
                            SBO_Application.ActivateMenuItem( "SM_VID_F3" ); 
                        } 
                        break;
                    case "vids_2":
                        if ( ( ( pVal.ItemUID == "btnFind" ) & ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED ) ) ) { 
                            DoMovieFind(); 
                        } 
                        break;
                    case "vids_3":
                        if ( ( ( pVal.ItemUID == "btnAdd" ) & ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED ) ) ) { 
                            DoAddMovie(); 
                        } 
                        break;
                    case "vids_4":
                        if ( ( ( pVal.ItemUID == "btnRent" ) & ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED ) ) ) { 
                            DoRentMovie(); 
                        } 
                        if ( ( ( pVal.ItemUID == "btnRet" ) & ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED ) ) ) { 
                            DoReturnMovie(); 
                        } 
                        break;
                }
                
            } 
        } 
        
        private void DoMovieFind() { 
            
            SAPbouiCOM.EditText oEdit = null; 
            SAPbouiCOM.Item oItemBP = null, oItem = null, ShelfItem = null, RentedItem = null; 
            SAPbouiCOM.Form oForm = null; 
            string strFind = null; 
            bool isFound = false; 
            
            isFound = false; 
            
            oForm = SBO_Application.Forms.ActiveForm; 
            
            oItem = oForm.Items.Item( "txtCode" ); 
            oEdit = ( ( SAPbouiCOM.EditText )( oItem.Specific ) ); 
            strFind = oEdit.String; 
            
            DBDSVids.Query( null ); 
            
            int i = 0; 
            
            for ( i=0; i<=DBDSVids.Size - 1; i++ ) { 
                if ( ( DBDSVids.GetValue( "Code", i ).Trim( char.Parse( " " ) ) == strFind ) ) { 
                    isFound = true; 
                    oItem = oForm.Items.Item( "txtShelf" ); 
                    oEdit = ( ( SAPbouiCOM.EditText )( oItem.Specific ) ); 
                    oEdit.String = DBDSVids.GetValue( "U_Shelf", i ).Trim( char.Parse( " " ) ); 
                    oItem = oForm.Items.Item( "txtSpace" ); 
                    oEdit = ( ( SAPbouiCOM.EditText )( oItem.Specific ) ); 
                    oEdit.String = DBDSVids.GetValue( "U_Space", i ).Trim( char.Parse( " " ) ); 
                    
                    //  Adding the returned BP to the Combo Box
                    SAPbouiCOM.ComboBox oCombo = null; 
                    string BP = null; 
                    oItemBP = oForm.Items.Item( "BPLink" ); 
                    oCombo = ( ( SAPbouiCOM.ComboBox )( oItemBP.Specific ) ); 
                    BP = DBDSVids.GetValue( "U_CardCode", i ).Trim( char.Parse( " " ) ); 
                    oCombo.ValidValues.Add( BP, "" ); 
                    oCombo.Select( BP, (SAPbouiCOM.BoSearchKey)(0) ); 
                } 
            } 
            if ( !( isFound ) ) { 
                SBO_Application.MessageBox( "Movie Code " + strFind + " was not found", 1, "Ok", "", "" ); 
            } 
        } 
        
        private int SetConnectionContext() { 
            int setConnectionContextReturn = 0;
            
            string sCookie = null; 
            string sConnectionContext = null; 
            int lRetCode = 0; 
            
            // // First initialize the Company object
            
            oCompany = new SAPbobsCOM.Company(); 
            
            // // Acquire the connection context cookie from the DI API.
            sCookie = oCompany.GetContextCookie(); 
            
            // // Retrieve the connection context string from the UI API using the
            // // acquired cookie.
            sConnectionContext = SBO_Application.Company.GetConnectionContext( sCookie ); 
            
            // // before setting the SBO Login Context make sure the company is not
            // // connected
            
            if ( oCompany.Connected == true ) { 
                oCompany.Disconnect(); 
            } 
            
            // // Set the connection context information to the DI API.
            setConnectionContextReturn = oCompany.SetSboLoginContext( sConnectionContext ); 
            
            return setConnectionContextReturn;
        } 
        
    } 
    
    
} 
