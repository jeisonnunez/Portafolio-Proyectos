using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic.CompilerServices;


//****************************************************************************
//  SAP MANAGE DI API 2007 SDK Sample
//****************************************************************************
//
//  Copyright (c) SAP MANAGE
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************


namespace BGT
{
	public class frmMain : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			Application.Run(new frmMain());
		}

		internal System.Windows.Forms.TextBox txtDBPass;
		internal System.Windows.Forms.TextBox txtDBUser;
		internal System.Windows.Forms.Label lblPass;
		internal System.Windows.Forms.Label Label4;
		
		public SAPbobsCOM.Company oCompany; // The company object
		
		#region " Windows Form Designer generated code "
		
		public frmMain() {
			
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
		internal System.Windows.Forms.GroupBox grpSample;
		internal System.Windows.Forms.Label lblExplenation;
		internal System.Windows.Forms.Button cmdLoad;
		internal System.Windows.Forms.TextBox txtQnum;
		internal System.Windows.Forms.Label lblQ;
		internal System.Windows.Forms.GroupBox GrpSpecialLineDetails;
		internal System.Windows.Forms.Label lblLineNum;
		internal System.Windows.Forms.NumericUpDown NumAfterLine;
		internal System.Windows.Forms.TextBox txtSpecial;
		internal System.Windows.Forms.Label lblType;
		internal System.Windows.Forms.RadioButton RadText;
		internal System.Windows.Forms.RadioButton RadSubTotal;
		internal System.Windows.Forms.Button cmdAddSpecialLine;
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
			this.grpSample = new System.Windows.Forms.GroupBox();
			this.GrpSpecialLineDetails = new System.Windows.Forms.GroupBox();
			this.cmdAddSpecialLine = new System.Windows.Forms.Button();
			this.lblLineNum = new System.Windows.Forms.Label();
			this.NumAfterLine = new System.Windows.Forms.NumericUpDown();
			this.txtSpecial = new System.Windows.Forms.TextBox();
			this.lblType = new System.Windows.Forms.Label();
			this.RadText = new System.Windows.Forms.RadioButton();
			this.RadSubTotal = new System.Windows.Forms.RadioButton();
			this.lblQ = new System.Windows.Forms.Label();
			this.txtQnum = new System.Windows.Forms.TextBox();
			this.cmdLoad = new System.Windows.Forms.Button();
			this.lblExplenation = new System.Windows.Forms.Label();
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
			this.grpSample.SuspendLayout();
			this.GrpSpecialLineDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumAfterLine)).BeginInit();
			this.grpConn.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpSample
			// 
			this.grpSample.Controls.Add(this.GrpSpecialLineDetails);
			this.grpSample.Controls.Add(this.lblQ);
			this.grpSample.Controls.Add(this.txtQnum);
			this.grpSample.Controls.Add(this.cmdLoad);
			this.grpSample.Controls.Add(this.lblExplenation);
			this.grpSample.Enabled = false;
			this.grpSample.Location = new System.Drawing.Point(8, 144);
			this.grpSample.Name = "grpSample";
			this.grpSample.Size = new System.Drawing.Size(648, 392);
			this.grpSample.TabIndex = 15;
			this.grpSample.TabStop = false;
			this.grpSample.Text = "Sample";
			// 
			// GrpSpecialLineDetails
			// 
			this.GrpSpecialLineDetails.Controls.Add(this.cmdAddSpecialLine);
			this.GrpSpecialLineDetails.Controls.Add(this.lblLineNum);
			this.GrpSpecialLineDetails.Controls.Add(this.NumAfterLine);
			this.GrpSpecialLineDetails.Controls.Add(this.txtSpecial);
			this.GrpSpecialLineDetails.Controls.Add(this.lblType);
			this.GrpSpecialLineDetails.Controls.Add(this.RadText);
			this.GrpSpecialLineDetails.Controls.Add(this.RadSubTotal);
			this.GrpSpecialLineDetails.Enabled = false;
			this.GrpSpecialLineDetails.Location = new System.Drawing.Point(24, 128);
			this.GrpSpecialLineDetails.Name = "GrpSpecialLineDetails";
			this.GrpSpecialLineDetails.Size = new System.Drawing.Size(592, 232);
			this.GrpSpecialLineDetails.TabIndex = 18;
			this.GrpSpecialLineDetails.TabStop = false;
			this.GrpSpecialLineDetails.Text = "Special Line Details";
			// 
			// cmdAddSpecialLine
			// 
			this.cmdAddSpecialLine.Location = new System.Drawing.Point(32, 152);
			this.cmdAddSpecialLine.Name = "cmdAddSpecialLine";
			this.cmdAddSpecialLine.Size = new System.Drawing.Size(136, 23);
			this.cmdAddSpecialLine.TabIndex = 32;
			this.cmdAddSpecialLine.Text = "Add Special Line";
			this.cmdAddSpecialLine.Click += new System.EventHandler(this.cmdAddSpecialLine_Click);
			// 
			// lblLineNum
			// 
			this.lblLineNum.Location = new System.Drawing.Point(32, 104);
			this.lblLineNum.Name = "lblLineNum";
			this.lblLineNum.Size = new System.Drawing.Size(64, 23);
			this.lblLineNum.TabIndex = 31;
			this.lblLineNum.Text = "After Line";
			// 
			// NumAfterLine
			// 
			this.NumAfterLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.NumAfterLine.Location = new System.Drawing.Point(112, 104);
			this.NumAfterLine.Minimum = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			this.NumAfterLine.Name = "NumAfterLine";
			this.NumAfterLine.Size = new System.Drawing.Size(48, 29);
			this.NumAfterLine.TabIndex = 30;
			this.NumAfterLine.Value = new System.Decimal(new int[] {
																	   1,
																	   0,
																	   0,
																	   0});
			// 
			// txtSpecial
			// 
			this.txtSpecial.Enabled = false;
			this.txtSpecial.Location = new System.Drawing.Point(168, 64);
			this.txtSpecial.Name = "txtSpecial";
			this.txtSpecial.Size = new System.Drawing.Size(392, 20);
			this.txtSpecial.TabIndex = 28;
			this.txtSpecial.Text = "Type here the text that will appear in the special line";
			// 
			// lblType
			// 
			this.lblType.Location = new System.Drawing.Point(32, 32);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(72, 23);
			this.lblType.TabIndex = 27;
			this.lblType.Text = "Line Type";
			// 
			// RadText
			// 
			this.RadText.Location = new System.Drawing.Point(112, 64);
			this.RadText.Name = "RadText";
			this.RadText.Size = new System.Drawing.Size(48, 24);
			this.RadText.TabIndex = 26;
			this.RadText.Text = "Text";
			this.RadText.CheckedChanged += new System.EventHandler(this.RadText_CheckedChanged);
			// 
			// RadSubTotal
			// 
			this.RadSubTotal.Checked = true;
			this.RadSubTotal.Location = new System.Drawing.Point(112, 32);
			this.RadSubTotal.Name = "RadSubTotal";
			this.RadSubTotal.TabIndex = 25;
			this.RadSubTotal.TabStop = true;
			this.RadSubTotal.Text = "SubTotal";
			// 
			// lblQ
			// 
			this.lblQ.Location = new System.Drawing.Point(16, 80);
			this.lblQ.Name = "lblQ";
			this.lblQ.TabIndex = 17;
			this.lblQ.Text = "Quotation Number";
			// 
			// txtQnum
			// 
			this.txtQnum.Location = new System.Drawing.Point(120, 80);
			this.txtQnum.Name = "txtQnum";
			this.txtQnum.TabIndex = 16;
			this.txtQnum.Text = "";
			// 
			// cmdLoad
			// 
			this.cmdLoad.Location = new System.Drawing.Point(232, 80);
			this.cmdLoad.Name = "cmdLoad";
			this.cmdLoad.Size = new System.Drawing.Size(112, 23);
			this.cmdLoad.TabIndex = 15;
			this.cmdLoad.Text = "Load Quotation";
			this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
			// 
			// lblExplenation
			// 
			this.lblExplenation.Location = new System.Drawing.Point(24, 24);
			this.lblExplenation.Name = "lblExplenation";
			this.lblExplenation.Size = new System.Drawing.Size(600, 40);
			this.lblExplenation.TabIndex = 14;
			this.lblExplenation.Text = "This sample demonstrates how to use Special Lines via the DI API. In order to wor" +
				"k with it you need to provide a quotation number of a quotation with lines. Afte" +
				"r loading a quotation you can add Special Lines.";
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
			this.grpConn.Size = new System.Drawing.Size(568, 128);
			this.grpConn.TabIndex = 16;
			this.grpConn.TabStop = false;
			this.grpConn.Text = "Connection Properties";
			// 
			// cmdGetCompanyList
			// 
			this.cmdGetCompanyList.Location = new System.Drawing.Point(440, 24);
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
			this.cmdConnect.Location = new System.Drawing.Point(456, 88);
			this.cmdConnect.Name = "cmdConnect";
			this.cmdConnect.Size = new System.Drawing.Size(88, 24);
			this.cmdConnect.TabIndex = 12;
			this.cmdConnect.Text = "Connect";
			this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Enabled = false;
			this.txtPassword.Location = new System.Drawing.Point(320, 96);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(88, 20);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.Text = "manager";
			// 
			// txtUSer
			// 
			this.txtUSer.Enabled = false;
			this.txtUSer.Location = new System.Drawing.Point(320, 72);
			this.txtUSer.Name = "txtUSer";
			this.txtUSer.Size = new System.Drawing.Size(88, 20);
			this.txtUSer.TabIndex = 10;
			this.txtUSer.Text = "manager";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(256, 96);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(64, 23);
			this.lblPassword.TabIndex = 9;
			this.lblPassword.Text = "Password";
			// 
			// lblUser
			// 
			this.lblUser.Location = new System.Drawing.Point(256, 72);
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
			this.txtDBPass.Location = new System.Drawing.Point(336, 40);
			this.txtDBPass.Name = "txtDBPass";
			this.txtDBPass.PasswordChar = '*';
			this.txtDBPass.Size = new System.Drawing.Size(72, 20);
			this.txtDBPass.TabIndex = 45;
			this.txtDBPass.Text = "";
			// 
			// txtDBUser
			// 
			this.txtDBUser.Location = new System.Drawing.Point(336, 16);
			this.txtDBUser.Name = "txtDBUser";
			this.txtDBUser.Size = new System.Drawing.Size(72, 20);
			this.txtDBUser.TabIndex = 43;
			this.txtDBUser.Text = "sa";
			// 
			// lblPass
			// 
			this.lblPass.Location = new System.Drawing.Point(256, 40);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(80, 16);
			this.lblPass.TabIndex = 46;
			this.lblPass.Text = "DB Password";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(256, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 16);
			this.Label4.TabIndex = 44;
			this.Label4.Text = "DB Username";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(682, 551);
			this.Controls.Add(this.grpConn);
			this.Controls.Add(this.grpSample);
			this.ForeColor = System.Drawing.Color.Blue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimumSize = new System.Drawing.Size(570, 470);
			this.Name = "frmMain";
			this.Text = "SAP Database Interface Sample";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpSample.ResumeLayout(false);
			this.GrpSpecialLineDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NumAfterLine)).EndInit();
			this.grpConn.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		
		#endregion
		
		//Error handling variables
		public string sErrMsg;
		public int lErrCode;
		public int lRetCode;
		public SAPbobsCOM.Documents Qut;
		
		
		//****************************************************************************
		// This function is called when the form is loaded.
		// It performs various initialization procedures.
		//****************************************************************************
		private void frmMain_Load (System.Object sender, System.EventArgs e)
		{
			cmbDBType.SelectedIndex = 3;
		}
		//****************************************************************************
		// This function connects to the database
		//****************************************************************************
		private void Connect ()
		{
			Cursor = System.Windows.Forms.Cursors.WaitCursor; //Change mouse cursor
			
			// Set connection properties
			oCompany.CompanyDB = cmbCompany.Text;
			oCompany.UserName = txtUSer.Text;
			oCompany.Password = txtPassword.Text;
			
			//Try to connect
			lRetCode = oCompany.Connect();
			
			if (lRetCode != 0) // if the connection failed
			{
				int temp_int = lErrCode;
				string temp_string = sErrMsg;
				oCompany.GetLastError(out temp_int, out temp_string);
				Interaction.MsgBox("Connection Failed - " + temp_string, MsgBoxStyle.Exclamation, "Default Connection Failed");
			}
			if (oCompany.Connected) // if connected
			{
				this.Text = this.Text + " - Connected to " + oCompany.CompanyDB;
				grpConn.Enabled = false;
				grpSample.Enabled = true;
			}
			
			Cursor = System.Windows.Forms.Cursors.Default; //Change mouse cursor
		}
		
		//****************************************************************************
		// This function is called when the "Connect" button is called
		//****************************************************************************
		private void cmdConnect_Click (System.Object sender, System.EventArgs e)
		{
			Connect();
		}
		//****************************************************************************
		// This function loads a Quotation
		//****************************************************************************
		private void cmdLoad_Click (System.Object sender, System.EventArgs e)
		{
			Qut = (SAPbobsCOM.Documents) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oQuotations);
			
			if (Qut.GetByKey(System.Convert.ToInt32(txtQnum.Text)))
			{
				if (Qut.Lines.Count != 0)
				{
					
					MessageBox.Show("Quotation Loaded, " + Qut.Lines.Count.ToString() + " lines found.");
					cmdLoad.Enabled = false;
					txtQnum.Enabled = false;
					
					GrpSpecialLineDetails.Enabled = true;
					NumAfterLine.Minimum = 0;
					NumAfterLine.Maximum = Qut.Lines.Count - 1;
				}
				else
				{
					MessageBox.Show("This Quotation doesn\'t contain lines, Please load a quotation with lines");
				}
			}
			else
			{
				MessageBox.Show("Invalid Quotation Number");
			}
		}
		//****************************************************************************
		// This function adds a special Line
		//****************************************************************************
		private void cmdAddSpecialLine_Click (System.Object sender, System.EventArgs e)
		{
			if (RadSubTotal.Checked == true)
			{
				Qut.SpecialLines.LineType = SAPbobsCOM.BoDocSpecialLineType.dslt_Subtotal;
			}
			else
			{
				Qut.SpecialLines.LineType = SAPbobsCOM.BoDocSpecialLineType.dslt_Text;
				Qut.SpecialLines.LineText = txtSpecial.Text;
			}
			
			Qut.SpecialLines.AfterLineNumber = System.Convert.ToInt32(NumAfterLine.Value);
			
			lRetCode = Qut.Update();
			if (lRetCode != 0)
			{
				int temp_int = lErrCode;
				string temp_string = sErrMsg;
				oCompany.GetLastError(out temp_int, out temp_string);
				MessageBox.Show(lErrCode + " " + sErrMsg); // Display error message
			}
			else
			{
				MessageBox.Show("Special Lines Added");
			}
		}
		
		private void RadText_CheckedChanged (System.Object sender, System.EventArgs e)
		{
			if (RadText.Checked == true)
			{
				txtSpecial.Enabled = true;
			}
			else
			{
				txtSpecial.Enabled = false;
			}
		}
		
		private void cmdGetCompanyList_Click (System.Object sender, System.EventArgs e)
		{
			oCompany = new SAPbobsCOM.Company();
			
			SAPbobsCOM.Recordset oRecordset;
			
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
				oRecordset = oCompany.GetCompanyList(); // get the company list
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
				while (!(oRecordset.EoF == true))
				{
					cmbCompany.Items.Add(oRecordset.Fields.Item(0).Value);
					oRecordset.MoveNext();
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
