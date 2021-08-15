using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace CreateUserTables {
    public class FrmMain : System.Windows.Forms.Form { 
        
        #region ' Windows Form Designer generated code ' 
        
        public FrmMain() : base() { 
            
            
            // This call is required by the Windows Form Designer.
            InitializeComponent(); 
            
            // Add any initialization after the InitializeComponent() call
            
        } 
        
        // Form overrides dispose to clean up the component list.
        protected override void Dispose( bool disposing ) { 
            if ( disposing ) { 
                if ( !( ( components == null ) ) ) { 
                    components.Dispose(); 
                } 
            } 
            base.Dispose( disposing ); 
        } 
        
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        internal System.Windows.Forms.Button btnConnect; 
        internal System.Windows.Forms.Button btnCreate; 
        internal System.Windows.Forms.Button btnAddFields; 
        internal System.Windows.Forms.GroupBox GroupBox1; 
        internal System.Windows.Forms.Button BtnExit; 
        internal System.Windows.Forms.Button CmdAddRecord; 
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() { 
            this.btnConnect = new System.Windows.Forms.Button(); 
            this.btnCreate = new System.Windows.Forms.Button(); 
            this.btnAddFields = new System.Windows.Forms.Button(); 
            this.GroupBox1 = new System.Windows.Forms.GroupBox(); 
            this.BtnExit = new System.Windows.Forms.Button(); 
            this.CmdAddRecord = new System.Windows.Forms.Button(); 
            this.GroupBox1.SuspendLayout(); 
            this.SuspendLayout(); 
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point( 24, 24 ); 
            this.btnConnect.Name = "btnConnect"; 
            this.btnConnect.Size = new System.Drawing.Size( 128, 32 ); 
            this.btnConnect.TabIndex = 0; 
            this.btnConnect.Text = "Connect to DB"; 
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point( 24, 64 ); 
            this.btnCreate.Name = "btnCreate"; 
            this.btnCreate.Size = new System.Drawing.Size( 128, 32 ); 
            this.btnCreate.TabIndex = 1; 
            this.btnCreate.Text = "Create User Table"; 
            // 
            // btnAddFields
            // 
            this.btnAddFields.Location = new System.Drawing.Point( 24, 104 ); 
            this.btnAddFields.Name = "btnAddFields"; 
            this.btnAddFields.Size = new System.Drawing.Size( 128, 32 ); 
            this.btnAddFields.TabIndex = 2; 
            this.btnAddFields.Text = "Add User Fields"; 
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add( this.CmdAddRecord ); 
            this.GroupBox1.Controls.Add( this.BtnExit ); 
            this.GroupBox1.Location = new System.Drawing.Point( 8, 0 ); 
            this.GroupBox1.Name = "GroupBox1"; 
            this.GroupBox1.Size = new System.Drawing.Size( 160, 232 ); 
            this.GroupBox1.TabIndex = 3; 
            this.GroupBox1.TabStop = false; 
            this.GroupBox1.Text = "Add MetaData"; 
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point( 16, 184 ); 
            this.BtnExit.Name = "BtnExit"; 
            this.BtnExit.Size = new System.Drawing.Size( 128, 32 ); 
            this.BtnExit.TabIndex = 0; 
            this.BtnExit.Text = "Exit"; 
            // 
            // CmdAddRecord
            // 
            this.CmdAddRecord.Location = new System.Drawing.Point( 16, 144 ); 
            this.CmdAddRecord.Name = "CmdAddRecord"; 
            this.CmdAddRecord.Size = new System.Drawing.Size( 128, 32 ); 
            this.CmdAddRecord.TabIndex = 1; 
            this.CmdAddRecord.Text = "Add Records"; 
            // 
            // FrmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 ); 
            this.ClientSize = new System.Drawing.Size( 176, 245 ); 
            this.Controls.Add( this.btnAddFields ); 
            this.Controls.Add( this.btnCreate ); 
            this.Controls.Add( this.btnConnect ); 
            this.Controls.Add( this.GroupBox1 ); 
            this.Name = "FrmMain"; 
            this.Text = "Video Rent - Create User Tables"; 
            this.GroupBox1.ResumeLayout( false ); 
            this.ResumeLayout( false ); 
            
            // events handled by btnConnect_Click
            btnConnect.Click += new System.EventHandler( btnConnect_Click ); 
            // events handled by btnCreate_Click
            btnCreate.Click += new System.EventHandler( btnCreate_Click ); 
            // events handled by btnAddFields_Click
            btnAddFields.Click += new System.EventHandler( btnAddFields_Click ); 
            // events handled by BtnExit_Click
            BtnExit.Click += new System.EventHandler( BtnExit_Click ); 
            // events handled by CmdAddRecord_Click
            CmdAddRecord.Click += new System.EventHandler( CmdAddRecord_Click ); 
        } 
        
        
        #endregion 
        public SAPbobsCOM.Company oCompany; 
        
        
        //  Error handling variables
        public string sErrMsg; 
        public long lErrCode; 
        public long lRetCode; 
        
        private void ConnectToCompany() { 
            
            //  Initialize the Company Object.
            //  Create a new company object
            oCompany = new SAPbobsCOM.Company(); 
            
            //  Set the mandatory properties for the connection to the database.
            //  To use a remote Db Server enter his name instead of the string "(local)"
            //  This string is used to work on a DB installed on your local machine
            
            oCompany.Server = "(local)"; 
            oCompany.CompanyDB = "SBODemo_US"; 
            oCompany.UserName = "manager"; 
            oCompany.Password = "manager"; 
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English; 
            oCompany.DbUserName = "sa"; 
            oCompany.DbPassword = ""; 
            
            oCompany.Connect(); 
            
            //  Check for errors during connect
            int transTemp6 = System.Convert.ToInt32( lErrCode ); 
            oCompany.GetLastError( out transTemp6, out sErrMsg ); 
            if ( lErrCode != 0 ) { 
                Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else { 
                Interaction.MsgBox( "Connection Established", MsgBoxStyle.Information, null ); 
            } 
            
        } 
        
        
        private void btnConnect_Click( System.Object sender, System.EventArgs e ) { 
            ConnectToCompany(); 
        } 
        
        
        private void btnCreate_Click( System.Object sender, System.EventArgs e ) { 
            
            //  User tables MetaData object
            SAPbobsCOM.UserTablesMD oUserTablesMD = null; 
            
            //  Init the MetaData object
            oUserTablesMD = ( ( SAPbobsCOM.UserTablesMD )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oUserTables ) ) ); 
            
            //  set the 2 mandatory fields
            oUserTablesMD.TableName = "VIDS"; 
            oUserTablesMD.TableDescription = "Video Managment"; 
            lRetCode = oUserTablesMD.Add(); 
            
            // check for errors in the process
            if ( lRetCode != 0 ) { 
                int transTemp5 = System.Convert.ToInt32( lErrCode ); 
                oCompany.GetLastError( out transTemp5, out sErrMsg ); 
                Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else { 
                Interaction.MsgBox( "Table: " + oUserTablesMD.TableName + " was added successfully", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            
        } 
        
        
        private void btnAddFields_Click( System.Object sender, System.EventArgs e ) { 
            //  A User Fields object
            SAPbobsCOM.UserFieldsMD oUserFieldsMD = null; 
            
            //  Remember to free occupied resources
            GC.Collect(); 
            
            //  Init the user fields object
            oUserFieldsMD = ( ( SAPbobsCOM.UserFieldsMD )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oUserFields ) ) ); 
            
            // ******************************
            //  Adding the "SHELF" field
            // ******************************
            //  Setting the Field's mandatory properties
            oUserFieldsMD.TableName = "@VIDS"; 
            oUserFieldsMD.Name = "SHELF"; 
            oUserFieldsMD.Description = "Shelf Number"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric; 
            oUserFieldsMD.EditSize = 2; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            
            // Check for errors
            if ( lRetCode != 0 ) { 
                int transTemp4 = System.Convert.ToInt32( lErrCode ); 
                oCompany.GetLastError( out transTemp4, out sErrMsg ); 
                Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else { 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            
            // ******************************
            //  Adding the "SPACE" field
            // ******************************
            //  Setting the Field's mandatory properties
            oUserFieldsMD.TableName = "@VIDS"; 
            oUserFieldsMD.Name = "SPACE"; 
            oUserFieldsMD.Description = "SPACE Number"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric; 
            oUserFieldsMD.EditSize = 3; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            
            // Check for errors
            if ( lRetCode != 0 ) { 
                int transTemp3 = System.Convert.ToInt32( lErrCode ); 
                oCompany.GetLastError( out transTemp3, out sErrMsg ); 
                Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else { 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            // ******************************
            //  Adding the "RENTED" field
            // ******************************
            //  Setting the Field's mandatory properties
            oUserFieldsMD.TableName = "@VIDS"; 
            oUserFieldsMD.Name = "RENTED"; 
            oUserFieldsMD.Description = "Rented/Available"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha; 
            oUserFieldsMD.EditSize = 1; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            
            // Check for errors
            if ( lRetCode != 0 ) { 
                int transTemp2 = System.Convert.ToInt32( lErrCode ); 
                oCompany.GetLastError( out transTemp2, out sErrMsg ); 
                Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else { 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            // ******************************
            //  Adding the "CARDCODE" field
            // ******************************
            //  Setting the Field's mandatory properties
            oUserFieldsMD.TableName = "@VIDS"; 
            oUserFieldsMD.Name = "CARDCODE"; 
            oUserFieldsMD.Description = "Card Code"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha; 
            oUserFieldsMD.EditSize = 15; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            
            // Check for errors
            if ( lRetCode != 0 ) { 
                int transTemp1 = System.Convert.ToInt32( lErrCode ); 
                oCompany.GetLastError( out transTemp1, out sErrMsg ); 
                Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else { 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
        } 
        
        
        private void BtnExit_Click( System.Object sender, System.EventArgs e ) { 
            oCompany.Disconnect(); 
            oCompany = null; 
            GC.Collect(); 
            System.Environment.Exit( 0 ); 
        } 
        
        
        private void CmdAddRecord_Click( System.Object sender, System.EventArgs e ) { 
            SAPbobsCOM.UserTable oUserTable = null; 
            
            // set the object with the requested table
            oUserTable = oCompany.UserTables.Item( "VIDS" ); 
            
            // set the two default fields 
            oUserTable.Code = System.Convert.ToString( 15 ); 
            oUserTable.Name = "Speed 1"; 
            
            // set the user fields
            // Shelf Number
            oUserTable.UserFields.Fields.Item( "U_SHELF" ).Value = 5; 
            // Space Number
            oUserTable.UserFields.Fields.Item( "U_SPACE" ).Value = 2; 
            // Rented
            oUserTable.UserFields.Fields.Item( "U_RENTED" ).Value = "Y"; 
            // CardCode
            oUserTable.UserFields.Fields.Item( "U_CARDCODE" ).Value = "C50003"; 
            
            // add the data to the Data base
            oUserTable.Add(); 
            
            // Check for errors
            int transTemp0 = System.Convert.ToInt32( lErrCode ); 
            oCompany.GetLastError( out transTemp0, out sErrMsg ); 
            if ( lErrCode != 0 ) { 
                Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else { 
                Interaction.MsgBox( "Record saved in DB successfuly", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            
            oUserTable = null; 
            System.GC.Collect(); 
            
        } 
        
        [STAThread]
        public static void Main() { Application.Run( new FrmMain() ); }
    } 
    
    
} 
