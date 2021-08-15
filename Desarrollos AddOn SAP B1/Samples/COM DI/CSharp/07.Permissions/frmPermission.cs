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
//****************************************************************************


namespace ord
{
	public class frmPermission : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public frmPermission() {
			
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
		internal System.Windows.Forms.GroupBox grpPermission;
		internal System.Windows.Forms.Label lblFormType;
		internal System.Windows.Forms.GroupBox grpSetPermission;
		internal System.Windows.Forms.Button cmdUserPermission;
		internal System.Windows.Forms.Label lblExplenation;
		internal System.Windows.Forms.Button cmdNewPermission;
		internal System.Windows.Forms.TextBox txtPermissionName;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtPermissionID;
		internal System.Windows.Forms.Label lblPermissionID;
		internal System.Windows.Forms.TextBox txtFormType;
		internal System.Windows.Forms.TextBox txtNewFormType;
		internal System.Windows.Forms.Label lblStaticType;
		internal System.Windows.Forms.Button cmdNewForm;
		public System.Windows.Forms.CheckedListBox lstUsers;
		internal System.Windows.Forms.Label lblReadMe;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox grpConn;
		internal System.Windows.Forms.Button cmdGetCompanyList;
		internal System.Windows.Forms.Label Label3;
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
			this.grpPermission = new System.Windows.Forms.GroupBox();
			this.txtPermissionID = new System.Windows.Forms.TextBox();
			this.lblPermissionID = new System.Windows.Forms.Label();
			this.txtPermissionName = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.cmdNewPermission = new System.Windows.Forms.Button();
			this.txtFormType = new System.Windows.Forms.TextBox();
			this.lblFormType = new System.Windows.Forms.Label();
			this.grpSetPermission = new System.Windows.Forms.GroupBox();
			this.lblExplenation = new System.Windows.Forms.Label();
			this.lstUsers = new System.Windows.Forms.CheckedListBox();
			this.cmdUserPermission = new System.Windows.Forms.Button();
			this.txtNewFormType = new System.Windows.Forms.TextBox();
			this.lblStaticType = new System.Windows.Forms.Label();
			this.cmdNewForm = new System.Windows.Forms.Button();
			this.lblReadMe = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.grpConn = new System.Windows.Forms.GroupBox();
			this.cmdGetCompanyList = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
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
			this.grpPermission.SuspendLayout();
			this.grpSetPermission.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.grpConn.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpPermission
			// 
			this.grpPermission.Controls.Add(this.txtPermissionID);
			this.grpPermission.Controls.Add(this.lblPermissionID);
			this.grpPermission.Controls.Add(this.txtPermissionName);
			this.grpPermission.Controls.Add(this.Label2);
			this.grpPermission.Controls.Add(this.cmdNewPermission);
			this.grpPermission.Controls.Add(this.txtFormType);
			this.grpPermission.Controls.Add(this.lblFormType);
			this.grpPermission.Enabled = false;
			this.grpPermission.Location = new System.Drawing.Point(8, 264);
			this.grpPermission.Name = "grpPermission";
			this.grpPermission.Size = new System.Drawing.Size(224, 160);
			this.grpPermission.TabIndex = 19;
			this.grpPermission.TabStop = false;
			this.grpPermission.Text = "- 1 - Create a New Permission";
			// 
			// txtPermissionID
			// 
			this.txtPermissionID.Location = new System.Drawing.Point(96, 24);
			this.txtPermissionID.Name = "txtPermissionID";
			this.txtPermissionID.TabIndex = 5;
			this.txtPermissionID.Text = "";
			// 
			// lblPermissionID
			// 
			this.lblPermissionID.Location = new System.Drawing.Point(16, 24);
			this.lblPermissionID.Name = "lblPermissionID";
			this.lblPermissionID.Size = new System.Drawing.Size(80, 16);
			this.lblPermissionID.TabIndex = 24;
			this.lblPermissionID.Text = "Permission ID";
			// 
			// txtPermissionName
			// 
			this.txtPermissionName.Location = new System.Drawing.Point(104, 56);
			this.txtPermissionName.Name = "txtPermissionName";
			this.txtPermissionName.TabIndex = 6;
			this.txtPermissionName.Text = "";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(16, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 16);
			this.Label2.TabIndex = 22;
			this.Label2.Text = "Permission Name";
			// 
			// cmdNewPermission
			// 
			this.cmdNewPermission.Location = new System.Drawing.Point(16, 120);
			this.cmdNewPermission.Name = "cmdNewPermission";
			this.cmdNewPermission.Size = new System.Drawing.Size(104, 23);
			this.cmdNewPermission.TabIndex = 8;
			this.cmdNewPermission.Text = "Add Permission";
			this.cmdNewPermission.Click += new System.EventHandler(this.cmdNewPermission_Click);
			// 
			// txtFormType
			// 
			this.txtFormType.Location = new System.Drawing.Point(80, 88);
			this.txtFormType.Name = "txtFormType";
			this.txtFormType.TabIndex = 7;
			this.txtFormType.Text = "";
			// 
			// lblFormType
			// 
			this.lblFormType.Location = new System.Drawing.Point(16, 88);
			this.lblFormType.Name = "lblFormType";
			this.lblFormType.Size = new System.Drawing.Size(64, 16);
			this.lblFormType.TabIndex = 0;
			this.lblFormType.Text = "Form Type";
			// 
			// grpSetPermission
			// 
			this.grpSetPermission.Controls.Add(this.lblExplenation);
			this.grpSetPermission.Controls.Add(this.lstUsers);
			this.grpSetPermission.Controls.Add(this.cmdUserPermission);
			this.grpSetPermission.Enabled = false;
			this.grpSetPermission.Location = new System.Drawing.Point(248, 264);
			this.grpSetPermission.Name = "grpSetPermission";
			this.grpSetPermission.Size = new System.Drawing.Size(288, 160);
			this.grpSetPermission.TabIndex = 2;
			this.grpSetPermission.TabStop = false;
			this.grpSetPermission.Text = " - 2 - Set the new permission to users";
			// 
			// lblExplenation
			// 
			this.lblExplenation.Location = new System.Drawing.Point(16, 24);
			this.lblExplenation.Name = "lblExplenation";
			this.lblExplenation.Size = new System.Drawing.Size(264, 24);
			this.lblExplenation.TabIndex = 22;
			this.lblExplenation.Text = "Mark the users that will be able to use this form type";
			// 
			// lstUsers
			// 
			this.lstUsers.Location = new System.Drawing.Point(16, 48);
			this.lstUsers.Name = "lstUsers";
			this.lstUsers.Size = new System.Drawing.Size(120, 94);
			this.lstUsers.TabIndex = 10;
			// 
			// cmdUserPermission
			// 
			this.cmdUserPermission.Location = new System.Drawing.Point(160, 80);
			this.cmdUserPermission.Name = "cmdUserPermission";
			this.cmdUserPermission.Size = new System.Drawing.Size(104, 24);
			this.cmdUserPermission.TabIndex = 11;
			this.cmdUserPermission.Text = "Set Permissions";
			this.cmdUserPermission.Click += new System.EventHandler(this.cmdUserPermission_Click);
			// 
			// txtNewFormType
			// 
			this.txtNewFormType.Location = new System.Drawing.Point(72, 72);
			this.txtNewFormType.Name = "txtNewFormType";
			this.txtNewFormType.TabIndex = 25;
			this.txtNewFormType.Text = "";
			// 
			// lblStaticType
			// 
			this.lblStaticType.Location = new System.Drawing.Point(8, 72);
			this.lblStaticType.Name = "lblStaticType";
			this.lblStaticType.Size = new System.Drawing.Size(64, 16);
			this.lblStaticType.TabIndex = 27;
			this.lblStaticType.Text = "Form Type";
			// 
			// cmdNewForm
			// 
			this.cmdNewForm.Location = new System.Drawing.Point(184, 72);
			this.cmdNewForm.Name = "cmdNewForm";
			this.cmdNewForm.Size = new System.Drawing.Size(104, 24);
			this.cmdNewForm.TabIndex = 26;
			this.cmdNewForm.Text = "Create Form";
			this.cmdNewForm.Click += new System.EventHandler(this.cmdNewForm_Click);
			// 
			// lblReadMe
			// 
			this.lblReadMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.lblReadMe.Location = new System.Drawing.Point(8, 176);
			this.lblReadMe.Name = "lblReadMe";
			this.lblReadMe.Size = new System.Drawing.Size(512, 80);
			this.lblReadMe.TabIndex = 28;
			this.lblReadMe.Text = @"This sample shows how to add new permissions and how to assign permissions to users. After you connect to your company add a new permission, then you'll be able to assign this permission to any of the company users. You can see the result by creating a form with the form type you added to the permission. Only permitted users will have access to this fom";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtNewFormType);
			this.GroupBox1.Controls.Add(this.lblStaticType);
			this.GroupBox1.Controls.Add(this.cmdNewForm);
			this.GroupBox1.Location = new System.Drawing.Point(8, 432);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(528, 112);
			this.GroupBox1.TabIndex = 29;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "- 3 - Test the permission";
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.Label1.Location = new System.Drawing.Point(8, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(496, 40);
			this.Label1.TabIndex = 28;
			this.Label1.Text = "When clicking on \"Create Form\" we\'ll try to create a form in SBO with the form ty" +
				"pe specified. If the user is not allowed to view the form an error will appear";
			// 
			// grpConn
			// 
			this.grpConn.Controls.Add(this.txtDBPass);
			this.grpConn.Controls.Add(this.txtDBUser);
			this.grpConn.Controls.Add(this.lblPass);
			this.grpConn.Controls.Add(this.Label4);
			this.grpConn.Controls.Add(this.cmdGetCompanyList);
			this.grpConn.Controls.Add(this.Label3);
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
			this.grpConn.Size = new System.Drawing.Size(544, 128);
			this.grpConn.TabIndex = 30;
			this.grpConn.TabStop = false;
			this.grpConn.Text = "Connection Properties";
			// 
			// cmdGetCompanyList
			// 
			this.cmdGetCompanyList.Location = new System.Drawing.Point(416, 24);
			this.cmdGetCompanyList.Name = "cmdGetCompanyList";
			this.cmdGetCompanyList.Size = new System.Drawing.Size(112, 24);
			this.cmdGetCompanyList.TabIndex = 15;
			this.cmdGetCompanyList.Text = "Get Company List";
			this.cmdGetCompanyList.Click += new System.EventHandler(this.cmdGetCompanyList_Click);
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(8, 24);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(104, 23);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "Database Type";
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
			this.cmdConnect.Location = new System.Drawing.Point(432, 88);
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
			this.txtDBPass.Location = new System.Drawing.Point(328, 40);
			this.txtDBPass.Name = "txtDBPass";
			this.txtDBPass.PasswordChar = '*';
			this.txtDBPass.Size = new System.Drawing.Size(72, 20);
			this.txtDBPass.TabIndex = 45;
			this.txtDBPass.Text = "";
			// 
			// txtDBUser
			// 
			this.txtDBUser.Location = new System.Drawing.Point(328, 16);
			this.txtDBUser.Name = "txtDBUser";
			this.txtDBUser.Size = new System.Drawing.Size(72, 20);
			this.txtDBUser.TabIndex = 43;
			this.txtDBUser.Text = "sa";
			// 
			// lblPass
			// 
			this.lblPass.Location = new System.Drawing.Point(248, 40);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(80, 16);
			this.lblPass.TabIndex = 46;
			this.lblPass.Text = "DB Password";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(248, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 16);
			this.Label4.TabIndex = 44;
			this.Label4.Text = "DB Username";
			// 
			// frmPermission
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(562, 557);
			this.Controls.Add(this.grpConn);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.lblReadMe);
			this.Controls.Add(this.grpPermission);
			this.Controls.Add(this.grpSetPermission);
			this.ForeColor = System.Drawing.Color.Blue;
			this.MinimumSize = new System.Drawing.Size(570, 470);
			this.Name = "frmPermission";
			this.Text = "SAP DI Permissions Sample";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpPermission.ResumeLayout(false);
			this.grpSetPermission.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.grpConn.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		
		#endregion
		
