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
	internal class KeyByValue : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public KeyByValue() {
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
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.ComboBox Combo2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.ListBox List1;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.ComboBox Combo1;
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
			base.Load += new System.EventHandler(KeyByValue_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Combo2 = new System.Windows.Forms.ComboBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.List1 = new System.Windows.Forms.ListBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Combo1 = new System.Windows.Forms.ComboBox();
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
			this.Frame2.Controls.Add(this.Text2);
			this.Frame2.Controls.Add(this.Combo2);
			this.Frame2.Controls.Add(this.Text1);
			this.Frame2.Controls.Add(this.List1);
			this.Frame2.Controls.Add(this.Command1);
			this.Frame2.Controls.Add(this.Combo1);
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
			this.Frame2.Size = new System.Drawing.Size(241, 385);
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
			this.Text2.Location = new System.Drawing.Point(112, 112);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(120, 19);
			this.Text2.TabIndex = 11;
			this.Text2.Text = "Bob";
			//
			//Combo2
			//
			this.Combo2.BackColor = System.Drawing.SystemColors.Window;
			this.Combo2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Combo2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Combo2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo2.Location = new System.Drawing.Point(112, 80);
			this.Combo2.Name = "Combo2";
			this.Combo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo2.Size = new System.Drawing.Size(120, 22);
			this.Combo2.TabIndex = 10;
			this.Combo2.Text = "Equal";
			//
			//Text1
			//
			this.Text1.AcceptsReturn = true;
			this.Text1.AutoSize = false;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text1.Location = new System.Drawing.Point(112, 48);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(120, 19);
			this.Text1.TabIndex = 9;
			this.Text1.Text = "ContactPerson";
			//
			//List1
			//
			this.List1.BackColor = System.Drawing.SystemColors.Window;
			this.List1.Cursor = System.Windows.Forms.Cursors.Default;
			this.List1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.List1.ItemHeight = 14;
			this.List1.Location = new System.Drawing.Point(8, 168);
			this.List1.Name = "List1";
			this.List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.List1.Size = new System.Drawing.Size(225, 172);
			this.List1.TabIndex = 5;
			//
			//Command1
			//
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(72, 352);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.TabIndex = 1;
			this.Command1.Text = "Execute";
			//
			//Combo1
			//
			this.Combo1.BackColor = System.Drawing.SystemColors.Window;
			this.Combo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Combo1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Combo1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo1.Location = new System.Drawing.Point(112, 16);
			this.Combo1.Name = "Combo1";
			this.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo1.Size = new System.Drawing.Size(120, 22);
			this.Combo1.TabIndex = 0;
			this.Combo1.Text = "BusinessPartner";
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(8, 112);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(73, 17);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Value:";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 80);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(73, 17);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Condition:";
			//
			//Label2
			//
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 48);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(81, 17);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Property Name:";
			//
			//Label5
			//
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 144);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "First 10 Results:";
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
			this.Label1.Size = new System.Drawing.Size(104, 17);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Select Object Type:";
			//
			//KeyByValue
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(242, 388);
			this.Controls.Add(this.Frame2);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(265, 213);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "KeyByValue";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "GetObjectKeyBySingleValue bob";
			this.Frame2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static KeyByValue m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static KeyByValue DefInstance
		{
			get{
				KeyByValue returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new KeyByValue();
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
		////  File:      KeyByValue.frm
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		
		private void KeyByValue_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			SetComboBoxes();
		}
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			
			SAPbobsCOM.SBObob oSBObob;
			SAPbobsCOM.Recordset oRecordSet;
			SAPbobsCOM.BusinessPartners oBusinessPartner;
			SAPbobsCOM.Items oItem;
			
			
			int i;
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				
				//// Get an initialized SBObob object
				//oSBObob = oCompany.GetBusinessObject(SAPbobsCOM.SBObob)
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				//// Get an initialized Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				
				
				i = 0;
				List1.Items.Clear();
				////******************************************************
				//// only Items and BusinessPartners Object type are used
				//// in this sample.
				////******************************************************
				
				if (Microsoft.VisualBasic.Compatibility.VB6.Support.GetItemString(Combo1, Combo1.SelectedIndex) == "BusinessPartners")
				{
					
					//// Get an initialized BusinessPartners object
					oBusinessPartner = (SAPbobsCOM.BusinessPartners) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
					
					//// Execute the SBObob GetObjectKeyBySingleValue method
					oRecordSet = oSBObob.GetObjectKeyBySingleValue(SAPbobsCOM.BoObjectTypes.oBusinessPartners, Text1.Text, Text2.Text, (SAPbobsCOM.BoQueryConditions) Combo2.SelectedIndex);
					
					List1.Items.Add("Code" + "\t" + "\t" + "Name");
					List1.Items.Add("-------------------------------------------------------------");
					
					//// use the RecordSet to set the BusnessPartners object
					//// by using the GetByKey method
					
					while (!(oRecordSet.EoF == true))
					{
						//// make sure the record set didn't reach the EOF
						if (oRecordSet.EoF == false && i < 10)
						{
							//// set the business partners object
							oBusinessPartner.GetByKey(oRecordSet.Fields.Item(0).Value.ToString());
							//// add the partner's code and name to the list box
							List1.Items.Add(oBusinessPartner.CardCode + "\t" + "\t" + oBusinessPartner.CardName);
							i = i + 1;
						}
						oRecordSet.MoveNext();
					}
					
				}
				else
				{
					
					//// Get an initialized Items object
					oItem = (SAPbobsCOM.Items) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems);
					
					//// Execute the SBObob GetObjectKeyBySingleValue method
					oRecordSet = oSBObob.GetObjectKeyBySingleValue(SAPbobsCOM.BoObjectTypes.oItems, Text1.Text, Text2.Text, (SAPbobsCOM.BoQueryConditions) Combo2.SelectedIndex);
					
					List1.Items.Add("Code" + "\t" + "\t" + "Name");
					List1.Items.Add("-------------------------------------------------------------");
					
					//// use the RecordSet to set the BusnessPartners object
					//// by using the GetByKey method
					
					while (!(oRecordSet.EoF == true))
					{
						//// make sure the record set didn't reach the EOF
						if (oRecordSet.EoF == false && i < 10)
						{
							//// set the business partners object
							oItem.GetByKey(oRecordSet.Fields.Item(0).Value.ToString());
							//// add the partner's code and name to the list box
							List1.Items.Add(oItem.ItemCode + "\t" + "\t" + oItem.ItemName);
							i = i + 1;
						}
						oRecordSet.MoveNext();
					}
					
				}
				
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
		
		
		private void SetComboBoxes ()
		{
			
			Combo1.Items.Insert(0, "BusinessPartners");
			Combo1.Items.Insert(1, "Items");
			//// any business object may be used
			
			Combo1.SelectedIndex = 0;
			
			Combo2.Items.Insert(0, "Equal");
			Combo2.Items.Insert(1, "NotEqual");
			Combo2.Items.Insert(2, "Like");
			
			Combo2.SelectedIndex = 1;
			
		}
	}
}
