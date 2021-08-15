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
////  File:      MetaDataOperations.vb
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
	internal class MetaDataOperations : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			Application.Run(new MetaDataOperations());
		}
		#region "Windows Form Designer generated code "
		public MetaDataOperations() {
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
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
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
		public System.Windows.Forms.Button Command3;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.GroupBox Frame1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(MetaDataOperations_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Command3 = new System.Windows.Forms.Button();
			Command3.Click += new System.EventHandler(Command3_Click);
			this.Command2 = new System.Windows.Forms.Button();
			Command2.Click += new System.EventHandler(Command2_Click);
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.Command3);
			this.Frame1.Controls.Add(this.Command2);
			this.Frame1.Controls.Add(this.Command1);
			this.Frame1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(0, 0);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(257, 233);
			this.Frame1.TabIndex = 0;
			this.Frame1.TabStop = false;
			//
			//Command3
			//
			this.Command3.BackColor = System.Drawing.SystemColors.Control;
			this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command3.Location = new System.Drawing.Point(16, 144);
			this.Command3.Name = "Command3";
			this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command3.Size = new System.Drawing.Size(225, 49);
			this.Command3.TabIndex = 3;
			this.Command3.Text = "Add Private Key";
			//
			//Command2
			//
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(16, 80);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(225, 49);
			this.Command2.TabIndex = 2;
			this.Command2.Text = "Add User Fields";
			//
			//Command1
			//
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(16, 16);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(225, 49);
			this.Command1.TabIndex = 1;
			this.Command1.Text = "Add User Table";
			//
			//TablesFieldsAnd
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(257, 233);
			this.Controls.Add(this.Frame1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(258, 210);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TablesFieldsAnd";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Meta Data Operations";
			this.Frame1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static MetaDataOperations m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static MetaDataOperations DefInstance
		{
			get{
				MetaDataOperations returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new MetaDataOperations();
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
		
		
		
		////**************************************************************************************************
		//// BEFORE STARTING:
		//// Add reference to the "SAP Business One Objects Bridge Version 2005"
		////-----------------------------------------------------------------
		//// 1. Project->References
		//// 2. check the "SAP Business One Objects Bridge Version 2005" check box
		////**************************************************************************************************
		
		private void MetaDataOperations_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			ConnectToCompany();
			
		}
		
		private void ConnectToCompany ()
		{
			
			//// Initialize the Company Object.
			//// Create a new company object
			globals_Renamed.oCompany = new SAPbobsCOM.Company();
			
			//// Set the mandatory properties for the connection to the database.
			//// To use a remote Db Server enter his name instead of the string "(local)"
			//// This string is used to work on a DB installed on your local machine
			
			globals_Renamed.oCompany.Server = "(local)";
			globals_Renamed.oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English;
			
			//// Use Windows authentication for database server.
			//// True for NT server authentication,
			//// False for database server authentication.
			globals_Renamed.oCompany.UseTrusted = true;
			
			ChooseCompany.DefInstance.ShowDialog();
			
		}
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			GC.Collect();
			AddUserTable.DefInstance.ShowDialog();
		}
		
		private void Command2_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			GC.Collect();
			AddUserFields.DefInstance.ShowDialog();
		}
		
		
		private void Command3_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			GC.Collect();
			AddPrivateKey.DefInstance.ShowDialog();
		}
		
		
	}
}
