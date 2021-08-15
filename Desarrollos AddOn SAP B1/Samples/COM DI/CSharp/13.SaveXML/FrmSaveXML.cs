using Microsoft.VisualBasic;
using System.Data;
using System;
using System.Collections;
using System.Windows.Forms;
using AxSHDocVw;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

////  SAP MANAGE DI API 2007 SDK Sample
////****************************************************************************
////
////  Copyright (c) SAP MANAGE
////
//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
////****************************************************************************
//// BEFORE STARTING:
//// Add reference to the "SAP Business One Objects Bridge Version 2005"
////-----------------------------------------------------------------
//// 1. Project->References
//// 2. check the "SAP Business One Objects Bridge Version 2005" check box
////****************************************************************************




namespace DI_SaveXML
{
	public class frmSaveXML : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			Application.Run(new frmSaveXML());
		}
		
		private SAPbobsCOM.Company oCompany;
		private string sErrMsg = null;
		private int lErrCode = 0;
		protected int lRetCode;
		
		private SAPbobsCOM.Recordset RS;
		internal System.Windows.Forms.TextBox txtDBPass;
		internal System.Windows.Forms.TextBox txtDBUser;
		internal System.Windows.Forms.Label lblPass;
		internal System.Windows.Forms.Label Label4;
		[field:System.CLSCompliant(false)]		protected SAPbobsCOM.SBObob Bob;
		
		#region " Windows Form Designer generated code "
		
		public frmSaveXML() {
			
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
		internal System.Windows.Forms.ListBox lstBO;
		internal System.Windows.Forms.TextBox txtKey;
		internal System.Windows.Forms.Button cmdPrev;
		internal AxSHDocVw.AxWebBrowser WB;
		internal System.Windows.Forms.Button cmdSave;
		internal System.Windows.Forms.Label lblFile;
		internal System.Windows.Forms.TextBox txtFile;
		internal System.Windows.Forms.Button cmdNext;
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
		internal System.Windows.Forms.Label lblCompany;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSaveXML));
			this.lstBO = new System.Windows.Forms.ListBox();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.cmdNext = new System.Windows.Forms.Button();
			this.cmdPrev = new System.Windows.Forms.Button();
			this.WB = new AxSHDocVw.AxWebBrowser();
			this.cmdSave = new System.Windows.Forms.Button();
			this.lblFile = new System.Windows.Forms.Label();
			this.txtFile = new System.Windows.Forms.TextBox();
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
			((System.ComponentModel.ISupportInitialize)(this.WB)).BeginInit();
			this.grpConn.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstBO
			// 
			this.lstBO.Enabled = false;
			this.lstBO.Items.AddRange(new object[] {
													   "Business Partners",
													   "Items"});
			this.lstBO.Location = new System.Drawing.Point(8, 160);
			this.lstBO.Name = "lstBO";
			this.lstBO.Size = new System.Drawing.Size(120, 95);
			this.lstBO.TabIndex = 0;
			this.lstBO.SelectedIndexChanged += new System.EventHandler(this.lstBO_SelectedIndexChanged);
			// 
			// txtKey
			// 
			this.txtKey.Enabled = false;
			this.txtKey.Location = new System.Drawing.Point(8, 264);
			this.txtKey.Name = "txtKey";
			this.txtKey.Size = new System.Drawing.Size(120, 20);
			this.txtKey.TabIndex = 1;
			this.txtKey.Text = "Object Key";
			// 
			// cmdNext
			// 
			this.cmdNext.Enabled = false;
			this.cmdNext.Location = new System.Drawing.Point(88, 296);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(40, 23);
			this.cmdNext.TabIndex = 2;
			this.cmdNext.Text = "--->";
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			// 
			// cmdPrev
			// 
			this.cmdPrev.Enabled = false;
			this.cmdPrev.Location = new System.Drawing.Point(8, 296);
			this.cmdPrev.Name = "cmdPrev";
			this.cmdPrev.Size = new System.Drawing.Size(40, 23);
			this.cmdPrev.TabIndex = 3;
			this.cmdPrev.Text = "<---";
			this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
			// 
			// WB
			// 
			this.WB.Enabled = true;
			this.WB.Location = new System.Drawing.Point(144, 160);
			this.WB.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WB.OcxState")));
			this.WB.Size = new System.Drawing.Size(456, 248);
			this.WB.TabIndex = 4;
			// 
			// cmdSave
			// 
			this.cmdSave.Enabled = false;
			this.cmdSave.Location = new System.Drawing.Point(8, 408);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.TabIndex = 5;
			this.cmdSave.Text = "Save";
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// lblFile
			// 
			this.lblFile.Location = new System.Drawing.Point(8, 328);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(80, 16);
			this.lblFile.TabIndex = 6;
			this.lblFile.Text = "File Name";
			// 
			// txtFile
			// 
			this.txtFile.Enabled = false;
			this.txtFile.Location = new System.Drawing.Point(8, 352);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(120, 20);
			this.txtFile.TabIndex = 7;
			this.txtFile.Text = "";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(96, 416);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(472, 16);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "The file will be saved in the current directory, don\'t enter full path.";
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
			this.grpConn.Location = new System.Drawing.Point(8, 8);
			this.grpConn.Name = "grpConn";
			this.grpConn.Size = new System.Drawing.Size(592, 128);
			this.grpConn.TabIndex = 9;
			this.grpConn.TabStop = false;
			this.grpConn.Text = "Connection Properties";
			// 
			// cmdGetCompanyList
			// 
			this.cmdGetCompanyList.Location = new System.Drawing.Point(464, 24);
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
			this.cmdConnect.Location = new System.Drawing.Point(488, 88);
			this.cmdConnect.Name = "cmdConnect";
			this.cmdConnect.Size = new System.Drawing.Size(88, 24);
			this.cmdConnect.TabIndex = 12;
			this.cmdConnect.Text = "Connect";
			this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Enabled = false;
			this.txtPassword.Location = new System.Drawing.Point(312, 96);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(88, 20);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.Text = "manager";
			// 
			// txtUSer
			// 
			this.txtUSer.Enabled = false;
			this.txtUSer.Location = new System.Drawing.Point(312, 72);
			this.txtUSer.Name = "txtUSer";
			this.txtUSer.Size = new System.Drawing.Size(88, 20);
			this.txtUSer.TabIndex = 10;
			this.txtUSer.Text = "manager";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(248, 96);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(64, 23);
			this.lblPassword.TabIndex = 9;
			this.lblPassword.Text = "Password";
			// 
			// lblUser
			// 
			this.lblUser.Location = new System.Drawing.Point(248, 72);
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
			this.txtDBPass.Location = new System.Drawing.Point(352, 40);
			this.txtDBPass.Name = "txtDBPass";
			this.txtDBPass.PasswordChar = '*';
			this.txtDBPass.Size = new System.Drawing.Size(72, 20);
			this.txtDBPass.TabIndex = 45;
			this.txtDBPass.Text = "";
			// 
			// txtDBUser
			// 
			this.txtDBUser.Location = new System.Drawing.Point(352, 16);
			this.txtDBUser.Name = "txtDBUser";
			this.txtDBUser.Size = new System.Drawing.Size(72, 20);
			this.txtDBUser.TabIndex = 43;
			this.txtDBUser.Text = "sa";
			// 
			// lblPass
			// 
			this.lblPass.Location = new System.Drawing.Point(272, 40);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(80, 16);
			this.lblPass.TabIndex = 46;
			this.lblPass.Text = "DB Password";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(272, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 16);
			this.Label4.TabIndex = 44;
			this.Label4.Text = "DB Username";
			// 
			// frmSaveXML
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(640, 445);
			this.Controls.Add(this.grpConn);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.WB);
			this.Controls.Add(this.cmdPrev);
			this.Controls.Add(this.cmdNext);
			this.Controls.Add(this.txtKey);
			this.Controls.Add(this.lstBO);
			this.MinimumSize = new System.Drawing.Size(420, 290);
			this.Name = "frmSaveXML";
			this.Text = "Save Objects as XML";
			this.Resize += new System.EventHandler(this.frmSaveXML_Resize);
			this.Load += new System.EventHandler(this.frmSaveXML_Load);
			((System.ComponentModel.ISupportInitialize)(this.WB)).EndInit();
			this.grpConn.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		
		#endregion
		
		private void frmSaveXML_Load (System.Object sender, System.EventArgs e)
		{
			cmbDBType.SelectedIndex = 3;
		}
		
		////****************************************************************************
		//// Connect to the company
		////****************************************************************************
		private void ConnectToCompany ()
		{
			
			//// Initialize the Company Object.
			//// Create a new company object
			
			//// Set the mandatory properties for the connection to the database.
			//// To use a remote Db Server enter his name instead of the string "(local)"
			//// This string is used to work on a DB installed on your local machine
			
			oCompany.CompanyDB = cmbCompany.Text;
			oCompany.UserName = txtUSer.Text;
			oCompany.Password = txtPassword.Text;
			oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English;
			
			//// Use Windows authentication for database server.
			//// True for NT server authentication,
			//// False for database server authentication.
			oCompany.UseTrusted = true;
			
			//// connect
			oCompany.Connect();
			
			//// Check for errors during connect
			int temp_int = lErrCode;
			string temp_string = sErrMsg;
			oCompany.GetLastError(out temp_int, out temp_string);
			if (lErrCode != 0)
			{
				MessageBox.Show(sErrMsg);
			}
			else
			{
				cmbCompany.Enabled = false;
				txtUSer.Enabled = false;
				txtPassword.Enabled = false;
				
				lstBO.Enabled = true;
				txtKey.Enabled = true;
				cmdNext.Enabled = true;
				cmdPrev.Enabled = true;
				txtFile.Enabled = true;
				cmdSave.Enabled = true;
				
			}
			
		}
		
		private void lstBO_SelectedIndexChanged (System.Object sender, System.EventArgs e)
		{
			
			RS = (SAPbobsCOM.Recordset) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			cmdPrev.Enabled = true;
			cmdNext.Enabled = true;
			switch (lstBO.SelectedIndex)
			{
				case 0:
					
					RS.DoQuery("SELECT CardCode from OCRD");
					break;
				case 1:
					
					RS.DoQuery("SELECT ItemCode from OITM");
					break;
			}
			RS.MoveFirst();
			txtKey.Text = RS.Fields.Item(0).Value.ToString();
		}
		
		private void cmdNext_Click (System.Object sender, System.EventArgs e)
		{
			if (!(RS.EoF))
			{
				RS.MoveNext();
			}
			if (!(RS.EoF))
			{
				txtKey.Text = RS.Fields.Item(0).Value.ToString();
			}
		}
		
		private void cmdPrev_Click (System.Object sender, System.EventArgs e)
		{
			if (!(RS.BoF))
			{
				RS.MovePrevious();
			}
			txtKey.Text = RS.Fields.Item(0).Value.ToString();
		}
		
		private void cmdSave_Click (System.Object sender, System.EventArgs e)
		{
			SAPbobsCOM.BusinessPartners BP;
			SAPbobsCOM.Items ITM;
			
			// Set the export type suitable for reloading
			oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode;
			
			switch (lstBO.SelectedIndex)
			{
				case 0: // Business Partners
					
					BP = (SAPbobsCOM.BusinessPartners) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
					BP.GetByKey(txtKey.Text);
					string temp_string = txtFile.Text + ".xml";
					BP.SaveXML(ref temp_string);
					break;
				case 1: // Items
					
					ITM = (SAPbobsCOM.Items) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems);
					ITM.GetByKey(txtKey.Text);
					string temp_string2 = txtFile.Text + ".xml";
					ITM.SaveXML(ref temp_string2);
					break;
			}
			
			MessageBox.Show("File Saved");
			object temp_object = FileSystem.CurDir() + "\\" + txtFile.Text + ".xml";
			WB.Navigate2(ref temp_object);
		}
		
		private void frmSaveXML_Resize (object sender, System.EventArgs e)
		{
			WB.Width = this.Width - 10 - WB.Left;
			WB.Height = this.Height - 30 - WB.Top;
		}
		
		private void cmdConnect_Click (System.Object sender, System.EventArgs e)
		{
			
			ConnectToCompany();
			
			if (oCompany.Connected == true)
			{
				System.Windows.Forms.MessageBox.Show("Connected to: " + oCompany.CompanyName);
			}
			else
			{
				MessageBox.Show("Not connected. Shutting down");
				ProjectData.EndApp();
			}
			
		}
		
		private void cmdGetCompanyList_Click (System.Object sender, System.EventArgs e)
		{
			SAPbobsCOM.Recordset oRecordSet;
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
				MessageBox.Show(ex.Message);
				return;
			}
			
			int temp_int = lErrCode;
			string temp_string = sErrMsg;
			oCompany.GetLastError(out temp_int, out temp_string);
			
			if (lErrCode != 0)
			{
				MessageBox.Show(sErrMsg);
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
