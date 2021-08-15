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


namespace DOWNPAYMENT
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
		internal System.Windows.Forms.DateTimePicker DateDue;
		internal System.Windows.Forms.NumericUpDown numPercent;
		internal System.Windows.Forms.Label lblPercent;
		internal System.Windows.Forms.Button cmdCreateDownPaymentInv;
		internal System.Windows.Forms.Button cmdPayDownPayment;
		internal System.Windows.Forms.Button cmdInv;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.GroupBox grpConn;
		internal System.Windows.Forms.Button cmdGetCompanyList;
		internal System.Windows.Forms.Label Label5;
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
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label lblCompany;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.grpSample = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.cmdInv = new System.Windows.Forms.Button();
			this.cmdPayDownPayment = new System.Windows.Forms.Button();
			this.numPercent = new System.Windows.Forms.NumericUpDown();
			this.lblPercent = new System.Windows.Forms.Label();
			this.cmdCreateDownPaymentInv = new System.Windows.Forms.Button();
			this.DateDue = new System.Windows.Forms.DateTimePicker();
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
			this.Label5 = new System.Windows.Forms.Label();
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
			this.label6 = new System.Windows.Forms.Label();
			this.grpSample.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPercent)).BeginInit();
			this.grpConn.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpSample
			// 
			this.grpSample.Controls.Add(this.Label4);
			this.grpSample.Controls.Add(this.Label2);
			this.grpSample.Controls.Add(this.cmdInv);
			this.grpSample.Controls.Add(this.cmdPayDownPayment);
			this.grpSample.Controls.Add(this.numPercent);
			this.grpSample.Controls.Add(this.lblPercent);
			this.grpSample.Controls.Add(this.cmdCreateDownPaymentInv);
			this.grpSample.Controls.Add(this.DateDue);
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
			this.grpSample.Size = new System.Drawing.Size(672, 472);
			this.grpSample.TabIndex = 15;
			this.grpSample.TabStop = false;
			this.grpSample.Text = "Sample";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(24, 120);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(552, 48);
			this.Label4.TabIndex = 44;
			this.Label4.Text = "Define BP Accounts:\r\nIn BP Accounting tab Define -> General tab Define:\r\n1. Payme" +
				"nt advances\r\n2. Control Account -> Downpayment Recievable Account.\r\n";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(16, 296);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(552, 96);
			this.Label2.TabIndex = 43;
			this.Label2.Text = @"This Add-On demonstrates the process of using DownPayment Invoice via the DI.
In order to make it clearer, it was devided to 3 parts:
   1. Creating a Down Payment Invoice.
   2. Paying the Down Payment Invoice.
   3. Creating an Invoice that uses the paid Down Payment.
      The Invoice contains the same parameters as the Down Payment (Card Code, Due Date... ).


