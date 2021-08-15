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
	internal class Conversions : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public Conversions() {
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
		public System.Windows.Forms.TextBox Text6;
		public System.Windows.Forms.TextBox Text5;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.TextBox Text4;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TextBox Text3;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(Conversions_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Text6 = new System.Windows.Forms.TextBox();
			this.Text5 = new System.Windows.Forms.TextBox();
			this.Command2 = new System.Windows.Forms.Button();
			Command2.Click += new System.EventHandler(Command2_Click);
			this.Text4 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.Text6);
			this.Frame1.Controls.Add(this.Text5);
			this.Frame1.Controls.Add(this.Command2);
			this.Frame1.Controls.Add(this.Text4);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(0, 152);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(241, 137);
			this.Frame1.TabIndex = 8;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Valid Value To Enum Value";
			//
			//Text6
			//
			this.Text6.AcceptsReturn = true;
			this.Text6.AutoSize = false;
			this.Text6.BackColor = System.Drawing.SystemColors.Window;
			this.Text6.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text6.Enabled = false;
			this.Text6.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text6.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text6.Location = new System.Drawing.Point(112, 24);
			this.Text6.MaxLength = 0;
			this.Text6.Name = "Text6";
			this.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text6.Size = new System.Drawing.Size(120, 19);
			this.Text6.TabIndex = 12;
			this.Text6.Text = "BoCardTypes";
			//
			//Text5
			//
			this.Text5.AcceptsReturn = true;
			this.Text5.AutoSize = false;
			this.Text5.BackColor = System.Drawing.SystemColors.Window;
			this.Text5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text5.Enabled = false;
			this.Text5.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text5.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text5.Location = new System.Drawing.Point(112, 48);
			this.Text5.MaxLength = 0;
			this.Text5.Name = "Text5";
			this.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text5.Size = new System.Drawing.Size(120, 19);
			this.Text5.TabIndex = 11;
			this.Text5.Text = "S";
			//
			//Command2
			//
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(72, 104);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(97, 25);
			this.Command2.TabIndex = 10;
			this.Command2.Text = "Execute";
			//
			//Text4
			//
			this.Text4.AcceptsReturn = true;
			this.Text4.AutoSize = false;
			this.Text4.BackColor = System.Drawing.SystemColors.Window;
			this.Text4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text4.Enabled = false;
			this.Text4.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text4.Location = new System.Drawing.Point(112, 72);
			this.Text4.MaxLength = 0;
			this.Text4.Name = "Text4";
			this.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text4.Size = new System.Drawing.Size(120, 19);
			this.Text4.TabIndex = 9;
			this.Text4.Text = "";
			//
			//Label6
			//
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 24);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(104, 17);
			this.Label6.TabIndex = 15;
			this.Label6.Text = "Enumeration Name:";
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(8, 48);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(89, 17);
			this.Label4.TabIndex = 14;
			this.Label4.Text = "Valid Value:";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 72);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(104, 17);
			this.Label3.TabIndex = 13;
			this.Label3.Text = "Enumeration Value:";
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Text3);
			this.Frame2.Controls.Add(this.Command1);
			this.Frame2.Controls.Add(this.Text2);
			this.Frame2.Controls.Add(this.Text1);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(0, 8);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(241, 137);
			this.Frame2.TabIndex = 4;
			this.Frame2.TabStop = false;
			this.Frame2.Text = "Enum Value To Valid Value";
			//
			//Text3
			//
			this.Text3.AcceptsReturn = true;
			this.Text3.AutoSize = false;
			this.Text3.BackColor = System.Drawing.SystemColors.Window;
			this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text3.Enabled = false;
			this.Text3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text3.Location = new System.Drawing.Point(112, 72);
			this.Text3.MaxLength = 0;
			this.Text3.Name = "Text3";
			this.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text3.Size = new System.Drawing.Size(120, 19);
			this.Text3.TabIndex = 2;
			this.Text3.Text = "";
			//
			//Command1
			//
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(72, 104);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.TabIndex = 3;
			this.Command1.Text = "Execute";
			//
			//Text2
			//
			this.Text2.AcceptsReturn = true;
			this.Text2.AutoSize = false;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text2.Enabled = false;
			this.Text2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text2.Location = new System.Drawing.Point(112, 48);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(120, 19);
			this.Text2.TabIndex = 1;
			this.Text2.Text = "cCustomer";
			//
			//Text1
			//
			this.Text1.AcceptsReturn = true;
			this.Text1.AutoSize = false;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text1.Enabled = false;
			this.Text1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text1.Location = new System.Drawing.Point(112, 24);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(120, 19);
			this.Text1.TabIndex = 0;
			this.Text1.Text = "BoCardTypes";
			//
			//Label5
			//
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 48);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(104, 17);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "Enumeration Value:";
			//
			//Label2
			//
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 72);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(89, 17);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Valid Value:";
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 24);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(104, 17);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Enumeration Name:";
			//
			//Conversions
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(242, 288);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Frame2);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(265, 213);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Conversions";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Conversion bobs";
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static Conversions m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static Conversions DefInstance
		{
			get{
				Conversions returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new Conversions();
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
		////  File:      Conversions.frm
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
		
		private void Conversions_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				//// Get an initialized SBObob object
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				
				
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
				//// the return value of this method is
				//// the actual value used to mark a business partner
				//// as a customer in the data base
				Text3.Text = oSBObob.ConvertEnumValueToValidValue("BoCardTypes", System.Convert.ToInt32(SAPbobsCOM.BoCardTypes.cCustomer));
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
		
		private void Command2_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			int res;
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				//// Execute the method
				//// the return value of this method is
				//// the value used to state a business partner
				//// as a supplier in the DI
				res = oSBObob.ConvertValidValueToEnumValue("BoCardTypes", "S");
				
				
				switch (res)
				{
					default:
						if (res == System.Convert.ToInt32(SAPbobsCOM.BoCardTypes.cLid))
						{
							
							Text4.Text = "cLid";
							break;
						}
						if (res == System.Convert.ToInt32(SAPbobsCOM.BoCardTypes.cSupplier))
						{
							
							Text4.Text = "cSupplier";
							break;
						}
						if (res == System.Convert.ToInt32(SAPbobsCOM.BoCardTypes.cCustomer))
						{
							
							Text4.Text = "cCustomer";
							break;
						}
						break;
				}
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
	}
}
