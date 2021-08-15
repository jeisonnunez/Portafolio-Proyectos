#define Win32
using Microsoft.VisualBasic;
using System.Data;
using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace Project1
{
	internal class UsingSBObob : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			Application.Run(new UsingSBObob());
		}
		#region "Windows Form Designer generated code "
		public UsingSBObob() {
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
		public System.Windows.Forms.Button Command12;
		public System.Windows.Forms.Button Command11;
		public System.Windows.Forms.Button Command10;
		public System.Windows.Forms.Button Command9;
		public System.Windows.Forms.Button Command8;
		public System.Windows.Forms.Button Command7;
		public System.Windows.Forms.Button Command6;
		public System.Windows.Forms.Button Command5;
		public System.Windows.Forms.Button Command4;
		public System.Windows.Forms.Button Command3;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.GroupBox Frame1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(UsingSBObob));
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(UsingSBObob_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ToolTip1.Active = true;
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Command12 = new System.Windows.Forms.Button();
			Command12.Click += new System.EventHandler(Command12_Click);
			this.Command11 = new System.Windows.Forms.Button();
			Command11.Click += new System.EventHandler(Command11_Click);
			this.Command10 = new System.Windows.Forms.Button();
			Command10.Click += new System.EventHandler(Command10_Click);
			this.Command9 = new System.Windows.Forms.Button();
			Command9.Click += new System.EventHandler(Command9_Click);
			this.Command8 = new System.Windows.Forms.Button();
			Command8.Click += new System.EventHandler(Command8_Click);
			this.Command7 = new System.Windows.Forms.Button();
			Command7.Click += new System.EventHandler(Command7_Click);
			this.Command6 = new System.Windows.Forms.Button();
			Command6.Click += new System.EventHandler(Command6_Click);
			this.Command5 = new System.Windows.Forms.Button();
			Command5.Click += new System.EventHandler(Command5_Click);
			this.Command4 = new System.Windows.Forms.Button();
			Command4.Click += new System.EventHandler(Command4_Click);
			this.Command3 = new System.Windows.Forms.Button();
			Command3.Click += new System.EventHandler(Command3_Click);
			this.Command2 = new System.Windows.Forms.Button();
			Command2.Click += new System.EventHandler(Command2_Click);
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "Using SBObob";
			this.ClientSize = new System.Drawing.Size(257, 498);
			this.Location = new System.Drawing.Point(258, 210);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ShowInTaskbar = false;
			this.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ControlBox = true;
			this.Enabled = true;
			this.KeyPreview = false;
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.HelpButton = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Name = "UsingSBObob";
			this.Frame1.Size = new System.Drawing.Size(257, 497);
			this.Frame1.Location = new System.Drawing.Point(0, 0);
			this.Frame1.TabIndex = 0;
			this.Frame1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Visible = true;
			this.Frame1.Name = "Frame1";
			this.Command12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command12.Text = "Get Object Key By Single Value";
			this.Command12.Size = new System.Drawing.Size(225, 33);
			this.Command12.Location = new System.Drawing.Point(16, 456);
			this.Command12.TabIndex = 12;
			this.Command12.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command12.BackColor = System.Drawing.SystemColors.Control;
			this.Command12.CausesValidation = true;
			this.Command12.Enabled = true;
			this.Command12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command12.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command12.TabStop = true;
			this.Command12.Name = "Command12";
			this.Command11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command11.Text = "Formating bobs";
			this.Command11.Size = new System.Drawing.Size(225, 33);
			this.Command11.Location = new System.Drawing.Point(16, 416);
			this.Command11.TabIndex = 11;
			this.Command11.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command11.BackColor = System.Drawing.SystemColors.Control;
			this.Command11.CausesValidation = true;
			this.Command11.Enabled = true;
			this.Command11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command11.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command11.TabStop = true;
			this.Command11.Name = "Command11";
			this.Command10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command10.Text = "Get Contact Emploees";
			this.Command10.Size = new System.Drawing.Size(225, 33);
			this.Command10.Location = new System.Drawing.Point(16, 376);
			this.Command10.TabIndex = 10;
			this.Command10.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command10.BackColor = System.Drawing.SystemColors.Control;
			this.Command10.CausesValidation = true;
			this.Command10.Enabled = true;
			this.Command10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command10.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command10.TabStop = true;
			this.Command10.Name = "Command10";
			this.Command9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command9.Text = "Get Warehouse List";
			this.Command9.Size = new System.Drawing.Size(225, 33);
			this.Command9.Location = new System.Drawing.Point(16, 336);
			this.Command9.TabIndex = 9;
			this.Command9.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command9.BackColor = System.Drawing.SystemColors.Control;
			this.Command9.CausesValidation = true;
			this.Command9.Enabled = true;
			this.Command9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command9.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command9.TabStop = true;
			this.Command9.Name = "Command9";
			this.Command8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command8.Text = "Get User List";
			this.Command8.Size = new System.Drawing.Size(225, 33);
			this.Command8.Location = new System.Drawing.Point(16, 296);
			this.Command8.TabIndex = 8;
			this.Command8.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command8.BackColor = System.Drawing.SystemColors.Control;
			this.Command8.CausesValidation = true;
			this.Command8.Enabled = true;
			this.Command8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command8.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command8.TabStop = true;
			this.Command8.Name = "Command8";
			this.Command7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command7.Text = "Get Item List";
			this.Command7.Size = new System.Drawing.Size(225, 33);
			this.Command7.Location = new System.Drawing.Point(16, 256);
			this.Command7.TabIndex = 7;
			this.Command7.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command7.BackColor = System.Drawing.SystemColors.Control;
			this.Command7.CausesValidation = true;
			this.Command7.Enabled = true;
			this.Command7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command7.TabStop = true;
			this.Command7.Name = "Command7";
			this.Command6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command6.Text = "Get Item Price";
			this.Command6.Size = new System.Drawing.Size(225, 33);
			this.Command6.Location = new System.Drawing.Point(16, 216);
			this.Command6.TabIndex = 6;
			this.Command6.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command6.BackColor = System.Drawing.SystemColors.Control;
			this.Command6.CausesValidation = true;
			this.Command6.Enabled = true;
			this.Command6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command6.TabStop = true;
			this.Command6.Name = "Command6";
			this.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command5.Text = "Get Index Rate";
			this.Command5.Size = new System.Drawing.Size(225, 33);
			this.Command5.Location = new System.Drawing.Point(16, 176);
			this.Command5.TabIndex = 5;
			this.Command5.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command5.BackColor = System.Drawing.SystemColors.Control;
			this.Command5.CausesValidation = true;
			this.Command5.Enabled = true;
			this.Command5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command5.TabStop = true;
			this.Command5.Name = "Command5";
			this.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command4.Text = "Conversion bobs";
			this.Command4.Size = new System.Drawing.Size(225, 33);
			this.Command4.Location = new System.Drawing.Point(16, 136);
			this.Command4.TabIndex = 4;
			this.Command4.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command4.BackColor = System.Drawing.SystemColors.Control;
			this.Command4.CausesValidation = true;
			this.Command4.Enabled = true;
			this.Command4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command4.TabStop = true;
			this.Command4.Name = "Command4";
			this.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command3.Text = "Currency  bobs";
			this.Command3.Size = new System.Drawing.Size(225, 33);
			this.Command3.Location = new System.Drawing.Point(16, 96);
			this.Command3.TabIndex = 3;
			this.Command3.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command3.BackColor = System.Drawing.SystemColors.Control;
			this.Command3.CausesValidation = true;
			this.Command3.Enabled = true;
			this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command3.TabStop = true;
			this.Command3.Name = "Command3";
			this.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command2.Text = "Get Due Date";
			this.Command2.Size = new System.Drawing.Size(225, 33);
			this.Command2.Location = new System.Drawing.Point(16, 56);
			this.Command2.TabIndex = 2;
			this.Command2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.CausesValidation = true;
			this.Command2.Enabled = true;
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.TabStop = true;
			this.Command2.Name = "Command2";
			this.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command1.Text = "Get Business Partners List";
			this.Command1.Size = new System.Drawing.Size(225, 33);
			this.Command1.Location = new System.Drawing.Point(16, 16);
			this.Command1.TabIndex = 1;
			this.Command1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.CausesValidation = true;
			this.Command1.Enabled = true;
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.TabStop = true;
			this.Command1.Name = "Command1";
			this.Controls.Add(Frame1);
			this.Frame1.Controls.Add(Command12);
			this.Frame1.Controls.Add(Command11);
			this.Frame1.Controls.Add(Command10);
			this.Frame1.Controls.Add(Command9);
			this.Frame1.Controls.Add(Command8);
			this.Frame1.Controls.Add(Command7);
			this.Frame1.Controls.Add(Command6);
			this.Frame1.Controls.Add(Command5);
			this.Frame1.Controls.Add(Command4);
			this.Frame1.Controls.Add(Command3);
			this.Frame1.Controls.Add(Command2);
			this.Frame1.Controls.Add(Command1);
		}
		#endregion
		#region "Upgrade Support "
		private static UsingSBObob m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static UsingSBObob DefInstance
		{
			get{
				UsingSBObob returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new UsingSBObob();
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
		////  SAP MANAGE DI API 2007 SDK Sample
		////****************************************************************************
		////
		////  File:      UsingSBObob.frm
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		////**************************************************************************************************
		//// BEFORE STARTING:
		//// Add reference to the "SAP Business One Objects Bridge Version 6.5"
		////-----------------------------------------------------------------
		//// 1. Project->References
		//// 2. check the "SAP Business One Objects Bridge Version 6.5" check box
		////**************************************************************************************************
		
		private void UsingSBObob_Load (System.Object eventSender, System.EventArgs eventArgs)
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
			BPList.DefInstance.ShowDialog();
		}
		private void Command2_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			DueDate.DefInstance.ShowDialog();
		}
		private void Command3_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			Currencies.DefInstance.ShowDialog();
		}
		private void Command4_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			Conversions.DefInstance.ShowDialog();
		}
		private void Command5_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			IndexRate.DefInstance.ShowDialog();
		}
		private void Command6_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			ItemPrice.DefInstance.ShowDialog();
		}
		private void Command7_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			ItemList.DefInstance.ShowDialog();
		}
		private void Command8_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			UserList.DefInstance.ShowDialog();
		}
		private void Command9_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			WarehouseList.DefInstance.ShowDialog();
		}
		private void Command10_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			ContactEmployees.DefInstance.ShowDialog();
		}
		private void Command11_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			Formating.DefInstance.ShowDialog();
		}
		private void Command12_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			KeyByValue.DefInstance.ShowDialog();
		}
	}
}
