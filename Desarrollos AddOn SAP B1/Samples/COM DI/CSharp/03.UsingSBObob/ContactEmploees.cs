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
	internal class ContactEmployees : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public ContactEmployees() {
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
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(ContactEmployees_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.List1 = new System.Windows.Forms.ListBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Combo1 = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.List1);
			this.Frame2.Controls.Add(this.Command1);
			this.Frame2.Controls.Add(this.Combo1);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(0, 0);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(241, 281);
			this.Frame2.TabIndex = 2;
			this.Frame2.TabStop = false;
			//
			//List1
			//
			this.List1.BackColor = System.Drawing.SystemColors.Window;
			this.List1.Cursor = System.Windows.Forms.Cursors.Default;
			this.List1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.List1.ItemHeight = 14;
			this.List1.Location = new System.Drawing.Point(8, 64);
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
			this.Command1.Location = new System.Drawing.Point(72, 248);
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
			this.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Combo1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Combo1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo1.Location = new System.Drawing.Point(112, 16);
			this.Combo1.Name = "Combo1";
			this.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo1.Size = new System.Drawing.Size(120, 22);
			this.Combo1.TabIndex = 0;
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
			this.Label5.Size = new System.Drawing.Size(113, 17);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "First 10 Employees:";
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
			this.Label1.Size = new System.Drawing.Size(96, 17);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Select Card Code:";
			//
			//ContactEmployees
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(242, 284);
			this.Controls.Add(this.Frame2);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(265, 213);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContactEmployees";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "GetContactEmployees bob";
			this.Frame2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static ContactEmployees m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static ContactEmployees DefInstance
		{
			get{
				ContactEmployees returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new ContactEmployees();
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
		////  File:      ContactEmployees.frm
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
		
		private void ContactEmployees_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			//// Get an initialized SBObob object
			oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
			//// Get an initialized Recordset object
			oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			
			SetComboBox();
		}
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			
			int i;
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				
				//// Execute the SBObob GetContactEmployee method
				oRecordSet = oSBObob.GetContactEmployees(Microsoft.VisualBasic.Compatibility.VB6.Support.GetItemString(Combo1, Combo1.SelectedIndex));
				//// the RecorSet now contains a list of Keys of the Requested Type
				
				i = 0;
				List1.Items.Clear();
				List1.Items.Add("Supplier\'s Contact Name");
				List1.Items.Add("-------------------------------------------------------------");
				
				//// use the RecordSet to set the BusnessPartners object
				//// by using the GetByKey method
				
				while (!(oRecordSet.EoF == true))
				{
					//// make sure the record set hasn't reach the EOF
					if (oRecordSet.EoF == false && i < 10)
					{
						//// add the Contact's name to the list box
						List1.Items.Add(oRecordSet.Fields.Item(1).Value);
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
			
			int i;
			
			
			//// get a list of all suppliers Card Code
			oRecordSet = oSBObob.GetBPList(SAPbobsCOM.BoCardTypes.cSupplier);
			
			i = 0;
			while (!(oRecordSet.EoF == true))
			{
				//// make sure the record set didn't reach the EOF
				if (oRecordSet.EoF == false && i < 10)
				{
					//// add the partner's code to the combo box
					Combo1.Items.Insert(i, oRecordSet.Fields.Item(0).Value);
					i = i + 1;
				}
				oRecordSet.MoveNext();
			}
			Combo1.SelectedIndex = 0;
			
		}
	}
}
