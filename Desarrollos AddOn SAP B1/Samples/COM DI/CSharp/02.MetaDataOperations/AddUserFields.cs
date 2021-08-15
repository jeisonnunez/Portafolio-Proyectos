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

////  SAP MANAGE DI API 2007 SDK Sample
////****************************************************************************
////
////  File:      AddUserFields.vb
////
////  Copyright (c) SAP MANAGE
////
//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
////****************************************************************************

namespace Project1
{
	internal class AddUserFields : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public AddUserFields() {
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
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.GroupBox Frame1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddUserFields));
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(AddUserFields_Load);
			base.Closed += new System.EventHandler(AddUserFields_Closed);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.ToolTip1.Active = true;
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text4 = new System.Windows.Forms.TextBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Combo1 = new System.Windows.Forms.ComboBox();
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "Add User Fields";
			this.ClientSize = new System.Drawing.Size(242, 220);
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
			this.Name = "AddUserFields";
			this.Frame2.Size = new System.Drawing.Size(241, 161);
			this.Frame2.Location = new System.Drawing.Point(0, 56);
			this.Frame2.TabIndex = 7;
			this.Frame2.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Enabled = true;
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Visible = true;
			this.Frame2.Name = "Frame2";
			this.Text4.AutoSize = false;
			this.Text4.Size = new System.Drawing.Size(129, 19);
			this.Text4.Location = new System.Drawing.Point(104, 88);
			this.Text4.TabIndex = 5;
			this.Text4.Text = "20";
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
			this.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Command1.Text = "Add Field";
			this.Command1.Size = new System.Drawing.Size(97, 25);
			this.Command1.Location = new System.Drawing.Point(72, 128);
			this.Command1.TabIndex = 6;
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
			this.Combo1.Location = new System.Drawing.Point(104, 64);
			this.Combo1.TabIndex = 4;
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
			this.Text3.AutoSize = false;
			this.Text3.Size = new System.Drawing.Size(129, 19);
			this.Text3.Location = new System.Drawing.Point(104, 40);
			this.Text3.TabIndex = 3;
			this.Text3.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text3.AcceptsReturn = true;
			this.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text3.BackColor = System.Drawing.SystemColors.Window;
			this.Text3.CausesValidation = true;
			this.Text3.Enabled = true;
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
			this.Text2.Size = new System.Drawing.Size(129, 19);
			this.Text2.Location = new System.Drawing.Point(104, 16);
			this.Text2.TabIndex = 2;
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
			this.Label5.Text = "Field Description:";
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.Location = new System.Drawing.Point(8, 40);
			this.Label5.TabIndex = 12;
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
			this.Label4.Text = "Field Size:";
			this.Label4.Size = new System.Drawing.Size(73, 17);
			this.Label4.Location = new System.Drawing.Point(8, 88);
			this.Label4.TabIndex = 11;
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
			this.Label2.Text = "Field Type:";
			this.Label2.Size = new System.Drawing.Size(89, 17);
			this.Label2.Location = new System.Drawing.Point(8, 64);
			this.Label2.TabIndex = 9;
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
			this.Label1.Text = "Field Name:";
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.TabIndex = 8;
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
			this.Frame1.Size = new System.Drawing.Size(241, 49);
			this.Frame1.Location = new System.Drawing.Point(0, 0);
			this.Frame1.TabIndex = 0;
			this.Frame1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Visible = true;
			this.Frame1.Name = "Frame1";
			this.Text1.AutoSize = false;
			this.Text1.Size = new System.Drawing.Size(129, 21);
			this.Text1.Location = new System.Drawing.Point(104, 16);
			this.Text1.TabIndex = 1;
			this.Text1.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text1.AcceptsReturn = true;
			this.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.CausesValidation = true;
			this.Text1.Enabled = true;
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
			this.Label3.Text = "Table Name:";
			this.Label3.Size = new System.Drawing.Size(89, 25);
			this.Label3.Location = new System.Drawing.Point(8, 16);
			this.Label3.TabIndex = 10;
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
			this.Controls.Add(Frame2);
			this.Controls.Add(Frame1);
			this.Frame2.Controls.Add(Text4);
			this.Frame2.Controls.Add(Command1);
			this.Frame2.Controls.Add(Combo1);
			this.Frame2.Controls.Add(Text3);
			this.Frame2.Controls.Add(Text2);
			this.Frame2.Controls.Add(Label5);
			this.Frame2.Controls.Add(Label4);
			this.Frame2.Controls.Add(Label2);
			this.Frame2.Controls.Add(Label1);
			this.Frame1.Controls.Add(Text1);
			this.Frame1.Controls.Add(Label3);
		}
		#endregion
		#region "Upgrade Support "
		private static AddUserFields m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static AddUserFields DefInstance
		{
			get{
				AddUserFields returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new AddUserFields();
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
		
		
		
		private void AddUserFields_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			SetComboBox();
		}
		
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			////****************************************************************************
			//// The UserFieldsMD represents a meta-data object which allows us
			//// to add\remove fields from tables or change the field's characteristics
			////****************************************************************************
			
			SAPbobsCOM.UserFieldsMD oUserFieldsMD;
			
			////****************************************************************************
			//// In any meta-data operation there should be no other object "alive"
			//// but the meta-data object, otherwise the operation will fail.
			//// This restriction is intended to prevent a collisions
			////****************************************************************************
			
			//// the meta-data object needs to be initialized with a
			//// regular UserFields object
			oUserFieldsMD = (SAPbobsCOM.UserFieldsMD) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields);
			
			////**************************************************
			//// when adding user tables or fields to the SBO DB
			//// use a prefix identifying your partner name space
			//// this will prevent collisions between different
			//// partners add-ons
			////
			//// SAP's name space prefix is "BE_"
			////**************************************************
			
			//// Setting the Field's mandatory properties
			
			oUserFieldsMD.TableName = Text1.Text;
			oUserFieldsMD.Name = Text2.Text;
			oUserFieldsMD.Description = Text3.Text;
			oUserFieldsMD.Type = (SAPbobsCOM.BoFieldTypes) Combo1.SelectedIndex;
			oUserFieldsMD.EditSize = System.Convert.ToInt32(Text4.Text);
			
			//// Adding the Field to the Table
			globals_Renamed.lRetCode = oUserFieldsMD.Add();
			
			//// Check for errors
			if (globals_Renamed.lRetCode != 0)
			{
				int temp_int = globals_Renamed.lErrCode;
				string temp_string = globals_Renamed.sErrMsg;
				globals_Renamed.oCompany.GetLastError(out temp_int, out temp_string);
				MessageBox.Show(globals_Renamed.sErrMsg);
			}
			else
			{
MessageBox.Show("Field: \'" + oUserFieldsMD.Name + "\' was added successfuly to " + oUserFieldsMD.TableName + " Table");
				
				Text2.Text = "";
				Text3.Text = "";
				//// setting a default size
				Text4.Text = "20";
				
			}
		}
		
		
		private void SetComboBox ()
		{
			
			Combo1.Items.Insert(0, "db_Alpha");
			Combo1.Items.Insert(1, "db_Memo");
			Combo1.Items.Insert(2, "db_Numeric");
			Combo1.Items.Insert(3, "db_Date");
			
			Combo1.SelectedIndex = 0;
			
		}
		
		private void AddUserFields_Closed (object sender, System.EventArgs e)
		{
			////*************************************************
			//// in .NET environment, due to garbage collection
			//// Disposing the active form at closing is the
			//// only way to insure all memory is release
			//// and thus detroying unwanted objects
			////*************************************************
			ActiveForm.Dispose();
		}
	}
}
