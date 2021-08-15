//  SAP MANAGE UIDI API 2007 SDK Sample
//**************************************************************************************************
//
//  File:      AddColumn.cs
//
//  Copyright (c) SAP MANAGE
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// BEFORE STARTING:
// 1. Add reference to the "SAP Business One UI API"
// 2. Add reference to the "SAP Business One Objects Bridge VERSION 2007"
// 3. Insert the development connection string to the "Command Line Argument"
//-----------------------------------------------------------------
// 1.
//    a. Project->References
//    b. check the "SAP Business One UI API Version 2007" check box
//    c. check the "SAP Business One DI API Version 2007" check box
//
// 2.
//     a. Project->Properties
//     b. choose 'Make' tab folder
//     c. place the following connection string in the 'Command Line Arguments' field
// 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
//
//**************************************************************************************************
// 
// This sample requires some user preperations:
//     1) Create a user table called 'SER' with the following fields:
//          - ItemCode - Alphanumeric(20)
//          - SupSer   - Alphanumeric(32)
//          - MyInfo   - Alphanumeric(10)
//     2) Create a user table called 'SERVAR' with the following field:
//          - CurrKey  - Alphanumeric(30)
//     3) Add a record to the 'SERVAR' table with the following values:
//          - Code = 1
//          - Name = CurrKey
//          - CurrKey = 1
//**************************************************************************************************

using System;
using System.Windows.Forms;
namespace Project1 {
    internal class AddColumn  { 
        
        private SAPbobsCOM.Company oCompany; 
        private SAPbouiCOM.Application SBO_Application; 
        
        // '''''''''''''''''
        //  Connect to SBO '
        // '''''''''''''''''
        private void SetApplication() { 
            SAPbouiCOM.SboGuiApi SboGuiApi = null; 
            string sConnectionString = null; 
            
            SboGuiApi = new SAPbouiCOM.SboGuiApi(); 
            
            sConnectionString = System.Convert.ToString( Environment.GetCommandLineArgs().GetValue( 1 ) ); 
            SboGuiApi.Connect( sConnectionString ); 
            SBO_Application = SboGuiApi.GetApplication( -1 ); 
            
        } 
        
        
        // '''''''''''''''''''''''''''''''''
        //  Connect with connection string '
        // '''''''''''''''''''''''''''''''''
        private int SetConnectionContext() { 
            int setConnectionContextReturn = 0;
            
            string sCookie = null; 
            string sConnectionContext = null; 
            int lRetCode = 0; 
            
            oCompany = new SAPbobsCOM.Company(); 
            
            sCookie = oCompany.GetContextCookie(); 
            sConnectionContext = SBO_Application.Company.GetConnectionContext( sCookie ); 
            
            if ( oCompany.Connected == true ) { 
                oCompany.Disconnect(); 
            } 
            setConnectionContextReturn = oCompany.SetSboLoginContext( sConnectionContext ); 
            
            return setConnectionContextReturn;
        } 
        
        
        // '''''''''''''''''
        //  Connect to SBO '
        // '''''''''''''''''
        private int ConnectToCompany() { 
            int connectToCompanyReturn = 0;
            
            // Establish the connection to the company database.
            connectToCompanyReturn = oCompany.Connect(); 
            
            return connectToCompanyReturn;
        } 
        
        
        // '''''''''''''''''
        //  Init the Class '
        // '''''''''''''''''
        public AddColumn() : base() { 
            
            SetApplication(); 
            if ( !( SetConnectionContext() == 0 ) ) { 
                SBO_Application.MessageBox( "Failed setting a connection to DI API", 1, "Ok", "", "" ); 
                System.Environment.Exit( 0 ); //  Terminating the Add-On Application
            } 
            if ( !( ConnectToCompany() == 0 ) ) { 
                SBO_Application.MessageBox( "Failed connecting to the company's Data Base", 1, "Ok", "", "" ); 
                Application.Exit(); //  Terminating the Add-On Application
            } 
            
            SBO_Application.MessageBox( "DI Connected To: " + oCompany.CompanyName, 1, "Ok", "", "" ); 
            // events handled by SBO_Application_ItemEvent
			bool tmpB = false;

			SBO_Application.ItemEvent += new SAPbouiCOM._IApplicationEvents_ItemEventEventHandler( SBO_Application_ItemEvent ); 
 
        } 
        