In each step the relavent button is enabled.
";
			// 
			// cmdInv
			// 
			this.cmdInv.Enabled = false;
			this.cmdInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.cmdInv.Location = new System.Drawing.Point(464, 400);
			this.cmdInv.Name = "cmdInv";
			this.cmdInv.Size = new System.Drawing.Size(192, 56);
			this.cmdInv.TabIndex = 42;
			this.cmdInv.Text = "Create Invoice With Down Payment";
			this.cmdInv.Click += new System.EventHandler(this.cmdInv_Click);
			// 
			// cmdPayDownPayment
			// 
			this.cmdPayDownPayment.Enabled = false;
			this.cmdPayDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.cmdPayDownPayment.Location = new System.Drawing.Point(232, 400);
			this.cmdPayDownPayment.Name = "cmdPayDownPayment";
			this.cmdPayDownPayment.Size = new System.Drawing.Size(192, 56);
			this.cmdPayDownPayment.TabIndex = 41;
			this.cmdPayDownPayment.Text = "Pay Down Payment Invoice";
			this.cmdPayDownPayment.Click += new System.EventHandler(this.cmdPayDownPayment_Click);
			// 
			// numPercent
			// 
			this.numPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.numPercent.Location = new System.Drawing.Point(160, 256);
			this.numPercent.Name = "numPercent";
			this.numPercent.Size = new System.Drawing.Size(104, 29);
			this.numPercent.TabIndex = 40;
			this.numPercent.Value = new System.Decimal(new int[] {
																	 50,
																	 0,
																	 0,
																	 0});
			// 
			// lblPercent
			// 
			this.lblPercent.Location = new System.Drawing.Point(56, 256);
			this.lblPercent.Name = "lblPercent";
			this.lblPercent.Size = new System.Drawing.Size(104, 32);
			this.lblPercent.TabIndex = 37;
			this.lblPercent.Text = "Down Payment Percent";
			// 
			// cmdCreateDownPaymentInv
			// 
			this.cmdCreateDownPaymentInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.cmdCreateDownPaymentInv.Location = new System.Drawing.Point(16, 400);
			this.cmdCreateDownPaymentInv.Name = "cmdCreateDownPaymentInv";
			this.cmdCreateDownPaymentInv.Size = new System.Drawing.Size(176, 56);
			this.cmdCreateDownPaymentInv.TabIndex = 36;
			this.cmdCreateDownPaymentInv.Text = "Create Down Payment Invoice";
			this.cmdCreateDownPaymentInv.Click += new System.EventHandler(this.cmdCreateDownPaymentInv_Click);
			// 
			// DateDue
			// 
			this.DateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateDue.Location = new System.Drawing.Point(160, 232);
			this.DateDue.Name = "DateDue";
			this.DateDue.Size = new System.Drawing.Size(104, 20);
			this.DateDue.TabIndex = 33;
			// 
			// lblPrice
			// 
			this.lblPrice.Location = new System.Drawing.Point(368, 256);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(104, 23);
			this.lblPrice.TabIndex = 18;
			this.lblPrice.Text = "Price";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(472, 256);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.TabIndex = 17;
			this.txtPrice.Text = "50";
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(336, 184);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(104, 23);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Invoice Line Info";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(24, 184);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(104, 23);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "Invoice Header Info";
			// 
			// lblExplenation
			// 
			this.lblExplenation.Location = new System.Drawing.Point(24, 24);
			this.lblExplenation.Name = "lblExplenation";
			this.lblExplenation.Size = new System.Drawing.Size(552, 96);
			this.lblExplenation.TabIndex = 14;
			this.lblExplenation.Text = @"Preconditions:

1. You must run the sample on the SBODemo_US database.
2. Goto Administration->Setup->Financials->G/L Account Determination and fefine relevant accounts:
     A. Payments Advances (General tab)
     B. Down Payment Recievable (press the '...' button near Account Recievable in the General tab)
