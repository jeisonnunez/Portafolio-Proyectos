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
////  File:      AddPrivateKey.fvb
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
	internal class AddPrivateKey : System.Windows.Forms.Form
	{
		
		#region "Windows Form Designer generated code "
		public AddPrivateKey() {
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
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.ListBox List1;
		public System.Windows.Forms.GroupBox Frame4;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.TextBox Text3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ComboBox ComboBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(AddPrivateKey_Load);
			base.Closed += new System.EventHandler(AddPrivateKey_Closed);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Command2 = new System.Windows.Forms.Button();
			Command2.Click += new System.EventHandler(Command2_Click);
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.Frame4 = new System.Windows.Forms.GroupBox();
			this.List1 = new System.Windows.Forms.ListBox();
			this.Command1 = new System.Windows.Forms.Button();
			Command1.Click += new System.EventHandler(Command1_Click);
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Frame3.SuspendLayout();
			this.Frame4.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//Command2
			//
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(40, 368);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(161, 25);
			this.Command2.TabIndex = 11;
			this.Command2.Text = "Add Key To Table";
			//
			//Frame3
			//
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this.Frame4);
			this.Frame3.Controls.Add(this.Command1);
			this.Frame3.Controls.Add(this.Text3);
			this.Frame3.Controls.Add(this.Label2);
			this.Frame3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(0, 96);
			this.Frame3.Name = "Frame3";
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(241, 209);
			this.Frame3.TabIndex = 9;
			this.Frame3.TabStop = false;
			//
			//Frame4
			//
			this.Frame4.BackColor = System.Drawing.SystemColors.Control;
			this.Frame4.Controls.Add(this.List1);
			this.Frame4.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame4.Location = new System.Drawing.Point(8, 88);
			this.Frame4.Name = "Frame4";
			this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame4.Size = new System.Drawing.Size(225, 113);
			this.Frame4.TabIndex = 11;
			this.Frame4.TabStop = false;
			this.Frame4.Text = "Key Columns (Fields)";
			//
			//List1
			//
			this.List1.BackColor = System.Drawing.SystemColors.Window;
			this.List1.Cursor = System.Windows.Forms.Cursors.Default;
			this.List1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.List1.ItemHeight = 14;
			this.List1.Location = new System.Drawing.Point(8, 16);
			this.List1.Name = "List1";
			this.List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.List1.Size = new System.Drawing.Size(209, 74);
			this.List1.TabIndex = 12;
			//
			//Command1
			//
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(32, 56);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(169, 25);
			this.Command1.TabIndex = 10;
			this.Command1.Text = "Add Column (Field) To Key";
			//
			//Text3
			//
			this.Text3.AcceptsReturn = true;
			this.Text3.AutoSize = false;
			this.Text3.BackColor = System.Drawing.SystemColors.Window;
			this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text3.Location = new System.Drawing.Point(96, 16);
			this.Text3.MaxLength = 0;
			this.Text3.Name = "Text3";
			this.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text3.Size = new System.Drawing.Size(137, 19);
			this.Text3.TabIndex = 9;
			this.Text3.Text = "";
			//
			//Label2
			//
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 16);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(72, 32);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Column Alias: (Field Name)";
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.Text1);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(0, 0);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(241, 49);
			this.Frame1.TabIndex = 7;
			this.Frame1.TabStop = false;
			//
			//Text1
			//
			this.Text1.AcceptsReturn = true;
			this.Text1.AutoSize = false;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text1.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text1.Location = new System.Drawing.Point(96, 16);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(137, 21);
			this.Text1.TabIndex = 7;
			this.Text1.Text = "";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 16);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(89, 17);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Table Name:";
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Text2);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(0, 48);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(241, 49);
			this.Frame2.TabIndex = 0;
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
			this.Text2.Location = new System.Drawing.Point(96, 16);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(137, 19);
			this.Text2.TabIndex = 8;
			this.Text2.Text = "";
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
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Key Name:";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Location = new System.Drawing.Point(0, 312);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(240, 48);
			this.GroupBox1.TabIndex = 12;
			this.GroupBox1.TabStop = false;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(8, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(128, 16);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "Add Key As Unique:";
			//
			//ComboBox1
			//
			this.ComboBox1.Location = new System.Drawing.Point(144, 16);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(88, 22);
			this.ComboBox1.TabIndex = 1;
			//
			//AddPrivateKey
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(243, 399);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Command2);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Frame2);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Location = new System.Drawing.Point(3, 22);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddPrivateKey";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Private Key";
			this.Frame3.ResumeLayout(false);
			this.Frame4.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		#region "Upgrade Support "
		private static AddPrivateKey m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static AddPrivateKey DefInstance
		{
			get{
				AddPrivateKey returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new AddPrivateKey();
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
		
		
		
		////****************************************************************************
		//// The UserKeysMD represents a meta-data object which allows us
		//// to add\remove user defined keys
		////****************************************************************************
		
		public SAPbobsCOM.UserKeysMD oUserKeysMD;
		
		////****************************************************************************
		//// In any meta-data operation there should be no other object "alive"
		//// but the meta-data object, otherwise the operation will fail.
		//// This restriction is intended to prevent a collisions
		////****************************************************************************
		
		
		//// flag
		private bool bFlagFirst;
		
		
		private void AddPrivateKey_Load (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			SetComboBox();
			
			//// the meta-data object needs to be initialized with a
			//// regular UserKeys object
			oUserKeysMD = (SAPbobsCOM.UserKeysMD) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserKeys);
			
			bFlagFirst = true;
			
		}
		
		private void Command1_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			////*******************************************
			//// Add column to key Button:
			////-------------------------------------------
			//// in order to add an additional column to
			//// the key an additional element must be
			//// created in the Elements collection.
			//// The Add method of the Elements collection
			//// should be used only as of the second element
			
			
			//// catch exceptions
			//// can be used instead of Company.GetLastError method
			try
			{
				
				//// don't use add for the first element
				if (bFlagFirst == true)
				{
					bFlagFirst = false;
				}
				else
				{
					//// add an item to the Elemets collection
					oUserKeysMD.Elements.Add();
				}
				
				//// set the column alias
				oUserKeysMD.Elements.ColumnAlias = Text3.Text;
				
				List1.Items.Add(oUserKeysMD.Elements.ColumnAlias);
				
				Text3.Text = "";
				
				return;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}				
		}
	
		
		private void Command2_Click (System.Object eventSender, System.EventArgs eventArgs)
		{
			
			//// set tthe table name and the key name
			oUserKeysMD.TableName = Text1.Text;
			oUserKeysMD.KeyName = Text2.Text;
			
			oUserKeysMD.Unique = (SAPbobsCOM.BoYesNoEnum) ComboBox1.SelectedIndex;
			
			//// add the key
			globals_Renamed.lRetCode = oUserKeysMD.Add();
			
			//// check for errors
			if (globals_Renamed.lRetCode != 0)
			{
				int temp_int = globals_Renamed.lErrCode;
				string temp_string = globals_Renamed.sErrMsg;
				globals_Renamed.oCompany.GetLastError(out temp_int, out temp_string);
				MessageBox.Show(temp_string);
			}
			else
			{
				MessageBox.Show("Key Name: " + oUserKeysMD.KeyName + " was added successfuly to table " + oUserKeysMD.TableName + " and consists of " + oUserKeysMD.Elements.Count + " Columns");
				Text1.Text = "";
				Text2.Text = "";
				Text3.Text = "";
			}
			List1.Items.Clear();
			//// for adding an additional key
			//// reset the object
			ResetUserKeysMD();
		}
		
		private void ResetUserKeysMD ()
		{
			//// the meta-data object needs to be initialized with a
			//// regular UserKeys object
			oUserKeysMD = (SAPbobsCOM.UserKeysMD) globals_Renamed.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserKeys);
			
			bFlagFirst = true;
		}
		
		private void AddPrivateKey_Closed (object sender, System.EventArgs e)
		{
			
			////*************************************************
			//// in .NET environment, due to garbage collection
			//// Disposing the active form at closing is the
			//// only way to insure all memory is release
			//// and thus detroying unwanted objects
			////*************************************************
			ActiveForm.Dispose();
		}
		
		private void SetComboBox ()
		{
			ComboBox1.Items.Insert(0, "No");
			ComboBox1.Items.Insert(1, "Yes");
			ComboBox1.SelectedIndex = 0;
		}
	}
}
