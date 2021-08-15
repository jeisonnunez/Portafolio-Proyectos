using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

//  SAP DI API 2006 SDK Sample
//****************************************************************************
//
//  File:      LogInForm.vb
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
// Log In to Company
//
//****************************************************************************

namespace FormWindowTemplateVb
{
	public class LogInForm : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public LogInForm() {
			
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
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txtPort;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtLicenseServer;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtCompanyPassword;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtCompanyUserName;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtDataBasePassword;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtDataBaseUserName;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtDataBaseName;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtDataBaseServer;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button cmdLogInComp;
		internal System.Windows.Forms.ComboBox cmbDBType;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			base.Load += new System.EventHandler(LogInForm_Load);
			this.txtPort = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.txtLicenseServer = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtCompanyPassword = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtCompanyUserName = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtDataBasePassword = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtDataBaseUserName = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtDataBaseName = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtDataBaseServer = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmdLogInComp = new System.Windows.Forms.Button();
			cmdLogInComp.Click += new System.EventHandler(cmdLogInComp_Click);
			this.cmbDBType = new System.Windows.Forms.ComboBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.cmbDBType);
			this.GroupBox1.Controls.Add(this.txtPort);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.txtLicenseServer);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.txtCompanyPassword);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.txtCompanyUserName);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.txtDataBasePassword);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtDataBaseUserName);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtDataBaseName);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtDataBaseServer);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(24, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(456, 216);
			this.GroupBox1.TabIndex = 67;
			this.GroupBox1.TabStop = false;
			//
			//txtPort
			//
			this.txtPort.Location = new System.Drawing.Point(344, 40);
			this.txtPort.Name = "txtPort";
			this.txtPort.TabIndex = 65;
			this.txtPort.Text = "30000";
			//
			//Label10
			//
			this.Label10.Location = new System.Drawing.Point(256, 40);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(56, 16);
			this.Label10.TabIndex = 64;
			this.Label10.Text = "Port";
			//
			//txtLicenseServer
			//
			this.txtLicenseServer.Location = new System.Drawing.Point(344, 16);
			this.txtLicenseServer.Name = "txtLicenseServer";
			this.txtLicenseServer.TabIndex = 61;
			this.txtLicenseServer.Text = "ILTLVH111";
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(256, 16);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(80, 16);
			this.Label9.TabIndex = 60;
			this.Label9.Text = "License Server";
			//
			//txtCompanyPassword
			//
			this.txtCompanyPassword.Location = new System.Drawing.Point(126, 168);
			this.txtCompanyPassword.Name = "txtCompanyPassword";
			this.txtCompanyPassword.TabIndex = 57;
			this.txtCompanyPassword.Text = "manager";
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(16, 168);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(112, 24);
			this.Label7.TabIndex = 56;
			this.Label7.Text = "Company Password";
			//
			//txtCompanyUserName
			//
			this.txtCompanyUserName.Location = new System.Drawing.Point(126, 144);
			this.txtCompanyUserName.Name = "txtCompanyUserName";
			this.txtCompanyUserName.TabIndex = 55;
			this.txtCompanyUserName.Text = "manager";
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(16, 144);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(112, 16);
			this.Label6.TabIndex = 54;
			this.Label6.Text = "Company UserName";
			//
			//txtDataBasePassword
			//
			this.txtDataBasePassword.Location = new System.Drawing.Point(126, 120);
			this.txtDataBasePassword.Name = "txtDataBasePassword";
			this.txtDataBasePassword.TabIndex = 53;
			this.txtDataBasePassword.Text = "";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(16, 120);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(112, 16);
			this.Label5.TabIndex = 52;
			this.Label5.Text = "DataBase Password";
			//
			//txtDataBaseUserName
			//
			this.txtDataBaseUserName.Location = new System.Drawing.Point(126, 96);
			this.txtDataBaseUserName.Name = "txtDataBaseUserName";
			this.txtDataBaseUserName.TabIndex = 51;
			this.txtDataBaseUserName.Text = "sa";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(16, 96);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(112, 16);
			this.Label4.TabIndex = 50;
			this.Label4.Text = "DataBase UserName";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(14, 61);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(112, 16);
			this.Label3.TabIndex = 48;
			this.Label3.Text = "DataBase Type";
			//
			//txtDataBaseName
			//
			this.txtDataBaseName.Location = new System.Drawing.Point(126, 37);
			this.txtDataBaseName.Name = "txtDataBaseName";
			this.txtDataBaseName.TabIndex = 47;
			this.txtDataBaseName.Text = "SBODemo_US";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(14, 37);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(112, 16);
			this.Label2.TabIndex = 46;
			this.Label2.Text = "DataBase Name";
			//
			//txtDataBaseServer
			//
			this.txtDataBaseServer.Location = new System.Drawing.Point(126, 13);
			this.txtDataBaseServer.Name = "txtDataBaseServer";
			this.txtDataBaseServer.TabIndex = 45;
			this.txtDataBaseServer.Text = "localhost";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(14, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(112, 16);
			this.Label1.TabIndex = 44;
			this.Label1.Text = "DataBase Server:";
			//
			//cmdLogInComp
			//
			this.cmdLogInComp.Location = new System.Drawing.Point(408, 256);
			this.cmdLogInComp.Name = "cmdLogInComp";
			this.cmdLogInComp.TabIndex = 68;
			this.cmdLogInComp.Text = "Log In";
			//
			//cmbDBType
			//
			this.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDBType.Items.AddRange(new object[] { "MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB" });
			this.cmbDBType.Location = new System.Drawing.Point(120, 64);
			this.cmbDBType.Name = "cmbDBType";
			this.cmbDBType.Size = new System.Drawing.Size(121, 21);
			this.cmbDBType.TabIndex = 66;
			//
			//LogInForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(504, 293);
			this.Controls.Add(this.cmdLogInComp);
			this.Controls.Add(this.GroupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogInForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log In";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void cmdLogInComp_Click (System.Object sender, System.EventArgs e)
		{
			
			//Create a new company object
			
			int lRetCode;
			int lErrCode = 0;
			string sErrMsg = "";
			
			//// Set the mandatory properties for the connection to the database.
			//// To use a remote Db Server enter his name instead of the string "(local)"
			//// This string is used to work on a DB installed on your local machine
			try
			{
				MainModule.oCompany.Server = txtDataBaseServer.Text;
				
				MainModule.oCompany.CompanyDB = txtDataBaseName.Text;
				
				MainModule.oCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes) (cmbDBType.SelectedIndex + 1);
				
				//db user name
				MainModule.oCompany.DbUserName = txtDataBaseUserName.Text;
				
				//user name
				MainModule.oCompany.UserName = txtCompanyUserName.Text;
				//user password
				MainModule.oCompany.Password = txtCompanyPassword.Text;
				
				MainModule.oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English;
				
				// Use Windows authentication for database server.
				// True for NT server authentication,
				// False for database server authentication.
				// oCompany.UseTrusted = True
				
				//insert license server and port
				MainModule.oCompany.LicenseServer = txtLicenseServer.Text + ":" + txtPort.Text;
				
				//Change mouse cursor
				Cursor = System.Windows.Forms.Cursors.WaitCursor;
				
				
				//Connecting to a company DB
				lRetCode = MainModule.oCompany.Connect();
				
				
				if (lRetCode != 0)
				{
					int temp_int = lErrCode;
					string temp_string = sErrMsg;
					MainModule.oCompany.GetLastError(out temp_int, out temp_string);
					MessageBox.Show(temp_string);
					MainModule.oCompany.Disconnect();
					return;
				}
				
				//Change mouse cursor
				Cursor = System.Windows.Forms.Cursors.Default;
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
			
		}
		
		
		private void LogInForm_Load (System.Object sender, System.EventArgs e)
		{
			cmbDBType.SelectedIndex = 3;
		}
		
	}
	
}
