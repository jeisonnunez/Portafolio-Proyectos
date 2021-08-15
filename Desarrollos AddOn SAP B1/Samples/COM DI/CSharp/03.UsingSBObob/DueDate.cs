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
	internal class DueDate : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public DueDate() {
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
		public System.Windows.Forms.ComboBox Combo1;
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
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(DueDate_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Combo1 = new System.Windows.Forms.ComboBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Combo1);
			this.Frame2.Controls.Add(this.Text2);
			this.Frame2.Controls.Add(this.Text1);
			this.Frame2.Controls.Add(this.Command1);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(0, 0);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(241, 129);
			this.Frame2.TabIndex = 1;
			this.Frame2.TabStop = false;
			//
			//Combo1
			//
			this.Combo1.BackColor = System.Drawing.SystemColors.Window;
			this.Combo1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Combo1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Combo1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Combo1.Location = new System.Drawing.Point(144, 16);
			this.Combo1.Name = "Combo1";
			this.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo1.Size = new System.Drawing.Size(89, 22);
			this.Combo1.TabIndex = 7;
			//
			//Text2
			//
			this.Text2.AcceptsReturn = true;
			this.Text2.AutoSize = false;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text2.Location = new System.Drawing.Point(144, 64);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(89, 19);
			this.Text2.TabIndex = 6;
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
			this.Text1.Location = new System.Drawing.Point(144, 40);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(89, 19);
			this.Text1.TabIndex = 4;
			this.Text1.Text = "";
			//
			//Command1
			//
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(72, 96);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.TabIndex = 0;
			this.Command1.Text = "Execute";
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
			this.Label2.Size = new System.Drawing.Size(89, 17);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Reference Date:";
			//
			//Label5
			//
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 72);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(73, 17);
			this.Label5.TabIndex = 3;
			this.Label5.Text = "Due Date:";
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
			this.Label1.Size = new System.Drawing.Size(136, 17);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Select a Business Partner:";
			//
			//DueDate
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(242, 132);
			this.Controls.Add(this.Frame2);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(265, 213);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DueDate";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "GetDueDate bob";
			this.Frame2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static DueDate m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static DueDate DefInstance
		{
			get{
				DueDate returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new DueDate();
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
		////  File:      DueDate.frm
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
		
		
		
		private void DueDate_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			int i;
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				//// Get an initialized SBObob object
				oSBObob = (SAPbobsCOM.SBObob) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
				//// Get an initialized Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
				
				//// Set the List of Customers
				oRecordSet = oSBObob.GetBPList(SAPbobsCOM.BoCardTypes.cCustomer);
				//// the RecorSet now contains a list of Keys of the Requested Type
				
				//// use the RecordSet to set the BusnessPartners object
				//// by using the GetByKey method
				i = 0;
				while (!(oRecordSet.EoF == true))
				{
					//// make sure the record set didn't reach the EOF
					if (oRecordSet.EoF == false && i < 10)
					{
						//// add the partner's code
						Combo1.Items.Add(oRecordSet.Fields.Item(0).Value);
						i = i + 1;
					}
					oRecordSet.MoveNext();
				}
				
				Combo1.SelectedIndex = 0;
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}				
		}
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			////*************************************
			//// Get the Due Date
			////**************************************
			DateTime refDate;
			
			refDate = System.Convert.ToDateTime(Text1.Text);
			
			//// Execute the GetDueDate method
			oRecordSet = oSBObob.GetDueDate(Microsoft.VisualBasic.Compatibility.VB6.Support.GetItemString(Combo1, Combo1.SelectedIndex), refDate);
			
			int temp_int = globals_Renamed.lErrCode;
			string temp_string = globals_Renamed.sErrMsg;
			globals_Renamed.oCompany.GetLastError(out temp_int, out temp_string);
			if (globals_Renamed.lErrCode != 0)
			{
				MessageBox.Show(globals_Renamed.sErrMsg);
			}
			else
			{
				Text2.Text = oRecordSet.Fields.Item(0).Value.ToString();
			}
			
		}
	}
}