		private SAPbouiCOM.Application SBO_Application;
		
		//Error handling variables
		public string sErrMsg;
		public int lErrCode;
		public int lRetCode;
		private void SetApplication ()
		{
			
			//*******************************************************************
			//// Use an SboGuiApi object to establish connection
			//// with the SAP Business One application and return an
			//// initialized appliction object
			//*******************************************************************
			
			SAPbouiCOM.SboGuiApi SboGuiApi;
			string sConnectionString;
			
			SboGuiApi = new SAPbouiCOM.SboGuiApi();
			
			sConnectionString = Environment.GetCommandLineArgs().GetValue(1).ToString();
			
			//// connect to a running SBO Application
			
			try // If there's no active application the connection will fail
			{
				SboGuiApi.Connect(sConnectionString);
			}
			catch // Connection failed
			{
				System.Windows.Forms.MessageBox.Show("No SAP Business One Application was found");
				ProjectData.EndApp();
			}
			//// get an initialized application object
			
			SBO_Application = SboGuiApi.GetApplication(-1);
			//SBO_Application.MessageBox("Hello World")
			
		}
		//****************************************************************************
		// This function is called when the form is loaded.
		// It performs various initialization procedures.
		//****************************************************************************
		private void frmMain_Load (System.Object sender, System.EventArgs e)
		{
			cmbDBType.SelectedIndex = 3;
			SetApplication();
			
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
				Interaction.MsgBox("Connection Failed - " + temp_string, MsgBoxStyle.Exclamation, "Default Connection Failed");
			}
			else
			{
				LoadUsers();
				grpPermission.Enabled = true;
			}
			if (OrderApp.oCompany.Connected) // if connected
			{
				this.Text = this.Text + " - Connected to " + OrderApp.oCompany.CompanyDB;
				grpConn.Enabled = false;
				grpPermission.Enabled = true;
				
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
		// This function adds a new permission
		//****************************************************************************
		private void AddToPermissionTree ()
		{
			long RetVal;
			//			long ErrCode;
			string ErrMsg = "";
			SAPbobsCOM.UserPermissionTree oPermission;
			
			oPermission = (SAPbobsCOM.UserPermissionTree) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserPermissionTree);
			
			oPermission.Name = txtPermissionName.Text;
			oPermission.PermissionID = txtPermissionID.Text;
			oPermission.UserPermissionForms.FormType = txtFormType.Text;
			
			oPermission.Options = SAPbobsCOM.BoUPTOptions.bou_FullReadNone;
			RetVal = oPermission.Add();
			
			int temp_int = (int) (RetVal);
			string temp_string = ErrMsg;
			OrderApp.oCompany.GetLastError(out temp_int, out temp_string);
			if (RetVal != 0)
			{
				MessageBox.Show(temp_string);
			}
			else
			{
				grpPermission.Enabled = false;
				grpSetPermission.Enabled = true;
			}
		}
		
