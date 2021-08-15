#define Win32
using Microsoft.VisualBasic;
using System.Data;
using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

////  SAP MANAGE DI API 2007 SDK Sample
////****************************************************************************
////
////  File:      ChooseCompany.vb
////
////  Copyright (c) SAP MANAGE
////
//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
////****************************************************************************

namespace Project1
{
	internal class ChooseCompany : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public ChooseCompany() {
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
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		public System.Windows.Forms.GroupBox Frame1;
		internal System.Windows.Forms.Button cmdGetCompanyList;
		public System.Windows.Forms.ComboBox cmbDBType;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.ComboBox Combo1;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox GroupBox1;
		public System.Windows.Forms.TextBox txtDBPass;
		public System.Windows.Forms.TextBox txtDBUser;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Button Command1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.cmdGetCompanyList = new System.Windows.Forms.Button();
			this.cmbDBType = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Combo1 = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Command1 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDBPass = new System.Windows.Forms.TextBox();
			this.txtDBUser = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.GroupBox1);
			this.Frame1.Controls.Add(this.cmdGetCompanyList);
			this.Frame1.Controls.Add(this.cmbDBType);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Combo1);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(5, 7);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(249, 201);
			this.Frame1.TabIndex = 6;
			this.Frame1.TabStop = false;
			// 
			// cmdGetCompanyList
			// 
			this.cmdGetCompanyList.Location = new System.Drawing.Point(8, 128);
			this.cmdGetCompanyList.Name = "cmdGetCompanyList";
			this.cmdGetCompanyList.Size = new System.Drawing.Size(112, 23);
			this.cmdGetCompanyList.TabIndex = 6;
			this.cmdGetCompanyList.Text = "Get Company List";
			this.cmdGetCompanyList.Click += new System.EventHandler(this.cmdGetCompanyList_Click);
			// 
			// cmbDBType
			// 
			this.cmbDBType.BackColor = System.Drawing.SystemColors.Window;
			this.cmbDBType.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDBType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbDBType.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbDBType.Items.AddRange(new object[] {
														   "MSSQL",
														   "DB_2",
														   "SYBASE",
														   "MSSQL2005",
														   "MAXDB"});
			this.cmbDBType.Location = new System.Drawing.Point(104, 16);
			this.cmbDBType.Name = "cmbDBType";
			this.cmbDBType.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbDBType.Size = new System.Drawing.Size(137, 22);
			this.cmbDBType.TabIndex = 4;
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(8, 16);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(89, 17);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "DB Type";
			// 
			// Combo1
			// 
			this.Combo1.BackColor = System.Drawing.SystemColors.Window;
			this.Combo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Combo1.Enabled = false;
			this.Combo1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Combo1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo1.Location = new System.Drawing.Point(104, 168);
			this.Combo1.Name = "Combo1";
			this.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo1.Size = new System.Drawing.Size(137, 22);
			this.Combo1.TabIndex = 2;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Enabled = false;
			this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 168);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Company DB:";
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Text2);
			this.Frame2.Controls.Add(this.Text1);
			this.Frame2.Controls.Add(this.Label3);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(5, 216);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(249, 81);
			this.Frame2.TabIndex = 7;
			this.Frame2.TabStop = false;
			// 
			// Text2
			// 
			this.Text2.AcceptsReturn = true;
			this.Text2.AutoSize = false;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text2.Enabled = false;
			this.Text2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text2.Location = new System.Drawing.Point(104, 48);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.PasswordChar = '*';
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(137, 19);
			this.Text2.TabIndex = 8;
			this.Text2.Text = "";
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
			this.Text1.Location = new System.Drawing.Point(104, 16);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(137, 19);
			this.Text1.TabIndex = 6;
			this.Text1.Text = "";
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Enabled = false;
			this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 48);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(89, 17);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Password:";
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Enabled = false;
			this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 16);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(73, 17);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "User Name:";
			// 
			// Command1
			// 
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Enabled = false;
			this.Command1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(45, 304);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(145, 33);
			this.Command1.TabIndex = 5;
			this.Command1.Text = "Connect";
			this.Command1.Click += new System.EventHandler(this.Command1_Click);
			// 
			// GroupBox1
			// 
			this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.GroupBox1.Controls.Add(this.txtDBPass);
			this.GroupBox1.Controls.Add(this.txtDBUser);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.GroupBox1.Location = new System.Drawing.Point(12, 40);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.GroupBox1.Size = new System.Drawing.Size(224, 81);
			this.GroupBox1.TabIndex = 12;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "DB Login Info";
			// 
			// txtDBPass
			// 
			this.txtDBPass.AcceptsReturn = true;
			this.txtDBPass.AutoSize = false;
			this.txtDBPass.BackColor = System.Drawing.SystemColors.Window;
			this.txtDBPass.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDBPass.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDBPass.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDBPass.Location = new System.Drawing.Point(104, 48);
			this.txtDBPass.MaxLength = 0;
			this.txtDBPass.Name = "txtDBPass";
			this.txtDBPass.PasswordChar = '*';
			this.txtDBPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDBPass.Size = new System.Drawing.Size(112, 19);
			this.txtDBPass.TabIndex = 8;
			this.txtDBPass.Text = "";
			// 
			// txtDBUser
			// 
			this.txtDBUser.AcceptsReturn = true;
			this.txtDBUser.AutoSize = false;
			this.txtDBUser.BackColor = System.Drawing.SystemColors.Window;
			this.txtDBUser.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDBUser.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDBUser.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDBUser.Location = new System.Drawing.Point(104, 16);
			this.txtDBUser.MaxLength = 0;
			this.txtDBUser.Name = "txtDBUser";
			this.txtDBUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDBUser.Size = new System.Drawing.Size(112, 19);
			this.txtDBUser.TabIndex = 6;
			this.txtDBUser.Text = "";
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 48);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "Password:";
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 16);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(73, 17);
			this.Label6.TabIndex = 5;
			this.Label6.Text = "User Name:";
			// 
			// ChooseCompany
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(258, 343);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Command1);
			this.Controls.Add(this.Frame1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(184, 250);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChooseCompany";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Choose Company DB";
			this.Load += new System.EventHandler(this.ChooseCompany_Load);
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region "Upgrade Support "
		private static ChooseCompany m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static ChooseCompany DefInstance
		{
			get{
				ChooseCompany returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new ChooseCompany();
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
		
		
		
		////****************************************************************************
		//// The Recordset is a non-business object.
		//// it is an auxiliary object for querying the DB
		////****************************************************************************
		private SAPbobsCOM.Recordset oRecordSet;
		
		private void ChooseCompany_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			cmbDBType.SelectedIndex = 3;
			
		}
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			//// setting the rest of the mandatory properties
			
			globals_Renamed.oCompany.CompanyDB = Combo1.Text;
			globals_Renamed.oCompany.UserName = Text1.Text;
			globals_Renamed.oCompany.Password = Text2.Text;
			
			//// Connecting to a company DB
			globals_Renamed.lRetCode = globals_Renamed.oCompany.Connect();
			
			if (globals_Renamed.lRetCode != 0)
			{
				int temp_int = globals_Renamed.lErrCode;
				string temp_string = globals_Renamed.sErrMsg;
				globals_Renamed.oCompany.GetLastError(out temp_int, out temp_string);
				MessageBox.Show(temp_string);
			}
			else
			{
				MessageBox.Show("Connected to " + globals_Renamed.oCompany.CompanyName);
				this.Text = this.Text + ": Connected";
				
				// Disable controls
				Label1.Enabled = false;
				Label2.Enabled = false;
				Label3.Enabled = false;
				Combo1.Enabled = false;
				Text1.Enabled = false;
				Text2.Enabled = false;
				Command1.Enabled = false;
				cmbDBType.Enabled = false;
				cmdGetCompanyList.Enabled = false;
			}
			
		}
		
		private void cmdGetCompanyList_Click (System.Object sender, System.EventArgs e)
		{
			//			int i; // to be used as an index
			
			globals_Renamed.oCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes) (cmbDBType.SelectedIndex + 1);
			globals_Renamed.oCompany.UseTrusted = false;
			globals_Renamed.oCompany.DbUserName = txtDBUser.Text;
			globals_Renamed.oCompany.DbPassword = txtDBPass.Text;
			
			//// once the Server property of the Company is set
			//// we may query for a list of companies to choos from
			//// this method returns a Recordset object
			try
			{
				oRecordSet = globals_Renamed.oCompany.GetCompanyList();
				
				//// Use GetLastError method directly after a function
				//// which doesn't have a return code
				//// you may also use the On Error GoTo.
				//// functions with no return codes throws exceptions
				
				int temp_int = globals_Renamed.lErrCode;
				string temp_string = globals_Renamed.sErrMsg;
				globals_Renamed.oCompany.GetLastError(out temp_int, out temp_string);
				
				if (temp_int != 0)
				{
					MessageBox.Show(temp_string);
				}
				else
				{
					if (globals_Renamed.oCompany.Connected == false)
					{
						//// Load the available company DB names to the combo box
						//// the returned Recordset containds 4 fields:
						//// dbName - represents the database name
						//// cmpName - represents the company name
						//// versStr - represents the version number of the company database
						//// dbUser - represents the database owner
						//// we are interested in the first filed (mandatory property)
						
						//// Clear the company list
						Combo1.Items.Clear();
						//// Go through the Recordset and extract the dbname
						while (!(oRecordSet.EoF == true))
						{
							//// add the value of the first field of the Recordset
							Combo1.Items.Add(oRecordSet.Fields.Item(0).Value);
							//// move the record pointer to the next row
							oRecordSet.MoveNext();
						}
						
						// Enable controls
						Label1.Enabled = true;
						Label2.Enabled = true;
						Label3.Enabled = true;
						Combo1.Enabled = true;
						Text1.Enabled = true;
						Text2.Enabled = true;
						Command1.Enabled = true;
					}
					
				}
				
				if (globals_Renamed.oCompany.Connected == true)
				{
					//// if the company object is allreay connected to a DB
					//// you must first Disconnect it before connecting it
					//// to a different DB
					//// bare in mind that by disconnecting the company object
					//// you lose all of the properties (Server, Language)
					Command1.Enabled = false;
					Combo1.SelectedText = globals_Renamed.oCompany.CompanyDB;
					Text1.Text = globals_Renamed.oCompany.UserName;
					Text2.Text = globals_Renamed.oCompany.Password;
					this.Text = this.Text + ": Connected";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				globals_Renamed.InitializeCompany();
			}
		}
	}
}
