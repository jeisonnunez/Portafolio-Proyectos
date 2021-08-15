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
	internal class UserList : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public UserList() {
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
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.GroupBox Frame2;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(UserList));
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(UserList_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ToolTip1.Active = true;
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.List1 = new System.Windows.Forms.ListBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "GetUserList bob";
			this.ClientSize = new System.Drawing.Size(242, 228);
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
			this.Name = "UserList";
			this.Frame2.Size = new System.Drawing.Size(241, 225);
			this.Frame2.Location = new System.Drawing.Point(0, 0);
			this.Frame2.TabIndex = 0;
			this.Frame2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Enabled = true;
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Visible = true;
			this.Frame2.Name = "Frame2";
			this.List1.Size = new System.Drawing.Size(225, 176);
			this.List1.Location = new System.Drawing.Point(8, 40);
			this.List1.TabIndex = 2;
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
			this.Label5.Text = "First 10 users:";
			this.Label5.Size = new System.Drawing.Size(113, 17);
			this.Label5.Location = new System.Drawing.Point(8, 16);
			this.Label5.TabIndex = 1;
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
			this.Controls.Add(Frame2);
			this.Frame2.Controls.Add(List1);
			this.Frame2.Controls.Add(Label5);
		}
		#endregion
		#region "Upgrade Support "
		private static UserList m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static UserList DefInstance
		{
			get{
				UserList returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new UserList();
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
		////  File:      UserList.frm
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		
		private void UserList_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			SAPbobsCOM.SBObob oSBObob;
			SAPbobsCOM.Recordset oRecordSet;
			
			int i;
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				
				//// Get an initialized SBObob object
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				//// Get an initialized Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				
				//// Execute the SBObob GetUserList method
				oRecordSet = oSBObob.GetUserList();
				//// the RecorSet now contains a list of Keys of the Requested Type
				
				i = 0;
				List1.Items.Clear();
				List1.Items.Add("User Name");
				List1.Items.Add("-------------------------------------------------------------");
				
				//// use the RecordSet to set the BusnessPartners object
				//// by using the GetByKey method
				
				while (!(oRecordSet.EoF == true))
				{
					//// make sure the record set didn't reach the EOF
					if (oRecordSet.EoF == false && i < 10)
					{
						//// add the user's name
						List1.Items.Add(oRecordSet.Fields.Item(0).Value);
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
	}
}
