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
	internal class ItemPrice : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public ItemPrice() {
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
		public System.Windows.Forms.TextBox Text5;
		public System.Windows.Forms.TextBox Text4;
		public System.Windows.Forms.TextBox Text3;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text5 = new System.Windows.Forms.TextBox();
			this.Text4 = new System.Windows.Forms.TextBox();
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Text5);
			this.Frame2.Controls.Add(this.Text4);
			this.Frame2.Controls.Add(this.Text3);
			this.Frame2.Controls.Add(this.Text2);
			this.Frame2.Controls.Add(this.Text1);
			this.Frame2.Controls.Add(this.Command1);
			this.Frame2.Controls.Add(this.Label4);
			this.Frame2.Controls.Add(this.Label3);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(0, 0);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(241, 185);
			this.Frame2.TabIndex = 1;
			this.Frame2.TabStop = false;
			//
			//Text5
			//
			this.Text5.AcceptsReturn = true;
			this.Text5.AutoSize = false;
			this.Text5.BackColor = System.Drawing.SystemColors.Window;
			this.Text5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text5.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text5.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text5.Location = new System.Drawing.Point(104, 120);
			this.Text5.MaxLength = 0;
			this.Text5.Name = "Text5";
			this.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text5.Size = new System.Drawing.Size(97, 19);
			this.Text5.TabIndex = 11;
			this.Text5.Text = "";
			//
			//Text4
			//
			this.Text4.AcceptsReturn = true;
			this.Text4.AutoSize = false;
			this.Text4.BackColor = System.Drawing.SystemColors.Window;
			this.Text4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text4.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text4.Location = new System.Drawing.Point(136, 88);
			this.Text4.MaxLength = 0;
			this.Text4.Name = "Text4";
			this.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text4.Size = new System.Drawing.Size(96, 19);
			this.Text4.TabIndex = 10;
			this.Text4.Text = "";
			//
			//Text3
			//
			this.Text3.AcceptsReturn = true;
			this.Text3.AutoSize = false;
			this.Text3.BackColor = System.Drawing.SystemColors.Window;
			this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text3.Location = new System.Drawing.Point(136, 64);
			this.Text3.MaxLength = 0;
			this.Text3.Name = "Text3";
			this.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text3.Size = new System.Drawing.Size(96, 19);
			this.Text3.TabIndex = 9;
			this.Text3.Text = "1";
			//
			//Text2
			//
			this.Text2.AcceptsReturn = true;
			this.Text2.AutoSize = false;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text2.Location = new System.Drawing.Point(136, 40);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(96, 19);
			this.Text2.TabIndex = 7;
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
			this.Text1.Location = new System.Drawing.Point(136, 16);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(96, 19);
			this.Text1.TabIndex = 6;
			this.Text1.Text = "";
			//
			//Command1
			//
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(72, 152);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.TabIndex = 0;
			this.Command1.Text = "Execute";
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(24, 120);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(81, 17);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Item Price:";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 88);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(104, 17);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Transaction Date:";
			//
			//Label2
			//
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 64);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(89, 17);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Amount:";
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
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.TabIndex = 3;
			this.Label5.Text = "Item Name:";
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
			this.Label1.Size = new System.Drawing.Size(128, 17);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Business Partner Name:";
			//
			//ItemPrice
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(242, 187);
			this.Controls.Add(this.Frame2);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(265, 213);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ItemPrice";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "GetItemPrice bob";
			this.Frame2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static ItemPrice m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static ItemPrice DefInstance
		{
			get{
				ItemPrice returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new ItemPrice();
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
		////  File:      ItemPrice.frm
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
			
			//			int i;
			
			string sCardCode;
			string sItemCode;
			double dAmount;
			DateTime TransactionDate;
			
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				////**************************************************************
				//// first set the parameters required by the GetItemPrice method
				////**************************************************************
				
				
				//// Get an initialized SBObob object
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				//// Get an initialized Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				
				//// Execute the SBObob GetObjectKeyBySingleValue method
				//// to get the partner's CardCode
				oRecordSet = oSBObob.GetObjectKeyBySingleValue(SAPbobsCOM.BoObjectTypes.oBusinessPartners, "CardName", Text1.Text, SAPbobsCOM.BoQueryConditions.bqc_Equal);
				
				//UPGRADE_WARNING: Couldn't resolve default property of object oRecordSet.Fields().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				sCardCode = oRecordSet.Fields.Item(0).Value.ToString();
				
				//// Execute the SBObob GetObjectKeyBySingleValue method
				//// to get the Item's ItemCode
				oRecordSet = oSBObob.GetObjectKeyBySingleValue(SAPbobsCOM.BoObjectTypes.oItems, "ItemName", Text2.Text, SAPbobsCOM.BoQueryConditions.bqc_Equal);
				
				sItemCode = oRecordSet.Fields.Item(0).Value.ToString();
				
				dAmount = System.Convert.ToDouble(Text3.Text);
				
				TransactionDate = System.Convert.ToDateTime(Text4.Text);
				
				////****************************************************
				//// Executing the SBObob GetItemPrice
				////****************************************************
				
				oRecordSet = oSBObob.GetItemPrice(sCardCode, sItemCode, dAmount, TransactionDate);
				
				Text5.Text = oRecordSet.Fields.Item(0).Value + " " + oRecordSet.Fields.Item(1).Value;
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
	}
}