        // '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //  This function loads data from the database to the form '
        // '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public string LoadUserFieldToMatrix( SAPbouiCOM.Form f, string SuppSerial ) { 
            string loadUserFieldToMatrixReturn = null;
            SAPbobsCOM.Recordset oRecordset = null; 
            int RowNum = 0; 
            SAPbouiCOM.EditText ItemCode = null; 
            SAPbouiCOM.Matrix oMatrix = null; 
            SAPbouiCOM.Item oItem = null; 
            string sSQL = null; 
            
            oItem = f.Items.Item( "43" ); //  The Matrix, is item #43 as viewed in debug information
            oMatrix = ( ( SAPbouiCOM.Matrix )( oItem.Specific ) ); 
            RowNum = oMatrix.GetNextSelectedRow( 0, (SAPbouiCOM.BoOrderType)(0) ); 
            ItemCode = ( ( SAPbouiCOM.EditText )( oMatrix.Columns.Item( 5 ).Cells.Item( RowNum ).Specific ) ); //  Column #5 is the Item Code
            
            try { 
                // Query the database
                oRecordset = ( ( SAPbobsCOM.Recordset )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.BoRecordset ) ) ); 
                
                sSQL = "SELECT     U_MyInfo, U_ItemCode, U_SupSer " + "FROM         dbo.[@SER] " + "WHERE     (U_ItemCode = N'" + ItemCode.Value + "') AND (U_SupSer = N'" + SuppSerial + "')"; 
                
