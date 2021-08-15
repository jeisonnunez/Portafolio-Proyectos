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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.PictureBox picSapLogo;
		internal System.Windows.Forms.GroupBox grpSample;
		internal System.Windows.Forms.TextBox txtItemCode;
		internal System.Windows.Forms.Label lblItemCode;
		internal System.Windows.Forms.Label lblDueDate;
		internal System.Windows.Forms.Label lblQuantity;
		internal System.Windows.Forms.TextBox txtQuantity;
		internal System.Windows.Forms.Label lblCardCode;
		internal System.Windows.Forms.TextBox txtCardCode;
		internal System.Windows.Forms.Label lblExplenation;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label lblPrice;
		internal System.Windows.Forms.TextBox txtPrice;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label lblIns1;
		internal System.Windows.Forms.Label lblPercent1;
		internal System.Windows.Forms.Label lblInsDueDate1;
		internal System.Windows.Forms.Label lblIns2;
		internal System.Windows.Forms.Label lblPercent2;
		internal System.Windows.Forms.TextBox txtPercent2;
		internal System.Windows.Forms.Label lblInsDueDate2;
		internal System.Windows.Forms.NumericUpDown numPercent;
		internal System.Windows.Forms.DateTimePicker DateDue;
		internal System.Windows.Forms.DateTimePicker DateInsDue1;
		internal System.Windows.Forms.DateTimePicker DateInsDue2;
		internal System.Windows.Forms.Button btnInv;
		internal System.Windows.Forms.RadioButton optApplyTaxFirst;
		internal System.Windows.Forms.RadioButton optApplyTaxDistrib;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.picSapLogo = new System.Windows.Forms.PictureBox();
			base.Load += new System.EventHandler(frmMain_Load);
			this.grpSample = new System.Windows.Forms.GroupBox();
			this.btnInv = new System.Windows.Forms.Button();
			btnInv.Click += new System.EventHandler(btnInv_Click);
			this.DateInsDue2 = new System.Windows.Forms.DateTimePicker();
			this.DateInsDue1 = new System.Windows.Forms.DateTimePicker();
			this.DateDue = new System.Windows.Forms.DateTimePicker();
			this.numPercent = new System.Windows.Forms.NumericUpDown();
			numPercent.ValueChanged += new System.EventHandler(numPercent_ValueChanged);
			this.lblIns2 = new System.Windows.Forms.Label();
			this.lblPercent2 = new System.Windows.Forms.Label();
			this.txtPercent2 = new System.Windows.Forms.TextBox();
			this.lblInsDueDate2 = new System.Windows.Forms.Label();
			this.optApplyTaxDistrib = new System.Windows.Forms.RadioButton();
			this.optApplyTaxFirst = new System.Windows.Forms.RadioButton();
			this.lblIns1 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.lblPercent1 = new System.Windows.Forms.Label();
			this.lblInsDueDate1 = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblExplenation = new System.Windows.Forms.Label();
			this.lblCardCode = new System.Windows.Forms.Label();
			this.txtCardCode = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.lblDueDate = new System.Windows.Forms.Label();
			this.lblItemCode = new System.Windows.Forms.Label();
			this.txtItemCode = new System.Windows.Forms.TextBox();
			this.grpConn = new System.Windows.Forms.GroupBox();
			this.cmdGetCompanyList = new System.Windows.Forms.Button();
			cmdGetCompanyList.Click += new System.EventHandler(cmdGetCompanyList_Click);
			this.Label2 = new System.Windows.Forms.Label();
			this.cmbDBType = new System.Windows.Forms.ComboBox();
			this.cmdConnect = new System.Windows.Forms.Button();
			cmdConnect.Click += new System.EventHandler(cmdConnect_Click);
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUSer = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.cmbCompany = new System.Windows.Forms.ComboBox();
			this.lblCompany = new System.Windows.Forms.Label();
			this.grpSample.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.numPercent).BeginInit();
			this.grpConn.SuspendLayout();
			this.SuspendLayout();
			//
			//picSapLogo
			//
			this.picSapLogo.BackgroundImage = ((System.Drawing.Image) resources.GetObject("picSapLogo.BackgroundImage"));
			this.picSapLogo.Location = new System.Drawing.Point(440, 8);
			this.picSapLogo.Name = "picSapLogo";
			this.picSapLogo.Size = new System.Drawing.Size(120, 64);
			this.picSapLogo.TabIndex = 14;
			this.picSapLogo.TabStop = false;
			//
			//grpSample
			//
			this.grpSample.Controls.Add(this.btnInv);
			this.grpSample.Controls.Add(this.DateInsDue2);
			this.grpSample.Controls.Add(this.DateInsDue1);
			this.grpSample.Controls.Add(this.DateDue);
			this.grpSample.Controls.Add(this.numPercent);
			this.grpSample.Controls.Add(this.lblIns2);
			this.grpSample.Controls.Add(this.lblPercent2);
			this.grpSample.Controls.Add(this.txtPercent2);
			this.grpSample.Controls.Add(this.lblInsDueDate2);
			this.grpSample.Controls.Add(this.optApplyTaxDistrib);
			this.grpSample.Controls.Add(this.optApplyTaxFirst);
			this.grpSample.Controls.Add(this.lblIns1);
			this.grpSample.Controls.Add(this.Label4);
			this.grpSample.Controls.Add(this.lblPercent1);
			this.grpSample.Controls.Add(this.lblInsDueDate1);
			this.grpSample.Controls.Add(this.lblPrice);
			this.grpSample.Controls.Add(this.txtPrice);
			this.grpSample.Controls.Add(this.Label3);
			this.grpSample.Controls.Add(this.Label1);
			this.grpSample.Controls.Add(this.lblExplenation);
			this.grpSample.Controls.Add(this.lblCardCode);
			this.grpSample.Controls.Add(this.txtCardCode);
			this.grpSample.Controls.Add(this.lblQuantity);
			this.grpSample.Controls.Add(this.txtQuantity);
			this.grpSample.Controls.Add(this.lblDueDate);
			this.grpSample.Controls.Add(this.lblItemCode);
			this.grpSample.Controls.Add(this.txtItemCode);
			this.grpSample.Enabled = false;
			this.grpSample.Location = new System.Drawing.Point(8, 144);
			this.grpSample.Name = "grpSample";
			this.grpSample.Size = new System.Drawing.Size(648, 400);
			this.grpSample.TabIndex = 15;
			this.grpSample.TabStop = false;
			this.grpSample.Text = "Sample";
			//
			//btnInv
			//
			this.btnInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(177)));
			this.btnInv.Location = new System.Drawing.Point(24, 344);
			this.btnInv.Name = "btnInv";
			this.btnInv.Size = new System.Drawing.Size(336, 40);
			this.btnInv.TabIndex = 36;
			this.btnInv.Text = "Create Invoice with 2 Installments";
			//
			//DateInsDue2
			//
			this.DateInsDue2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateInsDue2.Location = new System.Drawing.Point(480, 280);
			this.DateInsDue2.Name = "DateInsDue2";
			this.DateInsDue2.Size = new System.Drawing.Size(104, 20);
			this.DateInsDue2.TabIndex = 35;
			//
			//DateInsDue1
			//
			this.DateInsDue1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateInsDue1.Location = new System.Drawing.Point(192, 280);
			this.DateInsDue1.Name = "DateInsDue1";
			this.DateInsDue1.Size = new System.Drawing.Size(104, 20);
			this.DateInsDue1.TabIndex = 34;
			//
			//DateDue
			//
			this.DateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateDue.Location = new System.Drawing.Point(160, 120);
			this.DateDue.Name = "DateDue";
			this.DateDue.Size = new System.Drawing.Size(104, 20);
			this.DateDue.TabIndex = 33;
			//
			//numPercent
			//
			this.numPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(177)));
			this.numPercent.Location = new System.Drawing.Point(192, 304);
			this.numPercent.Name = "numPercent";
			this.numPercent.Size = new System.Drawing.Size(104, 29);
			this.numPercent.TabIndex = 32;
			this.numPercent.Value = new decimal(new int[] { 50, 0, 0, 0 });
			//
			//lblIns2
			//
			this.lblIns2.Location = new System.Drawing.Point(328, 256);
			this.lblIns2.Name = "lblIns2";
			this.lblIns2.Size = new System.Drawing.Size(120, 23);
			this.lblIns2.TabIndex = 31;
			this.lblIns2.Text = "Invoice Installment #2";
			//
			//lblPercent2
			//
			this.lblPercent2.Location = new System.Drawing.Point(376, 304);
			this.lblPercent2.Name = "lblPercent2";
			this.lblPercent2.Size = new System.Drawing.Size(104, 23);
			this.lblPercent2.TabIndex = 30;
			this.lblPercent2.Text = "Percent";
			//
			//txtPercent2
			//
			this.txtPercent2.Enabled = false;
			this.txtPercent2.Location = new System.Drawing.Point(480, 304);
			this.txtPercent2.Name = "txtPercent2";
			this.txtPercent2.TabIndex = 29;
			this.txtPercent2.Text = "50";
			//
			//lblInsDueDate2
			//
			this.lblInsDueDate2.Location = new System.Drawing.Point(376, 280);
			this.lblInsDueDate2.Name = "lblInsDueDate2";
			this.lblInsDueDate2.Size = new System.Drawing.Size(104, 23);
			this.lblInsDueDate2.TabIndex = 28;
			this.lblInsDueDate2.Text = "Due Date";
			//
			//optApplyTaxDistrib
			//
			this.optApplyTaxDistrib.Checked = true;
			this.optApplyTaxDistrib.Location = new System.Drawing.Point(40, 200);
			this.optApplyTaxDistrib.Name = "optApplyTaxDistrib";
			this.optApplyTaxDistrib.Size = new System.Drawing.Size(168, 24);
			this.optApplyTaxDistrib.TabIndex = 26;
			this.optApplyTaxDistrib.TabStop = true;
			this.optApplyTaxDistrib.Text = "Apply Tax Proportionally";
			//
			//optApplyTaxFirst
			//
			this.optApplyTaxFirst.Location = new System.Drawing.Point(40, 224);
			this.optApplyTaxFirst.Name = "optApplyTaxFirst";
			this.optApplyTaxFirst.Size = new System.Drawing.Size(176, 24);
			this.optApplyTaxFirst.TabIndex = 25;
			this.optApplyTaxFirst.Text = "Apply Tax On First Installment";
			//
			//lblIns1
			//
			this.lblIns1.Location = new System.Drawing.Point(40, 256);
			this.lblIns1.Name = "lblIns1";
			this.lblIns1.Size = new System.Drawing.Size(120, 23);
			this.lblIns1.TabIndex = 24;
			this.lblIns1.Text = "Invoice Installment #1";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(24, 176);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(328, 23);
			this.Label4.TabIndex = 23;
			this.Label4.Text = "Invoice Installments Info. This sample uses only 2 Installments";
			//
			//lblPercent1
			//
			this.lblPercent1.Location = new System.Drawing.Point(88, 304);
			this.lblPercent1.Name = "lblPercent1";
			this.lblPercent1.Size = new System.Drawing.Size(104, 23);
			this.lblPercent1.TabIndex = 22;
			this.lblPercent1.Text = "Percent";
			//
			//lblInsDueDate1
			//
			this.lblInsDueDate1.Location = new System.Drawing.Point(88, 280);
			this.lblInsDueDate1.Name = "lblInsDueDate1";
			this.lblInsDueDate1.Size = new System.Drawing.Size(104, 23);
			this.lblInsDueDate1.TabIndex = 20;
			this.lblInsDueDate1.Text = "Due Date";
			//
			//lblPrice
			//
			this.lblPrice.Location = new System.Drawing.Point(368, 144);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(104, 23);
			this.lblPrice.TabIndex = 18;
			this.lblPrice.Text = "Price";
			//
			//txtPrice
			//
			this.txtPrice.Location = new System.Drawing.Point(472, 144);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.TabIndex = 17;
			this.txtPrice.Text = "50";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(336, 72);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(104, 23);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Invoice Line Info";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 72);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(104, 23);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "Invoice Header Info";
			//
			//lblExplenation
			//
			this.lblExplenation.Location = new System.Drawing.Point(24, 24);
			this.lblExplenation.Name = "lblExplenation";
			this.lblExplenation.Size = new System.Drawing.Size(600, 40);
			this.lblExplenation.TabIndex = 14;
			this.lblExplenation.Text = "This sample demonstrates how to use installments. It creates an invoice with a si" + "ngle line, and lets you set the installments for it. Make sure you are running t" + "his sample on the SBO_Demo database";
			//
			//lblCardCode
			//
			this.lblCardCode.Location = new System.Drawing.Point(56, 96);
			this.lblCardCode.Name = "lblCardCode";
			this.lblCardCode.Size = new System.Drawing.Size(104, 23);
			this.lblCardCode.TabIndex = 13;
			this.lblCardCode.Text = "Card Code";
			//
			//txtCardCode
			//
			this.txtCardCode.Location = new System.Drawing.Point(160, 96);
			this.txtCardCode.Name = "txtCardCode";
			this.txtCardCode.TabIndex = 12;
			this.txtCardCode.Text = "C20000";
			//
			//lblQuantity
			//
			this.lblQuantity.Location = new System.Drawing.Point(368, 120);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(104, 23);
			this.lblQuantity.TabIndex = 11;
			this.lblQuantity.Text = "Quantity";
			//
			//txtQuantity
			//
			this.txtQuantity.Location = new System.Drawing.Point(472, 120);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.TabIndex = 10;
			this.txtQuantity.Text = "1";
			//
			//lblDueDate
			//
			this.lblDueDate.Location = new System.Drawing.Point(56, 120);
			this.lblDueDate.Name = "lblDueDate";
			this.lblDueDate.Size = new System.Drawing.Size(104, 23);
			this.lblDueDate.TabIndex = 9;
			this.lblDueDate.Text = "Due Date";
			//
			//lblItemCode
			//
			this.lblItemCode.Location = new System.Drawing.Point(368, 96);
			this.lblItemCode.Name = "lblItemCode";
			this.lblItemCode.Size = new System.Drawing.Size(104, 23);
			this.lblItemCode.TabIndex = 7;
			this.lblItemCode.Text = "Item Code";
			//
			//txtItemCode
			//
			this.txtItemCode.Location = new System.Drawing.Point(472, 96);
			this.txtItemCode.Name = "txtItemCode";
			this.txtItemCode.TabIndex = 0;
			this.txtItemCode.Text = "A00001";
			//
			//grpConn
			//
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
			this.grpConn.Size = new System.Drawing.Size(416, 128);
			this.grpConn.TabIndex = 16;
			this.grpConn.TabStop = false;
			this.grpConn.Text = "Connection Properties";
			//
			//cmdGetCompanyList
			//
			this.cmdGetCompanyList.Location = new System.Drawing.Point(16, 52);
			this.cmdGetCompanyList.Name = "cmdGetCompanyList";
			this.cmdGetCompanyList.Size = new System.Drawing.Size(112, 24);
			this.cmdGetCompanyList.TabIndex = 15;
			this.cmdGetCompanyList.Text = "Get Company List";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(8, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(104, 23);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Database Type";
			//
			//cmbDBType
			//
			this.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDBType.Items.AddRange(new object[] { "MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB" });
			this.cmbDBType.Location = new System.Drawing.Point(120, 24);
			this.cmbDBType.Name = "cmbDBType";
			this.cmbDBType.Size = new System.Drawing.Size(121, 21);
			this.cmbDBType.TabIndex = 13;
			//
			//cmdConnect
			//
			this.cmdConnect.Enabled = false;
			this.cmdConnect.Location = new System.Drawing.Point(256, 88);
			this.cmdConnect.Name = "cmdConnect";
			this.cmdConnect.Size = new System.Drawing.Size(88, 24);
			this.cmdConnect.TabIndex = 12;
			this.cmdConnect.Text = "Connect";
			//
			//txtPassword
			//
			this.txtPassword.Enabled = false;
			this.txtPassword.Location = new System.Drawing.Point(312, 48);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPassword.Size = new System.Drawing.Size(88, 20);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.Text = "manager";
			//
			//txtUSer
			//
			this.txtUSer.Enabled = false;
			this.txtUSer.Location = new System.Drawing.Point(312, 24);
			this.txtUSer.Name = "txtUSer";
			this.txtUSer.Size = new System.Drawing.Size(88, 20);
			this.txtUSer.TabIndex = 10;
			this.txtUSer.Text = "manager";
			//
			//lblPassword
			//
			this.lblPassword.Location = new System.Drawing.Point(248, 48);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(64, 23);
			this.lblPassword.TabIndex = 9;
			this.lblPassword.Text = "Password";
			//
			//lblUser
			//
			this.lblUser.Location = new System.Drawing.Point(248, 24);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(64, 23);
			this.lblUser.TabIndex = 8;
			this.lblUser.Text = "User Name";
			//
			//cmbCompany
			//
			this.cmbCompany.Enabled = false;
			this.cmbCompany.Location = new System.Drawing.Point(120, 88);
			this.cmbCompany.Name = "cmbCompany";
			this.cmbCompany.Size = new System.Drawing.Size(121, 21);
			this.cmbCompany.TabIndex = 7;
			//
			//lblCompany
			//
			this.lblCompany.Location = new System.Drawing.Point(8, 88);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(104, 23);
			this.lblCompany.TabIndex = 6;
			this.lblCompany.Text = "Company Database";
			//
			//frmMain
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(682, 559);
			this.Controls.Add(this.grpConn);
			this.Controls.Add(this.grpSample);
			this.Controls.Add(this.picSapLogo);
			this.ForeColor = System.Drawing.Color.Blue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimumSize = new System.Drawing.Size(570, 470);
			this.Name = "frmMain";
			this.Text = "SAP Database Interface Sample";
			this.grpSample.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.numPercent).EndInit();
			this.grpConn.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//Error handling variables
		public string sErrMsg;
		public int lErrCode;
		public int lRetCode;
		
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
		
		private void numPercent_ValueChanged (System.Object sender, System.EventArgs e)
		{
			txtPercent2.Text = (100 - numPercent.Value).ToString();
		}
		
		private void btnInv_Click (System.Object sender, System.EventArgs e)
		{
			try
			{
				SAPbobsCOM.Documents oInv;
				SAPbobsCOM.Document_Installments oIns;
				
				//Create Invoice Object
				oInv = (SAPbobsCOM.Documents) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices);
				
				//Set Invoice Header Values
				oInv.CardCode = txtCardCode.Text;
				oInv.DocDueDate = DateDue.Value;
				
				if (optApplyTaxFirst.Checked == true)
				{
					oInv.ApplyTaxOnFirstInstallment = SAPbobsCOM.BoYesNoEnum.tYES;
				}
				
				//Set Invoice Line Values
				oInv.Lines.ItemCode = txtItemCode.Text;
				oInv.Lines.Quantity = Convert.ToDouble(txtQuantity.Text);
				oInv.Lines.Price = Convert.ToDouble(txtPrice.Text);
				
				//Set Installments
				oIns = oInv.Installments;
				//Installment #1
				oIns.DueDate = DateInsDue1.Value;
				oIns.Percentage = Convert.ToDouble(numPercent.Value);
				oIns.Add();
				
				//Installment #2
				oIns.DueDate = DateInsDue2.Value;
				oIns.Percentage = Convert.ToDouble(txtPercent2.Text);
				
				lRetCode = oInv.Add(); // Try to add the invoice to the database
				if (lRetCode != 0)
				{
					int temp_int = lErrCode;
					string temp_string = sErrMsg;
					oCompany.GetLastError(out temp_int, out temp_string);
					MessageBox.Show(lErrCode + " " + temp_string); // Display error message
				}
				else
				{
					Interaction.MsgBox("Invoice Added to DataBase", MsgBoxStyle.Information, "Invoice Added");
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		
		private void cmdGetCompanyList_Click (System.Object sender, System.EventArgs e)
		{
			oCompany = new SAPbobsCOM.Company();
			
			// Init Connection Properties
			oCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes) (cmbDBType.SelectedIndex + 1);
			oCompany.Server = "localhost"; // change to your company server
			oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English; // change to your language
			oCompany.UseTrusted = true;
			
			//Me.Show() ' shows the form while it's loaded...
			
			//Create a list of companies...
			try
			{
				DownPayment.oRecordSet = oCompany.GetCompanyList(); // get the company list
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
				while (!(DownPayment.oRecordSet.EoF == true))
				{
					cmbCompany.Items.Add(DownPayment.oRecordSet.Fields.Item(0).Value);
					DownPayment.oRecordSet.MoveNext();
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
