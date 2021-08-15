using Microsoft.VisualBasic;
using System;
using Microsoft.VisualBasic.CompilerServices;

////  SAP MANAGE DI API 2007 SDK Sample
////****************************************************************************
////
////  File:      FrmMain.vb
////
////  Copyright (c) SAP MANAGE
////
//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// BEFORE STARTING:
//// Add reference to the "SAP Business One Objects Bridge Version 2005"
////-----------------------------------------------------------------
//// 1. Project->References
//// 2. check the "SAP Business One Objects Bridge Version 2005" check box
////****************************************************************************

namespace LoadFromXML
{
	public class FrmMain : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run( new FrmMain() );
		}
		
		#region " Windows Form Designer generated code "
		
		public FrmMain() {
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose (bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.Button cmdLoadXML;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox grpConn;
		internal System.Windows.Forms.Button cmdGetCompanyList;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox cmbDBType;
		internal System.Windows.Forms.Button cmdConnect;
		internal System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.TextBox txtUSer;
		internal System.Windows.Forms.Label lblPassword;
		internal System.Windows.Forms.Label lblUser;
		internal System.Windows.Forms.ComboBox cmbCompany;
		internal System.Windows.Forms.TextBox txtDBPass;
		internal System.Windows.Forms.TextBox txtDBUser;
		internal System.Windows.Forms.Label lblPass;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label lblCompany;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdLoadXML = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.grpConn = new System.Windows.Forms.GroupBox();
			this.cmdGetCompanyList = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.cmbDBType = new System.Windows.Forms.ComboBox();
			this.cmdConnect = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUSer = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.cmbCompany = new System.Windows.Forms.ComboBox();
			this.lblCompany = new System.Windows.Forms.Label();
			this.txtDBPass = new System.Windows.Forms.TextBox();
			this.txtDBUser = new System.Windows.Forms.TextBox();
			this.lblPass = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.grpConn.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdLoadXML
			// 
			this.cmdLoadXML.Enabled = false;
			this.cmdLoadXML.Location = new System.Drawing.Point(200, 320);
			this.cmdLoadXML.Name = "cmdLoadXML";
			this.cmdLoadXML.TabIndex = 7;
			this.cmdLoadXML.Text = "Load XML";
			this.cmdLoadXML.Click += new System.EventHandler(this.cmdLoadXML_Click);
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(24, 208);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(208, 96);
			this.Label1.TabIndex = 8;
			this.Label1.Text = @"This program will try to load some business partner and item object found in an Xml file. This will be done within one DB transaction. If one object will fail, the transaction will be rolled back, meaning that none of the objects will be added to the data base.";
			// 
			// grpConn
			// 
			this.grpConn.Controls.Add(this.txtDBPass);
			this.grpConn.Controls.Add(this.txtDBUser);
			this.grpConn.Controls.Add(this.lblPass);
			this.grpConn.Controls.Add(this.Label4);
			this.grpConn.Controls.Add(this.cmdGetCompanyList);
			this.grpConn.Controls.Add(this.Label2);
			this.grpConn.Controls.Add(this.cmbDBType);
			this.grpConn.Controls.Add(this.cmdConnect);
			this.grpConn.Controls.Add(this.txtPassword);
			this.grpConn.Controls.Add(this.txtUSer);
			this.grpConn.Controls.Add(this.lblPassword);
			this.grpConn.Controls.Add(this.lblUser);
			this.grpConn.Controls.Add(this.cmbCompany);
			this.grpConn.Controls.Add(this.lblCompany);
			this.grpConn.Location = new System.Drawing.Point(0, 8);
			this.grpConn.Name = "grpConn";
			this.grpConn.Size = new System.Drawing.Size(416, 184);
			this.grpConn.TabIndex = 9;
			this.grpConn.TabStop = false;
			this.grpConn.Text = "Connection Properties";
			// 
			// cmdGetCompanyList
			// 
			this.cmdGetCompanyList.Location = new System.Drawing.Point(16, 52);
			this.cmdGetCompanyList.Name = "cmdGetCompanyList";
			this.cmdGetCompanyList.Size = new System.Drawing.Size(112, 24);
			this.cmdGetCompanyList.TabIndex = 15;
			this.cmdGetCompanyList.Text = "Get Company List";
			this.cmdGetCompanyList.Click += new System.EventHandler(this.cmdGetCompanyList_Click);
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(8, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(104, 23);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Database Type";
			// 
			// cmbDBType
			// 
			this.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDBType.Items.AddRange(new object[] {
														   "MSSQL",
														   "DB_2",
														   "SYBASE",
														   "MSSQL2005",
														   "MAXDB"});
			this.cmbDBType.Location = new System.Drawing.Point(120, 24);
			this.cmbDBType.Name = "cmbDBType";
			this.cmbDBType.Size = new System.Drawing.Size(121, 21);
			this.cmbDBType.TabIndex = 13;
			// 
			// cmdConnect
			// 
			this.cmdConnect.Enabled = false;
			this.cmdConnect.Location = new System.Drawing.Point(312, 144);
			this.cmdConnect.Name = "cmdConnect";
			this.cmdConnect.Size = new System.Drawing.Size(88, 24);
			this.cmdConnect.TabIndex = 12;
			this.cmdConnect.Text = "Connect";
			this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Enabled = false;
			this.txtPassword.Location = new System.Drawing.Point(144, 144);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(88, 20);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.Text = "manager";
			// 
			// txtUSer
			// 
			this.txtUSer.Enabled = false;
			this.txtUSer.Location = new System.Drawing.Point(144, 120);
			this.txtUSer.Name = "txtUSer";
			this.txtUSer.Size = new System.Drawing.Size(88, 20);
			this.txtUSer.TabIndex = 10;
			this.txtUSer.Text = "manager";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(80, 144);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(64, 23);
			this.lblPassword.TabIndex = 9;
			this.lblPassword.Text = "Password";
			// 
			// lblUser
			// 
			this.lblUser.Location = new System.Drawing.Point(80, 120);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(64, 23);
			this.lblUser.TabIndex = 8;
			this.lblUser.Text = "User Name";
			// 
			// cmbCompany
			// 
			this.cmbCompany.Enabled = false;
			this.cmbCompany.Location = new System.Drawing.Point(120, 88);
			this.cmbCompany.Name = "cmbCompany";
			this.cmbCompany.Size = new System.Drawing.Size(121, 21);
			this.cmbCompany.TabIndex = 7;
			// 
			// lblCompany
			// 
			this.lblCompany.Location = new System.Drawing.Point(8, 88);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(104, 23);
			this.lblCompany.TabIndex = 6;
			this.lblCompany.Text = "Company Database";
			// 
			// txtDBPass
			// 
			this.txtDBPass.Location = new System.Drawing.Point(328, 48);
			this.txtDBPass.Name = "txtDBPass";
			this.txtDBPass.PasswordChar = '*';
			this.txtDBPass.Size = new System.Drawing.Size(72, 20);
			this.txtDBPass.TabIndex = 45;
			this.txtDBPass.Text = "";
			// 
			// txtDBUser
			// 
			this.txtDBUser.Location = new System.Drawing.Point(328, 24);
			this.txtDBUser.Name = "txtDBUser";
			this.txtDBUser.Size = new System.Drawing.Size(72, 20);
			this.txtDBUser.TabIndex = 43;
			this.txtDBUser.Text = "sa";
			// 
			// lblPass
			// 
			this.lblPass.Location = new System.Drawing.Point(248, 48);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(80, 16);
			this.lblPass.TabIndex = 46;
			this.lblPass.Text = "DB Password";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(248, 24);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 16);
			this.Label4.TabIndex = 44;
			this.Label4.Text = "DB Username";
			// 
			// FrmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 373);
			this.Controls.Add(this.grpConn);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cmdLoadXML);
			this.Name = "FrmMain";
			this.Text = "Load XML";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.grpConn.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		
		#endregion
		
		public SAPbobsCOM.Company oCompany;
		
		public string sErrMsg;
		public long lErrCode;
		public long lRetCode;
		
		private SAPbobsCOM.BusinessPartners oBusinessPartner;
		private SAPbobsCOM.Items oItem;
		private SAPbobsCOM.Recordset oRecordSet;
		
		private void FrmMain_Load (System.Object sender, System.EventArgs e)
		{
			cmbDBType.SelectedIndex = 3;
		}
		
		private void cmdConnect_Click (System.Object sender, System.EventArgs e)
		{
			//// setting the rest of the mandatory properties
			
			oCompany.CompanyDB = cmbCompany.Text;
			oCompany.UserName = txtUSer.Text;
			oCompany.Password = txtPassword.Text;
			
			//// Connecting to a company DB
			lRetCode = oCompany.Connect();
			
			//// Check for errors
			if (lRetCode != 0)
			{
				int temp_int = (int) (lErrCode);
				string temp_string = sErrMsg;
				oCompany.GetLastError(out temp_int, out temp_string);
				Interaction.MsgBox( temp_string, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 				
			}
			else
			{
				Interaction.MsgBox( "Connected to " + oCompany.CompanyName, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
				cmbCompany.Enabled = false;
				txtPassword.Enabled = false;
				txtUSer.Enabled = false;
				cmdConnect.Enabled = false;
				cmdLoadXML.Enabled = true;
			}
			
		}
		
		private void InitializeCompany ()
		{
			
			//// Initialize the Company Object.
			//// Create a new company object
			oCompany = new SAPbobsCOM.Company();
			
			//// Set the mandatory properties for the connection to the database.
			//// here I bring only 2 of the 5 mandatory fields.
			//// To use a remote Db Server enter his name instead of the string "(local)"
			//// This string is used to work on a DB installed on your local machine
			//// the other mandatory fields are CompanyDB, UserName and Password
			//// I am setting those fields in the ChooseCompany Form
			
			oCompany.Server = "(local)";
			oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English;
			
			//// Use Windows authentication for database server.
			//// True for NT server authentication,
			//// False for database server authentication.
			oCompany.UseTrusted = true;
			
		}
		
		private void cmdLoadXML_Click (System.Object sender, System.EventArgs e)
		{
			LoadObjectsFromXML();
		}
		
		private void LoadObjectsFromXML ()
		{
			string sXmlFileName = null; 
            
			long iElementCount = 0; 
            
			long iCounter = 0; 
            
			// setting the file name
            
			sXmlFileName = System.IO.Directory.GetParent( System.Windows.Forms.Application.StartupPath).ToString();
			sXmlFileName = System.IO.Directory.GetParent( sXmlFileName).ToString() + @"\xml\BPandContacts.xml";
            
			// Get the number of Business object in the file ...
            
			iElementCount = oCompany.GetXMLelementCount( sXmlFileName ); 
            
			Interaction.MsgBox( iElementCount + " Elemnts found in xml file" + Constants.vbNewLine + "Ready To Satrt Transaction", (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
            
			// start a transaction
			// starting a transaction means that nothing changes in the DB
			// untill we end the transaction with the commit flag
            
			// if an error is encountered the transaction rolls back
			// which means that all changes as of the StartTransaction
			// are discarded
            
			oCompany.StartTransaction(); 
            
			// Run a loop through the objects and when with in the file
			// and the objects to the DB
            
			for ( iCounter=0; iCounter<=iElementCount - 1; iCounter++ ) 
			{ 
                
				// get the objects type at the specified position
				oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode; 
				switch ( oCompany.GetXMLobjectType( sXmlFileName, System.Convert.ToInt32( iCounter ) ) ) 
				{
					case SAPbobsCOM.BoObjectTypes.oBusinessPartners:
						// get the business object data from the file
						oBusinessPartner = ( ( SAPbobsCOM.BusinessPartners )( oCompany.GetBusinessObjectFromXML( sXmlFileName, System.Convert.ToInt32( iCounter ) ) ) ); 
						// add the object to the data base
						oBusinessPartner.Add(); 
                        
						break;
					case SAPbobsCOM.BoObjectTypes.oItems:
						// get the business object data from the file
						oItem = ( ( SAPbobsCOM.Items )( oCompany.GetBusinessObjectFromXML( sXmlFileName, System.Convert.ToInt32( iCounter ) ) ) ); 
						// add the object to the data base
						oItem.Add(); 
						break;
				}
                
                
				// Check for errors during connect
				// if an error is encountered the transaction will
				// terminate automatically
				int transTemp0 = System.Convert.ToInt32( lErrCode ); 
				oCompany.GetLastError( out transTemp0, out sErrMsg ); 
				if ( transTemp0 != 0 ) 
				{ 
					System.Windows.Forms.MessageBox.Show(sErrMsg + Constants.vbNewLine + "Transaction will be rolled back");
                    
					// exiting the sub
					return; 
                    
				} 
                
			} 
            
			// the objects will added to the DB only at this point
			oCompany.EndTransaction( SAPbobsCOM.BoWfTransOpt.wf_Commit ); 
            
			System.Windows.Forms.MessageBox.Show("Data inserted successfully");
			
            
		}
	
	private void cmdGetCompanyList_Click (System.Object sender, System.EventArgs e)
	{
		oCompany = new SAPbobsCOM.Company();
		
		// Init Connection Properties
		oCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes) (cmbDBType.SelectedIndex + 1);
		oCompany.Server = "localhost"; // change to your company server
		oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English; // change to your language
		oCompany.UseTrusted = false;
		oCompany.DbUserName = txtDBUser.Text;
		oCompany.DbPassword = txtDBPass.Text;
		
		//Me.Show() ' shows the form while it's loaded...
		
		//Create a list of companies...
		try
		{
			oRecordSet = oCompany.GetCompanyList(); // get the company list
		}
		catch (Exception ex)
		{
			Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 			
			return;
		}
		
		int temp_int = (int) (lErrCode);
		string temp_string = sErrMsg;
		oCompany.GetLastError(out temp_int, out temp_string);
		
		if (lErrCode != 0)
		{
			Interaction.MsgBox(temp_string , (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 			
		}
		else
		{
			while (!(oRecordSet.EoF == true))
			{
				cmbCompany.Items.Add(oRecordSet.Fields.Item(0).Value);
				oRecordSet.MoveNext();
			}
			
			//Disable Controls
			cmdGetCompanyList.Enabled = false;
			cmbDBType.Enabled = false;
			
			//Enable Controls
			txtUSer.Enabled = true;
			txtPassword.Enabled = true;
			cmdConnect.Enabled = true;
			cmbCompany.Enabled = true;
			
		}
		
		//Select the first company as default
		if (cmbCompany.Items.Count > 0)
		{
			cmbCompany.SelectedIndex = 0;
		}
		else
		{
			Interaction.MsgBox("There was no Database Found...", 0, "Database not found...");
			ProjectData.EndApp(); // Terminate Application...
		}
		
		if (oCompany.Connected) // if already connected
		{
			this.Text = this.Text + ": Connected";
			// Remove the following 2 remark lines if you want to try to connect automatically
			//Else
			//Connect()
		}
		
	}
}

}