                oRecordset.DoQuery( sSQL ); 
                oRecordset.MoveFirst(); 
                loadUserFieldToMatrixReturn = System.Convert.ToString( oRecordset.Fields.Item( "U_MyInfo" ).Value ); 
            } 
            catch ( Exception oEx ) { 
                loadUserFieldToMatrixReturn = ""; 
                SBO_Application.MessageBox( "The Select Failed: " + oEx.Message, 1, "Ok", "", "" ); 
            } 
            
            return loadUserFieldToMatrixReturn;
        } 
        
        
        // ''''''''''''''''''''''''''''''''''''
        //  Update a record in the table @SER '
        // ''''''''''''''''''''''''''''''''''''
        public void UpdateDBWithUserField( string ItemCode, string SuppSerial, string UserField ) { 
            SAPbobsCOM.UserTable UT = null, UTKey = null; 
            SAPbobsCOM.UserTables UTS = null; 
            string sSQL = null; 
            SAPbobsCOM.Recordset oRecordset = null; 
            
            try { 
                oRecordset = ( ( SAPbobsCOM.Recordset )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.BoRecordset ) ) ); 
                
                sSQL = "SELECT     Code, U_ItemCode, U_SupSer " + "FROM         dbo.[@SER] " + "WHERE     (U_ItemCode = N'" + ItemCode + "') AND (U_SupSer = N'" + SuppSerial + "')"; 
                
                oRecordset.DoQuery( sSQL ); 
                //  Check if a record exists with this [ItemCode] and [SuppSerial] 
                if ( oRecordset.RecordCount > 0 ) { 
                    oRecordset.MoveFirst(); 
                    sSQL = System.Convert.ToString( oRecordset.Fields.Item( "Code" ).Value ); 
                    
                    UTS = oCompany.UserTables; 
                    UT = UTS.Item( "SER" ); 
                    UT.GetByKey( sSQL ); 
                    UT.UserFields.Fields.Item( "U_MyInfo" ).Value = UserField; 
                    UT.Update(); 
                } 
                else { 
                    //  Get The Last Key and Increase it
                    UTS = oCompany.UserTables; 
                    UTKey = UTS.Item( "SERVAR" ); 
                    UTKey.GetByKey( "1" ); 
                    string CurKey = null; 
                    CurKey = System.Convert.ToString( UTKey.UserFields.Fields.Item( "U_CurrKey" ).Value ); 
                    CurKey = System.Convert.ToString( int.Parse( CurKey ) + 1 ); 
                    UTKey.UserFields.Fields.Item( "U_CurrKey" ).Value = CurKey; 
                    UTKey.Update(); 
                    
                    UT = UTS.Item( "SER" ); 
                    
                    UT.Code = CurKey; 
                    UT.Name = CurKey; 
                    
                    // Insert a new record to the table
                    UT.UserFields.Fields.Item( "U_ItemCode" ).Value = ItemCode; 
                    UT.UserFields.Fields.Item( "U_SupSer" ).Value = SuppSerial; 
                    UT.UserFields.Fields.Item( "U_MyInfo" ).Value = UserField; 
                    
                    UT.Add(); 
                    UT.Update(); 
                } 
                
            } 
            catch ( Exception oEx ) { 
                SBO_Application.MessageBox( "The Select Failed: " + oEx.Message, 1, "Ok", "", "" ); 
            } 
        } 
        
        
        // '''''''''''''''''''''
        //  Handle Item Events '
        // '''''''''''''''''''''
		private void SBO_Application_ItemEvent( string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent ) {
			BubbleEvent = true;
			// If pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD Then
            //     SBO_Application.MessageBox("load")
            // End If
            SAPbouiCOM.Form oForm = null; 
            SAPbouiCOM.Matrix oMatrix = null; 
            SAPbouiCOM.Item oItem = null; 
            SAPbouiCOM.Column oColumn = null; 
            SAPbobsCOM.Recordset oRecordset = null; 
            SAPbouiCOM.EditText oEditText = null; 
            SAPbouiCOM.ComboBox MyCell = null; 
            // Dim ColNum = oMatrix.Columns.Count
            // Dim RowNum = oMatrix.RowCount
            
            oForm = SBO_Application.Forms.Item( FormUID ); 
            
            //  If the Upper Matrix was pressed we load the lower matrix with the correct records.
            if ( ( oForm.TypeEx == "65270" ) ) { 
                if ( ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED & pVal.ItemUID == "43" ) ) { 
                    int SelRow = 0; 
                    
                    //  Get the Lower Matrix
                    oItem = oForm.Items.Item( "3" ); 
                    oMatrix = ( ( SAPbouiCOM.Matrix )( oItem.Specific ) ); 
                    
                    int j = 0; 
                    
                    object ColNum = oMatrix.Columns.Count; 
                    object RowNum = oMatrix.RowCount; 
                    
                    //  Load date to matrix from the database
                    oForm.Freeze( true ); 
                    for ( j=1; j<=System.Convert.ToInt32( RowNum ); j++ ) { 
                        try { 
                            oEditText = ( ( SAPbouiCOM.EditText )( oMatrix.Columns.Item( 1 ).Cells.Item( j ).Specific ) ); 
                            object ItemCode = oEditText.Value; 
                            MyCell = ( ( SAPbouiCOM.ComboBox )( oMatrix.Columns.Item( 17 ).Cells.Item( j ).Specific ) ); 
                            MyCell.Select( LoadUserFieldToMatrix( oForm, oEditText.Value ), (SAPbouiCOM.BoSearchKey)(0) ); 
                        } 
                        catch ( Exception oEx ) { 
                            oForm.Freeze( false ); 
                            oForm.Update(); 
                            MessageBox.Show( oEx.Message + " j = " + System.Convert.ToString( j ) ); 
                        } 
                    } 
                    oForm.Freeze( false ); 
                    oForm.Update(); 
                } 
                
                if ( ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED & pVal.ItemUID == "1" ) ) { 
                    
                    if ( oForm.Mode == SAPbouiCOM.BoFormMode.fm_UPDATE_MODE ) { 
                        int i = 0, j = 0; 
                        object[,] mm = new object[ 2, 2 ]; 
                        
                        oItem = oForm.Items.Item( "43" ); 
                        oMatrix = ( ( SAPbouiCOM.Matrix )( oItem.Specific ) ); 
                        
                        object ColNum = oMatrix.Columns.Count; 
                        object RowNum = oMatrix.RowCount; 
                        
                        ColNum = oMatrix.Columns.Count; 
                        RowNum = oMatrix.RowCount; 
                        mm = new object[ 10, (int)RowNum ]; 
                        
                        i = oMatrix.GetNextSelectedRow( 0, (SAPbouiCOM.BoOrderType)(0) ); 
                        
                        oEditText = ( ( SAPbouiCOM.EditText )( oMatrix.Columns.Item( 5 ).Cells.Item( i ).Specific ) ); 
                        
                        object ItemCode = oEditText.Value; 
                        
                        try { 
                            oRecordset = ( ( SAPbobsCOM.Recordset )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.BoRecordset ) ) ); 
                            oRecordset.DoQuery( "SELECT * from OSRI WHERE ItemCode = '" + oEditText.Value + "'" ); 
                        } 
                        catch ( Exception oEx ) { 
                            SBO_Application.MessageBox( "The Select Failed: " + oEx.Message, 1, "Ok", "", "" ); 
                        } 
                        
                        //  Get the Lower Matrix
                        oItem = oForm.Items.Item( "3" ); 
                        oMatrix = ( ( SAPbouiCOM.Matrix )( oItem.Specific ) ); 
                        
                        ColNum = oMatrix.Columns.Count; 
                        RowNum = oMatrix.RowCount; 
                        
                        for ( j=1; j<=System.Convert.ToInt32( RowNum ); j++ ) { 
                            try { 
                                oEditText = ( ( SAPbouiCOM.EditText )( oMatrix.Columns.Item( 1 ).Cells.Item( j ).Specific ) ); 
                                MyCell = ( ( SAPbouiCOM.ComboBox )( oMatrix.Columns.Item( 17 ).Cells.Item( j ).Specific ) ); 
                                
                                if ( ( oEditText.Value != null ) & ( oEditText.Value != "" ) ) { 
                                    UpdateDBWithUserField( System.Convert.ToString( ItemCode ), oEditText.Value, MyCell.Selected.Value ); 
                                } 
                                else { 
                                    MessageBox.Show( "Nothing was in the cell" ); 
                                } 
                            } 
                            catch ( Exception oEx ) { 
                                MessageBox.Show( oEx.Message + " col i = " + System.Convert.ToString( i ) + " row j = " + System.Convert.ToString( j ) ); 
                            } 
                        } 
                    } 
                } 
                
                //  Catch the Load event of Serial numbers managment form 
                if ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_FORM_LOAD ) { 
                    oForm = SBO_Application.Forms.Item( FormUID ); 
                    oItem = oForm.Items.Item( 2 ); 
                    oMatrix = ( ( SAPbouiCOM.Matrix )( oItem.Specific ) ); 
                    
                    int i = 0, j = 0; 
                    object[,] MyMatrix = new object[ 2, 2 ]; 
                    
                    object ColNum = oMatrix.Columns.Count; 
                    object RowNum = oMatrix.RowCount; 
                    
                    ColNum = oMatrix.Columns.Count; 
                    RowNum = oMatrix.RowCount; 
                    //  **************************************************************************************
                    //  YOU CAN SAVE THE DATA IN THE MATRIX BEFORE IT IS CLEARED BY REMOVING THE REMARKED CODE
                    
                    // ReDim MyMatrix(10, RowNum)
                    
                    // For i = 0 To 9
                    //     For j = 0 To RowNum - 1
                    //         Try
                    //             oEditText = oMatrix.Columns.Item(i + 1).Cells.Item(j + 1).Specific
                    //             If (oEditText.Value <> Nothing) And (oEditText.Value <> "") Then
                    //                 MyMatrix(i, j) = oEditText.Value
                    //             End If
                    //         Catch oEx As Exception
                    //             MessageBox.Show(oEx.Message & " col i = " & CStr(i) & " row j = " & CStr(j))
                    //         End Try
                    //     Next j
                    // Next i
                    //  **************************************************************************************
                    
                    oMatrix.Clear(); 
                    
                    oColumn = oMatrix.Columns.Add( "MyCol", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX ); 
                    oColumn.TitleObject.Caption = "My Info"; 
                    oColumn.Width = 70; 
                    oColumn.Visible = true; 
                    oColumn.ValidValues.Add( "a", "" ); 
                    oColumn.ValidValues.Add( "b", "" ); 
                    oColumn.ValidValues.Add( "c", "" ); 
                    
                    try { 
                        oForm.DataSources.DBDataSources.Add( "@SER" ); 
                        oColumn.DataBind.SetBound( true, "@SER", "U_MyInfo" ); 
                    } 
                    catch ( Exception oEx ) { 
                        MessageBox.Show( oEx.Message ); 
                    } 
                } 
            } 
        } 
        
    } 
    
} 
