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
		
		public SAPbobsCOM.Budget BGT;
		internal System.Windows.Forms.TextBox txtDBPass;
		internal System.Windows.Forms.TextBox txtDBUser;
		internal System.Windows.Forms.Label lblPass;
		internal System.Windows.Forms.Label Label4; // The budget object we will update
		public SAPbobsCOM.Company oCompany; // The company object
		
		#region " Windows Form Designer generated code "
		
		public frmMain() {
			TB = new TrackBar[13];
			txtMonth = new Label[13];
			
			
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
		internal System.Windows.Forms.CheckBox chkAuto;
		internal System.Windows.Forms.NumericUpDown numSum;
		internal System.Windows.Forms.Label lblSum;
		internal System.Windows.Forms.Label lblMonths;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label lblRealSum;
		internal System.Windows.Forms.ComboBox cmbAccounts;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button cmdUpdate;
		internal System.Windows.Forms.Button cmdLoadBudget;
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
		internal System.Windows.Forms.Label lblCompany;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.grpSample = new System.Windows.Forms.GroupBox();
			this.cmdUpdate = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.cmbAccounts = new System.Windows.Forms.ComboBox();
			this.lblRealSum = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblSum = new System.Windows.Forms.Label();
			this.numSum = new System.Windows.Forms.NumericUpDown();
			this.chkAuto = new System.Windows.Forms.CheckBox();
			this.lblMonths = new System.Windows.Forms.Label();
			this.cmdLoadBudget = new System.Windows.Forms.Button();
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
			this.grpSample.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
			this.grpConn.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpSample
			// 
			this.grpSample.Controls.Add(this.cmdUpdate);
			this.grpSample.Controls.Add(this.Label2);
			this.grpSample.Controls.Add(this.cmbAccounts);
			this.grpSample.Controls.Add(this.lblRealSum);
			this.grpSample.Controls.Add(this.Label1);
			this.grpSample.Controls.Add(this.lblSum);
			this.grpSample.Controls.Add(this.numSum);
			this.grpSample.Controls.Add(this.chkAuto);
			this.grpSample.Controls.Add(this.lblMonths);
			this.grpSample.Controls.Add(this.cmdLoadBudget);
			this.grpSample.Enabled = false;
			this.grpSample.Location = new System.Drawing.Point(8, 144);
			this.grpSample.Name = "grpSample";
			this.grpSample.Size = new System.Drawing.Size(648, 400);
			this.grpSample.TabIndex = 15;
			this.grpSample.TabStop = false;
			this.grpSample.Text = "Sample";
			// 
			// cmdUpdate
			// 
			this.cmdUpdate.Location = new System.Drawing.Point(16, 360);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(104, 23);
			this.cmdUpdate.TabIndex = 26;
			this.cmdUpdate.Text = "Update Budget";
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(16, 320);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 16);
			this.Label2.TabIndex = 25;
			this.Label2.Text = "Change Budget";
			// 
			// cmbAccounts
			// 
			this.cmbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAccounts.Location = new System.Drawing.Point(112, 320);
			this.cmbAccounts.Name = "cmbAccounts";
			this.cmbAccounts.Size = new System.Drawing.Size(408, 21);
			this.cmbAccounts.TabIndex = 24;
			// 
			// lblRealSum
			// 
			this.lblRealSum.Location = new System.Drawing.Point(192, 360);
			this.lblRealSum.Name = "lblRealSum";
			this.lblRealSum.Size = new System.Drawing.Size(104, 16);
			this.lblRealSum.TabIndex = 23;
			this.lblRealSum.Text = "12000";
			this.lblRealSum.Visible = false;
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(152, 360);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(36, 16);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "Sum:";
			this.Label1.Visible = false;
			// 
			// lblSum
			// 
			this.lblSum.Location = new System.Drawing.Point(192, 32);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(72, 23);
			this.lblSum.TabIndex = 21;
			this.lblSum.Text = "Budget Sum";
			// 
			// numSum
			// 
			this.numSum.Enabled = false;
			this.numSum.Location = new System.Drawing.Point(264, 32);
			this.numSum.Maximum = new System.Decimal(new int[] {
																   9999999,
																   0,
																   0,
																   0});
			this.numSum.Minimum = new System.Decimal(new int[] {
																   12,
																   0,
																   0,
																   0});
			this.numSum.Name = "numSum";
			this.numSum.TabIndex = 20;
			this.numSum.Value = new System.Decimal(new int[] {
																 12000,
																 0,
																 0,
																 0});
			// 
			// chkAuto
			// 
			this.chkAuto.Checked = true;
			this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAuto.Location = new System.Drawing.Point(408, 32);
			this.chkAuto.Name = "chkAuto";
			this.chkAuto.TabIndex = 19;
			this.chkAuto.Text = "Auto Correct";
			// 
			// lblMonths
			// 
			this.lblMonths.Location = new System.Drawing.Point(8, 72);
			this.lblMonths.Name = "lblMonths";
			this.lblMonths.Size = new System.Drawing.Size(624, 16);
			this.lblMonths.TabIndex = 18;
			this.lblMonths.Text = "January    February   March       April         May          June        July    " +
				"     August  September  October  November  December ";
			// 
			// cmdLoadBudget
			// 
			this.cmdLoadBudget.Location = new System.Drawing.Point(528, 320);
			this.cmdLoadBudget.Name = "cmdLoadBudget";
			this.cmdLoadBudget.Size = new System.Drawing.Size(104, 24);
			this.cmdLoadBudget.TabIndex = 17;
			this.cmdLoadBudget.Text = "Load Budget";
			this.cmdLoadBudget.Click += new System.EventHandler(this.cmdLoadBudget_Click);
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
			this.grpConn.Location = new System.Drawing.Point(8, 0);
			this.grpConn.Name = "grpConn";
			this.grpConn.Size = new System.Drawing.Size(568, 128);
			this.grpConn.TabIndex = 16;
			this.grpConn.TabStop = false;
			this.grpConn.Text = "Connection Properties";
			// 
			// cmdGetCompanyList
			// 
			this.cmdGetCompanyList.Location = new System.Drawing.Point(448, 24);
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
			this.cmdConnect.Location = new System.Drawing.Point(464, 88);
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
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(264, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 16);
			this.Label4.TabIndex = 44;
			this.Label4.Text = "DB Username";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(666, 559);
			this.Controls.Add(this.grpConn);
			this.Controls.Add(this.grpSample);
			this.ForeColor = System.Drawing.Color.Blue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimumSize = new System.Drawing.Size(570, 470);
			this.Name = "frmMain";
			this.Text = "SAP Database Interface Sample";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpSample.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
			this.grpConn.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		
		#endregion
		
		//Error handling variables
		public string sErrMsg;
		public int lErrCode;
		public int lRetCode;
		
		private TrackBar[] TB; // 12 track bars for each month
		private Label[] txtMonth; // 12 labels for monthly budget
		
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
			
			CreateTrackBars();
		}
		
		//****************************************************************************
		// This sub creates all the track bars and sets their defaults
		//****************************************************************************
		private void CreateTrackBars ()
		{
			int i; // Just a counter to iterate the months
			
			for (i = 0; i <= 11; i++)
			{
				TB[i] = new TrackBar();
				
				TB[i].Parent = grpSample;
				TB[i].Orientation = Orientation.Vertical;
				TB[i].Width = 60;
				TB[i].Height = 200;
				
				TB[i].Left = 5 +((TB[i].Width + 10) * i);
				TB[i].Top = lblMonths.Top + lblMonths.Height;
				TB[i].LargeChange = 1;
				TB[i].SmallChange = 1;
				TB[i].TickFrequency = 12;
				TB[i].Maximum = 120;
				TB[i].Minimum = 0;
				TB[i].Name = i.ToString();
				TB[i].Value = 11;
				TB[i].Tag = 11;
				
				// Add the event handler
				TB[i].Scroll += new System.EventHandler(ProcessScroll);
				
				// Add label to each track bar
				txtMonth[i] = new Label();
				txtMonth[i].Left = TB[i].Left;
				txtMonth[i].Width = TB[i].Width + 10;
				txtMonth[i].Top = TB[i].Top + TB[i].Height;
				txtMonth[i].Tag = 1000;
				txtMonth[i].Text = txtMonth[i].Tag.ToString();
				txtMonth[i].Parent = grpSample;
				txtMonth[i].Visible = true;
			}
		}
		
		//****************************************************************************
		// This sub responds to any scrolling of the track bars
		//****************************************************************************
		public void ProcessScroll( object sender, System.EventArgs e ) 
		{ 
			TrackBar MyTrackBar = null; 
			double delta = 0, Change = 0; 
			int ChangeAble = 0; 
            
			//  Get the changed track bar
			MyTrackBar = ( ( TrackBar )( sender ) ); 
            
			delta = TB[ System.Convert.ToInt32( double.Parse( MyTrackBar.Name ) ) ].Value - System.Convert.ToInt32( TB[ System.Convert.ToInt32( double.Parse( MyTrackBar.Name ) ) ].Tag ); 
			TB[ System.Convert.ToInt32( double.Parse( MyTrackBar.Name ) ) ].Tag = System.Convert.ToDouble( TB[ System.Convert.ToInt32( double.Parse( MyTrackBar.Name ) ) ].Tag ) + delta; 
			TB[ System.Convert.ToInt32( double.Parse( MyTrackBar.Name ) ) ].Value = System.Convert.ToInt32( TB[ System.Convert.ToInt32( double.Parse( MyTrackBar.Name ) ) ].Tag ); 
            
			Change = delta / 11; 
			ChangeAble = 0; 
			int i = 0; 
			for ( i=0; i<=11; i++ ) 
			{ 
				if ( MyTrackBar.Name != i.ToString() & ( TB[ i ].Value - Change <= TB[ i ].Maximum ) & ( TB[ i ].Value - Change >= TB[ i ].Minimum ) ) 
				{ 
					ChangeAble += 1; 
				} 
			} 
            
			Change = delta / ChangeAble; 
			for ( i=0; i<=11; i++ ) 
			{ 
				if ( MyTrackBar.Name != i.ToString() & chkAuto.Checked ) 
				{ 
					TB[ i ].Tag = System.Convert.ToDouble( TB[ i ].Tag ) - Change; 
					if ( System.Convert.ToDouble( Conversion.Int( System.Convert.ToDouble( TB[ i ].Tag ) - Change ) ) >= 0 & ( System.Convert.ToDouble( Conversion.Int( System.Convert.ToDouble( TB[ i ].Tag ) - Change ) ) <= TB[ i ].Maximum ) ) 
					{ 
						TB[ i ].Value = System.Convert.ToInt32( Conversion.Int( System.Convert.ToDouble( TB[ i ].Tag ) - Change ) ); 
					} 
					else 
					{ 
						TB[ i ].Tag = TB[ i ].Value; 
					} 
				} 
			} 
            
			//  Make a sum
			double Sum = 0; 
			double PresentedSum = 0; 
			double tmp = 0; 
			Sum = 0; 
			for ( i=0; i<=11; i++ ) 
			{ 
				Sum += TB[ i ].Value; 
			} 
			if ( Sum != 0 ) 
			{ 
				for ( i=0; i<=11; i++ ) 
				{ 
					tmp = System.Convert.ToDouble( ( numSum.Value * System.Convert.ToDecimal( ( TB[ i ].Value / Sum ) ) ) ); 
					txtMonth[ i ].Text = System.Convert.ToString( System.Convert.ToInt32( tmp * 100 ) / 100 ); 
				} 
                
				// Correct slight calculations
				object MySum = 0; 
				for ( i=0; i<=11; i++ ) 
				{ 
					MySum = System.Convert.ToDouble( MySum ) + double.Parse( txtMonth[ i ].Text ); 
				} 
				lblRealSum.Text = MySum.ToString(); 
				double Dif = 0; 
                
				Dif = System.Convert.ToDouble( numSum.Value - System.Convert.ToDecimal( double.Parse( lblRealSum.Text ) ) ); 
				if ( Dif != 0 ) 
				{ 
					int j = 0; 
					for ( j=0; j<=11; j++ ) 
					{ 
						if ( ( double.Parse( txtMonth[ j ].Text ) > 0 ) & ( System.Convert.ToDouble( TB[ j ].Value ) < TB[ j ].Maximum ) ) 
						{ 
							txtMonth[ j ].Text = System.Convert.ToString( System.Convert.ToInt32( ( double.Parse( txtMonth[ j ].Text ) + Dif ) * 100 ) / 100 ); 
							Dif = 0; 
						} 
					} 
				} 
                
			} 
			else 
			{ 
				MessageBox.Show( "This Budget is not possible" ); 
			} 
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
			else
			{
				LoadData();
				LoadBudget();
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
		// This function loads a selected budget
		//****************************************************************************
		public void LoadBudget ()
		{
			SAPbobsCOM.ChartOfAccounts ACC;
			//			bool bFreeBudget;
			SAPbobsCOM.Recordset r;
			
			r = (SAPbobsCOM.Recordset) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			ACC = (SAPbobsCOM.ChartOfAccounts) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oChartOfAccounts);
			
			BGT = (SAPbobsCOM.Budget) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBudget);
			
			try
			{
				r.DoQuery("SELECT * FROM OBGT");
				BGT.Browser.Recordset = r;
				BGT.Browser.MoveFirst();
				
				while (BGT.Numerator !=(cmbAccounts.SelectedIndex + 1))
				{
					BGT.Browser.MoveNext();
				}
				
				numSum.Value = System.Convert.ToDecimal(BGT.TotalAnnualBudgetDebitSys + BGT.TotalAnnualBudgetCreditSys);
				int i;
				
				for (i = 0; i <= 11; i++)
				{
					double tmp;
					BGT.Lines.SetCurrentLine(i);
					txtMonth[i].Text = BGT.Lines.BudgetTotCredit + BGT.Lines.BudgetTotDebit.ToString();
					
					tmp = BGT.Lines.BudgetTotCredit + BGT.Lines.BudgetTotDebit;
					TB[i].Tag = (tmp / System.Convert.ToDouble(numSum.Value)) * TB[i].Maximum;
					TB[i].Value = System.Convert.ToInt32(TB[i].Tag);
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		//****************************************************************************
		// This sub loads the accounts data into a combo box
		//****************************************************************************
		public void LoadData ()
		{
			SAPbobsCOM.Recordset r;
			SAPbobsCOM.Recordset rAcc;
			SAPbobsCOM.Budget BGT;
			
			BGT = (SAPbobsCOM.Budget) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBudget);
			r = (SAPbobsCOM.Recordset) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			rAcc = (SAPbobsCOM.Recordset) oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			
			try
			{
				r.DoQuery("SELECT * FROM OBGT");
				BGT.Browser.Recordset = r;
				
				BGT.Browser.MoveFirst();
				
				while (! BGT.Browser.EoF)
				{
					rAcc.DoQuery("SELECT AcctName FROM OACT WHERE AcctCode = \'" + BGT.AccountCode + "\'");
					rAcc.MoveFirst();
					cmbAccounts.Items.Add(rAcc.Fields.Item(0).Value);
					BGT.Browser.MoveNext();
				}
				cmbAccounts.SelectedIndex = 0;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		//****************************************************************************
		// This sub updates the selected budget
		//****************************************************************************
		private void cmdUpdate_Click (System.Object sender, System.EventArgs e)
		{
			//			short j;
			int i;
			
			BGT.Browser.MoveFirst();
			while (BGT.Numerator !=(cmbAccounts.SelectedIndex + 1))
			{
				BGT.Browser.MoveNext();
			}
			
			for (i = 0; i <= 11; i++)
			{
				//				double tmp;
				BGT.Lines.SetCurrentLine(i);
				BGT.Lines.BudgetTotDebit = System.Convert.ToDouble(txtMonth[i].Text);
			}
			string s = "";
			
			int temp_int = i;
			string temp_string = s;
			oCompany.GetLastError(out temp_int, out temp_string);
			
			i = BGT.Update();
			
			if (i != 0)
			{
				int temp_int2 = i;
				string temp_string2 = s;
				oCompany.GetLastError(out temp_int2, out temp_string2);
				MessageBox.Show(s);
			}
			else
			{
				MessageBox.Show("Budget Updated");
			}
			
		}
		//****************************************************************************
		// This sub responds to the click event on the "load budget" button
		//****************************************************************************
		private void cmdLoadBudget_Click (System.Object sender, System.EventArgs e)
		{
			LoadBudget();
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
				OrderApp.oRecordSet = oCompany.GetCompanyList(); // get the company list
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