		//****************************************************************************
		// This function loads all the users in the company to a list box
		//****************************************************************************
		private void LoadUsers ()
		{
			SAPbobsCOM.Users oUsers;
			SAPbobsCOM.Recordset oRecordSet;
			
			oUsers = (SAPbobsCOM.Users) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers);
			oRecordSet = (SAPbobsCOM.Recordset) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			
			oRecordSet.DoQuery("SELECT * FROM OUSR");
			oUsers.Browser.Recordset = oRecordSet;
			oUsers.Browser.Refresh();
			oUsers.Browser.MoveFirst();
			
			// add to list box
			int i;
			lstUsers.Items.Add(oUsers.UserCode, false);
			for (i=1;i<oUsers.Browser.RecordCount;i++)
			{
				oUsers.Browser.MoveNext();
				lstUsers.Items.Add(oUsers.UserCode, false);
			}

			txtNewFormType.Text = txtFormType.Text;
		}
		
		//****************************************************************************
		// This function responds to a click in the "Add Permission" button
		//****************************************************************************
		private void cmdNewPermission_Click (System.Object sender, System.EventArgs e)
		{
			AddToPermissionTree();
		}
		
		//****************************************************************************
		// This sub assigns the permission to users
		//****************************************************************************
		private void cmdUserPermission_Click (System.Object sender, System.EventArgs e)
		{
            
			SAPbobsCOM.Users oUser = null; 
            
			oUser = ( ( SAPbobsCOM.Users )( OrderApp.oCompany.GetBusinessObject( SAPbobsCOM.BoObjectTypes.oUsers ) ) ); 
            
			int i = 0; 
			for ( i=0; i<=lstUsers.CheckedIndices.Count - 1; i++ ) 
			{ 
				object j = lstUsers.CheckedIndices[ i ]; 
				lRetCode = System.Convert.ToInt32( oUser.GetByKey( System.Convert.ToInt32( j ) + 1 ) ); 
				OrderApp.oCompany.GetLastError( out lRetCode, out sErrMsg ); 
                
				if ( lRetCode != 0 ) 
				{ 
					MessageBox.Show( sErrMsg ); 
				} 
                
				oUser.UserPermission.Add(); 
				oUser.UserPermission.SetCurrentLine( 0 ); 
				oUser.UserPermission.PermissionID = txtPermissionID.Text; 
				oUser.UserPermission.Permission = SAPbobsCOM.BoPermission.boper_ReadOnly; 
                
				lRetCode = oUser.Update(); 
                
				OrderApp.oCompany.GetLastError( out lRetCode, out sErrMsg ); 
				if ( lRetCode != 0 ) 
				{ 
					MessageBox.Show( sErrMsg ); 
				} 
			} 
		}
		
		//****************************************************************************
		// This sub creates a form with s specified type
		//****************************************************************************
		private void CreateForm ()
		{
			SAPbouiCOM.Form oForm;
			SAPbouiCOM.FormCreationParams cp;
			
			cp = (SAPbouiCOM.FormCreationParams) SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams);
			cp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed;
			cp.FormType = txtNewFormType.Text;
			cp.UniqueID = "MyID";
			
			try
			{
				oForm = SBO_Application.Forms.AddEx(cp);
				oForm.Visible = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		//****************************************************************************
		// This function responds to a click in the "Create Form" button
		//****************************************************************************
		private void cmdNewForm_Click (System.Object sender, System.EventArgs e)
		{
			CreateForm();
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
		}
	}
	
}
