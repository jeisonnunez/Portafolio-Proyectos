#define Win32
using Microsoft.VisualBasic;
using System.Data;
using AxMSComDlg;
using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace Project1
{
	internal class DIExercise : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			Application.Run(new DIExercise());
		}
		#region "Windows Form Designer generated code "
		public DIExercise() {
			if (m_vb6FormDefInstance == null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}
		//Form overrides dispose to clean up the component list.
		protected override void Dispose (bool Disposing)
		{
			if (Disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}

		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Label lblLoad;
		public System.Windows.Forms.MainMenu MainMenu1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.ListBox lstIndex;
		internal System.Windows.Forms.CheckedListBox chklstXML;
		internal System.Windows.Forms.Button cmdExportFiles;
		internal Microsoft.VisualBasic.Compatibility.VB6.DirListBox DirListBox;
		internal Microsoft.VisualBasic.Compatibility.VB6.DriveListBox DriveBox;
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
		internal System.Windows.Forms.TextBox txtDBPass;
		internal System.Windows.Forms.TextBox txtDBUser;
		internal System.Windows.Forms.Label lblPass;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label lblCompany;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Text1 = new System.Windows.Forms.TextBox();
			this.lblLoad = new System.Windows.Forms.Label();
			this.MainMenu1 = new System.Windows.Forms.MainMenu();
			this.lstIndex = new System.Windows.Forms.ListBox();
			this.chklstXML = new System.Windows.Forms.CheckedListBox();
			this.cmdExportFiles = new System.Windows.Forms.Button();
			this.DirListBox = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
			this.DriveBox = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
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
			this.grpConn.SuspendLayout();
			this.SuspendLayout();
			// 
			// Text1
			// 
			this.Text1.AcceptsReturn = true;
			this.Text1.AutoSize = false;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text1.Enabled = false;
			this.Text1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text1.Location = new System.Drawing.Point(8, 376);
			this.Text1.MaxLength = 0;
			this.Text1.Multiline = true;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Text1.Size = new System.Drawing.Size(560, 256);
			this.Text1.TabIndex = 14;
			this.Text1.Text = "";
			this.Text1.WordWrap = false;
			// 
			// lblLoad
			// 
			this.lblLoad.BackColor = System.Drawing.SystemColors.Control;
			this.lblLoad.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLoad.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLoad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLoad.Location = new System.Drawing.Point(8, 352);
			this.lblLoad.Name = "lblLoad";
			this.lblLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLoad.Size = new System.Drawing.Size(473, 17);
			this.lblLoad.TabIndex = 17;
			// 
			// lstIndex
			// 
			this.lstIndex.Enabled = false;
			this.lstIndex.ItemHeight = 14;
			this.lstIndex.Location = new System.Drawing.Point(360, 176);
			this.lstIndex.Name = "lstIndex";
			this.lstIndex.Size = new System.Drawing.Size(120, 32);
			this.lstIndex.TabIndex = 18;
			this.lstIndex.Visible = false;
			// 
			// chklstXML
			// 
			this.chklstXML.Enabled = false;
			this.chklstXML.Location = new System.Drawing.Point(8, 144);
			this.chklstXML.Name = "chklstXML";
			this.chklstXML.Size = new System.Drawing.Size(152, 199);
			this.chklstXML.TabIndex = 19;
			this.chklstXML.SelectedIndexChanged += new System.EventHandler(this.chklstXML_SelectedIndexChanged);
			// 
			// cmdExportFiles
			// 
			this.cmdExportFiles.Enabled = false;
			this.cmdExportFiles.Location = new System.Drawing.Point(168, 304);
			this.cmdExportFiles.Name = "cmdExportFiles";
			this.cmdExportFiles.Size = new System.Drawing.Size(152, 32);
			this.cmdExportFiles.TabIndex = 20;
			this.cmdExportFiles.Text = "Export XML files";
			this.cmdExportFiles.Click += new System.EventHandler(this.cmdExportFiles_Click);
			// 
			// DirListBox
			// 
			this.DirListBox.Enabled = false;
			this.DirListBox.IntegralHeight = false;
			this.DirListBox.Location = new System.Drawing.Point(168, 176);
			this.DirListBox.Name = "DirListBox";
			this.DirListBox.Size = new System.Drawing.Size(152, 120);
			this.DirListBox.TabIndex = 21;
			// 
			// DriveBox
			// 
			this.DriveBox.Enabled = false;
			this.DriveBox.Location = new System.Drawing.Point(168, 144);
			this.DriveBox.Name = "DriveBox";
			this.DriveBox.Size = new System.Drawing.Size(152, 21);
			this.DriveBox.TabIndex = 22;
			this.DriveBox.SelectedIndexChanged += new System.EventHandler(this.DriveBox_SelectedIndexChanged);
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
			this.grpConn.Size = new System.Drawing.Size(552, 128);
			this.grpConn.TabIndex = 23;
			this.grpConn.TabStop = false;
			this.grpConn.Text = "Connection Properties";
			// 
			// cmdGetCompanyList
			// 
			this.cmdGetCompanyList.Location = new System.Drawing.Point(432, 24);
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
			this.cmbDBType.Size = new System.Drawing.Size(121, 22);
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
			this.cmbCompany.Size = new System.Drawing.Size(121, 22);
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
			// DIExercise
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(570, 639);
			this.Controls.Add(this.grpConn);
			this.Controls.Add(this.DriveBox);
			this.Controls.Add(this.DirListBox);
			this.Controls.Add(this.cmdExportFiles);
			this.Controls.Add(this.chklstXML);
			this.Controls.Add(this.lstIndex);
			this.Controls.Add(this.Text1);
			this.Controls.Add(this.lblLoad);
			this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Menu = this.MainMenu1;
			this.MinimizeBox = false;
			this.Name = "DIExercise";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XML SCHEMA EXPORTER";
			this.Load += new System.EventHandler(this.DIExercise_Load);
			this.grpConn.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region "Upgrade Support "
		private static DIExercise m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static DIExercise DefInstance
		{
			get{
				DIExercise returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new DIExercise();
					m_InitializingDefInstance = false;
				}
				returnValue = m_vb6FormDefInstance;
				return returnValue;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}
		#endregion
		////  SAP MANAGE DI API 6.7 SDK Sample
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
		
		////****************************************************************************
		//// BEFORE STARTING:
		//// Add reference to the "SAP Business One Objects Bridge Version 6.7"
		////-----------------------------------------------------------------
		//// 1. Project->References
		//// 2. check the "SAP Business One Objects Bridge Version 6.7" check box
		////****************************************************************************
		
		private SAPbobsCOM.Company oCompany;
		private string sErrMsg = null;
		private int lErrCode = 0;
		protected int lRetCode = 0;
		
		
		////****************************************************************************
		//// This function creates a list of all the objects
		////****************************************************************************
		private void LoadEnumObjects ()
		{
			
			short i;
			string s;
			
			Cursor = System.Windows.Forms.Cursors.WaitCursor;
			for (i = 1; i <= 500; i++)
			{
				Cursor = System.Windows.Forms.Cursors.WaitCursor;
				lblLoad.Text = "Loading XML Schemas... " + Conversion.Str(i / 5) + "%";
				
				s = TryToGetSchema(ref i);
				if (s != "Error")
				{
					string strEnum;
					SAPbobsCOM.BoObjectTypes SBO;
					SBO = (SAPbobsCOM.BoObjectTypes) i;
					strEnum = SBO.ToString();
					chklstXML.Items.Add(strEnum);
					lstIndex.Items.Add(Conversion.Str(i));
				}
				System.Windows.Forms.Application.DoEvents();
			}
			Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		////****************************************************************************
		//// Try to get an object schema
		////****************************************************************************
		public string TryToGetSchema(ref short i)
		{
			string returnValue = "";
			// Get xml schema...
			string str_Renamed;
			
			try
			{
				
				str_Renamed = oCompany.GetBusinessObjectXmlSchema((SAPbobsCOM.BoObjectTypes) i);
				returnValue = str_Renamed;
				
				return returnValue;
			}
			catch
			{
				goto ErrorHandler;
			}
			
ErrorHandler:
//			returnValue = "Error";
			return returnValue;
		}
		
		////****************************************************************************
		//// Loading procedure
		////****************************************************************************
		private void DIExercise_Load (System.Object eventSender, System.EventArgs eventArgs)
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
			//oCompany = New SAPbobsCOM.Company
			
			//// Set the mandatory properties for the connection to the database.
			//// To use a remote Db Server enter his name instead of the string "(local)"
			//// This string is used to work on a DB installed on your local machine
			
			//oCompany.Server = "(local)"
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
				//Disable Controls
				cmdGetCompanyList.Enabled = false;
				cmbDBType.Enabled = false;
				
				txtUSer.Enabled = false;
				txtPassword.Enabled = false;
				cmdConnect.Enabled = false;
				cmbCompany.Enabled = false;
				
				//Enable Controls
				
				chklstXML.Enabled = true;
				DriveBox.Enabled = true;
				DirListBox.Enabled = true;
				cmdExportFiles.Enabled = true;
				Text1.Enabled = true;
				lstIndex.Enabled = true;
				
			}
		}
		
		////****************************************************************************
		//// Show the schema of the selected object
		////****************************************************************************
		private void chklstXML_SelectedIndexChanged (object sender, System.EventArgs e)
		{
			string s;
			//s = lstIndex.Items.Item(cmbOBjects.SelectedIndex)
			s = lstIndex.Items[chklstXML.SelectedIndex].ToString();
			short temp_short = System.Convert.ToInt16(s);
			Text1.Text = TryToGetSchema(ref temp_short);
		}
		
		////****************************************************************************
		//// Same the selected objects schemas in files
		////****************************************************************************
		private void cmdExportFiles_Click (System.Object sender, System.EventArgs e)
		{
			int i;
			for (i = 0; i <= chklstXML.CheckedIndices.Count - 1; i++)
			{
				chklstXML.SelectedIndex = chklstXML.CheckedIndices[i];
				SaveXMLSchema(chklstXML.SelectedItem + ".xml");
			}
			Interaction.MsgBox("Files Exported...", MsgBoxStyle.Information, null);
		}
		
		////****************************************************************************
		//// Updating the path to save the files
		////****************************************************************************
		private void DriveBox_SelectedIndexChanged (object sender, System.EventArgs e)
		{
			DirListBox.Path = DriveBox.Drive;
		}
		
		////****************************************************************************
		//// Saving a file
		////****************************************************************************
		private void SaveXMLSchema (string s)
		{
			System.IO.File file = null; 
			System.IO.StreamWriter Sw = null; 
			System.IO.TextWriter Tw = null; 
            
			Tw = System.IO.File.CreateText( DirListBox.Path.ToString() + @"\" + s ); 
			Tw.WriteLine( Text1.Text ); 
			Tw.Close(); 
		}
		
		private void cmdGetCompanyList_Click (System.Object sender, System.EventArgs e)
		{
			SAPbobsCOM.Recordset oRecordSet; // A recordset object
			
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
		
		private void cmdConnect_Click (System.Object sender, System.EventArgs e)
		{
			ConnectToCompany();
			
			if (oCompany.Connected == true)
			{
				MessageBox.Show("Connected to: " + oCompany.CompanyName);
			}
			else
			{
				MessageBox.Show("Not connected. Shutting down");
				ProjectData.EndApp();
			}
			this.Show();
			LoadEnumObjects();
			
		}
	}
}
