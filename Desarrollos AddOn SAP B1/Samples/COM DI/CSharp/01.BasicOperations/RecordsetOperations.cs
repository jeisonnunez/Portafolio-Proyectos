#define Win32
using Microsoft.VisualBasic;
using System.Data;
using AxMSComDlg;
using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

//  SAP MANAGE DI API 2007 SDK Sample
//****************************************************************************
//
//  File:      RecordsetOperations.vb
//
//  Copyright (c) SAP MANAGE
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************

namespace Project1
{

	internal class RecordsetOperations : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public RecordsetOperations() {
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
		public System.Windows.Forms.TextBox Text4;
		public System.Windows.Forms.Button Command4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.Button Command3;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.TextBox Text3;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.GroupBox Frame1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RecordsetOperations));
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(RecordsetOperations_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ToolTip1.Active = true;
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.Text4 = new System.Windows.Forms.TextBox();
			this.Command4 = new System.Windows.Forms.Button();
			Command4.Click += new System.EventHandler(Command4_Click);
			this.Label3 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Command3 = new System.Windows.Forms.Button();
			Command3.Click += new System.EventHandler(Command3_Click);
			this.Command2 = new System.Windows.Forms.Button();
			Command2.Click += new System.EventHandler(Command2_Click);
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Text1 = new System.Windows.Forms.TextBox();
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "Recordset Operations";
			this.ClientSize = new System.Drawing.Size(338, 196);
			this.Location = new System.Drawing.Point(184, 250);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
			this.Name = "RecordsetOperations";
			this.Frame3.Text = "XML";
			this.Frame3.Size = new System.Drawing.Size(337, 57);
			this.Frame3.Location = new System.Drawing.Point(0, 136);
			this.Frame3.TabIndex = 10;
			this.Frame3.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Enabled = true;
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Visible = true;
			this.Frame3.Name = "Frame3";
			this.Text4.AutoSize = false;
			this.Text4.Size = new System.Drawing.Size(169, 19);
			this.Text4.Location = new System.Drawing.Point(64, 24);
			this.Text4.TabIndex = 13;
			this.Text4.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text4.AcceptsReturn = true;
			this.Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text4.BackColor = System.Drawing.SystemColors.Window;
			this.Text4.CausesValidation = true;
			this.Text4.Enabled = true;
			this.Text4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text4.HideSelection = true;
			this.Text4.ReadOnly = false;
			this.Text4.MaxLength = 0;
			this.Text4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text4.Multiline = false;
			this.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text4.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.Text4.TabStop = true;
			this.Text4.Visible = true;
			this.Text4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Text4.Name = "Text4";
			this.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command4.Text = "Save";
			this.Command4.Size = new System.Drawing.Size(73, 25);
			this.Command4.Location = new System.Drawing.Point(248, 24);
			this.Command4.TabIndex = 11;
			this.Command4.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command4.BackColor = System.Drawing.SystemColors.Control;
			this.Command4.CausesValidation = true;
			this.Command4.Enabled = true;
			this.Command4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command4.TabStop = true;
			this.Command4.Name = "Command4";
			this.Label3.Text = "File Name:";
			this.Label3.Size = new System.Drawing.Size(81, 17);
			this.Label3.Location = new System.Drawing.Point(8, 24);
			this.Label3.TabIndex = 12;
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
			this.Frame2.Text = "Results";
			this.Frame2.Size = new System.Drawing.Size(337, 65);
			this.Frame2.Location = new System.Drawing.Point(0, 64);
			this.Frame2.TabIndex = 3;
			this.Frame2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Enabled = true;
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Visible = true;
			this.Frame2.Name = "Frame2";
			this.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command3.Text = ">>";
			this.Command3.Size = new System.Drawing.Size(41, 41);
			this.Command3.Location = new System.Drawing.Point(288, 16);
			this.Command3.TabIndex = 9;
			this.Command3.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command3.BackColor = System.Drawing.SystemColors.Control;
			this.Command3.CausesValidation = true;
			this.Command3.Enabled = true;
			this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command3.TabStop = true;
			this.Command3.Name = "Command3";
			this.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command2.Text = "<<";
			this.Command2.Size = new System.Drawing.Size(41, 41);
			this.Command2.Location = new System.Drawing.Point(248, 16);
			this.Command2.TabIndex = 8;
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
			this.Text3.Location = new System.Drawing.Point(104, 40);
			this.Text3.TabIndex = 7;
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
			this.Text2.AutoSize = false;
			this.Text2.Enabled = false;
			this.Text2.Size = new System.Drawing.Size(129, 19);
			this.Text2.Location = new System.Drawing.Point(104, 16);
			this.Text2.TabIndex = 5;
			this.Text2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text2.AcceptsReturn = true;
			this.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.CausesValidation = true;
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
			this.Label2.Text = "Recordset Value:";
			this.Label2.Size = new System.Drawing.Size(89, 17);
			this.Label2.Location = new System.Drawing.Point(8, 40);
			this.Label2.TabIndex = 6;
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
			this.Label1.Text = "Recordset Value:";
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.TabIndex = 4;
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
			this.Frame1.Text = "DoQuery";
			this.Frame1.Size = new System.Drawing.Size(337, 57);
			this.Frame1.Location = new System.Drawing.Point(0, 0);
			this.Frame1.TabIndex = 0;
			this.Frame1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Visible = true;
			this.Frame1.Name = "Frame1";
			this.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command1.Text = "Execute";
			this.Command1.Size = new System.Drawing.Size(65, 25);
			this.Command1.Location = new System.Drawing.Point(256, 16);
			this.Command1.TabIndex = 2;
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
			this.Text1.Size = new System.Drawing.Size(225, 21);
			this.Text1.Location = new System.Drawing.Point(8, 16);
			this.Text1.TabIndex = 1;
			this.Text1.Text = "Select cardcode, cardname from ocrd";
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
			this.Controls.Add(Frame3);
			this.Controls.Add(Frame2);
			this.Controls.Add(Frame1);
			this.Frame3.Controls.Add(Text4);
			this.Frame3.Controls.Add(Command4);
			this.Frame3.Controls.Add(Label3);
			this.Frame2.Controls.Add(Command3);
			this.Frame2.Controls.Add(Command2);
			this.Frame2.Controls.Add(Text3);
			this.Frame2.Controls.Add(Text2);
			this.Frame2.Controls.Add(Label2);
			this.Frame2.Controls.Add(Label1);
			this.Frame1.Controls.Add(Command1);
			this.Frame1.Controls.Add(Text1);
		}
		#endregion
		#region "Upgrade Support "
		private static RecordsetOperations m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static RecordsetOperations DefInstance
		{
			get{
				RecordsetOperations returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new RecordsetOperations();
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
		
		
		private SAPbobsCOM.Recordset oRecordSet;
		
		
		private void RecordsetOperations_Load (System.Object eventSender, System.EventArgs eventArgs)
		{

			// Disabling all buttons but Execute
			Command2.Enabled = false;
			Command3.Enabled = false;
			Command4.Enabled = false;
		}
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			// Getting an initialized Recordset object
			oRecordSet = (SAPbobsCOM.Recordset) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			
			// Performing the select statement
			// The query result will be loaded
			// into the Recordset object
			oRecordSet.DoQuery(Text1.Text);
			
			// Enabling the buttons
			Command2.Enabled = true;
			Command3.Enabled = true;
			Command4.Enabled = true;
			
			// setting the Returned Results
			SetResults();
			
		}
		
		private void SetResults ()
		{
			
			// Our Select statement retrieved a 2 field record set
			// Placing the fields value in the text boxes
			Text2.Text = oRecordSet.Fields.Item(0).Value.ToString();
			Text3.Text = oRecordSet.Fields.Item(1).Value.ToString();
			
		}
		
		private void Command2_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			//*******************************************
			// Previous Button:
			//-------------------------------------------
			// If the Recordset pointer is not pointing
			// to the first row move it to the previous
			// one and set the results
			if (oRecordSet.BoF == false)
			{
				oRecordSet.MovePrevious();
				SetResults();
			}
		}
		
		private void Command3_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			//*******************************************
			// Next Button:
			//-------------------------------------------
			// If the Recordset pointer is not pointing
			// to the last row move it to next one
			if (oRecordSet.EoF == false)
			{
				oRecordSet.MoveNext();
			}
			// before setting the results check the
			// Recordset pointer again
			if (oRecordSet.EoF == false)
			{
				SetResults();
			}
		}
		
		private void Command4_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			//**********************************************************************
			// Saving as XML:
			//---------------------------------------------------------------------
			//
			// The XML file will be saved under "C:\"
			// You can use any other path, just make sure the folder exists
			//**********************************************************************
			string temp_string = "C:\\" + Text4.Text + ".xml";
			oRecordSet.SaveXML(ref temp_string);
		}
	}
}
