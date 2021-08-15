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
	internal class BPList : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public BPList() {
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
		public System.Windows.Forms.ListBox List1;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.ComboBox Combo1;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BPList));
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(BPList_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ToolTip1.Active = true;
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.List1 = new System.Windows.Forms.ListBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Combo1 = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "GetBPList bob";
			this.ClientSize = new System.Drawing.Size(242, 284);
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
			this.Name = "BPList";
			this.Frame2.Size = new System.Drawing.Size(241, 281);
			this.Frame2.Location = new System.Drawing.Point(0, 0);
			this.Frame2.TabIndex = 2;
			this.Frame2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Enabled = true;
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Visible = true;
			this.Frame2.Name = "Frame2";
			this.List1.Size = new System.Drawing.Size(225, 176);
			this.List1.Location = new System.Drawing.Point(8, 64);
			this.List1.TabIndex = 5;
			this.List1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.List1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.List1.BackColor = System.Drawing.SystemColors.Window;
			this.List1.CausesValidation = true;
			this.List1.Enabled = true;
			this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.List1.IntegralHeight = true;
			this.List1.Cursor = System.Windows.Forms.Cursors.Default;
			this.List1.SelectionMode = System.Windows.Forms.SelectionMode.One;
			this.List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.List1.Sorted = false;
			this.List1.TabStop = true;
			this.List1.Visible = true;
			this.List1.MultiColumn = false;
			this.List1.Name = "List1";
			this.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command1.Text = "Execute";
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.Location = new System.Drawing.Point(72, 248);
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
			this.Combo1.Size = new System.Drawing.Size(129, 21);
			this.Combo1.Location = new System.Drawing.Point(104, 16);
			this.Combo1.TabIndex = 0;
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
			this.Label5.Text = "First 10 Results:";
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.Location = new System.Drawing.Point(8, 40);
			this.Label5.TabIndex = 4;
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
			this.Label1.Text = "Select BP Type:";
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.Location = new System.Drawing.Point(8, 16);
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
			this.Controls.Add(Frame2);
			this.Frame2.Controls.Add(List1);
			this.Frame2.Controls.Add(Command1);
			this.Frame2.Controls.Add(Combo1);
			this.Frame2.Controls.Add(Label5);
			this.Frame2.Controls.Add(Label1);
		}
		#endregion
		#region "Upgrade Support "
		private static BPList m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static BPList DefInstance
		{
			get{
				BPList returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new BPList();
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
		////  File:      BPList.frm
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		
		private void BPList_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			SetComboBox();
		}
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			SAPbobsCOM.SBObob oSBObob;
			SAPbobsCOM.Recordset oRecordSet;
			SAPbobsCOM.BusinessPartners oBusinessPartner;
			
			int i;
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				
				//// Get an initialized SBObob object
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				//// Get an initialized Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				//// Get an initialized BusinessPartners object
				oBusinessPartner = (SAPbobsCOM.BusinessPartners) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
				
				//// Execute the SBObob GetBPList method
				oRecordSet = oSBObob.GetBPList((SAPbobsCOM.BoCardTypes) Combo1.SelectedIndex);
				//// the RecorSet now contains a list of Keys of the Requested Type
				
				i = 0;
				List1.Items.Clear();
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
				
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}
		
		
		private void SetComboBox ()
		{
			
			Combo1.Items.Insert(0, "Cutomer");
			Combo1.Items.Insert(1, "Supplier");
			Combo1.Items.Insert(2, "Lid");
			
			Combo1.SelectedIndex = 0;
			
		}
	}
}
