using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using SAPbobsCOM;

//  SAP DI API 2006 SDK Sample
//****************************************************************************
//
//  File:      AccountServiceForm.vb
//
//  Copyright (c) SAP
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************

//****************************************************************************
//
// Description:
// ------------
// Creates new balances for accounts
//
//****************************************************************************

namespace FormWindowTemplateVb
{
	public class AccountServiceForm : System.Windows.Forms.Form
	{
		
		
		SAPbobsCOM.AccountsService oAccountsService;
		//		int lErrCode;
		//		string sErrMsg;
		
		#region " Windows Form Designer generated code "
		
		public AccountServiceForm() {
			
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
		internal System.Windows.Forms.Button cmdCreateBalance;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label lbl1;
		internal System.Windows.Forms.TextBox txtOpenBalanceDetails;
		internal System.Windows.Forms.TextBox txtRef2;
		internal System.Windows.Forms.TextBox txtRef1;
		internal System.Windows.Forms.TextBox txtOpenBalenceDate;
		internal System.Windows.Forms.TextBox txtOpenBalanceAcc;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txtSecondAcctCredit;
		internal System.Windows.Forms.TextBox txtSecondAcctName;
		internal System.Windows.Forms.TextBox txtFirstAcctCredit;
		internal System.Windows.Forms.TextBox txtFirstAcctName;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdCreateBalance = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(AccountServiceForm_Load);
			cmdCreateBalance.Click += new System.EventHandler(cmdCreateBalance_Click);
			this.txtOpenBalanceDetails = new System.Windows.Forms.TextBox();
			this.txtRef2 = new System.Windows.Forms.TextBox();
			this.txtRef1 = new System.Windows.Forms.TextBox();
			this.txtOpenBalenceDate = new System.Windows.Forms.TextBox();
			this.txtOpenBalanceAcc = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSecondAcctCredit = new System.Windows.Forms.TextBox();
			this.txtSecondAcctName = new System.Windows.Forms.TextBox();
			this.txtFirstAcctCredit = new System.Windows.Forms.TextBox();
			this.txtFirstAcctName = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdCreateBalance
			//
			this.cmdCreateBalance.Location = new System.Drawing.Point(256, 360);
			this.cmdCreateBalance.Name = "cmdCreateBalance";
			this.cmdCreateBalance.Size = new System.Drawing.Size(120, 24);
			this.cmdCreateBalance.TabIndex = 0;
			this.cmdCreateBalance.Text = "Create Balance";
			//
			//txtOpenBalanceDetails
			//
			this.txtOpenBalanceDetails.Location = new System.Drawing.Point(168, 144);
			this.txtOpenBalanceDetails.Name = "txtOpenBalanceDetails";
			this.txtOpenBalanceDetails.Size = new System.Drawing.Size(200, 20);
			this.txtOpenBalanceDetails.TabIndex = 19;
			this.txtOpenBalanceDetails.Text = "G/L Accounts Opening Balance";
			//
			//txtRef2
			//
			this.txtRef2.Location = new System.Drawing.Point(168, 112);
			this.txtRef2.Name = "txtRef2";
			this.txtRef2.Size = new System.Drawing.Size(200, 20);
			this.txtRef2.TabIndex = 13;
			this.txtRef2.Text = "Ref 2";
			//
			//txtRef1
			//
			this.txtRef1.Location = new System.Drawing.Point(168, 80);
			this.txtRef1.Name = "txtRef1";
			this.txtRef1.Size = new System.Drawing.Size(200, 20);
			this.txtRef1.TabIndex = 12;
			this.txtRef1.Text = "Ref 1";
			//
			//txtOpenBalenceDate
			//
			this.txtOpenBalenceDate.Location = new System.Drawing.Point(168, 48);
			this.txtOpenBalenceDate.Name = "txtOpenBalenceDate";
			this.txtOpenBalenceDate.Size = new System.Drawing.Size(200, 20);
			this.txtOpenBalenceDate.TabIndex = 11;
			this.txtOpenBalenceDate.Text = "";
			//
			//txtOpenBalanceAcc
			//
			this.txtOpenBalanceAcc.Location = new System.Drawing.Point(168, 16);
			this.txtOpenBalanceAcc.Name = "txtOpenBalanceAcc";
			this.txtOpenBalanceAcc.Size = new System.Drawing.Size(200, 20);
			this.txtOpenBalanceAcc.TabIndex = 10;
			this.txtOpenBalanceAcc.Text = "Common Stock (HO, USA, GA )";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(24, 144);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(104, 16);
			this.Label5.TabIndex = 18;
			this.Label5.Text = "Details";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(24, 112);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(104, 16);
			this.Label4.TabIndex = 17;
			this.Label4.Text = "Ref2";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(24, 80);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(104, 16);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Ref1";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(24, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(104, 16);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "Date";
			//
			//lbl1
			//
			this.lbl1.Location = new System.Drawing.Point(24, 16);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(144, 24);
			this.lbl1.TabIndex = 14;
			this.lbl1.Text = "Openning Balance Account";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.txtSecondAcctCredit);
			this.GroupBox1.Controls.Add(this.txtSecondAcctName);
			this.GroupBox1.Controls.Add(this.txtFirstAcctCredit);
			this.GroupBox1.Controls.Add(this.txtFirstAcctName);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Location = new System.Drawing.Point(8, 184);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(368, 168);
			this.GroupBox1.TabIndex = 29;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Accounts For Credit";
			//
			//txtSecondAcctCredit
			//
			this.txtSecondAcctCredit.Location = new System.Drawing.Point(128, 122);
			this.txtSecondAcctCredit.Name = "txtSecondAcctCredit";
			this.txtSecondAcctCredit.Size = new System.Drawing.Size(224, 20);
			this.txtSecondAcctCredit.TabIndex = 36;
			this.txtSecondAcctCredit.Text = "300";
			//
			//txtSecondAcctName
			//
			this.txtSecondAcctName.Location = new System.Drawing.Point(128, 90);
			this.txtSecondAcctName.Name = "txtSecondAcctName";
			this.txtSecondAcctName.Size = new System.Drawing.Size(224, 20);
			this.txtSecondAcctName.TabIndex = 35;
			this.txtSecondAcctName.Text = "Sales Revenues - Foreign (HO, USA, GA )";
			//
			//txtFirstAcctCredit
			//
			this.txtFirstAcctCredit.Location = new System.Drawing.Point(128, 58);
			this.txtFirstAcctCredit.Name = "txtFirstAcctCredit";
			this.txtFirstAcctCredit.Size = new System.Drawing.Size(224, 20);
			this.txtFirstAcctCredit.TabIndex = 34;
			this.txtFirstAcctCredit.Text = "300";
			//
			//txtFirstAcctName
			//
			this.txtFirstAcctName.Location = new System.Drawing.Point(128, 26);
			this.txtFirstAcctName.Name = "txtFirstAcctName";
			this.txtFirstAcctName.Size = new System.Drawing.Size(224, 20);
			this.txtFirstAcctName.TabIndex = 33;
			this.txtFirstAcctName.Text = "Sales Revenues - Services (HO, USA, GA )";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(12, 122);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 18);
			this.Label1.TabIndex = 32;
			this.Label1.Text = "Second Account Credit";
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(12, 90);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(120, 18);
			this.Label6.TabIndex = 31;
			this.Label6.Text = "Second Account Name";
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(12, 58);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(104, 18);
			this.Label7.TabIndex = 30;
			this.Label7.Text = "First Account Credit";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(12, 26);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(104, 16);
			this.Label8.TabIndex = 29;
			this.Label8.Text = "First Account Name";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//AccountServiceForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 397);
			this.Controls.Add(this.txtOpenBalanceDetails);
			this.Controls.Add(this.txtRef2);
			this.Controls.Add(this.txtRef1);
			this.Controls.Add(this.txtOpenBalenceDate);
			this.Controls.Add(this.txtOpenBalanceAcc);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.cmdCreateBalance);
			this.Controls.Add(this.GroupBox1);
			this.Name = "AccountServiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Account Service - Create Open Balance";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		
		
		private void AccountServiceForm_Load (System.Object sender, System.EventArgs e)
		{
			
			//set the current date
			txtOpenBalenceDate.Text = DateTime.Today.ToString();
			
		}
		
		// the function gets an opening balance account and crediting the two account
		// with the credit amount
		private void cmdCreateBalance_Click (System.Object sender, System.EventArgs e)
		{
			
			
			SAPbobsCOM.OpenningBalanceAccount oOpenningBalanceAccount;
			SAPbobsCOM.GLAccounts oGLAccounts;
			SAPbobsCOM.GLAccount oGLAccountFirst;
			SAPbobsCOM.GLAccount oGLAccountSecond;
			
			
			try
			{
				//get company service
				MainModule.oCmpSrv = MainModule.oCompany.GetCompanyService();
				
				//get account service
				oAccountsService = (SAPbobsCOM.AccountsService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.AccountsService);
				
				//get Accounts Service Data Interface
				oOpenningBalanceAccount = (SAPbobsCOM.OpenningBalanceAccount) oAccountsService.GetDataInterface(AccountsServiceDataInterfaces.asdiOpenningBalanceAccount);
				
				//set the account number for the opening balance account
				oOpenningBalanceAccount.OpenBalanceAccount = GetAccountCode(txtOpenBalanceAcc.Text);
				
				//set the details
				oOpenningBalanceAccount.Details = txtOpenBalanceDetails.Text;
				
				//set the date
				oOpenningBalanceAccount.Date = System.Convert.ToDateTime(txtOpenBalenceDate.Text);
				
				//get ref to GlAccounts
				oGLAccounts = (SAPbobsCOM.GLAccounts) oAccountsService.GetDataInterface(AccountsServiceDataInterfaces.asdiGLAccounts);
				
				//add accounts that will be in credit or in debit
				//add first account
				oGLAccountFirst = oGLAccounts.Add();
				//set the account code
				oGLAccountFirst.Code = GetAccountCode(txtFirstAcctName.Text);
				//set credit amount
				oGLAccountFirst.Credit = System.Convert.ToDouble(txtFirstAcctCredit.Text);
				
				//add second account
				oGLAccountSecond = oGLAccounts.Add();
				//set the account code
				oGLAccountSecond.Code = GetAccountCode(txtSecondAcctName.Text);
				//set credit amount
				oGLAccountSecond.Credit = System.Convert.ToDouble(txtSecondAcctCredit.Text);
				
				//create the balance for the first and second accounts from the Openning Balance Account
				oAccountsService.CreateOpenBalance(oOpenningBalanceAccount, oGLAccounts);
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		
		//getting the name of the account and retrieving the account code
		private string GetAccountCode(string sAccountName)
		{
			
			SAPbobsCOM.ChartOfAccounts oChartOfAccounts;
			//			bool bFreeBudget;
			SAPbobsCOM.Recordset oRecordset;
			
			try
			{
				
				
				//get a record set
				oRecordset = (SAPbobsCOM.Recordset) MainModule.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				
				//get ref tp chart of accounts
				oChartOfAccounts = (SAPbobsCOM.ChartOfAccounts) MainModule.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oChartOfAccounts);
				
				//get all accounts
				oRecordset.DoQuery("SELECT * FROM OACT");
				
				//set the record set
				oChartOfAccounts.Browser.Recordset = oRecordset;
				
				oChartOfAccounts.Browser.MoveFirst();
				
				//find account by name
				while (oChartOfAccounts.Browser.EoF == false)
				{
					if (oChartOfAccounts.Name == sAccountName)
					{
						break;
					}
					oChartOfAccounts.Browser.MoveNext();
				}
				
				//return the User Code
				return oChartOfAccounts.Code;
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return "";
		}
		
		
	}
	
}
