using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace addUDO
{
    public class frmUDO : System.Windows.Forms.Form 
    { 
        #region '" Windows Form Designer generated code "' 
        public frmUDO() : base() 
        { 
            
            // This call is required by the Windows Form Designer.
            InitializeComponent(); 
            // Add any initialization after the InitializeComponent() call
        } 
        // Form overrides dispose to clean up the component list.
        protected override void Dispose( bool disposing ) 
        { 
            if ( disposing ) 
            { 
                if ( !( ( components == null ) ) ) 
                { 
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
        internal  System.Windows.Forms.GroupBox grpConnection; 
        internal  System.Windows.Forms.Label lblCompany; 
        internal  System.Windows.Forms.TextBox txtServer; 
        internal  System.Windows.Forms.ComboBox cmbCompany; 
        internal  System.Windows.Forms.Button btnGetCompanyList; 
        internal  System.Windows.Forms.TextBox txtPass; 
        internal  System.Windows.Forms.TextBox txtUser; 
        internal  System.Windows.Forms.Label lblPass; 
        internal  System.Windows.Forms.Label lblUser; 
        internal  System.Windows.Forms.Label Label1; 
        internal  System.Windows.Forms.Button btnConnect; 
        internal  System.Windows.Forms.GroupBox grpUDO; 
        internal  System.Windows.Forms.CheckedListBox chkUDOAfter; 
        internal  System.Windows.Forms.Button btnAdd; 
        internal  System.Windows.Forms.Button btnAddFields; 
        internal  System.Windows.Forms.Button btnAddUDO; 
        internal  System.Windows.Forms.Label Label2; 
        public  System.Windows.Forms.ComboBox cmbDBType; 
        internal  System.Windows.Forms.Label Label3; 
        internal  System.Windows.Forms.Label Label4; 
        internal  System.Windows.Forms.Label Label5; 
        internal  System.Windows.Forms.TextBox txtName; 
        internal  System.Windows.Forms.TextBox txtPrice; 
        internal  System.Windows.Forms.TextBox txtRoom; 
        internal  System.Windows.Forms.Button cmdAddRecord; 
        internal  System.Windows.Forms.TextBox txtCode; 
        internal  System.Windows.Forms.Label Label6; 
        internal  System.Windows.Forms.Button cmdUpdateRecord; 
        internal  System.Windows.Forms.Button cmdDeleteRecord; 
        internal  System.Windows.Forms.Button cmdGetRecord; 
        internal  System.Windows.Forms.ListBox lstMainDish; 
        internal  System.Windows.Forms.ListBox lstSideDish; 
        internal  System.Windows.Forms.ListBox lstDrink; 
        internal  System.Windows.Forms.TextBox txtMaindish; 
        internal  System.Windows.Forms.Label Label7; 
        internal  System.Windows.Forms.Label Label8; 
        internal  System.Windows.Forms.TextBox txtSideDish; 
        internal  System.Windows.Forms.Label Label9; 
        internal  System.Windows.Forms.TextBox txtDrink; 
        internal  System.Windows.Forms.Label Label10; 
        internal  System.Windows.Forms.Button cmdAddchild; 
        internal  System.Windows.Forms.Button cmdRemovechild; 
        internal  System.Windows.Forms.Label Label11; 
        internal  System.Windows.Forms.TextBox txtSBOPass; 
        internal  System.Windows.Forms.TextBox txtSBOUser; 
        internal  System.Windows.Forms.Label Label13; 
        internal  System.Windows.Forms.Label Label14; 
        internal  System.Windows.Forms.GroupBox grpRecords; 
        internal  System.Windows.Forms.GroupBox grpChild; 
        internal  System.Windows.Forms.TextBox TextBox1; 
        internal  System.Windows.Forms.TextBox TextBox2; 
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        { 
            this.grpConnection = new System.Windows.Forms.GroupBox(); 
            this.txtSBOPass = new System.Windows.Forms.TextBox(); 
            this.txtSBOUser = new System.Windows.Forms.TextBox(); 
            this.Label13 = new System.Windows.Forms.Label(); 
            this.Label14 = new System.Windows.Forms.Label(); 
            this.cmbDBType = new System.Windows.Forms.ComboBox(); 
            this.Label2 = new System.Windows.Forms.Label(); 
            this.lblCompany = new System.Windows.Forms.Label(); 
            this.txtServer = new System.Windows.Forms.TextBox(); 
            this.cmbCompany = new System.Windows.Forms.ComboBox(); 
            this.btnGetCompanyList = new System.Windows.Forms.Button(); 
            this.txtPass = new System.Windows.Forms.TextBox(); 
            this.txtUser = new System.Windows.Forms.TextBox(); 
            this.lblPass = new System.Windows.Forms.Label(); 
            this.lblUser = new System.Windows.Forms.Label(); 
            this.Label1 = new System.Windows.Forms.Label(); 
            this.btnConnect = new System.Windows.Forms.Button(); 
            this.grpUDO = new System.Windows.Forms.GroupBox(); 
            this.btnAddUDO = new System.Windows.Forms.Button(); 
            this.btnAddFields = new System.Windows.Forms.Button(); 
            this.chkUDOAfter = new System.Windows.Forms.CheckedListBox(); 
            this.btnAdd = new System.Windows.Forms.Button(); 
            this.grpRecords = new System.Windows.Forms.GroupBox(); 
            this.grpChild = new System.Windows.Forms.GroupBox(); 
            this.txtMaindish = new System.Windows.Forms.TextBox(); 
            this.Label7 = new System.Windows.Forms.Label(); 
            this.Label9 = new System.Windows.Forms.Label(); 
            this.Label8 = new System.Windows.Forms.Label(); 
            this.txtDrink = new System.Windows.Forms.TextBox(); 
            this.txtSideDish = new System.Windows.Forms.TextBox(); 
            this.cmdAddchild = new System.Windows.Forms.Button(); 
            this.cmdRemovechild = new System.Windows.Forms.Button(); 
            this.lstMainDish = new System.Windows.Forms.ListBox(); 
            this.Label10 = new System.Windows.Forms.Label(); 
            this.lstDrink = new System.Windows.Forms.ListBox(); 
            this.lstSideDish = new System.Windows.Forms.ListBox(); 
            this.Label11 = new System.Windows.Forms.Label(); 
            this.cmdGetRecord = new System.Windows.Forms.Button(); 
            this.cmdDeleteRecord = new System.Windows.Forms.Button(); 
            this.cmdUpdateRecord = new System.Windows.Forms.Button(); 
            this.txtCode = new System.Windows.Forms.TextBox(); 
            this.Label6 = new System.Windows.Forms.Label(); 
            this.cmdAddRecord = new System.Windows.Forms.Button(); 
            this.txtRoom = new System.Windows.Forms.TextBox(); 
            this.txtPrice = new System.Windows.Forms.TextBox(); 
            this.txtName = new System.Windows.Forms.TextBox(); 
            this.Label5 = new System.Windows.Forms.Label(); 
            this.Label4 = new System.Windows.Forms.Label(); 
            this.Label3 = new System.Windows.Forms.Label(); 
            this.TextBox2 = new System.Windows.Forms.TextBox(); 
            this.TextBox1 = new System.Windows.Forms.TextBox(); 
            this.grpConnection.SuspendLayout(); 
            this.grpUDO.SuspendLayout(); 
            this.grpRecords.SuspendLayout(); 
            this.grpChild.SuspendLayout(); 
            this.SuspendLayout(); 
            // grpConnection
            this.grpConnection.Controls.Add( this.txtSBOPass ); 
            this.grpConnection.Controls.Add( this.txtSBOUser ); 
            this.grpConnection.Controls.Add( this.Label13 ); 
            this.grpConnection.Controls.Add( this.Label14 ); 
            this.grpConnection.Controls.Add( this.cmbDBType ); 
            this.grpConnection.Controls.Add( this.Label2 ); 
            this.grpConnection.Controls.Add( this.lblCompany ); 
            this.grpConnection.Controls.Add( this.txtServer ); 
            this.grpConnection.Controls.Add( this.cmbCompany ); 
            this.grpConnection.Controls.Add( this.btnGetCompanyList ); 
            this.grpConnection.Controls.Add( this.txtPass ); 
            this.grpConnection.Controls.Add( this.txtUser ); 
            this.grpConnection.Controls.Add( this.lblPass ); 
            this.grpConnection.Controls.Add( this.lblUser ); 
            this.grpConnection.Controls.Add( this.Label1 ); 
            this.grpConnection.Controls.Add( this.btnConnect ); 
            this.grpConnection.Location = new System.Drawing.Point( 8, 8 ); 
            this.grpConnection.Name = "grpConnection"; 
            this.grpConnection.Size = new System.Drawing.Size( 624, 112 ); 
            this.grpConnection.TabIndex = 18; 
            this.grpConnection.TabStop = false; 
            this.grpConnection.Text = "Connection"; 
            // txtSBOPass
            this.txtSBOPass.Location = new System.Drawing.Point( 464, 72 ); 
            this.txtSBOPass.Name = "txtSBOPass"; 
            this.txtSBOPass.PasswordChar = Microsoft.VisualBasic.Strings.ChrW( 42 ); 
            this.txtSBOPass.Size = new System.Drawing.Size( 64, 20 ); 
            this.txtSBOPass.TabIndex = 33; 
            this.txtSBOPass.Text = ""; 
            // txtSBOUser
            this.txtSBOUser.Location = new System.Drawing.Point( 464, 48 ); 
            this.txtSBOUser.Name = "txtSBOUser"; 
            this.txtSBOUser.Size = new System.Drawing.Size( 64, 20 ); 
            this.txtSBOUser.TabIndex = 31; 
            this.txtSBOUser.Text = "manager"; 
            // Label13
            this.Label13.Location = new System.Drawing.Point( 376, 72 ); 
            this.Label13.Name = "Label13"; 
            this.Label13.Size = new System.Drawing.Size( 88, 16 ); 
            this.Label13.TabIndex = 34; 
            this.Label13.Text = "SBO Password"; 
            // Label14
            this.Label14.Location = new System.Drawing.Point( 376, 48 ); 
            this.Label14.Name = "Label14"; 
            this.Label14.Size = new System.Drawing.Size( 88, 16 ); 
            this.Label14.TabIndex = 32; 
            this.Label14.Text = "SBO Username"; 
            // cmbDBType
            this.cmbDBType.BackColor = System.Drawing.SystemColors.Window; 
            this.cmbDBType.Cursor = System.Windows.Forms.Cursors.Default; 
            this.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; 
            this.cmbDBType.Font = new System.Drawing.Font( "Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte( 0 ) ); 
            this.cmbDBType.ForeColor = System.Drawing.SystemColors.WindowText; 
            this.cmbDBType.Items.AddRange( new object[] { "MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB" } ); 
            this.cmbDBType.Location = new System.Drawing.Point( 112, 16 ); 
            this.cmbDBType.Name = "cmbDBType"; 
            this.cmbDBType.RightToLeft = System.Windows.Forms.RightToLeft.No; 
            this.cmbDBType.Size = new System.Drawing.Size( 137, 22 ); 
            this.cmbDBType.TabIndex = 30; 
            // Label2
            this.Label2.Location = new System.Drawing.Point( 16, 24 ); 
            this.Label2.Name = "Label2"; 
            this.Label2.Size = new System.Drawing.Size( 96, 16 ); 
            this.Label2.TabIndex = 28; 
            this.Label2.Text = "Database Type"; 
            // lblCompany
            this.lblCompany.Location = new System.Drawing.Point( 216, 80 ); 
            this.lblCompany.Name = "lblCompany"; 
            this.lblCompany.Size = new System.Drawing.Size( 56, 16 ); 
            this.lblCompany.TabIndex = 27; 
            this.lblCompany.Text = "Company"; 
            // txtServer
            this.txtServer.Location = new System.Drawing.Point( 360, 16 ); 
            this.txtServer.Name = "txtServer"; 
            this.txtServer.TabIndex = 18; 
            this.txtServer.Text = "(local)"; 
            // cmbCompany
            this.cmbCompany.Location = new System.Drawing.Point( 272, 80 ); 
            this.cmbCompany.Name = "cmbCompany"; 
            this.cmbCompany.Size = new System.Drawing.Size( 96, 21 ); 
            this.cmbCompany.TabIndex = 21; 
            this.cmbCompany.Text = "SBODemo_US"; 
            // btnGetCompanyList
            this.btnGetCompanyList.Location = new System.Drawing.Point( 216, 48 ); 
            this.btnGetCompanyList.Name = "btnGetCompanyList"; 
            this.btnGetCompanyList.Size = new System.Drawing.Size( 112, 23 ); 
            this.btnGetCompanyList.TabIndex = 19; 
            this.btnGetCompanyList.Text = "Get Company List"; 
            // txtPass
            this.txtPass.Location = new System.Drawing.Point( 136, 80 ); 
            this.txtPass.Name = "txtPass"; 
            this.txtPass.PasswordChar = Microsoft.VisualBasic.Strings.ChrW( 42 ); 
            this.txtPass.Size = new System.Drawing.Size( 72, 20 ); 
            this.txtPass.TabIndex = 24; 
            this.txtPass.Text = ""; 
            // txtUser
            this.txtUser.Location = new System.Drawing.Point( 136, 48 ); 
            this.txtUser.Name = "txtUser"; 
            this.txtUser.Size = new System.Drawing.Size( 72, 20 ); 
            this.txtUser.TabIndex = 22; 
            this.txtUser.Text = "sa"; 
            // lblPass
            this.lblPass.Location = new System.Drawing.Point( 16, 80 ); 
            this.lblPass.Name = "lblPass"; 
            this.lblPass.Size = new System.Drawing.Size( 112, 16 ); 
            this.lblPass.TabIndex = 26; 
            this.lblPass.Text = "Database Password"; 
            // lblUser
            this.lblUser.Location = new System.Drawing.Point( 16, 48 ); 
            this.lblUser.Name = "lblUser"; 
            this.lblUser.Size = new System.Drawing.Size( 112, 16 ); 
            this.lblUser.TabIndex = 23; 
            this.lblUser.Text = "Database Username"; 
            // Label1
            this.Label1.Location = new System.Drawing.Point( 264, 16 ); 
            this.Label1.Name = "Label1"; 
            this.Label1.Size = new System.Drawing.Size( 112, 16 ); 
            this.Label1.TabIndex = 20; 
            this.Label1.Text = "Database Server"; 
            // btnConnect
            this.btnConnect.Location = new System.Drawing.Point( 536, 72 ); 
            this.btnConnect.Name = "btnConnect"; 
            this.btnConnect.TabIndex = 25; 
            this.btnConnect.Text = "Connect"; 
            // grpUDO
            this.grpUDO.Controls.Add( this.btnAddUDO ); 
            this.grpUDO.Controls.Add( this.btnAddFields ); 
            this.grpUDO.Controls.Add( this.chkUDOAfter ); 
            this.grpUDO.Controls.Add( this.btnAdd ); 
            this.grpUDO.Enabled = false; 
            this.grpUDO.Location = new System.Drawing.Point( 8, 128 ); 
            this.grpUDO.Name = "grpUDO"; 
            this.grpUDO.Size = new System.Drawing.Size( 280, 184 ); 
            this.grpUDO.TabIndex = 22; 
            this.grpUDO.TabStop = false; 
            this.grpUDO.Text = "Part 1: User-Defined Tables, Fields and Objects"; 
            // btnAddUDO
            this.btnAddUDO.Location = new System.Drawing.Point( 24, 112 ); 
            this.btnAddUDO.Name = "btnAddUDO"; 
            this.btnAddUDO.Size = new System.Drawing.Size( 80, 23 ); 
            this.btnAddUDO.TabIndex = 6; 
            this.btnAddUDO.Text = "Add UDO"; 
            // btnAddFields
            this.btnAddFields.Location = new System.Drawing.Point( 24, 72 ); 
            this.btnAddFields.Name = "btnAddFields"; 
            this.btnAddFields.Size = new System.Drawing.Size( 80, 23 ); 
            this.btnAddFields.TabIndex = 4; 
            this.btnAddFields.Text = "Add Fields"; 
            // chkUDOAfter
            this.chkUDOAfter.Items.AddRange( new object[] { "SM_OMOR table", "... Name Field", "... Room Field", "... Price Field", "SM_MOR1 Table", "... MainDish Field", "... SideDish Field", "... Drink Field", "SM_MOR Object" } ); 
            this.chkUDOAfter.Location = new System.Drawing.Point( 120, 32 ); 
            this.chkUDOAfter.Name = "chkUDOAfter"; 
            this.chkUDOAfter.Size = new System.Drawing.Size( 136, 139 ); 
            this.chkUDOAfter.TabIndex = 2; 
            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point( 24, 32 ); 
            this.btnAdd.Name = "btnAdd"; 
            this.btnAdd.Size = new System.Drawing.Size( 80, 23 ); 
            this.btnAdd.TabIndex = 0; 
            this.btnAdd.Text = "Add Tables"; 
            // grpRecords
            this.grpRecords.Controls.Add( this.grpChild ); 
            this.grpRecords.Controls.Add( this.cmdGetRecord ); 
            this.grpRecords.Controls.Add( this.cmdDeleteRecord ); 
            this.grpRecords.Controls.Add( this.cmdUpdateRecord ); 
            this.grpRecords.Controls.Add( this.txtCode ); 
            this.grpRecords.Controls.Add( this.Label6 ); 
            this.grpRecords.Controls.Add( this.cmdAddRecord ); 
            this.grpRecords.Controls.Add( this.txtRoom ); 
            this.grpRecords.Controls.Add( this.txtPrice ); 
            this.grpRecords.Controls.Add( this.txtName ); 
            this.grpRecords.Controls.Add( this.Label5 ); 
            this.grpRecords.Controls.Add( this.Label4 ); 
            this.grpRecords.Controls.Add( this.Label3 ); 
            this.grpRecords.Controls.Add( this.TextBox2 ); 
            this.grpRecords.Enabled = false; 
            this.grpRecords.Location = new System.Drawing.Point( 8, 320 ); 
            this.grpRecords.Name = "grpRecords"; 
            this.grpRecords.Size = new System.Drawing.Size( 648, 312 ); 
            this.grpRecords.TabIndex = 31; 
            this.grpRecords.TabStop = false; 
            this.grpRecords.Text = "Part 2: UDO Records"; 
            // grpChild
            this.grpChild.Controls.Add( this.txtMaindish ); 
            this.grpChild.Controls.Add( this.Label7 ); 
            this.grpChild.Controls.Add( this.Label9 ); 
            this.grpChild.Controls.Add( this.Label8 ); 
            this.grpChild.Controls.Add( this.txtDrink ); 
            this.grpChild.Controls.Add( this.txtSideDish ); 
            this.grpChild.Controls.Add( this.cmdAddchild ); 
            this.grpChild.Controls.Add( this.cmdRemovechild ); 
            this.grpChild.Controls.Add( this.lstMainDish ); 
            this.grpChild.Controls.Add( this.Label10 ); 
            this.grpChild.Controls.Add( this.lstDrink ); 
            this.grpChild.Controls.Add( this.lstSideDish ); 
            this.grpChild.Controls.Add( this.Label11 ); 
            this.grpChild.Location = new System.Drawing.Point( 8, 72 ); 
            this.grpChild.Name = "grpChild"; 
            this.grpChild.Size = new System.Drawing.Size( 328, 232 ); 
            this.grpChild.TabIndex = 53; 
            this.grpChild.TabStop = false; 
            this.grpChild.Text = "Child Records"; 
            // txtMaindish
            this.txtMaindish.Location = new System.Drawing.Point( 64, 24 ); 
            this.txtMaindish.Name = "txtMaindish"; 
            this.txtMaindish.Size = new System.Drawing.Size( 88, 20 ); 
            this.txtMaindish.TabIndex = 42; 
            this.txtMaindish.Text = ""; 
            // Label7
            this.Label7.Location = new System.Drawing.Point( 8, 24 ); 
            this.Label7.Name = "Label7"; 
            this.Label7.Size = new System.Drawing.Size( 56, 23 ); 
            this.Label7.TabIndex = 43; 
            this.Label7.Text = "Main Dish"; 
            // Label9
            this.Label9.Location = new System.Drawing.Point( 8, 48 ); 
            this.Label9.Name = "Label9"; 
            this.Label9.Size = new System.Drawing.Size( 56, 23 ); 
            this.Label9.TabIndex = 47; 
            this.Label9.Text = "Drink"; 
            // Label8
            this.Label8.Location = new System.Drawing.Point( 160, 24 ); 
            this.Label8.Name = "Label8"; 
            this.Label8.Size = new System.Drawing.Size( 56, 23 ); 
            this.Label8.TabIndex = 45; 
            this.Label8.Text = "Side Dish"; 
            // txtDrink
            this.txtDrink.Location = new System.Drawing.Point( 64, 48 ); 
            this.txtDrink.Name = "txtDrink"; 
            this.txtDrink.Size = new System.Drawing.Size( 88, 20 ); 
            this.txtDrink.TabIndex = 46; 
            this.txtDrink.Text = ""; 
            // txtSideDish
            this.txtSideDish.Location = new System.Drawing.Point( 216, 24 ); 
            this.txtSideDish.Name = "txtSideDish"; 
            this.txtSideDish.Size = new System.Drawing.Size( 88, 20 ); 
            this.txtSideDish.TabIndex = 44; 
            this.txtSideDish.Text = ""; 
            // cmdAddchild
            this.cmdAddchild.Location = new System.Drawing.Point( 160, 48 ); 
            this.cmdAddchild.Name = "cmdAddchild"; 
            this.cmdAddchild.Size = new System.Drawing.Size( 64, 23 ); 
            this.cmdAddchild.TabIndex = 49; 
            this.cmdAddchild.Text = "Add Child"; 
            // cmdRemovechild
            this.cmdRemovechild.Location = new System.Drawing.Point( 232, 48 ); 
            this.cmdRemovechild.Name = "cmdRemovechild"; 
            this.cmdRemovechild.Size = new System.Drawing.Size( 88, 23 ); 
            this.cmdRemovechild.TabIndex = 50; 
            this.cmdRemovechild.Text = "Remove Child"; 
            // lstMainDish
            this.lstMainDish.Enabled = false; 
            this.lstMainDish.Location = new System.Drawing.Point( 8, 96 ); 
            this.lstMainDish.Name = "lstMainDish"; 
            this.lstMainDish.Size = new System.Drawing.Size( 72, 82 ); 
            this.lstMainDish.TabIndex = 39; 
            // Label10
            this.Label10.Location = new System.Drawing.Point( 8, 72 ); 
            this.Label10.Name = "Label10"; 
            this.Label10.Size = new System.Drawing.Size( 224, 16 ); 
            this.Label10.TabIndex = 48; 
            this.Label10.Text = "Main Dish           Side Dish           Drink"; 
            // lstDrink
            this.lstDrink.Enabled = false; 
            this.lstDrink.Location = new System.Drawing.Point( 168, 96 ); 
            this.lstDrink.Name = "lstDrink"; 
            this.lstDrink.Size = new System.Drawing.Size( 72, 82 ); 
            this.lstDrink.TabIndex = 41; 
            // lstSideDish
            this.lstSideDish.Enabled = false; 
            this.lstSideDish.Location = new System.Drawing.Point( 88, 96 ); 
            this.lstSideDish.Name = "lstSideDish"; 
            this.lstSideDish.Size = new System.Drawing.Size( 72, 82 ); 
            this.lstSideDish.TabIndex = 40; 
            // Label11
            this.Label11.Location = new System.Drawing.Point( 8, 184 ); 
            this.Label11.Name = "Label11"; 
            this.Label11.Size = new System.Drawing.Size( 248, 40 ); 
            this.Label11.TabIndex = 51; 
            this.Label11.Text = "The Add/Remove Child buttons affects the data locally; the data is only relevant " + "when adding or getting a UDO record."; 
            // cmdGetRecord
            this.cmdGetRecord.Location = new System.Drawing.Point( 440, 48 ); 
            this.cmdGetRecord.Name = "cmdGetRecord"; 
            this.cmdGetRecord.Size = new System.Drawing.Size( 96, 23 ); 
            this.cmdGetRecord.TabIndex = 38; 
            this.cmdGetRecord.Text = "Get Record"; 
            // cmdDeleteRecord
            this.cmdDeleteRecord.Location = new System.Drawing.Point( 440, 16 ); 
            this.cmdDeleteRecord.Name = "cmdDeleteRecord"; 
            this.cmdDeleteRecord.Size = new System.Drawing.Size( 96, 23 ); 
            this.cmdDeleteRecord.TabIndex = 37; 
            this.cmdDeleteRecord.Text = "Delete Record"; 
            // cmdUpdateRecord
            this.cmdUpdateRecord.Location = new System.Drawing.Point( 336, 48 ); 
            this.cmdUpdateRecord.Name = "cmdUpdateRecord"; 
            this.cmdUpdateRecord.Size = new System.Drawing.Size( 96, 23 ); 
            this.cmdUpdateRecord.TabIndex = 36; 
            this.cmdUpdateRecord.Text = "UpdateRecord"; 
            // txtCode
            this.txtCode.Location = new System.Drawing.Point( 64, 24 ); 
            this.txtCode.Name = "txtCode"; 
            this.txtCode.TabIndex = 35; 
            this.txtCode.Text = ""; 
            // Label6
            this.Label6.Location = new System.Drawing.Point( 16, 24 ); 
            this.Label6.Name = "Label6"; 
            this.Label6.Size = new System.Drawing.Size( 48, 23 ); 
            this.Label6.TabIndex = 34; 
            this.Label6.Text = "Code"; 
            // cmdAddRecord
            this.cmdAddRecord.Location = new System.Drawing.Point( 336, 16 ); 
            this.cmdAddRecord.Name = "cmdAddRecord"; 
            this.cmdAddRecord.Size = new System.Drawing.Size( 96, 23 ); 
            this.cmdAddRecord.TabIndex = 33; 
            this.cmdAddRecord.Text = "Add Record"; 
            // txtRoom
            this.txtRoom.Location = new System.Drawing.Point( 64, 48 ); 
            this.txtRoom.Name = "txtRoom"; 
            this.txtRoom.TabIndex = 5; 
            this.txtRoom.Text = ""; 
            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point( 224, 48 ); 
            this.txtPrice.Name = "txtPrice"; 
            this.txtPrice.TabIndex = 4; 
            this.txtPrice.Text = ""; 
            // txtName
            this.txtName.Location = new System.Drawing.Point( 224, 24 ); 
            this.txtName.Name = "txtName"; 
            this.txtName.TabIndex = 3; 
            this.txtName.Text = ""; 
            // Label5
            this.Label5.Location = new System.Drawing.Point( 176, 48 ); 
            this.Label5.Name = "Label5"; 
            this.Label5.Size = new System.Drawing.Size( 48, 23 ); 
            this.Label5.TabIndex = 2; 
            this.Label5.Text = "Price"; 
            // Label4
            this.Label4.Location = new System.Drawing.Point( 16, 48 ); 
            this.Label4.Name = "Label4"; 
            this.Label4.Size = new System.Drawing.Size( 48, 23 ); 
            this.Label4.TabIndex = 1; 
            this.Label4.Text = "Room"; 
            // Label3
            this.Label3.Location = new System.Drawing.Point( 176, 24 ); 
            this.Label3.Name = "Label3"; 
            this.Label3.Size = new System.Drawing.Size( 48, 23 ); 
            this.Label3.TabIndex = 0; 
            this.Label3.Text = "Name"; 
            // TextBox2
            this.TextBox2.Enabled = false; 
            this.TextBox2.Location = new System.Drawing.Point( 344, 80 ); 
            this.TextBox2.Multiline = true; 
            this.TextBox2.Name = "TextBox2"; 
            this.TextBox2.ReadOnly = true; 
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; 
            this.TextBox2.Size = new System.Drawing.Size( 296, 224 ); 
            this.TextBox2.TabIndex = 58; 
            this.TextBox2.Text = "In order to add a new UDO record:" + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "1. Fill the name, room and price fields." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "2. A" + "dd child records." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + " A. Fill Main Dish, Side Dish and Drink values." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.
            Strings.ChrW( 10 ) + @" B. Press ""A" + @"dd Child"" button." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + " C. Repeat A and B for every child record you want to add." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "3" + @". Press ""Add Record"" button." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 
            10 ) + "In order to update a UDO record:" + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "1. Fill the Co" + "de for the record you want to update." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "2. Fill the new values of name, room and " + "price." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + @"3. Press ""Update Record"" button."; 
            // TextBox1
            this.TextBox1.Enabled = false; 
            this.TextBox1.Location = new System.Drawing.Point( 296, 136 ); 
            this.TextBox1.Multiline = true; 
            this.TextBox1.Name = "TextBox1"; 
            this.TextBox1.ReadOnly = true; 
            this.TextBox1.Size = new System.Drawing.Size( 336, 176 ); 
            this.TextBox1.TabIndex = 54; 
            this.TextBox1.Text = "This sample is divided into 2 parts:" + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "Part 1, " + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "This part shows how to add user t" + "ables and fields, and register new User-Defined Objects." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "There are 3 buttons th" + "at show each of these actions." + Microsoft.
            VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "Part 2," + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "This part shows how to add/get/update" + "/delete records of User-Defined Objects." + Microsoft.VisualBasic.Strings.ChrW( 13 ) + Microsoft.VisualBasic.Strings.ChrW( 10 ) + "It uses the object that is registered " + "in Part 1 and allows you to manipulate records of this UDO."; 
            
            // frmUDO
            this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 ); 
            this.ClientSize = new System.Drawing.Size( 664, 645 ); 
            this.Controls.Add( this.grpRecords ); 
            this.Controls.Add( this.grpUDO ); 
            this.Controls.Add( this.grpConnection ); 
            this.Controls.Add( this.TextBox1 ); 
            this.Name = "frmUDO"; 
            this.Text = "UDO registration"; 
            this.grpConnection.ResumeLayout( false ); 
            this.grpUDO.ResumeLayout( false ); 
            this.grpRecords.ResumeLayout( false ); 
            this.grpChild.ResumeLayout( false ); 
            this.ResumeLayout( false ); 
            
            // events handled by frmUDO_Load             
            base.Load += new System.EventHandler( frmUDO_Load ); 
            // events handled by btnGetCompanyList_Click             
            btnGetCompanyList.Click += new System.EventHandler( btnGetCompanyList_Click ); 
            // events handled by btnConnect_Click             
            btnConnect.Click += new System.EventHandler( btnConnect_Click ); 
            // events handled by btnAdd_Click             
            btnAdd.Click += new System.EventHandler( btnAdd_Click ); 
            // events handled by btnAddFields_Click             
            btnAddFields.Click += new System.EventHandler( btnAddFields_Click ); 
            // events handled by btnAddUDO_Click             
            btnAddUDO.Click += new System.EventHandler( btnAddUDO_Click ); 
            // events handled by cmdAddRecord_Click             
            cmdAddRecord.Click += new System.EventHandler( cmdAddRecord_Click ); 
            // events handled by cmdUpdateRecord_Click             
            cmdUpdateRecord.Click += new System.EventHandler( cmdUpdateRecord_Click ); 
            // events handled by cmdGetRecord_Click             
            cmdGetRecord.Click += new System.EventHandler( cmdGetRecord_Click ); 
            // events handled by cmdDeleteRecord_Click             
            cmdDeleteRecord.Click += new System.EventHandler( cmdDeleteRecord_Click ); 
            // events handled by cmdAddchild_Click             
            cmdAddchild.Click += new System.EventHandler( cmdAddchild_Click ); 
            // events handled by cmdRemovechild_Click             
            cmdRemovechild.Click += new System.EventHandler( cmdRemovechild_Click ); 
        } 
        
        
        #endregion 
        public SAPbobsCOM.Company oCompany; 
        //  Error handling variables
        public string sErrMsg; 
        public int lErrCode; 
        public int lRetCode; 
        private void frmUDO_Load( System.Object sender, System.EventArgs e ) 
        { 
            cmbDBType.Text = "MSSQL2005"; 
            oCompany = new SAPbobsCOM.Company(); 

			// once the Server property of the Company is set
			// we may query for a list of companies to choos from
			// this method returns a Recordset object

            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English; 
        } 
        
        private void btnGetCompanyList_Click( System.Object sender, System.EventArgs e ) 
        { 
            SAPbobsCOM.Recordset oRecordSet = null; 
            try 
            { 
                oCompany.UseTrusted = false; 
                oCompany.Server = txtServer.Text; 
                oCompany.DbUserName = txtUser.Text; 
                oCompany.DbPassword = txtPass.Text; 
                oCompany.DbServerType = ( ( SAPbobsCOM.BoDataServerTypes )( cmbDBType.SelectedIndex + 1 ) ); 
                oRecordSet = oCompany.GetCompanyList(); 
                // Use GetLastError method directly after a function
                // which doesn't have a return code
                // you may also use the On Error GoTo.
                // functions with no return codes throws exceptions
                oCompany.GetLastError( out lErrCode, out sErrMsg ); 
                if ( lErrCode != 0 ) 
                { 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
                else 
                { 
                    // Load the available company DB names to the combo box
                    // the returned Recordset containds 4 fields:
                    // dbName - represents the database name
                    // cmpName - represents the company name
                    // versStr - represents the version number of the company database
                    // dbUser - represents the database owner
                    // we are interested in the first filed (mandatory property)
                    // Go through the Recordset and extract the dbname
                    cmbCompany.Items.Clear(); 
                    while (  ! ( oRecordSet.EoF == true ) ) 
                    { 
                        // add the value of the first field of the Recordset
                        cmbCompany.Items.Add( oRecordSet.Fields.Item( 0 ).Value ); 
                        // move the record pointer to the next row
                        oRecordSet.MoveNext(); 
                    } 
                    if ( cmbCompany.Items.Count > 0 ) 
                    { 
                        cmbCompany.SelectedIndex = 0; 
                    } 
                } 
            } 
            catch ( Exception ex ) 
            { 
                Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
        } 
        
        private  SAPbouiCOM.Application SBO_Application; 
        private void btnConnect_Click( System.Object sender, System.EventArgs e ) 
        { 
            //  Set the connection parameters
            oCompany.Server = txtServer.Text; 
            oCompany.CompanyDB = cmbCompany.Text; 
            oCompany.UserName = txtSBOUser.Text; 
            oCompany.Password = txtSBOPass.Text; 
            oCompany.DbServerType = ( ( SAPbobsCOM.BoDataServerTypes )( cmbDBType.SelectedIndex + 1 ) ); 
            lRetCode = oCompany.Connect(); 
            if ( lRetCode != 0 ) 
            { 
                oCompany.GetLastError( out lErrCode, out sErrMsg ); 
                Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else 
            { 
                grpConnection.Enabled = false; 
                grpUDO.Enabled = true; 
                grpRecords.Enabled = true; 
                Interaction.MsgBox( "Connected to " + oCompany.CompanyName, MsgBoxStyle.Information, "Now Connected" ); 
            } 
            
        } 
        
        private void AddUserTable( string Name, string Description, SAPbobsCOM.BoUTBTableType Type ) 
        { 
            //****************************************************************************
            // The UserTablesMD represents a meta-data object which allows us
            // to add\remove tables, change a table name etc.
            //****************************************************************************
            SAPbobsCOM.UserTablesMD oUserTablesMD = null; 
            //****************************************************************************
            // In any meta-data operation there should be no other object "alive"
            // but the meta-data object, otherwise the operation will fail.
            // This restriction is intended to prevent a collisions
            //****************************************************************************
            // the meta-data object needs to be initialized with a
            // regular UserTables object
            oUserTablesMD = ( ( SAPbobsCOM.UserTablesMD )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oUserTables ) ) ); 
            //**************************************************
            // when adding user tables or fields to the SBO DB
            // use a prefix identifying your partner name space
            // this will prevent collisions between different
            // partners add-ons
            // SAP's name space prefix is "BE_"
            //**************************************************		
            // set the table parameters
            oUserTablesMD.TableName = Name; 
            oUserTablesMD.TableDescription = Description; 
            oUserTablesMD.TableType = Type; 
            // Add the table
            // This action add an empty table with 2 default fields
            // 'Code' and 'Name' which serve as the key
            // in order to add your own User Fields
            // see the AddUserFields.frm in this project
            // a privat, user defined, key may be added
            // see AddPrivateKey.frm in this project
            lRetCode = oUserTablesMD.Add(); 
            // check for errors in the process
            if ( lRetCode != 0 ) 
            { 
                if ( lRetCode == -1 ) 
                { 
                } 
                else 
                { 
                    oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
            } 
            else 
            { 
                Interaction.MsgBox( "Table: " + oUserTablesMD.TableName + " was added successfully", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            oUserTablesMD = null; 
            GC.Collect(); // Release the handle to the table
        } 
        
        private void btnAdd_Click( System.Object sender, System.EventArgs e ) 
        { 
            AddUserTable( "SM_OMOR", "Meal Order", SAPbobsCOM.BoUTBTableType.bott_Document ); 
            chkUDOAfter.SetItemChecked( 0, true ); 
            AddUserTable( "SM_MOR1", "Meal Lines", SAPbobsCOM.BoUTBTableType.bott_DocumentLines ); 
            chkUDOAfter.SetItemChecked( 4, true ); 
        } 
        
        private object Add_SM_OMOR_Fields() 
        { 
            SAPbobsCOM.UserFieldsMD oUserFieldsMD = null; 
            oUserFieldsMD = ( ( SAPbobsCOM.UserFieldsMD )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oUserFields ) ) ); 
            // ************************************
            //  Adding "Name" field
            // ************************************
            // Setting the Field's properties
            oUserFieldsMD.TableName = "@SM_OMOR"; 
            oUserFieldsMD.Name = "Name"; 
            oUserFieldsMD.Description = "Name"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha; 
            oUserFieldsMD.EditSize = 20; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            // Check for errors
            if ( lRetCode != 0 ) 
            { 
                if ( lRetCode == -1 ) 
                { 
                    chkUDOAfter.SetItemChecked( 1, true ); 
                } 
                else 
                { 
                    oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
            } 
            else 
            { 
                chkUDOAfter.SetItemChecked( 1, true ); 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            // ************************************
            //  Adding "Room" field
            // ************************************
            // Setting the Field's properties
            oUserFieldsMD.TableName = "@SM_OMOR"; 
            oUserFieldsMD.Name = "Room"; 
            oUserFieldsMD.Description = "Room"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha; 
            oUserFieldsMD.EditSize = 20; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            // Check for errors
            if ( lRetCode != 0 ) 
            { 
                if ( lRetCode == -1 ) 
                { 
                    chkUDOAfter.SetItemChecked( 2, true ); 
                } 
                else 
                { 
                    oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
            } 
            else 
            { 
                chkUDOAfter.SetItemChecked( 2, true ); 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            // ************************************
            //  Adding "Price" field
            // ************************************
            // Setting the Field's properties
            oUserFieldsMD.TableName = "@SM_OMOR"; 
            oUserFieldsMD.Name = "Price"; 
            oUserFieldsMD.Description = "Price"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha; 
            oUserFieldsMD.EditSize = 20; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            // Check for errors
            if ( lRetCode != 0 ) 
            { 
                if ( lRetCode == -1 ) 
                { 
                    chkUDOAfter.SetItemChecked( 3, true ); 
                } 
                else 
                { 
                    oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
            } 
            else 
            { 
                chkUDOAfter.SetItemChecked( 3, true ); 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            GC.Collect(); // Release the handle to the User Fields
            return null;
        } 
        
        private object Add_SM_MOR1_Fields() 
        { 
            SAPbobsCOM.UserFieldsMD oUserFieldsMD = null; 
            oUserFieldsMD = ( ( SAPbobsCOM.UserFieldsMD )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oUserFields ) ) ); 
            // ************************************
            //  Adding "Main Dish" field
            // ************************************
            // Setting the Field's properties
            oUserFieldsMD.TableName = "@SM_MOR1"; 
            oUserFieldsMD.Name = "MainDish"; 
            oUserFieldsMD.Description = "Main Dish"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha; 
            oUserFieldsMD.EditSize = 20; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            // Check for errors
            if ( lRetCode != 0 ) 
            { 
                if ( lRetCode == -1 ) 
                { 
                    chkUDOAfter.SetItemChecked( 5, true ); 
                } 
                else 
                { 
                    oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
            } 
            else 
            { 
                chkUDOAfter.SetItemChecked( 5, true ); 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            // ************************************
            //  Adding "SideDish" field
            // ************************************
            // Setting the Field's properties
            oUserFieldsMD.TableName = "@SM_MOR1"; 
            oUserFieldsMD.Name = "SideDish"; 
            oUserFieldsMD.Description = "Side Dish"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha; 
            oUserFieldsMD.EditSize = 20; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            // Check for errors
            if ( lRetCode != 0 ) 
            { 
                if ( lRetCode == -1 ) 
                { 
                    chkUDOAfter.SetItemChecked( 6, true ); 
                } 
                else 
                { 
                    oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
            } 
            else 
            { 
                chkUDOAfter.SetItemChecked( 6, true ); 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            // ************************************
            //  Adding "Drink" field
            // ************************************
            // Setting the Field's properties
            oUserFieldsMD.TableName = "@SM_MOR1"; 
            oUserFieldsMD.Name = "Drink"; 
            oUserFieldsMD.Description = "Drink"; 
            oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha; 
            oUserFieldsMD.EditSize = 20; 
            // Adding the Field to the Table
            lRetCode = oUserFieldsMD.Add(); 
            // Check for errors
            if ( lRetCode != 0 ) 
            { 
                if ( lRetCode == -1 ) 
                { 
                    chkUDOAfter.SetItemChecked( 7, true ); 
                } 
                else 
                { 
                    oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
            } 
            else 
            { 
                chkUDOAfter.SetItemChecked( 7, true ); 
                Interaction.MsgBox( "Field: '" + oUserFieldsMD.Name + "' was added successfuly to " + oUserFieldsMD.TableName + " Table", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            GC.Collect(); // Release the handle to the User Fields
            return null;
        } 
        
        private bool TableExist( string TableName ) 
        { 
            SAPbobsCOM.UserTablesMD oUserTablesMD = null; 
            bool boolIdent = false; 
            oUserTablesMD = ( ( SAPbobsCOM.UserTablesMD )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oUserTables ) ) ); 
            boolIdent = oUserTablesMD.GetByKey( TableName ); 
            return ( boolIdent ); 
        } 
        
        private void btnAddFields_Click( System.Object sender, System.EventArgs e ) 
        { 
            Add_SM_OMOR_Fields(); 
            Add_SM_MOR1_Fields(); 
        } 
        
        private void AddUDO() 
        { 
            SAPbobsCOM.UserObjectsMD oUserObjectMD = null; 
            oUserObjectMD = ( ( SAPbobsCOM.UserObjectsMD )( oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oUserObjectsMD ) ) ); 
            oUserObjectMD.CanCancel = SAPbobsCOM.BoYesNoEnum.tYES; 
            oUserObjectMD.CanClose = SAPbobsCOM.BoYesNoEnum.tYES; 
            oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tNO; 
            oUserObjectMD.CanDelete = SAPbobsCOM.BoYesNoEnum.tYES; 
            oUserObjectMD.CanFind = SAPbobsCOM.BoYesNoEnum.tYES; 
            oUserObjectMD.CanYearTransfer = SAPbobsCOM.BoYesNoEnum.tYES; 
            oUserObjectMD.ChildTables.TableName = "SM_MOR1"; 
            oUserObjectMD.Code = "SM_MOR"; 
            oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tYES; 
            oUserObjectMD.Name = "SM_Meal_Order"; 
            oUserObjectMD.ObjectType = SAPbobsCOM.BoUDOObjType.boud_Document; 
            oUserObjectMD.TableName = "SM_OMOR"; 
            lRetCode = oUserObjectMD.Add(); 
            // check for errors in the process
            if ( lRetCode != 0 ) 
            { 
                if ( lRetCode == -1 ) 
                { 
                    chkUDOAfter.SetItemChecked( 8, true ); 
                } 
                else 
                { 
                    oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                    Interaction.MsgBox( sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                } 
            } 
            else 
            { 
                Interaction.MsgBox( "UDO: " + oUserObjectMD.Name + " was added successfully", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                chkUDOAfter.SetItemChecked( 8, true ); 
            } 
            oUserObjectMD = null; 
            GC.Collect(); // Release the handle to the table
        } 
        
        public void AddUDORecord() 
        { 
            SAPbobsCOM.GeneralService oGeneralService = null; 
            SAPbobsCOM.GeneralData oGeneralData = null; 
            SAPbobsCOM.GeneralData oChild = null; 
            SAPbobsCOM.GeneralDataCollection oChildren = null; 
            SAPbobsCOM.GeneralDataParams oGeneralParams = null; 
            SAPbobsCOM.CompanyService oCompanyService = null; 
            try 
            { 
                oCompanyService = oCompany.GetCompanyService(); 
                // Get GeneralService (oCmpSrv is the CompanyService)
                oGeneralService = oCompanyService.GetGeneralService( "SM_MOR" ); 
                // Create data for new row in main UDO
                oGeneralData = ( ( SAPbobsCOM.GeneralData )( oGeneralService.GetDataInterface( SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData ) ) ); 
                oGeneralData.SetProperty( "U_Name", txtName.Text ); 
                oGeneralData.SetProperty( "U_Room", txtRoom.Text ); 
                oGeneralData.SetProperty( "U_Price", txtPrice.Text ); 
                //  Handle child rows
                oChildren = oGeneralData.Child( "SM_MOR1" ); 
                int i = 0; 
                for ( i=1; i <= lstMainDish.Items.Count; i++ ) 
                { 
                    // Create data for rows in the child table
                    oChild = oChildren.Add(); 
                    oChild.SetProperty( "U_MainDish", lstMainDish.Items[ i - 1 ] ); 
                    oChild.SetProperty( "U_SideDish", lstSideDish.Items[ i - 1 ] ); 
                    oChild.SetProperty( "U_Drink", lstDrink.Items[ i - 1 ] ); 
                } 
                // Add the new row, including children, to database
                oGeneralParams = oGeneralService.Add( oGeneralData ); 
                txtCode.Text = System.Convert.ToString( oGeneralParams.GetProperty( "DocEntry" ) ); 
                Interaction.MsgBox( "Record added", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            catch ( Exception ex ) 
            { 
                Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
        } 
        
        public void GetUDORecord() 
        { 
            SAPbobsCOM.GeneralService oGeneralService = null; 
            SAPbobsCOM.GeneralData oGeneralData = null; 
            SAPbobsCOM.GeneralData oChild = null; 
            SAPbobsCOM.GeneralDataCollection oChildren = null; 
            SAPbobsCOM.GeneralDataParams oGeneralParams = null; 
            SAPbobsCOM.CompanyService oCompanyService = null; 
            oCompanyService = oCompany.GetCompanyService(); 
            try 
            { 
                // Get GeneralService (oCmpSrv is the CompanyService)
                oGeneralService = oCompanyService.GetGeneralService( "SM_MOR" ); 
                oGeneralParams = ( ( SAPbobsCOM.GeneralDataParams )( oGeneralService.GetDataInterface( SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams ) ) ); 
                oGeneralParams.SetProperty( "DocEntry", txtCode.Text ); 
                oGeneralData = oGeneralService.GetByParams( oGeneralParams ); 
                // Create data for a row in the child table
                oChildren = oGeneralData.Child( "SM_MOR1" ); 
                // Empty child record lists
                lstMainDish.Items.Clear(); 
                lstSideDish.Items.Clear(); 
                lstDrink.Items.Clear(); 
                //  Handle child rows
                oChildren = oGeneralData.Child( "SM_MOR1" ); 
                int i = 0; 
                Interaction.MsgBox( "going to add sons: " + oChildren.Count.ToString(), (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                for ( i=1; i <= oChildren.Count; i++ ) 
                { 
                    oChild = oChildren.Item( i - 1 ); 
                    lstMainDish.Items.Add( oChild.GetProperty( "U_MainDish" ) ); 
                    lstSideDish.Items.Add( oChild.GetProperty( "U_SideDish" ) ); 
                    lstDrink.Items.Add( oChild.GetProperty( "U_Drink" ) ); 
                } 
                // Add the new row, including children, to database
                txtName.Text = System.Convert.ToString( oGeneralData.GetProperty( "U_Name" ) ); 
                txtRoom.Text = System.Convert.ToString( oGeneralData.GetProperty( "U_Room" ) ); 
                txtPrice.Text = System.Convert.ToString( oGeneralData.GetProperty( "U_Price" ) ); 
            } 
            catch ( Exception ex ) 
            { 
                Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            Interaction.MsgBox( "Record loaded", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
        } 
        
        public void UpdateUDORecord() 
        { 
            SAPbobsCOM.GeneralService oGeneralService = null; 
            SAPbobsCOM.GeneralData oGeneralData = null; 
            SAPbobsCOM.GeneralDataParams oGeneralParams = null; 
            SAPbobsCOM.CompanyService sCmp = null; 
            sCmp = oCompany.GetCompanyService(); 
            //  This function updates only parent record.
            //  Child records remain as is.
            try 
            { 
                // Get a handle to the SM_MOR UDO
                oGeneralService = sCmp.GetGeneralService( "SM_MOR" ); 
                // Get UDO record
                oGeneralParams = ( ( SAPbobsCOM.GeneralDataParams )( oGeneralService.GetDataInterface( SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams ) ) ); 
                oGeneralParams.SetProperty( "DocEntry", txtCode.Text ); 
                oGeneralData = oGeneralService.GetByParams( oGeneralParams ); 
                // Update UDO record
                oGeneralData.SetProperty( "U_Room", txtRoom.Text ); 
                oGeneralData.SetProperty( "U_Price", txtPrice.Text ); 
                oGeneralData.SetProperty( "U_Name", txtName.Text ); 
                oGeneralService.Update( oGeneralData ); 
                Interaction.MsgBox( "Updated", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            catch ( Exception ex ) 
            { 
                Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
        } 
        
        public void DeleteUDORecord() 
        { 
            SAPbobsCOM.GeneralService oGeneralService = null; 
            SAPbobsCOM.GeneralDataParams oGeneralParams = null; 
            SAPbobsCOM.CompanyService sCmp = null; 
            sCmp = oCompany.GetCompanyService(); 
            try 
            { 
                // Get a handle to the SM_MOR UDO
                oGeneralService = sCmp.GetGeneralService( "SM_MOR" ); 
                // Delete UDO record
                oGeneralParams = ( ( SAPbobsCOM.GeneralDataParams )( oGeneralService.GetDataInterface( SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams ) ) ); 
                oGeneralParams.SetProperty( "DocEntry", txtCode.Text ); 
                oGeneralService.Delete( oGeneralParams ); 
                Interaction.MsgBox( "Deleted", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            catch ( Exception ex ) 
            { 
                Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
        } 
        
        public void AddChildRecord() 
        { 
            if ( txtMaindish.Text == "" ) 
            { 
                Interaction.MsgBox( "Main Dish is empty", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else if ( txtSideDish.Text == "" ) 
            { 
                Interaction.MsgBox( "Side Dish is empty", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else if ( txtDrink.Text == "" ) 
            { 
                Interaction.MsgBox( "Drink is empty", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            } 
            else 
            { 
                //  If all fields are full, add the child record
                lstMainDish.Items.Add( txtMaindish.Text ); 
                lstSideDish.Items.Add( txtSideDish.Text ); 
                lstDrink.Items.Add( txtDrink.Text ); 
            } 
        } 
        
        public void RomoveChildRecord() 
        { 
            if ( lstMainDish.Items.Count > 0 ) 
            { 
                lstMainDish.Items.Remove( lstMainDish.Items[ lstMainDish.Items.Count - 1 ] ); 
                lstSideDish.Items.Remove( lstSideDish.Items[ lstSideDish.Items.Count - 1 ] ); 
                lstDrink.Items.Remove( lstDrink.Items[ lstDrink.Items.Count - 1 ] ); 
            } 
        } 
        
        private void btnAddUDO_Click( System.Object sender, System.EventArgs e ) 
        { 
            AddUDO(); 
        } 
        
        private void cmdAddRecord_Click( System.Object sender, System.EventArgs e ) 
        { 
            AddUDORecord(); 
        } 
        
        private void cmdUpdateRecord_Click( System.Object sender, System.EventArgs e ) 
        { 
            UpdateUDORecord(); 
        } 
        
        private void cmdGetRecord_Click( System.Object sender, System.EventArgs e ) 
        { 
            GetUDORecord(); 
        } 
        
        private void cmdDeleteRecord_Click( System.Object sender, System.EventArgs e ) 
        { 
            DeleteUDORecord(); 
        } 
        
        private void cmdAddchild_Click( System.Object sender, System.EventArgs e ) 
        { 
            AddChildRecord(); 
        } 
        
        private void cmdRemovechild_Click( System.Object sender, System.EventArgs e ) 
        { 
            RomoveChildRecord(); 
        } 
        
        [STAThread]
        public static void Main() { Application.Run( new frmUDO() ); }
    } 
    
} 
