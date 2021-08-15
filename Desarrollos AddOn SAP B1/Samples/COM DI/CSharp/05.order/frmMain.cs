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
// In this sample the SAP Business one order form is imitated via DI 2005
//****************************************************************************


namespace ord
{
	public class frmMain : System.Windows.Forms.Form
	{
		
		
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
		internal System.Windows.Forms.GroupBox grpConn;
		internal System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.TextBox txtUSer;
		internal System.Windows.Forms.Label lblPassword;
		internal System.Windows.Forms.Label lblUser;
		internal System.Windows.Forms.ComboBox cmbCompany;
		internal System.Windows.Forms.Label lblCompany;
		internal System.Windows.Forms.Button cmdConnect;
		internal System.Windows.Forms.GroupBox grpOrder;
		internal System.Windows.Forms.ListBox lstCntctCodes;
		internal System.Windows.Forms.ListBox lstPhones;
		internal System.Windows.Forms.ComboBox cmbName;
		internal System.Windows.Forms.ComboBox cmbCustomer;
		internal System.Windows.Forms.Label lblCurrency;
		internal System.Windows.Forms.ComboBox cmbCurrency;
		internal System.Windows.Forms.ComboBox cmbContactPerson;
		internal System.Windows.Forms.DateTimePicker DateDelivery;
		internal System.Windows.Forms.Label lblDeliveryDate;
		internal System.Windows.Forms.DateTimePicker DatePosting;
		internal System.Windows.Forms.Label lblPostingDate;
		internal System.Windows.Forms.TextBox txtNo;
		internal System.Windows.Forms.Label lblNo;
		internal System.Windows.Forms.CheckBox chkManual;
		internal System.Windows.Forms.TextBox txtReference;
		internal System.Windows.Forms.Label lblReference;
		internal System.Windows.Forms.TextBox txtPhone;
		internal System.Windows.Forms.Label lblPhone;
		internal System.Windows.Forms.Label lblContactPerson;
		internal System.Windows.Forms.Label lblName;
		internal System.Windows.Forms.Label lblCustomer;
		internal System.Windows.Forms.Button cmdInvoice;
		internal System.Windows.Forms.Button cmdAddOrder;
		internal System.Windows.Forms.TabControl tabOrder;
		internal System.Windows.Forms.TabPage pageContents;
		internal System.Windows.Forms.ComboBox cmbTax;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label lblItemCode;
		internal System.Windows.Forms.Button cmdAddItem;
		internal System.Windows.Forms.ComboBox cmbItemsDesc;
		internal System.Windows.Forms.ComboBox cmbItemsCode;
		internal System.Windows.Forms.DataGrid DataLines;
		internal System.Windows.Forms.Label lblItemName;
		internal System.Windows.Forms.TabPage pageLogistics;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TabPage pageAccounting;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.Button cmdChoose;
		internal System.Windows.Forms.TextBox txtCcode;
		internal System.Windows.Forms.TextBox txtCName;
		internal System.Windows.Forms.ComboBox cmbDBType;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtDBPass;
		internal System.Windows.Forms.TextBox txtDBUser;
		internal System.Windows.Forms.Label lblPass;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button cmdGetCompanyList;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
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
			this.grpOrder = new System.Windows.Forms.GroupBox();
			this.txtCName = new System.Windows.Forms.TextBox();
			this.txtCcode = new System.Windows.Forms.TextBox();
			this.cmdChoose = new System.Windows.Forms.Button();
			this.cmdInvoice = new System.Windows.Forms.Button();
			this.cmdAddOrder = new System.Windows.Forms.Button();
			this.tabOrder = new System.Windows.Forms.TabControl();
			this.pageContents = new System.Windows.Forms.TabPage();
			this.cmbTax = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblItemCode = new System.Windows.Forms.Label();
			this.cmdAddItem = new System.Windows.Forms.Button();
			this.cmbItemsDesc = new System.Windows.Forms.ComboBox();
			this.cmbItemsCode = new System.Windows.Forms.ComboBox();
			this.DataLines = new System.Windows.Forms.DataGrid();
			this.lblItemName = new System.Windows.Forms.Label();
			this.pageLogistics = new System.Windows.Forms.TabPage();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.pageAccounting = new System.Windows.Forms.TabPage();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.lstCntctCodes = new System.Windows.Forms.ListBox();
			this.lstPhones = new System.Windows.Forms.ListBox();
			this.cmbName = new System.Windows.Forms.ComboBox();
			this.cmbCustomer = new System.Windows.Forms.ComboBox();
			this.lblCurrency = new System.Windows.Forms.Label();
			this.cmbCurrency = new System.Windows.Forms.ComboBox();
			this.cmbContactPerson = new System.Windows.Forms.ComboBox();
			this.DateDelivery = new System.Windows.Forms.DateTimePicker();
			this.lblDeliveryDate = new System.Windows.Forms.Label();
			this.DatePosting = new System.Windows.Forms.DateTimePicker();
			this.lblPostingDate = new System.Windows.Forms.Label();
			this.txtNo = new System.Windows.Forms.TextBox();
			this.lblNo = new System.Windows.Forms.Label();
			this.chkManual = new System.Windows.Forms.CheckBox();
			this.txtReference = new System.Windows.Forms.TextBox();
			this.lblReference = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblContactPerson = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCustomer = new System.Windows.Forms.Label();
			this.txtDBPass = new System.Windows.Forms.TextBox();
			this.txtDBUser = new System.Windows.Forms.TextBox();
			this.lblPass = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.grpConn.SuspendLayout();
			this.grpOrder.SuspendLayout();
			this.tabOrder.SuspendLayout();
			this.pageContents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataLines)).BeginInit();
			this.pageLogistics.SuspendLayout();
			this.pageAccounting.SuspendLayout();
			this.SuspendLayout();
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
			this.grpConn.Size = new System.Drawing.Size(560, 128);
			this.grpConn.TabIndex = 7;
			this.grpConn.TabStop = false;
			this.grpConn.Text = "Connection Properties";
			// 
			// cmdGetCompanyList
			// 
			this.cmdGetCompanyList.Location = new System.Drawing.Point(424, 24);
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
			this.cmdConnect.Location = new System.Drawing.Point(424, 88);
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
			// grpOrder
			// 
			this.grpOrder.Controls.Add(this.txtCName);
			this.grpOrder.Controls.Add(this.txtCcode);
			this.grpOrder.Controls.Add(this.cmdChoose);
			this.grpOrder.Controls.Add(this.cmdInvoice);
			this.grpOrder.Controls.Add(this.cmdAddOrder);
			this.grpOrder.Controls.Add(this.tabOrder);
			this.grpOrder.Controls.Add(this.lstCntctCodes);
			this.grpOrder.Controls.Add(this.lstPhones);
			this.grpOrder.Controls.Add(this.cmbName);
			this.grpOrder.Controls.Add(this.cmbCustomer);
			this.grpOrder.Controls.Add(this.lblCurrency);
			this.grpOrder.Controls.Add(this.cmbCurrency);
			this.grpOrder.Controls.Add(this.cmbContactPerson);
			this.grpOrder.Controls.Add(this.DateDelivery);
			this.grpOrder.Controls.Add(this.lblDeliveryDate);
			this.grpOrder.Controls.Add(this.DatePosting);
			this.grpOrder.Controls.Add(this.lblPostingDate);
			this.grpOrder.Controls.Add(this.txtNo);
			this.grpOrder.Controls.Add(this.lblNo);
			this.grpOrder.Controls.Add(this.chkManual);
			this.grpOrder.Controls.Add(this.txtReference);
			this.grpOrder.Controls.Add(this.lblReference);
			this.grpOrder.Controls.Add(this.txtPhone);
			this.grpOrder.Controls.Add(this.lblPhone);
			this.grpOrder.Controls.Add(this.lblContactPerson);
			this.grpOrder.Controls.Add(this.lblName);
			this.grpOrder.Controls.Add(this.lblCustomer);
			this.grpOrder.Enabled = false;
			this.grpOrder.Location = new System.Drawing.Point(8, 144);
			this.grpOrder.Name = "grpOrder";
			this.grpOrder.Size = new System.Drawing.Size(560, 432);
			this.grpOrder.TabIndex = 43;
			this.grpOrder.TabStop = false;
			this.grpOrder.Text = "Order Details";
			// 
			// txtCName
			// 
			this.txtCName.Enabled = false;
			this.txtCName.Location = new System.Drawing.Point(64, 48);
			this.txtCName.Name = "txtCName";
			this.txtCName.TabIndex = 70;
			this.txtCName.Text = "";
			// 
			// txtCcode
			// 
			this.txtCcode.Enabled = false;
			this.txtCcode.Location = new System.Drawing.Point(64, 24);
			this.txtCcode.Name = "txtCcode";
			this.txtCcode.TabIndex = 69;
			this.txtCcode.Text = "";
			// 
			// cmdChoose
			// 
			this.cmdChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdChoose.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.cmdChoose.Image = ((System.Drawing.Image)(resources.GetObject("cmdChoose.Image")));
			this.cmdChoose.Location = new System.Drawing.Point(176, 24);
			this.cmdChoose.Name = "cmdChoose";
			this.cmdChoose.Size = new System.Drawing.Size(16, 16);
			this.cmdChoose.TabIndex = 67;
			this.cmdChoose.TabStop = false;
			this.cmdChoose.Click += new System.EventHandler(this.cmdChoose_Click);
			// 
			// cmdInvoice
			// 
			this.cmdInvoice.Enabled = false;
			this.cmdInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.cmdInvoice.Location = new System.Drawing.Point(104, 392);
			this.cmdInvoice.Name = "cmdInvoice";
			this.cmdInvoice.Size = new System.Drawing.Size(424, 24);
			this.cmdInvoice.TabIndex = 66;
			this.cmdInvoice.Text = "Add an Invoice based on this Order";
			this.cmdInvoice.Click += new System.EventHandler(this.cmdInvoice_Click);
			// 
			// cmdAddOrder
			// 
			this.cmdAddOrder.Enabled = false;
			this.cmdAddOrder.Location = new System.Drawing.Point(16, 392);
			this.cmdAddOrder.Name = "cmdAddOrder";
			this.cmdAddOrder.TabIndex = 65;
			this.cmdAddOrder.Text = "Add Order";
			this.cmdAddOrder.Click += new System.EventHandler(this.cmdAddOrder_Click);
			// 
			// tabOrder
			// 
			this.tabOrder.Controls.Add(this.pageContents);
			this.tabOrder.Controls.Add(this.pageLogistics);
			this.tabOrder.Controls.Add(this.pageAccounting);
			this.tabOrder.Location = new System.Drawing.Point(8, 160);
			this.tabOrder.Name = "tabOrder";
			this.tabOrder.SelectedIndex = 0;
			this.tabOrder.Size = new System.Drawing.Size(536, 216);
			this.tabOrder.TabIndex = 64;
			// 
			// pageContents
			// 
			this.pageContents.Controls.Add(this.cmbTax);
			this.pageContents.Controls.Add(this.Label1);
			this.pageContents.Controls.Add(this.lblItemCode);
			this.pageContents.Controls.Add(this.cmdAddItem);
			this.pageContents.Controls.Add(this.cmbItemsDesc);
			this.pageContents.Controls.Add(this.cmbItemsCode);
			this.pageContents.Controls.Add(this.DataLines);
			this.pageContents.Controls.Add(this.lblItemName);
			this.pageContents.Location = new System.Drawing.Point(4, 22);
			this.pageContents.Name = "pageContents";
			this.pageContents.Size = new System.Drawing.Size(528, 190);
			this.pageContents.TabIndex = 0;
			this.pageContents.Text = "Contents";
			// 
			// cmbTax
			// 
			this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTax.Location = new System.Drawing.Point(376, 16);
			this.cmbTax.Name = "cmbTax";
			this.cmbTax.Size = new System.Drawing.Size(56, 21);
			this.cmbTax.TabIndex = 46;
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(352, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(24, 20);
			this.Label1.TabIndex = 45;
			this.Label1.Text = "Tax";
			// 
			// lblItemCode
			// 
			this.lblItemCode.Location = new System.Drawing.Point(8, 16);
			this.lblItemCode.Name = "lblItemCode";
			this.lblItemCode.Size = new System.Drawing.Size(32, 20);
			this.lblItemCode.TabIndex = 43;
			this.lblItemCode.Text = "Code";
			// 
			// cmdAddItem
			// 
			this.cmdAddItem.Location = new System.Drawing.Point(448, 16);
			this.cmdAddItem.Name = "cmdAddItem";
			this.cmdAddItem.Size = new System.Drawing.Size(72, 23);
			this.cmdAddItem.TabIndex = 3;
			this.cmdAddItem.Text = "Add Item";
			this.cmdAddItem.Click += new System.EventHandler(this.cmdAddItem_Click);
			// 
			// cmbItemsDesc
			// 
			this.cmbItemsDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbItemsDesc.Location = new System.Drawing.Point(184, 16);
			this.cmbItemsDesc.Name = "cmbItemsDesc";
			this.cmbItemsDesc.Size = new System.Drawing.Size(168, 21);
			this.cmbItemsDesc.TabIndex = 2;
			this.cmbItemsDesc.SelectedIndexChanged += new System.EventHandler(this.cmbItemsDesc_SelectedIndexChanged);
			// 
			// cmbItemsCode
			// 
			this.cmbItemsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbItemsCode.Location = new System.Drawing.Point(40, 16);
			this.cmbItemsCode.Name = "cmbItemsCode";
			this.cmbItemsCode.Size = new System.Drawing.Size(112, 21);
			this.cmbItemsCode.TabIndex = 1;
			this.cmbItemsCode.SelectedIndexChanged += new System.EventHandler(this.cmbItemsCode_SelectedIndexChanged);
			// 
			// DataLines
			// 
			this.DataLines.AllowSorting = false;
			this.DataLines.DataMember = "";
			this.DataLines.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataLines.Location = new System.Drawing.Point(8, 48);
			this.DataLines.Name = "DataLines";
			this.DataLines.Size = new System.Drawing.Size(464, 96);
			this.DataLines.TabIndex = 0;
			this.DataLines.CurrentCellChanged += new System.EventHandler(this.DataLines_CurrentCellChanged);
			// 
			// lblItemName
			// 
			this.lblItemName.Location = new System.Drawing.Point(152, 16);
			this.lblItemName.Name = "lblItemName";
			this.lblItemName.Size = new System.Drawing.Size(40, 20);
			this.lblItemName.TabIndex = 44;
			this.lblItemName.Text = "Name";
			// 
			// pageLogistics
			// 
			this.pageLogistics.Controls.Add(this.PictureBox1);
			this.pageLogistics.Location = new System.Drawing.Point(4, 22);
			this.pageLogistics.Name = "pageLogistics";
			this.pageLogistics.Size = new System.Drawing.Size(528, 190);
			this.pageLogistics.TabIndex = 1;
			this.pageLogistics.Text = "Logistics";
			this.pageLogistics.Visible = false;
			// 
			// PictureBox1
			// 
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(176, 7);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(176, 176);
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			// 
			// pageAccounting
			// 
			this.pageAccounting.Controls.Add(this.PictureBox2);
			this.pageAccounting.Location = new System.Drawing.Point(4, 22);
			this.pageAccounting.Name = "pageAccounting";
			this.pageAccounting.Size = new System.Drawing.Size(528, 190);
			this.pageAccounting.TabIndex = 2;
			this.pageAccounting.Text = "Accounting";
			this.pageAccounting.Visible = false;
			// 
			// PictureBox2
			// 
			this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
			this.PictureBox2.Location = new System.Drawing.Point(176, 7);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(176, 176);
			this.PictureBox2.TabIndex = 1;
			this.PictureBox2.TabStop = false;
			// 
			// lstCntctCodes
			// 
			this.lstCntctCodes.Location = new System.Drawing.Point(416, 24);
			this.lstCntctCodes.Name = "lstCntctCodes";
			this.lstCntctCodes.Size = new System.Drawing.Size(120, 17);
			this.lstCntctCodes.TabIndex = 63;
			this.lstCntctCodes.Visible = false;
			// 
			// lstPhones
			// 
			this.lstPhones.Location = new System.Drawing.Point(416, 48);
			this.lstPhones.Name = "lstPhones";
			this.lstPhones.Size = new System.Drawing.Size(120, 17);
			this.lstPhones.TabIndex = 62;
			this.lstPhones.Visible = false;
			// 
			// cmbName
			// 
			this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName.Location = new System.Drawing.Point(440, 104);
			this.cmbName.Name = "cmbName";
			this.cmbName.Size = new System.Drawing.Size(88, 21);
			this.cmbName.TabIndex = 44;
			this.cmbName.Visible = false;
			this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
			// 
			// cmbCustomer
			// 
			this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCustomer.DropDownWidth = 200;
			this.cmbCustomer.Location = new System.Drawing.Point(440, 80);
			this.cmbCustomer.MaxDropDownItems = 15;
			this.cmbCustomer.Name = "cmbCustomer";
			this.cmbCustomer.Size = new System.Drawing.Size(88, 21);
			this.cmbCustomer.TabIndex = 42;
			this.cmbCustomer.Visible = false;
			this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
			// 
			// lblCurrency
			// 
			this.lblCurrency.Location = new System.Drawing.Point(208, 96);
			this.lblCurrency.Name = "lblCurrency";
			this.lblCurrency.Size = new System.Drawing.Size(80, 23);
			this.lblCurrency.TabIndex = 61;
			this.lblCurrency.Text = "Currency";
			// 
			// cmbCurrency
			// 
			this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCurrency.Location = new System.Drawing.Point(296, 96);
			this.cmbCurrency.Name = "cmbCurrency";
			this.cmbCurrency.Size = new System.Drawing.Size(104, 21);
			this.cmbCurrency.TabIndex = 60;
			// 
			// cmbContactPerson
			// 
			this.cmbContactPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbContactPerson.Location = new System.Drawing.Point(88, 72);
			this.cmbContactPerson.Name = "cmbContactPerson";
			this.cmbContactPerson.Size = new System.Drawing.Size(104, 21);
			this.cmbContactPerson.TabIndex = 46;
			this.cmbContactPerson.SelectedIndexChanged += new System.EventHandler(this.cmbContactPerson_SelectedIndexChanged);
			// 
			// DateDelivery
			// 
			this.DateDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateDelivery.Location = new System.Drawing.Point(296, 72);
			this.DateDelivery.Name = "DateDelivery";
			this.DateDelivery.Size = new System.Drawing.Size(96, 20);
			this.DateDelivery.TabIndex = 59;
			// 
			// lblDeliveryDate
			// 
			this.lblDeliveryDate.Location = new System.Drawing.Point(208, 72);
			this.lblDeliveryDate.Name = "lblDeliveryDate";
			this.lblDeliveryDate.Size = new System.Drawing.Size(80, 23);
			this.lblDeliveryDate.TabIndex = 58;
			this.lblDeliveryDate.Text = "Delivery Date";
			// 
			// DatePosting
			// 
			this.DatePosting.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DatePosting.Location = new System.Drawing.Point(296, 48);
			this.DatePosting.Name = "DatePosting";
			this.DatePosting.Size = new System.Drawing.Size(96, 20);
			this.DatePosting.TabIndex = 57;
			// 
			// lblPostingDate
			// 
			this.lblPostingDate.Location = new System.Drawing.Point(208, 48);
			this.lblPostingDate.Name = "lblPostingDate";
			this.lblPostingDate.Size = new System.Drawing.Size(80, 23);
			this.lblPostingDate.TabIndex = 56;
			this.lblPostingDate.Text = "Posting Date";
			// 
			// txtNo
			// 
			this.txtNo.Enabled = false;
			this.txtNo.Location = new System.Drawing.Point(296, 24);
			this.txtNo.Name = "txtNo";
			this.txtNo.TabIndex = 53;
			this.txtNo.Text = "";
			// 
			// lblNo
			// 
			this.lblNo.Location = new System.Drawing.Point(208, 24);
			this.lblNo.Name = "lblNo";
			this.lblNo.Size = new System.Drawing.Size(24, 23);
			this.lblNo.TabIndex = 52;
			this.lblNo.Text = "No.";
			// 
			// chkManual
			// 
			this.chkManual.Location = new System.Drawing.Point(232, 24);
			this.chkManual.Name = "chkManual";
			this.chkManual.Size = new System.Drawing.Size(64, 24);
			this.chkManual.TabIndex = 51;
			this.chkManual.Text = "Manual";
			this.chkManual.CheckedChanged += new System.EventHandler(this.chkManual_CheckedChanged);
			// 
			// txtReference
			// 
			this.txtReference.Location = new System.Drawing.Point(88, 120);
			this.txtReference.Name = "txtReference";
			this.txtReference.TabIndex = 50;
			this.txtReference.Text = "";
			// 
			// lblReference
			// 
			this.lblReference.Location = new System.Drawing.Point(8, 120);
			this.lblReference.Name = "lblReference";
			this.lblReference.Size = new System.Drawing.Size(88, 23);
			this.lblReference.TabIndex = 49;
			this.lblReference.Text = "Reference";
			// 
			// txtPhone
			// 
			this.txtPhone.Enabled = false;
			this.txtPhone.Location = new System.Drawing.Point(88, 96);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.TabIndex = 48;
			this.txtPhone.Text = "";
			// 
			// lblPhone
			// 
			this.lblPhone.Location = new System.Drawing.Point(8, 96);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(88, 23);
			this.lblPhone.TabIndex = 47;
			this.lblPhone.Text = "Phone";
			// 
			// lblContactPerson
			// 
			this.lblContactPerson.Location = new System.Drawing.Point(8, 72);
			this.lblContactPerson.Name = "lblContactPerson";
			this.lblContactPerson.Size = new System.Drawing.Size(88, 23);
			this.lblContactPerson.TabIndex = 45;
			this.lblContactPerson.Text = "Contact Person";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(8, 48);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(48, 23);
			this.lblName.TabIndex = 43;
			this.lblName.Text = "Name";
			// 
			// lblCustomer
			// 
			this.lblCustomer.Location = new System.Drawing.Point(8, 24);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(56, 23);
			this.lblCustomer.TabIndex = 41;
			this.lblCustomer.Text = "Customer";
			// 
			// txtDBPass
			// 
			this.txtDBPass.Location = new System.Drawing.Point(328, 48);
			this.txtDBPass.Name = "txtDBPass";
			this.txtDBPass.PasswordChar = '*';
			this.txtDBPass.Size = new System.Drawing.Size(72, 20);
			this.txtDBPass.TabIndex = 41;
			this.txtDBPass.Text = "";
			// 
			// txtDBUser
			// 
			this.txtDBUser.Location = new System.Drawing.Point(328, 24);
			this.txtDBUser.Name = "txtDBUser";
			this.txtDBUser.Size = new System.Drawing.Size(72, 20);
			this.txtDBUser.TabIndex = 39;
			this.txtDBUser.Text = "sa";
			// 
			// lblPass
			// 
			this.lblPass.Location = new System.Drawing.Point(248, 48);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(80, 16);
			this.lblPass.TabIndex = 42;
			this.lblPass.Text = "DB Password";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(248, 24);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 16);
			this.Label4.TabIndex = 40;
			this.Label4.Text = "DB Username";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 581);
			this.Controls.Add(this.grpOrder);
			this.Controls.Add(this.grpConn);
			this.ForeColor = System.Drawing.Color.Blue;
			this.MinimumSize = new System.Drawing.Size(570, 470);
			this.Name = "frmMain";
			this.Text = "SAP Database Interface Sample";
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpConn.ResumeLayout(false);
			this.grpOrder.ResumeLayout(false);
			this.tabOrder.ResumeLayout(false);
			this.pageContents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataLines)).EndInit();
			this.pageLogistics.ResumeLayout(false);
			this.pageAccounting.ResumeLayout(false);
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
		// This function creates the data grid
		//****************************************************************************
		private void CreateLinesTable ()
		{
			// Create one DataTable with one column.
			
			OrderApp.TableLines = new DataTable("LinesTable");
			
			DataColumn col1Item = new DataColumn("Item No", Type.GetType("System.String"));
			col1Item.ReadOnly = true;
			DataColumn col2Item = new DataColumn("Item Description", Type.GetType("System.String"));
			col2Item.ReadOnly = true;
			DataColumn col3Item = new DataColumn("Quantity", Type.GetType("System.Double"));
			DataColumn col4Item = new DataColumn("Price", Type.GetType("System.Double"));
			col4Item.ReadOnly = true;
			DataColumn col5Item = new DataColumn("Tax Code", Type.GetType("System.String"));
			col5Item.ReadOnly = true;
			DataColumn col6Item = new DataColumn("Total (LC)", Type.GetType("System.Double"));
			
			OrderApp.TableLines.Columns.Add(col1Item);
			OrderApp.TableLines.Columns.Add(col2Item);
			OrderApp.TableLines.Columns.Add(col3Item);
			OrderApp.TableLines.Columns.Add(col4Item);
			OrderApp.TableLines.Columns.Add(col5Item);
			OrderApp.TableLines.Columns.Add(col6Item);
			
			OrderApp.TableLines.AcceptChanges();
			DataLines.DataSource = OrderApp.TableLines;
			
		}
		
		//****************************************************************************
		// This function connects to the database
		//****************************************************************************
		private void Connect ()
		{
			Cursor = System.Windows.Forms.Cursors.WaitCursor; //Change mouse cursor
			
			// Set connection properties
			OrderApp.oCompany.CompanyDB = cmbCompany.Text;
			OrderApp.oCompany.UserName = txtUSer.Text;
			OrderApp.oCompany.Password = txtPassword.Text;
			
			//Try to connect
			lRetCode = OrderApp.oCompany.Connect();
			
			if (lRetCode != 0) // if the connection failed
			{
				int temp_int = lErrCode;
				string temp_string = sErrMsg;
				OrderApp.oCompany.GetLastError(out temp_int, out temp_string);
				Interaction.MsgBox("Connection Failed - " + sErrMsg, MsgBoxStyle.Exclamation, "Default Connection Failed");
			}
			if (OrderApp.oCompany.Connected) // if connected
			{
				this.Text = this.Text + " - Connected to " + OrderApp.oCompany.CompanyDB;
				grpConn.Enabled = false;
				grpOrder.Enabled = true;
				LoadGui(); // Load data for UI elements like combo boxes
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
		// This function adds an order to the database
		//****************************************************************************
		private void AddOrderToDatabase ()
		{
			
			// Init the Order object
			OrderApp.oOrder = (SAPbobsCOM.Documents) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders);
			
			SAPbobsCOM.SBObob oBob;
			
			// set properties of the Order object
			OrderApp.oOrder.CardCode = cmbCustomer.Text;
			OrderApp.oOrder.CardName = cmbName.Text;
			if (lstCntctCodes.Items.Count > 0)
			{
				OrderApp.oOrder.ContactPersonCode = System.Convert.ToInt32(lstCntctCodes.Items[lstCntctCodes.SelectedIndex]);
			}
			OrderApp.oOrder.NumAtCard = txtReference.Text;
			if (chkManual.Checked)
			{
				OrderApp.oOrder.HandWritten = SAPbobsCOM.BoYesNoEnum.tYES;
			}
			else
			{
				OrderApp.oOrder.HandWritten = SAPbobsCOM.BoYesNoEnum.tNO;
			}
			OrderApp.oOrder.DocNum = System.Convert.ToInt32(txtNo.Text);
			OrderApp.oOrder.DocDate = DatePosting.Value;
			OrderApp.oOrder.DocDueDate = DateDelivery.Value;
			OrderApp.oOrder.DocCurrency = cmbCurrency.Items[cmbCurrency.SelectedIndex].ToString();
			
			OrderApp.TableLines.AcceptChanges(); // Update the lines table
			
			// Add lines to the Orer object from the table
			int i;
			i = 0;
			
			do
			{
				OrderApp.oOrder.Lines.ItemCode = OrderApp.TableLines.Rows[i][0].ToString();
				OrderApp.oOrder.Lines.ItemDescription = OrderApp.TableLines.Rows[i][1].ToString();
				OrderApp.oOrder.Lines.Quantity = System.Convert.ToDouble(OrderApp.TableLines.Rows[i][2]);
				OrderApp.oOrder.Lines.Price = System.Convert.ToDouble(OrderApp.TableLines.Rows[i][3]);
				OrderApp.oOrder.Lines.TaxCode = OrderApp.TableLines.Rows[i][4].ToString();
				OrderApp.oOrder.Lines.LineTotal = System.Convert.ToDouble(OrderApp.TableLines.Rows[i][5]);
				i += 1;
				if (i != OrderApp.TableLines.Rows.Count)
				{
					OrderApp.oOrder.Lines.Add();
				}
			} while (!(i == OrderApp.TableLines.Rows.Count));
			
			lRetCode = OrderApp.oOrder.Add(); // Try to add the orer to the database
			if (lRetCode != 0)
			{
				int temp_int = lErrCode;
				string temp_string = sErrMsg;
				OrderApp.oCompany.GetLastError(out temp_int, out temp_string);
				if (lErrCode != - 4006) // Incase adding an order failed
				{
					MessageBox.Show(lErrCode + " " + sErrMsg); // Display error message
				}
				else // If the currency Exchange is not set
				{
					double dCur;
					object sCur;
					sCur = Interaction.InputBox("Currency Exchange - exchange rate has not been set for today. set the exchange rate", "Currency Exchange Setting", "", -1, -1);
					if (Information.IsNumeric(sCur))
					{
						dCur = System.Convert.ToDouble(sCur);
						oBob = (SAPbobsCOM.SBObob) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
						//Update Currency rate
						oBob.SetCurrencyRate(cmbCurrency.Text, DateAndTime.Today, dCur, false);
					}
					else
					{
						Interaction.MsgBox("Invalid Value to Currency Exchange", MsgBoxStyle.Exclamation, "Invalid Value");
					}
				}
			}
			else
			{
				cmdInvoice.Enabled = true; // Enable the "Make Invoice On Order" button
				Interaction.MsgBox("Order Added to DataBase", MsgBoxStyle.Information, "Order Added");
			}
		}
		
		//****************************************************************************
		// This function loads data for UI elements like combo boxes
		//****************************************************************************
		private void LoadGui ()
		{
			SAPbobsCOM.SBObob oObj;
			SAPbobsCOM.Recordset rs;
			//			string strResult;
			//			string errResult;
			
			oObj = (SAPbobsCOM.SBObob) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
			rs = (SAPbobsCOM.Recordset) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			
			// Set the Customer Name and Customer Code Combo Boxes
			rs = oObj.GetBPList(SAPbobsCOM.BoCardTypes.cCustomer);
			rs.MoveFirst();
			while (!(rs.EoF))
			{
				cmbCustomer.Items.Add(rs.Fields.Item(0).Value);
				cmbName.Items.Add(rs.Fields.Item(1).Value);
				rs.MoveNext();
			}
			if (cmbCustomer.Items.Count > 0)
			{
				cmbCustomer.SelectedIndex = 0;
				cmbName.SelectedIndex = 0;
				LoadContactInfo();
			}
			txtCcode.Text = cmbCustomer.Text;
			txtCName.Text = cmbName.Text;
			
			
			// Create the next Order number
			string sSQL = "SELECT TOP 1 DocNum FROM dbo.ORDR ORDER BY DocNum DESC";
			rs = (SAPbobsCOM.Recordset) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			rs.DoQuery(sSQL);
			while (!(rs.EoF))
			{
				txtNo.Text = System.Convert.ToInt32(rs.Fields.Item(0).Value) + 1.ToString();
				rs.MoveNext();
			}
			
			//Load All items names and codes to combo boxes
			sSQL = "SELECT ItemCode, ItemName FROM OITM";
			
			rs = (SAPbobsCOM.Recordset) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			rs.DoQuery(sSQL);
			while (!(rs.EoF))
			{
				cmbItemsCode.Items.Add(rs.Fields.Item(0).Value);
				cmbItemsDesc.Items.Add(rs.Fields.Item(1).Value);
				rs.MoveNext();
			}
			cmbItemsCode.SelectedIndex = 0;
			cmbItemsDesc.SelectedIndex = 0;
			
			//Load Tax Codes to cmbTax combo box
			sSQL = "SELECT Code FROM OSTC";
			
			rs = (SAPbobsCOM.Recordset) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			rs.DoQuery(sSQL);
			while (!(rs.EoF))
			{
				cmbTax.Items.Add(rs.Fields.Item(0).Value);
				rs.MoveNext();
			}
			cmbTax.SelectedIndex = 0;
			
			// Currency Comobox
			sSQL = "SELECT CurrCode FROM OCRN";
			
			rs = (SAPbobsCOM.Recordset) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			rs.DoQuery(sSQL);
			while (!(rs.EoF))
			{
				cmbCurrency.Items.Add(rs.Fields.Item(0).Value);
				rs.MoveNext();
			}
			cmbCurrency.SelectedIndex = cmbCurrency.Items.Count - 1;
		}
		
		//****************************************************************************
		// This function undates the contact info by the current customer
		//****************************************************************************
		private void LoadContactInfo ()
		{
			SAPbobsCOM.Recordset rs;
			rs = (SAPbobsCOM.Recordset) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			
			rs.DoQuery("SELECT CntctCode, Name, Tel1 FROM OCPR WHERE CardCode = \'" + cmbCustomer.Text + "\'");
			
			// Clear old contact information
			lstCntctCodes.Items.Clear();
			cmbContactPerson.Items.Clear();
			lstPhones.Items.Clear();
			
			// Load new contact information
			while (!(rs.EoF))
			{
				lstCntctCodes.Items.Add(rs.Fields.Item(0).Value);
				cmbContactPerson.Items.Add(rs.Fields.Item(1).Value);
				lstPhones.Items.Add(rs.Fields.Item(2).Value);
				rs.MoveNext();
			}
			
			// Set the default contact
			if (cmbContactPerson.Items.Count > 0)
			{
				lstCntctCodes.SelectedIndex = 0;
				lstPhones.SelectedIndex = 0;
				txtPhone.Text = lstPhones.Items[0].ToString();
				cmbContactPerson.SelectedIndex = 0;
			}
		}
		
		//****************************************************************************
		// This function is called whenever the form is resized.
		// It moves GUI elements accordingly
		//****************************************************************************
		private void frmMain_Resize (object sender, System.EventArgs e)
		{
			tabOrder.Width = this.Width - 40;
			tabOrder.Height = this.Height - tabOrder.Top - cmdAddOrder.Height - 160;
			
			DataLines.Width = tabOrder.Width - 20;
			DataLines.Height = tabOrder.Height - 80;
			
			cmdAddOrder.Top = grpOrder.Height - cmdAddOrder.Height - 10;
			cmdInvoice.Top = grpOrder.Height - cmdAddOrder.Height - 10;
			
			grpOrder.Width = this.Width - grpOrder.Left - 15;
			grpOrder.Height = this.Height - grpOrder.Top - 30;
			
		}
		
		//****************************************************************************
		// This function adds an item in the GUI table
		// It is not updated in the database yet
		//****************************************************************************
		private void AddItemToOrder ()
		{
			SAPbobsCOM.SBObob oSBObob;
			
			DataRow NewRow;
			// Get an initialized SBObob object
			oSBObob = (SAPbobsCOM.SBObob) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
			
			NewRow = OrderApp.TableLines.NewRow();
			NewRow[0] = cmbItemsCode.Text;
			NewRow[1] = cmbItemsDesc.Text;
			NewRow[2] = "1";
			OrderApp.oRecordSet = oSBObob.GetItemPrice(cmbCustomer.Text, cmbItemsCode.Text, 1F, DatePosting.Value);
			NewRow[3] = OrderApp.oRecordSet.Fields.Item(0).Value;
			NewRow[4] = cmbTax.Text;
			NewRow[5] = 1 * System.Convert.ToInt32(OrderApp.oRecordSet.Fields.Item(0).Value);
			OrderApp.TableLines.Rows.Add(NewRow);
			cmdAddOrder.Enabled = true;
		}
		
		//****************************************************************************
		// This procedure adds an invoice to the database
		//****************************************************************************
		private void CreateInvoice ()
		{
			//  init the invoice object
			OrderApp.oInvoice = ( ( SAPbobsCOM.Documents )( OrderApp.oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oInvoices ) ) ); 
			OrderApp.oInvoice.CardCode = cmbCustomer.Text; 
            
			string sNewObjCode = null; 
			int i = 0; 
			//  Get last added document number (the order that was added)
			OrderApp.oCompany.GetNewObjectCode( out sNewObjCode ); 
            
			//  this loop adds the different items to the invoice object
			i = 0; 
			do 
			{ 
				OrderApp.oInvoice.Lines.BaseEntry = System.Convert.ToInt32( double.Parse( sNewObjCode ) ); 
				OrderApp.oInvoice.Lines.BaseLine = i; 
				OrderApp.oInvoice.Lines.BaseType = System.Convert.ToInt32( SAPbobsCOM.BoObjectTypes.oOrders ); 
				OrderApp.oInvoice.Lines.TaxCode = System.Convert.ToString( OrderApp.TableLines.Rows[ i ][ 4 ] ); 
				i += 1; 
				if ( i != OrderApp.TableLines.Rows.Count ) 
				{ 
					OrderApp.oInvoice.Lines.Add(); 
				} 
			} 
			while (  ! ( i == OrderApp.TableLines.Rows.Count ) ); 
            
			//  Try to add the invoice object to the database
			lRetCode = OrderApp.oInvoice.Add(); 
			if ( lRetCode != 0 ) 
			{ //  If the addition failed
				OrderApp.oCompany.GetLastError( out lErrCode, out sErrMsg ); 
				Interaction.MsgBox( lErrCode + " " + sErrMsg, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); //  Display error message
			} 
			else 
			{ 
				cmdInvoice.Enabled = true; 
				Interaction.MsgBox( "inv Added to DataBase", MsgBoxStyle.Information, "Order Added" ); 
			} 
		}
		
		//****************************************************************************
		// This procedure opens a form that shows the customer list
		//****************************************************************************
		private void cmdChoose_Click (System.Object sender, System.EventArgs e)
		{
			SelectCustomer f;
			
			f = new SelectCustomer();
			f.ShowDialog();
			txtCcode.Text = f.BPCode;
			txtCName.Text = f.BPName;
			cmbCustomer.SelectedIndex = f.iSelectedIndex;
			cmbName.SelectedIndex = f.iSelectedIndex;
			f = null;
		}
		
		//****************************************************************************
		// This function is called when the "Add Order" button is clicked
		//****************************************************************************
		private void cmdAddOrder_Click (System.Object sender, System.EventArgs e)
		{
			AddOrderToDatabase();
		}
		
		//****************************************************************************
		// Called AddItemToOrder
		//****************************************************************************
		private void cmdAddItem_Click (System.Object sender, System.EventArgs e)
		{
			AddItemToOrder();
		}
		
		//****************************************************************************
		// This function displays the current contact person phone number
		//****************************************************************************
		private void cmbContactPerson_SelectedIndexChanged (System.Object sender, System.EventArgs e)
		{
			lstPhones.SelectedIndex = cmbContactPerson.SelectedIndex;
			lstCntctCodes.SelectedIndex = cmbContactPerson.SelectedIndex;
			txtPhone.Text = lstPhones.Items[lstPhones.SelectedIndex].ToString();
		}
		
		//****************************************************************************
		// Keeps the item code and description syncronized
		//****************************************************************************
		private void cmbItemsCode_SelectedIndexChanged (System.Object sender, System.EventArgs e)
		{
			cmbItemsDesc.SelectedIndex = cmbItemsCode.SelectedIndex;
		}
		
		//****************************************************************************
		// Keeps the item code and description syncronized
		//****************************************************************************
		private void cmbItemsDesc_SelectedIndexChanged (System.Object sender, System.EventArgs e)
		{
			cmbItemsCode.SelectedIndex = cmbItemsDesc.SelectedIndex;
		}
		
		//****************************************************************************
		// This function uses the cell-change event of the data drid
		// to calculate the total sum for the item
		//****************************************************************************
		private void DataLines_CurrentCellChanged (object sender, System.EventArgs e)
		{
			//On Error Resume Next  - Cannot Convert to CSharp
			
			if (OrderApp.TableLines.Rows.Count > DataLines.CurrentRowIndex)
			{
				OrderApp.TableLines.Rows[DataLines.CurrentRowIndex][5] = System.Convert.ToInt32(OrderApp.TableLines.Rows[DataLines.CurrentRowIndex][3] )*System.Convert.ToInt32( OrderApp.TableLines.Rows[DataLines.CurrentRowIndex][2]);
				OrderApp.TableLines.AcceptChanges();
			}
			else
			{
				cmbItemsCode.Focus();
			}
		}
		
		//****************************************************************************
		// This function is called when the "Manual" checkbox is changed
		//****************************************************************************
		private void chkManual_CheckedChanged (System.Object sender, System.EventArgs e)
		{
			txtNo.Enabled = !(txtNo.Enabled);
		}
		
		//****************************************************************************
		// This function is called when the user chooses a different customer
		//****************************************************************************
		private void cmbCustomer_SelectedIndexChanged (System.Object sender, System.EventArgs e)
		{
			cmbName.SelectedIndex = cmbCustomer.SelectedIndex;
			LoadContactInfo();
		}
		
		//****************************************************************************
		// This function is called when the user chooses a different customer
		//****************************************************************************
		private void cmbName_SelectedIndexChanged (System.Object sender, System.EventArgs e)
		{
			cmbCustomer.SelectedIndex = cmbName.SelectedIndex;
			LoadContactInfo();
		}
		
		//****************************************************************************
		// This function is called when the user clicks the "Add Invoice" button
		//****************************************************************************
		private void cmdInvoice_Click (System.Object sender, System.EventArgs e)
		{
			cmdInvoice.Enabled = false;
			CreateInvoice(); // Adds invoice to database
		}
		
		private void cmdGetCompanyList_Click (System.Object sender, System.EventArgs e)
		{
			OrderApp.oCompany = new SAPbobsCOM.Company();
			
			// Init Connection Properties
			OrderApp.oCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes) (cmbDBType.SelectedIndex + 1);
			OrderApp.oCompany.Server = "localhost"; // change to your company server
			OrderApp.oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English; // change to your language
			OrderApp.oCompany.UseTrusted = false;
			OrderApp.oCompany.DbUserName = txtDBUser.Text;
			OrderApp.oCompany.DbPassword = txtDBPass.Text;
			
			//Me.Show() ' shows the form while it's loaded...
			
			//Create a list of companies...
			try
			{
				OrderApp.oRecordSet = OrderApp.oCompany.GetCompanyList(); // get the company list
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			
			int temp_int = lErrCode;
			string temp_string = sErrMsg;
			OrderApp.oCompany.GetLastError(out temp_int, out temp_string);
			
			if (lErrCode != 0)
			{
				MessageBox.Show(sErrMsg);
			}
			else
			{
				while (!(OrderApp.oRecordSet.EoF == true))
				{
					cmbCompany.Items.Add(OrderApp.oRecordSet.Fields.Item(0).Value);
					OrderApp.oRecordSet.MoveNext();
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
			
			if (OrderApp.oCompany.Connected) // if already connected
			{
				this.Text = this.Text + ": Connected";
				// Remove the following 2 remark lines if you want to try to connect automatically
				//Else
				//Connect()
			}
			CreateLinesTable();
			
		}
	}
	
}
