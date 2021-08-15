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
	internal class IndexRate : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public IndexRate() {
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
		public System.Windows.Forms.TextBox Text3;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(IndexRate));
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ToolTip1.Active = true;
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "GetIndexRate bob";
			this.ClientSize = new System.Drawing.Size(242, 132);
			this.Location = new System.Drawing.Point(265, 213);
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
			this.Name = "IndexRate";
			this.Frame2.Size = new System.Drawing.Size(241, 129);
			this.Frame2.Location = new System.Drawing.Point(0, 0);
			this.Frame2.TabIndex = 1;
			this.Frame2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Enabled = true;
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Visible = true;
			this.Frame2.Name = "Frame2";
			this.Text3.AutoSize = false;
			this.Text3.Size = new System.Drawing.Size(113, 19);
			this.Text3.Location = new System.Drawing.Point(120, 64);
			this.Text3.TabIndex = 7;
			this.Text3.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text3.AcceptsReturn = true;
			this.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text3.BackColor = System.Drawing.SystemColors.Window;
			this.Text3.CausesValidation = true;
			this.Text3.Enabled = true;
			this.Text3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text3.HideSelection = true;
			this.Text3.ReadOnly = false;
			this.Text3.MaxLength = 0;
			this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text3.Multiline = false;
			this.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text3.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.Text3.TabStop = true;
			this.Text3.Visible = true;
			this.Text3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Text3.Name = "Text3";
			this.Text2.AutoSize = false;
			this.Text2.Size = new System.Drawing.Size(113, 19);
			this.Text2.Location = new System.Drawing.Point(120, 40);
			this.Text2.TabIndex = 6;
			this.Text2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text2.AcceptsReturn = true;
			this.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.CausesValidation = true;
			this.Text2.Enabled = true;
			this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text2.HideSelection = true;
			this.Text2.ReadOnly = false;
			this.Text2.MaxLength = 0;
			this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text2.Multiline = false;
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.Text2.TabStop = true;
			this.Text2.Visible = true;
			this.Text2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Text2.Name = "Text2";
			this.Text1.AutoSize = false;
			this.Text1.Size = new System.Drawing.Size(113, 19);
			this.Text1.Location = new System.Drawing.Point(120, 16);
			this.Text1.TabIndex = 4;
			this.Text1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text1.AcceptsReturn = true;
			this.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.CausesValidation = true;
			this.Text1.Enabled = true;
			this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text1.HideSelection = true;
			this.Text1.ReadOnly = false;
			this.Text1.MaxLength = 0;
			this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text1.Multiline = false;
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.Text1.TabStop = true;
			this.Text1.Visible = true;
			this.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Text1.Name = "Text1";
			this.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command1.Text = "Execute";
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.Location = new System.Drawing.Point(72, 96);
			this.Command1.TabIndex = 0;
			this.Command1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.CausesValidation = true;
			this.Command1.Enabled = true;
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.TabStop = true;
			this.Command1.Name = "Command1";
			this.Label2.Text = "Date:";
			this.Label2.Size = new System.Drawing.Size(89, 17);
			this.Label2.Location = new System.Drawing.Point(8, 40);
			this.Label2.TabIndex = 5;
			this.Label2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Enabled = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.UseMnemonic = true;
			this.Label2.Visible = true;
			this.Label2.AutoSize = false;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.Name = "Label2";
			this.Label5.Text = "Index Rate:";
			this.Label5.Size = new System.Drawing.Size(73, 17);
			this.Label5.Location = new System.Drawing.Point(8, 64);
			this.Label5.TabIndex = 3;
			this.Label5.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.Enabled = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.UseMnemonic = true;
			this.Label5.Visible = true;
			this.Label5.AutoSize = false;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.Name = "Label5";
			this.Label1.Text = "Price Index Code:";
			this.Label1.Size = new System.Drawing.Size(129, 17);
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.TabIndex = 2;
			this.Label1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Enabled = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.UseMnemonic = true;
			this.Label1.Visible = true;
			this.Label1.AutoSize = false;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Name = "Label1";
			this.Controls.Add(Frame2);
			this.Frame2.Controls.Add(Text3);
			this.Frame2.Controls.Add(Text2);
			this.Frame2.Controls.Add(Text1);
			this.Frame2.Controls.Add(Command1);
			this.Frame2.Controls.Add(Label2);
			this.Frame2.Controls.Add(Label5);
			this.Frame2.Controls.Add(Label1);
		}
		#endregion
		#region "Upgrade Support "
		private static IndexRate m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static IndexRate DefInstance
		{
			get{
				IndexRate returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new IndexRate();
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
		////  File:      IndexRate.frm
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			SAPbobsCOM.SBObob oSBObob;
			SAPbobsCOM.Recordset oRecordSet;
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				//// Get an initialized SBObob object
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				//// Get an initialized Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				
				oRecordSet = oSBObob.GetIndexRate(Text1.Text, System.Convert.ToDateTime(Text2.Text));
				
				Text3.Text = oRecordSet.Fields.Item(0).Value.ToString();
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
	}
}
