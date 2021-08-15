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

////  SAP MANAGE DI API 2007 SDK Sample
////****************************************************************************
////
////  File:      AddUserTable.vb
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
	internal class AddUserTable : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public AddUserTable() {
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
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Button Command1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			base.Closed += new System.EventHandler(AddUserTable_Closed);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Text2);
			this.Frame2.Controls.Add(this.Text1);
			this.Frame2.Controls.Add(this.Label3);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(0, 0);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(249, 80);
			this.Frame2.TabIndex = 1;
			this.Frame2.TabStop = false;
			//
			//Text2
			//
			this.Text2.AcceptsReturn = true;
			this.Text2.AutoSize = false;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text2.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.Text2.Location = new System.Drawing.Point(104, 48);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(137, 19);
			this.Text2.TabIndex = 5;
			this.Text2.Text = "";
			//
			//Text1
			//
			this.Text1.AcceptsReturn = true;
			this.Text1.AutoSize = false;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text1.Location = new System.Drawing.Point(104, 16);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(137, 19);
			this.Text1.TabIndex = 3;
			this.Text1.Text = "";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 48);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(89, 24);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Table Description:";
			//
			//Label2
			//
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 16);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(73, 17);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Table Name:";
			//
			//Command1
			//
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(48, 88);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(145, 33);
			this.Command1.TabIndex = 0;
			this.Command1.Text = "Add Table";
			//
			//AddUserTable
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(250, 127);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Command1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(255, 270);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddUserTable";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Add User Table";
			this.Frame2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static AddUserTable m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static AddUserTable DefInstance
		{
			get{
				AddUserTable returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new AddUserTable();
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
		
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			////****************************************************************************
			//// The UserTablesMD represents a meta-data object which allows us
			//// to add\remove tables, change a table name etc.
			////****************************************************************************
			
			SAPbobsCOM.UserTablesMD oUserTablesMD;
			
			////****************************************************************************
			//// In any meta-data operation there should be no other object "alive"
			//// but the meta-data object, otherwise the operation will fail.
			//// This restriction is intended to prevent a collisions
			////****************************************************************************
			
			//// the meta-data object needs to be initialized with a
			//// regular UserTables object
			oUserTablesMD = (SAPbobsCOM.UserTablesMD) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables);
			
			////**************************************************
			//// when adding user tables or fields to the SBO DB
			//// use a prefix identifying your partner name space
			//// this will prevent collisions between different
			//// partners add-ons
			////
			//// SAP's name space prefix is "BE_"
			////**************************************************
			
			//// set the 2 mandatory fields
			oUserTablesMD.TableName = Text1.Text;
			oUserTablesMD.TableDescription = Text2.Text;
			
			//// Add the table
			//// This action add an empty table with 2 default fields
			//// 'Code' and 'Name' which serve as the key
			//// in order to add your own User Fields
			//// see the AddUserFields.frm in this project
			//// a privat, user defined, key may be added
			//// see AddPrivateKey.frm in this project
			
			globals_Renamed.lRetCode = oUserTablesMD.Add();
			
			//// check for errors in the process
			if (globals_Renamed.lRetCode != 0)
			{
				int temp_int = globals_Renamed.lErrCode;
				string temp_string = globals_Renamed.sErrMsg;
				globals_Renamed.oCompany.GetLastError(out temp_int, out temp_string);
				MessageBox.Show(temp_string);
			}
			else
			{
MessageBox.Show("Table: " + oUserTablesMD.TableName + " was added successfully");
				Text1.Text = "";
				Text2.Text = "";
			}
			
		}
		
		private void AddUserTable_Closed (object sender, System.EventArgs e)
		{
			////*************************************************
			//// in .NET environment, due to garbage collection
			//// Disposing the active form at closing is the
			//// only way to insure all memory is release
			//// and thus detroying unwanted objects
			////*************************************************
			ActiveForm.Dispose();
		}
	}
}