C. Down Payment Tax Offset Account (Tax tab)
";
			// 
			// lblCardCode
			// 
			this.lblCardCode.Location = new System.Drawing.Point(56, 208);
			this.lblCardCode.Name = "lblCardCode";
			this.lblCardCode.Size = new System.Drawing.Size(104, 23);
			this.lblCardCode.TabIndex = 13;
			this.lblCardCode.Text = "Card Code";
			// 
			// txtCardCode
			// 
			this.txtCardCode.Location = new System.Drawing.Point(160, 208);
			this.txtCardCode.Name = "txtCardCode";
			this.txtCardCode.TabIndex = 12;
			this.txtCardCode.Text = "C20000";
			// 
			// lblQuantity
			// 
			this.lblQuantity.Location = new System.Drawing.Point(368, 232);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(104, 23);
			this.lblQuantity.TabIndex = 11;
			this.lblQuantity.Text = "Quantity";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(472, 232);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.TabIndex = 10;
			this.txtQuantity.Text = "1";
			// 
			// lblDueDate
			// 
			this.lblDueDate.Location = new System.Drawing.Point(56, 232);
			this.lblDueDate.Name = "lblDueDate";
			this.lblDueDate.Size = new System.Drawing.Size(104, 23);
			this.lblDueDate.TabIndex = 9;
			this.lblDueDate.Text = "Due Date";
			// 
			// lblItemCode
			// 
			this.lblItemCode.Location = new System.Drawing.Point(368, 208);
			this.lblItemCode.Name = "lblItemCode";
			this.lblItemCode.Size = new System.Drawing.Size(104, 23);
			this.lblItemCode.TabIndex = 7;
			this.lblItemCode.Text = "Item Code";
			// 
			// txtItemCode
			// 
			this.txtItemCode.Location = new System.Drawing.Point(472, 208);
			this.txtItemCode.Name = "txtItemCode";
			this.txtItemCode.TabIndex = 0;
			this.txtItemCode.Text = "A00001";
			// 
			// grpConn
			// 
			this.grpConn.Controls.Add(this.txtDBPass);
			this.grpConn.Controls.Add(this.txtDBUser);
			this.grpConn.Controls.Add(this.lblPass);
			this.grpConn.Controls.Add(this.label6);
			this.grpConn.Controls.Add(this.cmdGetCompanyList);
			this.grpConn.Controls.Add(this.Label5);
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
			this.grpConn.Size = new System.Drawing.Size(576, 128);
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
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(8, 24);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(104, 23);
			this.Label5.TabIndex = 14;
			this.Label5.Text = "Database Type";
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
			this.cmdConnect.Location = new System.Drawing.Point(472, 88);
			this.cmdConnect.Name = "cmdConnect";
			this.cmdConnect.Size = new System.Drawing.Size(88, 24);
			this.cmdConnect.TabIndex = 12;
			this.cmdConnect.Text = "Connect";
			this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Enabled = false;
			this.txtPassword.Location = new System.Drawing.Point(328, 96);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(88, 20);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.Text = "manager";
			// 
			// txtUSer
			// 
			this.txtUSer.Enabled = false;
			this.txtUSer.Location = new System.Drawing.Point(328, 72);
			this.txtUSer.Name = "txtUSer";
			this.txtUSer.Size = new System.Drawing.Size(88, 20);
			this.txtUSer.TabIndex = 10;
			this.txtUSer.Text = "manager";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(264, 96);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(64, 23);
			this.lblPassword.TabIndex = 9;
			this.lblPassword.Text = "Password";
			// 
			// lblUser
			// 
			this.lblUser.Location = new System.Drawing.Point(264, 72);
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
			this.txtDBPass.Location = new System.Drawing.Point(344, 40);
			this.txtDBPass.Name = "txtDBPass";
			this.txtDBPass.PasswordChar = '*';
			this.txtDBPass.Size = new System.Drawing.Size(72, 20);
			this.txtDBPass.TabIndex = 45;
			this.txtDBPass.Text = "";
			// 
			// txtDBUser
			// 
			this.txtDBUser.Location = new System.Drawing.Point(344, 16);
			this.txtDBUser.Name = "txtDBUser";
			this.txtDBUser.Size = new System.Drawing.Size(72, 20);
			this.txtDBUser.TabIndex = 43;
			this.txtDBUser.Text = "sa";
			// 
			// lblPass
			// 
			this.lblPass.Location = new System.Drawing.Point(264, 40);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(80, 16);
			this.lblPass.TabIndex = 46;
			this.lblPass.Text = "DB Password";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(264, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 44;
			this.label6.Text = "DB Username";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(690, 623);
			this.Controls.Add(this.grpConn);
			this.Controls.Add(this.grpSample);
			this.ForeColor = System.Drawing.Color.Blue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimumSize = new System.Drawing.Size(570, 470);
			this.Name = "frmMain";
			this.Text = "SAP Database Interface Sample";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpSample.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numPercent)).EndInit();
			this.grpConn.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		
		#endregion
		
		public SAPbobsCOM.Documents oDPM;
		
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
			//oCompany = New SAPbobsCOM.Company
			
			//' Init Connection Properties
			//oCompany.Server = "localhost" ' change to your company server
			//oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English ' change to your language
			//oCompany.UseTrusted = True
			
			//Me.Show() ' shows the form while it's loaded...
			
			//'Create a list of companies...
			//oRecordSet = oCompany.GetCompanyList ' get the company list
			
			//oCompany.GetLastError(lErrCode, sErrMsg)
			
			//If lErrCode <> 0 Then
			//    MsgBox(sErrMsg)
			//Else
			//    Do Until oRecordSet.EoF = True
			//        cmbCompany.Items.Add(oRecordSet.Fields.Item(0).Value)
			//        oRecordSet.MoveNext()
			//    Loop
			//End If
			
			//'Select the first company as default
			//If cmbCompany.Items.Count > 0 Then
			//    cmbCompany.SelectedIndex = 0
			//Else
			//    MsgBox("There was no Database Found...", , "Database not found...")
			//    End ' Terminate Application...
			//End If
			
			//If oCompany.Connected Then ' if already connected
			//    Me.Text = Me.Text & ": Connected"
			//    ' Remove the following 2 remark lines if you want to try to connect automatically
			//    'Else
			//    'Connect()
			//End If
			
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
		// This function creates a new Down Payment invoice
		//****************************************************************************
		private void cmdCreateDownPaymentInv_Click (System.Object sender, System.EventArgs e)
		{
			try
			{
				
				//Create DownPayment Invoice Object
				oDPM = (SAPbobsCOM.Documents) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDownPayments);
				
				//Set Down Payment Header Values
				oDPM.CardCode = txtCardCode.Text;
				oDPM.DocDueDate = DateDue.Value;
				oDPM.DownPaymentPercentage = Convert.ToDouble(numPercent.Value);
				
				oDPM.DownPaymentType = SAPbobsCOM.DownPaymentTypeEnum.dptInvoice;
				
				//Set Down Payment Line Values
				oDPM.Lines.ItemCode = txtItemCode.Text;
				oDPM.Lines.Quantity = Convert.ToDouble(txtQuantity.Text);
				oDPM.Lines.Price = Convert.ToDouble(txtPrice.Text);
				
				lRetCode = oDPM.Add(); // Try to add the invoice to the database
				if (lRetCode != 0)
				{
					int temp_int = lErrCode;
					string temp_string = sErrMsg;
					oCompany.GetLastError(out temp_int, out temp_string);
					MessageBox.Show(lErrCode + " " + sErrMsg); // Display error message
				}
				else
				{
					Interaction.MsgBox("Down Payment Invoice Added to DataBase", MsgBoxStyle.Information, "Invoice Added");
					// Enabling the next button in the process
					cmdPayDownPayment.Enabled = true;
					cmdCreateDownPaymentInv.Enabled = false;
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		
		//****************************************************************************
		// This function creates a payment for the DownPayment invoice
		//****************************************************************************
		private void cmdPayDownPayment_Click (System.Object sender, System.EventArgs e)
		{
			
			SAPbobsCOM.Payments InPay;
			string sNewObjCode = "";
			
			string temp_string = sNewObjCode;
			oCompany.GetNewObjectCode(out temp_string);
			sNewObjCode = temp_string;
			InPay = (SAPbobsCOM.Payments) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oIncomingPayments);
			
			int tmpKey;
			tmpKey = Convert.ToInt32(sNewObjCode);

			oDPM.GetByKey(tmpKey);
			
			InPay.CardCode = txtCardCode.Text;
			InPay.DocDate = DateDue.Value;
			InPay.CashAccount = "_SYS00000000002";
			InPay.CashSum = oDPM.DocTotal;
			InPay.Invoices.DocEntry = Convert.ToInt32(sNewObjCode);
			InPay.Invoices.InvoiceType = SAPbobsCOM.BoRcptInvTypes.it_DownPayment;
			
			lRetCode = InPay.Add();
			
			if (lRetCode != 0)
			{
				int temp_int = lErrCode;
				string temp_string2 = sErrMsg;
				oCompany.GetLastError(out temp_int, out temp_string2);
				MessageBox.Show(temp_int + " " + temp_string2); // Display error message
			}
			else
			{
				Interaction.MsgBox("DownPayment Document# " + sNewObjCode + " Paid", MsgBoxStyle.Information, "Payment");
				cmdPayDownPayment.Enabled = false;
				cmdInv.Enabled = true;
			}			
		}
		
		//****************************************************************************
		// This function creates an Invoice that uses the DownPayment
		//****************************************************************************
		private void cmdInv_Click (System.Object sender, System.EventArgs e)
		{
			
			SAPbobsCOM.Documents oInvoice;
			
			// Add invoice
			oInvoice = (SAPbobsCOM.Documents) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices);
			oInvoice.CardCode = txtCardCode.Text;
			oInvoice.DocType = SAPbobsCOM.BoDocumentTypes.dDocument_Items;
			oInvoice.DocDate = DateDue.Value;
			oInvoice.Lines.ItemCode = txtItemCode.Text;
			oInvoice.Lines.Price = Convert.ToDouble(txtPrice.Text);
			oInvoice.Lines.Quantity = Convert.ToDouble(txtQuantity.Text);
			oInvoice.Lines.TaxCode = "PA";
			oInvoice.Lines.VatGroup = "PA";
			
			// Add the Invoice with Down Payment
			SAPbobsCOM.DownPaymentsToDraw dpToDraw;
			
			dpToDraw = oInvoice.DownPaymentsToDraw;
			//dpToDraw.DocEntry = Convert.ToString(oDPM.DocNum)
			dpToDraw.AmountToDraw = oDPM.DownPaymentAmount;
			
			lRetCode = oInvoice.Add();
			
			if (lRetCode != 0)
			{
				int temp_int = lErrCode;
				string temp_string = sErrMsg;
				oCompany.GetLastError(out temp_int, out temp_string);
				MessageBox.Show(lErrCode + " " + sErrMsg); // Display error message
			}
			else
			{
				Interaction.MsgBox("Invoice with Downpayment created, the process of using a downpayment invoice succeeded", MsgBoxStyle.Information, "Invoice Paid");
				cmdInv.Enabled = false;
			}
			
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
