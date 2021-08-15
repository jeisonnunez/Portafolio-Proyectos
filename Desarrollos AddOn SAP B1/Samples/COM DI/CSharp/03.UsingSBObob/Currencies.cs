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
	internal class Currencies : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public Currencies() {
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
		public System.Windows.Forms.TextBox Text4;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.ComboBox Combo1;
		public System.Windows.Forms.TextBox Text3;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.ComboBox Combo3;
		public System.Windows.Forms.TextBox Text5;
		public System.Windows.Forms.TextBox Text6;
		public System.Windows.Forms.ComboBox Combo2;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(Currencies_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.Text4 = new System.Windows.Forms.TextBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Combo1 = new System.Windows.Forms.ComboBox();
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Combo3 = new System.Windows.Forms.ComboBox();
			this.Text5 = new System.Windows.Forms.TextBox();
			this.Text6 = new System.Windows.Forms.TextBox();
			this.Combo2 = new System.Windows.Forms.ComboBox();
			this.Command2 = new System.Windows.Forms.Button();
			Command2.Click += new System.EventHandler(Command2_Click);
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Frame3.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//Frame3
			//
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this.Text4);
			this.Frame3.Controls.Add(this.Command1);
			this.Frame3.Controls.Add(this.Combo1);
			this.Frame3.Controls.Add(this.Text3);
			this.Frame3.Controls.Add(this.Label10);
			this.Frame3.Controls.Add(this.Label9);
			this.Frame3.Controls.Add(this.Label4);
			this.Frame3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(0, 80);
			this.Frame3.Name = "Frame3";
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(241, 153);
			this.Frame3.TabIndex = 14;
			this.Frame3.TabStop = false;
			this.Frame3.Text = "Get Currency Rate";
			//
			//Text4
			//
			this.Text4.AcceptsReturn = true;
			this.Text4.AutoSize = false;
			this.Text4.BackColor = System.Drawing.SystemColors.Window;
			this.Text4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text4.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text4.Location = new System.Drawing.Point(104, 64);
			this.Text4.MaxLength = 0;
			this.Text4.Name = "Text4";
			this.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text4.Size = new System.Drawing.Size(129, 19);
			this.Text4.TabIndex = 18;
			this.Text4.Text = "";
			//
			//Command1
			//
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(72, 120);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.TabIndex = 17;
			this.Command1.Text = "Execute";
			//
			//Combo1
			//
			this.Combo1.BackColor = System.Drawing.SystemColors.Window;
			this.Combo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Combo1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Combo1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo1.Location = new System.Drawing.Point(104, 16);
			this.Combo1.Name = "Combo1";
			this.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo1.Size = new System.Drawing.Size(129, 22);
			this.Combo1.TabIndex = 16;
			//
			//Text3
			//
			this.Text3.AcceptsReturn = true;
			this.Text3.AutoSize = false;
			this.Text3.BackColor = System.Drawing.SystemColors.Window;
			this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text3.Location = new System.Drawing.Point(104, 40);
			this.Text3.MaxLength = 0;
			this.Text3.Name = "Text3";
			this.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text3.Size = new System.Drawing.Size(129, 19);
			this.Text3.TabIndex = 15;
			this.Text3.Text = "";
			//
			//Label10
			//
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label10.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(8, 40);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(89, 17);
			this.Label10.TabIndex = 21;
			this.Label10.Text = "Date:";
			//
			//Label9
			//
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label9.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(8, 64);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(89, 17);
			this.Label9.TabIndex = 20;
			this.Label9.Text = "Exchange Rate:";
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(8, 16);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(96, 17);
			this.Label4.TabIndex = 19;
			this.Label4.Text = "Choose Currency:";
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.Combo3);
			this.Frame1.Controls.Add(this.Text5);
			this.Frame1.Controls.Add(this.Text6);
			this.Frame1.Controls.Add(this.Combo2);
			this.Frame1.Controls.Add(this.Command2);
			this.Frame1.Controls.Add(this.Label8);
			this.Frame1.Controls.Add(this.Label7);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(0, 240);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(241, 153);
			this.Frame1.TabIndex = 5;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Set Currency Rate";
			//
			//Combo3
			//
			this.Combo3.BackColor = System.Drawing.SystemColors.Window;
			this.Combo3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Combo3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Combo3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo3.Location = new System.Drawing.Point(104, 88);
			this.Combo3.Name = "Combo3";
			this.Combo3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo3.Size = new System.Drawing.Size(129, 22);
			this.Combo3.TabIndex = 22;
			//
			//Text5
			//
			this.Text5.AcceptsReturn = true;
			this.Text5.AutoSize = false;
			this.Text5.BackColor = System.Drawing.SystemColors.Window;
			this.Text5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text5.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text5.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text5.Location = new System.Drawing.Point(104, 40);
			this.Text5.MaxLength = 0;
			this.Text5.Name = "Text5";
			this.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text5.Size = new System.Drawing.Size(129, 19);
			this.Text5.TabIndex = 9;
			this.Text5.Text = "";
			//
			//Text6
			//
			this.Text6.AcceptsReturn = true;
			this.Text6.AutoSize = false;
			this.Text6.BackColor = System.Drawing.SystemColors.Window;
			this.Text6.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text6.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text6.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text6.Location = new System.Drawing.Point(104, 64);
			this.Text6.MaxLength = 0;
			this.Text6.Name = "Text6";
			this.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text6.Size = new System.Drawing.Size(129, 19);
			this.Text6.TabIndex = 8;
			this.Text6.Text = "";
			//
			//Combo2
			//
			this.Combo2.BackColor = System.Drawing.SystemColors.Window;
			this.Combo2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Combo2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Combo2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo2.Location = new System.Drawing.Point(104, 16);
			this.Combo2.Name = "Combo2";
			this.Combo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo2.Size = new System.Drawing.Size(129, 22);
			this.Combo2.TabIndex = 7;
			//
			//Command2
			//
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(72, 120);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(97, 25);
			this.Command2.TabIndex = 6;
			this.Command2.Text = "Execute";
			//
			//Label8
			//
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label8.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 16);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(96, 17);
			this.Label8.TabIndex = 13;
			this.Label8.Text = "Choose Currency:";
			//
			//Label7
			//
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label7.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(8, 64);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(89, 17);
			this.Label7.TabIndex = 12;
			this.Label7.Text = "Value:";
			//
			//Label6
			//
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 88);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(89, 17);
			this.Label6.TabIndex = 11;
			this.Label6.Text = "Update Current:";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 40);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(89, 17);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Date:";
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Text2);
			this.Frame2.Controls.Add(this.Text1);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(0, 0);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(241, 73);
			this.Frame2.TabIndex = 2;
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
			this.Text2.Location = new System.Drawing.Point(104, 40);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(129, 19);
			this.Text2.TabIndex = 1;
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
			this.Text1.Size = new System.Drawing.Size(129, 19);
			this.Text1.TabIndex = 0;
			this.Text1.Text = "";
			//
			//Label5
			//
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 40);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(96, 17);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "System Currency:";
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Local Currency:";
			//
			//Currencies
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(242, 396);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Frame2);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(265, 213);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Currencies";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Currency bobs";
			this.Frame3.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static Currencies m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static Currencies DefInstance
		{
			get{
				Currencies returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new Currencies();
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
		////  File:      Currencies.frm
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		
		private SAPbobsCOM.SBObob oSBObob;
		private SAPbobsCOM.Recordset oRecordSet;
		
		
		private void Currencies_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				SetComboBoxes();
				//// Get an initialized SBObob object
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				//// Get an initialized Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				oRecordSet = oSBObob.GetLocalCurrency();
				Text1.Text = oRecordSet.Fields.Item(0).Value.ToString();
				oRecordSet = oSBObob.GetSystemCurrency();
				Text2.Text = oRecordSet.Fields.Item(0).Value.ToString();
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				
				//// Executing the GetCurrencyRate method
				//// You can use this method to query the exchange rate
				//// between any currency and the local currency.
				//// For example, assume that the local currency is US dollars,
				//// and you use this method to query EUR on
				//// January 10, 2002. You can then use
				//// GetCurrencyRate("eur", Date("10.01.2002")).
				//// The result 0.98 from the returned Recordset object means
				//// that on January 10, 2002 the exchange rate was 1 EUR = 0.98 USD.
				
				oRecordSet = oSBObob.GetCurrencyRate(Microsoft.VisualBasic.Compatibility.VB6.Support.GetItemString(Combo1, Combo1.SelectedIndex), System.Convert.ToDateTime(Text3.Text));
				
				Text4.Text = oRecordSet.Fields.Item(0).Value.ToString();
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
		
		private void Command2_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				
				//// Executing the SetCurrencyRate method
				//// You can use this method to add a currency rate
				//// to the data base.
				
				oSBObob.SetCurrencyRate(Microsoft.VisualBasic.Compatibility.VB6.Support.GetItemString(Combo2, Combo2.SelectedIndex), System.Convert.ToDateTime(Text5.Text), System.Convert.ToDouble(Text6.Text), System.Convert.ToBoolean(Combo3.SelectedIndex));
				
				
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
		private void SetComboBoxes ()
		{
			
			Combo1.Items.Insert(0, "USD");
			Combo1.Items.Insert(1, "EUR");
			
			Combo1.SelectedIndex = 0;
			
			Combo2.Items.Insert(0, "USD");
			Combo2.Items.Insert(1, "EUR");
			
			Combo2.SelectedIndex = 0;
			
			Combo3.Items.Insert(0, "False");
			Combo3.Items.Insert(1, "True");
			
			Combo3.SelectedIndex = 0;
			
		}
	}
}
