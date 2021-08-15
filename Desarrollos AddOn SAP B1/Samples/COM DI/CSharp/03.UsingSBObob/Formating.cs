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
	internal class Formating : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public Formating() {
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
		public System.Windows.Forms.ComboBox Combo1;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.TextBox Text3;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Formating));
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(Formating_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ToolTip1.Active = true;
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Combo1 = new System.Windows.Forms.ComboBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Command2 = new System.Windows.Forms.Button();
			Command2.Click += new System.EventHandler(Command2_Click);
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "Formating bobs";
			this.ClientSize = new System.Drawing.Size(242, 259);
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
			this.Name = "Formating";
			this.Frame1.Text = "Money To String";
			this.Frame1.Size = new System.Drawing.Size(241, 137);
			this.Frame1.Location = new System.Drawing.Point(0, 120);
			this.Frame1.TabIndex = 4;
			this.Frame1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Visible = true;
			this.Frame1.Name = "Frame1";
			this.Combo1.Size = new System.Drawing.Size(129, 21);
			this.Combo1.Location = new System.Drawing.Point(104, 48);
			this.Combo1.TabIndex = 11;
			this.Combo1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Combo1.BackColor = System.Drawing.SystemColors.Window;
			this.Combo1.CausesValidation = true;
			this.Combo1.Enabled = true;
			this.Combo1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo1.IntegralHeight = true;
			this.Combo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo1.Sorted = false;
			this.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			this.Combo1.TabStop = true;
			this.Combo1.Visible = true;
			this.Combo1.Name = "Combo1";
			this.Text2.AutoSize = false;
			this.Text2.Size = new System.Drawing.Size(129, 19);
			this.Text2.Location = new System.Drawing.Point(104, 24);
			this.Text2.TabIndex = 7;
			this.Text2.Text = "0";
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
			this.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command2.Text = "Execute";
			this.Command2.Size = new System.Drawing.Size(97, 25);
			this.Command2.Location = new System.Drawing.Point(72, 104);
			this.Command2.TabIndex = 6;
			this.Command2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.CausesValidation = true;
			this.Command2.Enabled = true;
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.TabStop = true;
			this.Command2.Name = "Command2";
			this.Text3.AutoSize = false;
			this.Text3.Enabled = false;
			this.Text3.Size = new System.Drawing.Size(129, 19);
			this.Text3.Location = new System.Drawing.Point(104, 72);
			this.Text3.TabIndex = 5;
			this.Text3.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text3.AcceptsReturn = true;
			this.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text3.BackColor = System.Drawing.SystemColors.Window;
			this.Text3.CausesValidation = true;
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
			this.Label6.Text = "Amount:";
			this.Label6.Size = new System.Drawing.Size(97, 17);
			this.Label6.Location = new System.Drawing.Point(8, 24);
			this.Label6.TabIndex = 10;
			this.Label6.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.Enabled = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.UseMnemonic = true;
			this.Label6.Visible = true;
			this.Label6.AutoSize = false;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.Name = "Label6";
			this.Label4.Text = "Precision:";
			this.Label4.Size = new System.Drawing.Size(89, 17);
			this.Label4.Location = new System.Drawing.Point(8, 48);
			this.Label4.TabIndex = 9;
			this.Label4.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.Enabled = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.UseMnemonic = true;
			this.Label4.Visible = true;
			this.Label4.AutoSize = false;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Name = "Label4";
			this.Label3.Text = "Result:";
			this.Label3.Size = new System.Drawing.Size(97, 17);
			this.Label3.Location = new System.Drawing.Point(8, 72);
			this.Label3.TabIndex = 8;
			this.Label3.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Enabled = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.UseMnemonic = true;
			this.Label3.Visible = true;
			this.Label3.AutoSize = false;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Name = "Label3";
			this.Frame2.Text = "Date To String";
			this.Frame2.Size = new System.Drawing.Size(241, 105);
			this.Frame2.Location = new System.Drawing.Point(0, 8);
			this.Frame2.TabIndex = 2;
			this.Frame2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Enabled = true;
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Visible = true;
			this.Frame2.Name = "Frame2";
			this.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command1.Text = "Execute";
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.Location = new System.Drawing.Point(72, 64);
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
			this.Text1.AutoSize = false;
			this.Text1.Enabled = false;
			this.Text1.Size = new System.Drawing.Size(121, 19);
			this.Text1.Location = new System.Drawing.Point(112, 32);
			this.Text1.TabIndex = 0;
			this.Text1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text1.AcceptsReturn = true;
			this.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.CausesValidation = true;
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
			this.Label1.Text = "Format System\'s Date To String:";
			this.Label1.Size = new System.Drawing.Size(89, 33);
			this.Label1.Location = new System.Drawing.Point(8, 24);
			this.Label1.TabIndex = 3;
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
			this.Controls.Add(Frame1);
			this.Controls.Add(Frame2);
			this.Frame1.Controls.Add(Combo1);
			this.Frame1.Controls.Add(Text2);
			this.Frame1.Controls.Add(Command2);
			this.Frame1.Controls.Add(Text3);
			this.Frame1.Controls.Add(Label6);
			this.Frame1.Controls.Add(Label4);
			this.Frame1.Controls.Add(Label3);
			this.Frame2.Controls.Add(Command1);
			this.Frame2.Controls.Add(Text1);
			this.Frame2.Controls.Add(Label1);
		}
		#endregion
		#region "Upgrade Support "
		private static Formating m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static Formating DefInstance
		{
			get{
				Formating returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new Formating();
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
		////  File:      Formating.frm
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
		
		
		private void Formating_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			SetComboBox();
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				//// Get an initialized SBObob object
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				//// Get an initialized Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				
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
				
				//// Execute the method
				//// this methos will format the system's date (DateTime.Date)
				//// to string
				
				oRecordSet = oSBObob.Format_DateToString(DateAndTime.Today);
				
				//// To use the opposite method StringToDate
				//// insert a string in a format similar to the
				//// one resulted by the DateToString method
				
				Text1.Text = oRecordSet.Fields.Item(0).Value.ToString();
				
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
		
		private void Command2_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			int lPrecision = 0;
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				
				switch (Microsoft.VisualBasic.Compatibility.VB6.Support.GetItemString(Combo1, Combo1.SelectedIndex))
				{
					case "Sum":
						
						lPrecision = System.Convert.ToInt32(SAPbobsCOM.BoMoneyPrecisionTypes.mpt_Sum);
						break;
					case "Price":
						
						lPrecision = System.Convert.ToInt32(SAPbobsCOM.BoMoneyPrecisionTypes.mpt_Price);
						break;
					case "Rate":
						
						lPrecision = System.Convert.ToInt32(SAPbobsCOM.BoMoneyPrecisionTypes.mpt_Rate);
						break;
					case "Quantity":
						
						lPrecision = System.Convert.ToInt32(SAPbobsCOM.BoMoneyPrecisionTypes.mpt_Quantity);
						break;
					case "Percent":
						
						lPrecision = System.Convert.ToInt32(SAPbobsCOM.BoMoneyPrecisionTypes.mpt_Percent);
						break;
					case "Measure":
						
						lPrecision = System.Convert.ToInt32(SAPbobsCOM.BoMoneyPrecisionTypes.mpt_Measure);
						break;
					case "Tax":
						
						lPrecision = System.Convert.ToInt32(SAPbobsCOM.BoMoneyPrecisionTypes.mpt_Tax);
						break;
				}
				
				//// Execute the method
				//// the return value of this method is
				//// a string formated with the requested precision
				oRecordSet = oSBObob.Format_MoneyToString(System.Convert.ToDouble(Text2.Text), (SAPbobsCOM.BoMoneyPrecisionTypes) lPrecision);
				
				Text3.Text = oRecordSet.Fields.Item(0).Value.ToString();
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
		
		private void SetComboBox ()
		{
			
			Combo1.Items.Add("Sum");
			Combo1.Items.Add("Price");
			Combo1.Items.Add("Rate");
			Combo1.Items.Add("Quantity");
			Combo1.Items.Add("Percent");
			Combo1.Items.Add("Measure");
			Combo1.Items.Add("Tax");
			
			Combo1.SelectedIndex = 0;
			
		}
	}
}
