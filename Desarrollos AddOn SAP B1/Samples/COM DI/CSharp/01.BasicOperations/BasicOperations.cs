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

//  SAP MANAGE DI API 2007 SDK Sample
//****************************************************************************
//
//  File:      BasicOperations.vb
//
//  Copyright (c) SAP MANAGE
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************

namespace Project1
{
	public class BasicOperations : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			Application.Run(new BasicOperations());
		}
		#region "Windows Form Designer generated code "
		public BasicOperations() {
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
		public System.Windows.Forms.Button Command3;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.GroupBox Frame1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BasicOperations));
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(BasicOperations_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ToolTip1.Active = true;
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Command3 = new System.Windows.Forms.Button();
			Command3.Click += new System.EventHandler(Command3_Click);
			this.Command2 = new System.Windows.Forms.Button();
			Command2.Click += new System.EventHandler(Command2_Click);
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "Basic Operations";
			this.ClientSize = new System.Drawing.Size(257, 233);
			this.Location = new System.Drawing.Point(184, 250);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ShowInTaskbar = false;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ControlBox = true;
			this.Enabled = true;
			this.KeyPreview = false;
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.HelpButton = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Name = "BasicOperations";
			this.Frame1.Size = new System.Drawing.Size(257, 233);
			this.Frame1.Location = new System.Drawing.Point(0, 0);
			this.Frame1.TabIndex = 0;
			this.Frame1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Visible = true;
			this.Frame1.Name = "Frame1";
			this.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command3.Text = "Data Browser Operations";
			this.Command3.Size = new System.Drawing.Size(225, 49);
			this.Command3.Location = new System.Drawing.Point(16, 144);
			this.Command3.TabIndex = 3;
			this.Command3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command3.BackColor = System.Drawing.SystemColors.Control;
			this.Command3.CausesValidation = true;
			this.Command3.Enabled = true;
			this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command3.TabStop = true;
			this.Command3.Name = "Command3";
			this.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command2.Text = "Recordset Operations";
			this.Command2.Size = new System.Drawing.Size(225, 49);
			this.Command2.Location = new System.Drawing.Point(16, 80);
			this.Command2.TabIndex = 2;
			this.Command2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.CausesValidation = true;
			this.Command2.Enabled = true;
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.TabStop = true;
			this.Command2.Name = "Command2";
			this.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command1.Text = "Choose Company DB";
			this.Command1.Size = new System.Drawing.Size(225, 49);
			this.Command1.Location = new System.Drawing.Point(16, 16);
			this.Command1.TabIndex = 1;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.CausesValidation = true;
			this.Command1.Enabled = true;
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.TabStop = true;
			this.Command1.Name = "Command1";
			this.Controls.Add(Frame1);
			this.Frame1.Controls.Add(Command3);
			this.Frame1.Controls.Add(Command2);
			this.Frame1.Controls.Add(Command1);
		}
		#endregion
		#region "Upgrade Support "
		private static BasicOperations m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static BasicOperations DefInstance
		{
			get{
				BasicOperations returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new BasicOperations();
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
		
		
		
		//**************************************************************************************************
		// BEFORE STARTING:
		// Add reference to the "SAP Business One Objects Bridge Version 2005"
		//-----------------------------------------------------------------
		// 1. Project->References
		// 2. check the "SAP Business One Objects Bridge Version 2005" check box
		//**************************************************************************************************
		
		private void BasicOperations_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			// as long as we don'thave connection
			// to a data base
			Command2.Enabled = false;
			Command3.Enabled = false;
			
			
			globals_Renamed.InitializeCompany();
			
		}
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			ChooseCompany.DefInstance.ShowDialog();
			
			if (globals_Renamed.oCompany.Connected == true)
			{
				Command2.Enabled = true;
				Command3.Enabled = true;
			}
			
		}
		
		private void Command2_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			RecordsetOperations.DefInstance.ShowDialog();
		}
		
		
		private void Command3_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			DataBrowserOperations.DefInstance.ShowDialog();
		}
	}
}
