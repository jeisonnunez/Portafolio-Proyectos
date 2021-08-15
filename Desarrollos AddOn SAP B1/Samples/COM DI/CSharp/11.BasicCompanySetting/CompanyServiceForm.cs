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
//  File:      CompanyServiceForm.vb
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
// 1) Updates company properties
// 2) Create a new period
//****************************************************************************



namespace FormWindowTemplateVb
{
	public class CompanyServiceForm : System.Windows.Forms.Form
	{
		
		
		SAPbobsCOM.CompanyService oCompanyService;
		//		int lErrCode;
		//		string sErrMsg;
		
		#region " Windows Form Designer generated code "
		
		public CompanyServiceForm() {
			
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
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.TextBox txtColor;
		internal System.Windows.Forms.TextBox txtAddress;
		internal System.Windows.Forms.TextBox txtPhone;
		internal System.Windows.Forms.TextBox txtEmail;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button cmdUpdate;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.GroupBox groupbox1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtBeginDate;
		internal System.Windows.Forms.TextBox txtPeriodType;
		internal System.Windows.Forms.TextBox txtPeriodName;
		internal System.Windows.Forms.TextBox txtPeriodCode;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.CheckBox chkAutoCreateCard;
		internal System.Windows.Forms.CheckBox chkBlockStock;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.txtName = new System.Windows.Forms.TextBox();
			base.Load += new System.EventHandler(CompanyServiceForm_Load);
			this.txtColor = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.cmdUpdate = new System.Windows.Forms.Button();
			cmdUpdate.Click += new System.EventHandler(cmdUpdate_Click);
			this.Label6 = new System.Windows.Forms.Label();
			this.groupbox1 = new System.Windows.Forms.GroupBox();
			this.txtBeginDate = new System.Windows.Forms.TextBox();
			this.txtPeriodType = new System.Windows.Forms.TextBox();
			this.txtPeriodName = new System.Windows.Forms.TextBox();
			this.txtPeriodCode = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.chkAutoCreateCard = new System.Windows.Forms.CheckBox();
			this.chkBlockStock = new System.Windows.Forms.CheckBox();
			this.groupbox1.SuspendLayout();
			this.SuspendLayout();
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(152, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(128, 20);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "My Company";
			//
			//txtColor
			//
			this.txtColor.Location = new System.Drawing.Point(152, 56);
			this.txtColor.Name = "txtColor";
			this.txtColor.Size = new System.Drawing.Size(128, 20);
			this.txtColor.TabIndex = 1;
			this.txtColor.Text = "8";
			//
			//txtAddress
			//
			this.txtAddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtAddress.Location = new System.Drawing.Point(152, 88);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ReadOnly = true;
			this.txtAddress.Size = new System.Drawing.Size(128, 20);
			this.txtAddress.TabIndex = 2;
			this.txtAddress.Text = "";
			//
			//txtPhone
			//
			this.txtPhone.Location = new System.Drawing.Point(152, 120);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(128, 20);
			this.txtPhone.TabIndex = 3;
			this.txtPhone.Text = "(610) 999-9999";
			//
			//txtEmail
			//
			this.txtEmail.Location = new System.Drawing.Point(152, 152);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(128, 20);
			this.txtEmail.TabIndex = 4;
			this.txtEmail.Text = "MyEMail@oec.com";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 26);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 16);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Company Name";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(24, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(120, 16);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Company Color";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(24, 90);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(120, 16);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Company Address";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(24, 122);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(120, 16);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Phone Number 1";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(24, 154);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(120, 16);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "Company EMail";
			//
			//cmdUpdate
			//
			this.cmdUpdate.Location = new System.Drawing.Point(320, 408);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(120, 24);
			this.cmdUpdate.TabIndex = 10;
			this.cmdUpdate.Text = "Update";
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(24, 186);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(120, 32);
			this.Label6.TabIndex = 11;
			this.Label6.Text = "Auto Create Customer Equipment Card";
			//
			//groupbox1
			//
			this.groupbox1.Controls.Add(this.Label17);
			this.groupbox1.Controls.Add(this.txtBeginDate);
			this.groupbox1.Controls.Add(this.txtPeriodType);
			this.groupbox1.Controls.Add(this.txtPeriodName);
			this.groupbox1.Controls.Add(this.txtPeriodCode);
			this.groupbox1.Controls.Add(this.Label11);
			this.groupbox1.Controls.Add(this.Label10);
			this.groupbox1.Controls.Add(this.Label9);
			this.groupbox1.Controls.Add(this.Label8);
			this.groupbox1.Location = new System.Drawing.Point(24, 264);
			this.groupbox1.Name = "groupbox1";
			this.groupbox1.Size = new System.Drawing.Size(416, 136);
			this.groupbox1.TabIndex = 15;
			this.groupbox1.TabStop = false;
			this.groupbox1.Text = "New Period";
			//
			//txtBeginDate
			//
			this.txtBeginDate.Location = new System.Drawing.Point(136, 96);
			this.txtBeginDate.Name = "txtBeginDate";
			this.txtBeginDate.Size = new System.Drawing.Size(128, 20);
			this.txtBeginDate.TabIndex = 13;
			this.txtBeginDate.Text = "2008-01-01";
			//
			//txtPeriodType
			//
			this.txtPeriodType.Location = new System.Drawing.Point(136, 72);
			this.txtPeriodType.Name = "txtPeriodType";
			this.txtPeriodType.Size = new System.Drawing.Size(128, 20);
			this.txtPeriodType.TabIndex = 12;
			this.txtPeriodType.Text = "0";
			//
			//txtPeriodName
			//
			this.txtPeriodName.Location = new System.Drawing.Point(136, 48);
			this.txtPeriodName.Name = "txtPeriodName";
			this.txtPeriodName.Size = new System.Drawing.Size(128, 20);
			this.txtPeriodName.TabIndex = 11;
			this.txtPeriodName.Text = "My Period Name";
			//
			//txtPeriodCode
			//
			this.txtPeriodCode.Location = new System.Drawing.Point(136, 24);
			this.txtPeriodCode.Name = "txtPeriodCode";
			this.txtPeriodCode.Size = new System.Drawing.Size(128, 20);
			this.txtPeriodCode.TabIndex = 10;
			this.txtPeriodCode.Text = "MyCode";
			//
			//Label11
			//
			this.Label11.Location = new System.Drawing.Point(16, 96);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(104, 32);
			this.Label11.TabIndex = 9;
			this.Label11.Text = "Beginning of Financial Year";
			//
			//Label10
			//
			this.Label10.Location = new System.Drawing.Point(16, 72);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(104, 16);
			this.Label10.TabIndex = 8;
			this.Label10.Text = "Sub Period Type";
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(16, 48);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(96, 16);
			this.Label9.TabIndex = 7;
			this.Label9.Text = "Period Name";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(16, 24);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(120, 16);
			this.Label8.TabIndex = 6;
			this.Label8.Text = "Period Category Code";
			//
			//Label13
			//
			this.Label13.Location = new System.Drawing.Point(24, 120);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(120, 16);
			this.Label13.TabIndex = 8;
			this.Label13.Text = "Phone Number 1";
			//
			//Label14
			//
			this.Label14.Location = new System.Drawing.Point(24, 224);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(104, 24);
			this.Label14.TabIndex = 14;
			this.Label14.Text = "Block Stock Negative Quantity";
			//
			//Label15
			//
			this.Label15.Location = new System.Drawing.Point(24, 152);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(120, 16);
			this.Label15.TabIndex = 9;
			this.Label15.Text = "Company EMail";
			//
			//Label16
			//
			this.Label16.Location = new System.Drawing.Point(24, 184);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(120, 32);
			this.Label16.TabIndex = 11;
			this.Label16.Text = "Auto Create Customer Equipment Card";
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(288, 58);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(72, 16);
			this.Label7.TabIndex = 16;
			this.Label7.Text = "(e.g. Red=8)";
			//
			//Label17
			//
			this.Label17.Location = new System.Drawing.Point(272, 80);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(72, 16);
			this.Label17.TabIndex = 18;
			this.Label17.Text = "(e.g. Year=0)";
			//
			//chkAutoCreateCard
			//
			this.chkAutoCreateCard.Checked = true;
			this.chkAutoCreateCard.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAutoCreateCard.Location = new System.Drawing.Point(152, 192);
			this.chkAutoCreateCard.Name = "chkAutoCreateCard";
			this.chkAutoCreateCard.Size = new System.Drawing.Size(16, 24);
			this.chkAutoCreateCard.TabIndex = 17;
			//
			//chkBlockStock
			//
			this.chkBlockStock.Checked = true;
			this.chkBlockStock.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBlockStock.Location = new System.Drawing.Point(152, 224);
			this.chkBlockStock.Name = "chkBlockStock";
			this.chkBlockStock.Size = new System.Drawing.Size(16, 24);
			this.chkBlockStock.TabIndex = 18;
			//
			//CompanyServiceForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 445);
			this.Controls.Add(this.chkBlockStock);
			this.Controls.Add(this.chkAutoCreateCard);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.groupbox1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.cmdUpdate);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtColor);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.Label13);
			this.Controls.Add(this.Label14);
			this.Controls.Add(this.Label15);
			this.Controls.Add(this.Label16);
			this.Name = "CompanyServiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Company Service";
			this.groupbox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void CompanyServiceForm_Load (System.Object sender, System.EventArgs e)
		{
			
			
			
			
		}
		
		
		//the function is using the company service to updates some of the company
		//properties(name,color,phonenumber..) and to create new period
		private void cmdUpdate_Click (System.Object sender, System.EventArgs e)
		{
			
			CompanyInfo oCompanyInfo;
			AdminInfo oCompanyAdminInfo;
			//			string sAddress;
			PeriodCategory oPeriodCategory;
			
			try
			{
				
				//get company service
				oCompanyService = MainModule.oCompany.GetCompanyService();
				
				//// get admin info
				oCompanyAdminInfo = oCompanyService.GetAdminInfo();
				
				//set company name
				oCompanyAdminInfo.CompanyName = txtName.Text;
				
				//set Company color
				//Sets the number of the background color for active windows
				//(e.g Red=8,Orange=7)
				oCompanyAdminInfo.CompanyColor = System.Convert.ToInt32(txtColor.Text);
				
				//get the company address (read only)
				txtAddress.Text = oCompanyAdminInfo.Address;
				
				//set phone number
				oCompanyAdminInfo.PhoneNumber1 = txtPhone.Text;
				
				//set email
				oCompanyAdminInfo.eMail = txtEmail.Text;
				
				//update the admin info
				oCompanyService.UpdateAdminInfo(oCompanyAdminInfo);
				
				
				//// get company info
				oCompanyInfo = oCompanyService.GetCompanyInfo();
				
				//Auto Create Customer Equipment Card (1=yes ,0=No)
				oCompanyInfo.AutoCreateCustomerEqCard = (SAPbobsCOM.BoYesNoEnum) (Interaction.IIf(chkAutoCreateCard.Checked, 1, 0));
				
				//Block Stock Negative Quantity(1=yes ,0=No)
				oCompanyInfo.BlockStockNegativeQuantity = (SAPbobsCOM.BoYesNoEnum) (Interaction.IIf(chkBlockStock.Checked, 1, 0));
				
				//update the company info
				oCompanyService.UpdateCompanyInfo(oCompanyInfo);
				
				//get period category
				oPeriodCategory = (SAPbobsCOM.PeriodCategory) oCompanyService.GetDataInterface(CompanyServiceDataInterfaces.csdiPeriodCategory);
				
				//set period code
				oPeriodCategory.PeriodCategory = txtPeriodCode.Text;
				
				//set period name
				oPeriodCategory.PeriodName = txtPeriodName.Text;
				
				//set the period type can be year,quater,month or day
				//(e.g. spt_Year=0,spt_quater=1,spt_month=2,spt_days)
				oPeriodCategory.SubPeriodType = (SAPbobsCOM.BoSubPeriodTypeEnum) System.Convert.ToInt32(txtPeriodType.Text);
				
				//set the beginning of Financial Year
				oPeriodCategory.BeginningofFinancialYear = System.Convert.ToDateTime(txtBeginDate.Text);
				
				//create period
				oCompanyService.CreatePeriod(oPeriodCategory);
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		
		
	}
	
}
