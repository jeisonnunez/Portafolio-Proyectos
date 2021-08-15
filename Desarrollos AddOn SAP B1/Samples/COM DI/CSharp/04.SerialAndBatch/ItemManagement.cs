using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication2
{
	public class ItemManagement : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			Application.Run(new ItemManagement());
		}
		#region " Windows Form Designer generated code "
		
		public ItemManagement() {
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose (bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button goodsReceipt;
		internal System.Windows.Forms.Button GoodsIssue;
		internal System.Windows.Forms.Button ExitButton;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label MsgBoxLabel;
		internal System.Windows.Forms.Label MsgBoxLabel_1;
		internal System.Windows.Forms.Button addItemButton;
		internal System.Windows.Forms.Button getItemButton;
		internal System.Windows.Forms.Button deleteItemButton;
		internal System.Windows.Forms.RadioButton NoneRadioButton;
		internal System.Windows.Forms.RadioButton manSerRadioButton;
		internal System.Windows.Forms.RadioButton manBatchRadioButton;
		internal System.Windows.Forms.CheckBox OnReleaseOnly;
		internal System.Windows.Forms.CheckBox forceSerial;
		internal System.Windows.Forms.TextBox ItemIDText;
		internal System.Windows.Forms.TextBox ItemNameText;
		internal System.Windows.Forms.Label itemKind;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.ItemIDText = new System.Windows.Forms.TextBox();
			base.Load += new System.EventHandler(Form1_Load);
			ItemIDText.TextChanged += new System.EventHandler(ItemIDText_TextChanged);
			this.Label1 = new System.Windows.Forms.Label();
			this.addItemButton = new System.Windows.Forms.Button();
			addItemButton.Click += new System.EventHandler(addItemButton_Click);
			this.getItemButton = new System.Windows.Forms.Button();
			getItemButton.Click += new System.EventHandler(getItemButton_Click);
			this.Label5 = new System.Windows.Forms.Label();
			this.ItemNameText = new System.Windows.Forms.TextBox();
			this.manSerRadioButton = new System.Windows.Forms.RadioButton();
			manSerRadioButton.CheckedChanged += new System.EventHandler(manSerRadioButton_CheckedChanged);
			this.deleteItemButton = new System.Windows.Forms.Button();
			deleteItemButton.Click += new System.EventHandler(deleteItemButton_Click);
			this.OnReleaseOnly = new System.Windows.Forms.CheckBox();
			OnReleaseOnly.CheckedChanged += new System.EventHandler(OnReleaseOnly_CheckedChanged);
			this.forceSerial = new System.Windows.Forms.CheckBox();
			forceSerial.CheckedChanged += new System.EventHandler(forceSerial_CheckedChanged);
			this.itemKind = new System.Windows.Forms.Label();
			this.goodsReceipt = new System.Windows.Forms.Button();
			goodsReceipt.Click += new System.EventHandler(goodsReceipt_Click);
			this.GoodsIssue = new System.Windows.Forms.Button();
			GoodsIssue.Click += new System.EventHandler(GoodsIssue_Click);
			this.ExitButton = new System.Windows.Forms.Button();
			ExitButton.Click += new System.EventHandler(ExitButton_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.NoneRadioButton = new System.Windows.Forms.RadioButton();
			NoneRadioButton.CheckedChanged += new System.EventHandler(NoneRadioButton_CheckedChanged);
			this.manBatchRadioButton = new System.Windows.Forms.RadioButton();
			manBatchRadioButton.CheckedChanged += new System.EventHandler(manBatchRadioButton_CheckedChanged);
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.MsgBoxLabel = new System.Windows.Forms.Label();
			this.MsgBoxLabel_1 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			//
			//ItemIDText
			//
			this.ItemIDText.Location = new System.Drawing.Point(120, 24);
			this.ItemIDText.Name = "ItemIDText";
			this.ItemIDText.Size = new System.Drawing.Size(160, 20);
			this.ItemIDText.TabIndex = 0;
			this.ItemIDText.Text = "";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 28);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 16);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Item ID:";
			//
			//addItemButton
			//
			this.addItemButton.Location = new System.Drawing.Point(24, 32);
			this.addItemButton.Name = "addItemButton";
			this.addItemButton.Size = new System.Drawing.Size(72, 30);
			this.addItemButton.TabIndex = 2;
			this.addItemButton.Text = "add Item";
			//
			//getItemButton
			//
			this.getItemButton.Location = new System.Drawing.Point(24, 72);
			this.getItemButton.Name = "getItemButton";
			this.getItemButton.Size = new System.Drawing.Size(72, 30);
			this.getItemButton.TabIndex = 3;
			this.getItemButton.Text = "get Item";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(16, 56);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(96, 16);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Item Name:";
			//
			//ItemNameText
			//
			this.ItemNameText.Location = new System.Drawing.Point(120, 56);
			this.ItemNameText.Name = "ItemNameText";
			this.ItemNameText.Size = new System.Drawing.Size(160, 20);
			this.ItemNameText.TabIndex = 7;
			this.ItemNameText.Text = "";
			//
			//manSerRadioButton
			//
			this.manSerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.manSerRadioButton.Location = new System.Drawing.Point(24, 48);
			this.manSerRadioButton.Name = "manSerRadioButton";
			this.manSerRadioButton.Size = new System.Drawing.Size(152, 18);
			this.manSerRadioButton.TabIndex = 10;
			this.manSerRadioButton.Text = "Manage Serial Numbers";
			//
			//deleteItemButton
			//
			this.deleteItemButton.Location = new System.Drawing.Point(24, 112);
			this.deleteItemButton.Name = "deleteItemButton";
			this.deleteItemButton.Size = new System.Drawing.Size(72, 30);
			this.deleteItemButton.TabIndex = 12;
			this.deleteItemButton.Text = "delete Item";
			//
			//OnReleaseOnly
			//
			this.OnReleaseOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.OnReleaseOnly.Location = new System.Drawing.Point(56, 72);
			this.OnReleaseOnly.Name = "OnReleaseOnly";
			this.OnReleaseOnly.Size = new System.Drawing.Size(176, 18);
			this.OnReleaseOnly.TabIndex = 13;
			this.OnReleaseOnly.Text = "Manage On Release Only ";
			//
			//forceSerial
			//
			this.forceSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.forceSerial.Location = new System.Drawing.Point(24, 136);
			this.forceSerial.Name = "forceSerial";
			this.forceSerial.Size = new System.Drawing.Size(280, 18);
			this.forceSerial.TabIndex = 14;
			this.forceSerial.Text = "Force Serial/Batch Numbers Selection on Release";
			//
			//itemKind
			//
			this.itemKind.BackColor = System.Drawing.SystemColors.Control;
			this.itemKind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.itemKind.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.itemKind.ForeColor = System.Drawing.Color.FromArgb(((byte)(192)),((byte)(0)),((byte)(0)));
			this.itemKind.Location = new System.Drawing.Point(144, 24);
			this.itemKind.Name = "itemKind";
			this.itemKind.Size = new System.Drawing.Size(168, 16);
			this.itemKind.TabIndex = 15;
			this.itemKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//goodsReceipt
			//
			this.goodsReceipt.Location = new System.Drawing.Point(16, 16);
			this.goodsReceipt.Name = "goodsReceipt";
			this.goodsReceipt.Size = new System.Drawing.Size(96, 24);
			this.goodsReceipt.TabIndex = 16;
			this.goodsReceipt.Text = "Goods Receipt";
			//
			//GoodsIssue
			//
			this.GoodsIssue.Location = new System.Drawing.Point(16, 56);
			this.GoodsIssue.Name = "GoodsIssue";
			this.GoodsIssue.Size = new System.Drawing.Size(96, 24);
			this.GoodsIssue.TabIndex = 17;
			this.GoodsIssue.Text = "Goods Issue";
			//
			//ExitButton
			//
			this.ExitButton.Location = new System.Drawing.Point(48, 368);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(72, 30);
			this.ExitButton.TabIndex = 18;
			this.ExitButton.Text = "Exit";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.NoneRadioButton);
			this.GroupBox1.Controls.Add(this.manBatchRadioButton);
			this.GroupBox1.Controls.Add(this.manSerRadioButton);
			this.GroupBox1.Controls.Add(this.OnReleaseOnly);
			this.GroupBox1.Controls.Add(this.forceSerial);
			this.GroupBox1.Controls.Add(this.itemKind);
			this.GroupBox1.Location = new System.Drawing.Point(328, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(320, 208);
			this.GroupBox1.TabIndex = 19;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Serial and Batch numbers";
			//
			//NoneRadioButton
			//
			this.NoneRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.NoneRadioButton.Location = new System.Drawing.Point(24, 24);
			this.NoneRadioButton.Name = "NoneRadioButton";
			this.NoneRadioButton.Size = new System.Drawing.Size(72, 18);
			this.NoneRadioButton.TabIndex = 17;
			this.NoneRadioButton.Text = "None";
			//
			//manBatchRadioButton
			//
			this.manBatchRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.manBatchRadioButton.Location = new System.Drawing.Point(24, 104);
			this.manBatchRadioButton.Name = "manBatchRadioButton";
			this.manBatchRadioButton.Size = new System.Drawing.Size(152, 18);
			this.manBatchRadioButton.TabIndex = 16;
			this.manBatchRadioButton.Text = "Manage Batch Numbers";
			//
			//GroupBox2
			//
			this.GroupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.GroupBox2.Controls.Add(this.getItemButton);
			this.GroupBox2.Controls.Add(this.addItemButton);
			this.GroupBox2.Controls.Add(this.deleteItemButton);
			this.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GroupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.GroupBox2.Location = new System.Drawing.Point(24, 104);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(120, 168);
			this.GroupBox2.TabIndex = 20;
			this.GroupBox2.TabStop = false;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.GoodsIssue);
			this.GroupBox3.Controls.Add(this.goodsReceipt);
			this.GroupBox3.Controls.Add(this.Label3);
			this.GroupBox3.Location = new System.Drawing.Point(328, 232);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(320, 96);
			this.GroupBox3.TabIndex = 21;
			this.GroupBox3.TabStop = false;
			//
			//Label4
			//
			this.Label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label4.ForeColor = System.Drawing.Color.FromArgb(((byte)(192)),((byte)(0)),((byte)(0)));
			this.Label4.Location = new System.Drawing.Point(128, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(128, 16);
			this.Label4.TabIndex = 23;
			this.Label4.Text = "(Inventory Gen Exit)";
			//
			//Label3
			//
			this.Label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label3.ForeColor = System.Drawing.Color.FromArgb(((byte)(192)),((byte)(0)),((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(128, 24);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(128, 16);
			this.Label3.TabIndex = 22;
			this.Label3.Text = "(Inventory Gen Entry)";
			//
			//MsgBoxLabel
			//
			this.MsgBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.MsgBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((byte)(192)),((byte)(0)),((byte)(0)));
			this.MsgBoxLabel.Location = new System.Drawing.Point(168, 360);
			this.MsgBoxLabel.Name = "MsgBoxLabel";
			this.MsgBoxLabel.Size = new System.Drawing.Size(432, 56);
			this.MsgBoxLabel.TabIndex = 22;
			//
			//MsgBoxLabel_1
			//
			this.MsgBoxLabel_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.MsgBoxLabel_1.ForeColor = System.Drawing.Color.FromArgb(((byte)(192)),((byte)(0)),((byte)(0)));
			this.MsgBoxLabel_1.Location = new System.Drawing.Point(168, 432);
			this.MsgBoxLabel_1.Name = "MsgBoxLabel_1";
			this.MsgBoxLabel_1.Size = new System.Drawing.Size(432, 56);
			this.MsgBoxLabel_1.TabIndex = 23;
			//
			//ItemManagement
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(712, 509);
			this.Controls.Add(this.MsgBoxLabel_1);
			this.Controls.Add(this.MsgBoxLabel);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.ItemNameText);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ItemIDText);
			this.Name = "ItemManagement";
			this.Text = "Item Management";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		////  SAP MANAGE DI API 2007 SDK Sample
		////****************************************************************************
		////
		////  File:      ItemManagement.vb
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		private void Form1_Load (System.Object sender, System.EventArgs e)
		{
			
			LogInForm frm = new LogInForm();
			
			//show log in dialog
			frm.ShowDialog();
			
			if (globalD.oCompany.Connected == false)
			{
				ProjectData.EndApp();
			}
			
			globalD.oItems = (SAPbobsCOM.Items) globalD.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems);
			NoneRadioButton.Checked = true;
			
		}
		
		private void addItemButton_Click (System.Object sender, System.EventArgs e)
		{
			MsgBoxLabel.Text = "";
			MsgBoxLabel_1.Text = "";
			globalD.oItems.ItemCode = ItemIDText.Text;
			globalD.oItems.ItemName = ItemNameText.Text;
			globalD.oItems.ManageSerialNumbersOnReleaseOnly = SAPbobsCOM.BoYesNoEnum.tNO;
			globalD.oItems.ManageSerialNumbers = SAPbobsCOM.BoYesNoEnum.tNO;
			globalD.oItems.ForceSelectionOfSerialNumber = SAPbobsCOM.BoYesNoEnum.tNO;
			globalD.oItems.ManageBatchNumbers = SAPbobsCOM.BoYesNoEnum.tNO;
			//   ManageSerialNumbers cannot be set to 1 when
			//   ManageBatchNumbers is set to 1.
			if (manSerRadioButton.Checked == true)
			{
				globalD.oItems.ManageSerialNumbers = SAPbobsCOM.BoYesNoEnum.tYES;
				if (OnReleaseOnly.Checked == true)
				{
					globalD.oItems.ManageSerialNumbersOnReleaseOnly = SAPbobsCOM.BoYesNoEnum.tYES;
				}
			}
			else
			{
				//   Batch numbers are usually used for items joined
				//   under a single mantle of unique properties, such as medicines
				if (manBatchRadioButton.Checked == true)
				{
					globalD.oItems.ManageBatchNumbers = SAPbobsCOM.BoYesNoEnum.tYES;
				}
			}
			if (forceSerial.Checked == true)
			{
				globalD.oItems.ForceSelectionOfSerialNumber = SAPbobsCOM.BoYesNoEnum.tYES;
			}
			//   add the item record to the object table in SAP Business One company database
			globalD.RetVal = globalD.oItems.Add();
			if (globalD.RetVal != 0)
			{
				int temp_int = globalD.ErrCode;
				string temp_string = globalD.ErrMsg;
				globalD.oCompany.GetLastError(out temp_int, out temp_string);
				MsgBoxLabel.Text = temp_int + " " + temp_string;
			}
			else
			{
				MsgBoxLabel.Text = "The Item: " + globalD.oItems.ItemCode + " was added successfully";
			}
		}
		
		private void getItemButton_Click (System.Object sender, System.EventArgs e)
		{
			globalD.flagManage = false;
			globalD.flagRelease = false;
			globalD.flagForce = false;
			globalD.flagBatch = false;
			ItemNameText.Text = "";
			itemKind.Text = "";
			manSerRadioButton.Checked = false;
			OnReleaseOnly.Checked = false;
			forceSerial.Checked = false;
			//   Retrieve an item by its key
			if (retrieve_item() == false)
			{
				return;
			}
			ItemNameText.Text = globalD.oItems.ItemName;
			//   mapping the item's kind
			globalD.RetBool = globalD.oItems.ManageSerialNumbers;
			if (globalD.RetBool == SAPbobsCOM.BoYesNoEnum.tYES)
			{
				manSerRadioButton.Checked = true;
				globalD.flagManage = true;
			}
			else
			{
				globalD.RetBool = globalD.oItems.ManageBatchNumbers;
				if (globalD.RetBool == SAPbobsCOM.BoYesNoEnum.tYES)
				{
					manBatchRadioButton.Checked = true;
					globalD.flagBatch = true;
				}
				else
				{
					NoneRadioButton.Checked = true;
				}
			}
			if (globalD.flagManage == true)
			{
				globalD.RetBool = globalD.oItems.ManageSerialNumbersOnReleaseOnly;
				if (globalD.RetBool == SAPbobsCOM.BoYesNoEnum.tYES)
				{
					OnReleaseOnly.Checked = true;
					globalD.flagRelease = true;
				}
				else
				{
					OnReleaseOnly.Checked = false;
				}
			}
			globalD.RetBool = globalD.oItems.ForceSelectionOfSerialNumber;
			if (globalD.RetBool == SAPbobsCOM.BoYesNoEnum.tYES)
			{
				forceSerial.Checked = true;
				globalD.flagForce = true;
			}
			else
			{
				forceSerial.Checked = false;
			}
			set_label_with_desc();
		}
		
		private void deleteItemButton_Click (System.Object sender, System.EventArgs e)
		{
			//   before deleting the item we need to retrieve it by its key. (oItems object)
			if (retrieve_item() == false)
			{
				return;
			}
			//   delete the item from the object table.
			globalD.RetVal = globalD.oItems.Remove();
			if (globalD.RetVal != 0)
			{
				int temp_int = globalD.ErrCode;
				string temp_string = globalD.ErrMsg;
				globalD.oCompany.GetLastError(out temp_int, out temp_string);
				MsgBoxLabel.Text = globalD.ErrCode + " " + globalD.ErrMsg;
			}
			else
			{
				MsgBoxLabel.Text = "The Item: " + globalD.oItems.ItemCode + " was removed successfully";
			}
		}
		
		public bool retrieve_item()
		{
			
			MsgBoxLabel.Text = "";
			MsgBoxLabel_1.Text = "";
			ItemNameText.Enabled = false;
			//   retrieve the item by absolute key from SAP Business One database.
			globalD.ErrCode = 0;
			globalD.ErrMsg = "";
			globalD.RetVal = System.Convert.ToInt32(globalD.oItems.GetByKey(ItemIDText.Text));
			if (globalD.RetVal != System.Convert.ToInt32(true))
			{
				int temp_int = globalD.ErrCode;
				string temp_string = globalD.ErrMsg;
				globalD.oCompany.GetLastError(out temp_int, out temp_string);
				MsgBoxLabel.Text = "Failed to Retrieve the item " + globalD.ErrCode + " " + globalD.ErrMsg;
				return false;
			}
			return true;
			
		}
		
		private void goodsReceipt_Click (System.Object sender, System.EventArgs e)
		{
			if ((ItemIDText.Text) == "")
			{
				return;
			}
			//   In order to manage serial numbers for items, a relevant definition
			//   should be made in the item card,
			//   flagManage  & flagForce --> "MH"
			if (itemKind.Text == "(MH)")
			{
				globalD.flag = true; //   "good receipt" - to know when to activate the manageSerial dialog box
			}
			//   show the good receipt dialog box
			GoodR goodsReceipt = new GoodR();
			goodsReceipt.ShowDialog();
			//   reset the flag of the item kind
			globalD.flag = false;
		}
		
		private void GoodsIssue_Click (System.Object sender, System.EventArgs e)
		{
			if ((ItemIDText.Text) == "")
			{
				return;
			}
			//   in good issue, we need to popup also when the item is MMH
			if (itemKind.Text == "(MH)" || itemKind.Text == "(MMH)")
			{
				globalD.flag = true; //   "good issue" - to know when to activate the manageSerial dialog box
			}
			GoodI goodsIssue = new GoodI();
			//   show the good issue dialog box
			goodsIssue.ShowDialog();
			//   reset the flag of the item kind
			globalD.flag = false;
		}
		
		private void ExitButton_Click (System.Object sender, System.EventArgs e)
		{
			ProjectData.EndApp();
		}
		
		private void manSerRadioButton_CheckedChanged (System.Object sender, System.EventArgs e)
		{
			if (manSerRadioButton.Checked == true)
			{
				OnReleaseOnly.Checked = false;
				forceSerial.Checked = false;
				OnReleaseOnly.Visible = true;
				forceSerial.Visible = true;
			}
			//   refresh the GUI according the user's choise
			get_type();
		}
		
		private void OnReleaseOnly_CheckedChanged (System.Object sender, System.EventArgs e)
		{
			//   refresh the GUI according the user's choise
			get_type();
		}
		
		private void forceSerial_CheckedChanged (System.Object sender, System.EventArgs e)
		{
			//   refresh the GUI according the user's choise
			get_type();
		}
		
		public object get_type()
		{
			//   refresh the GUI according the user's choise
			MsgBoxLabel.Text = "";
			MsgBoxLabel_1.Text = "";
			globalD.flagManage = false;
			globalD.flagRelease = false;
			globalD.flagForce = false;
			globalD.flagBatch = false;
			itemKind.Text = "";
			if (manSerRadioButton.Checked == true)
			{
				globalD.flagManage = true;
			}
			else
			{
				if (manBatchRadioButton.Checked == true)
				{
					globalD.flagBatch = true;
				}
			}
			if (OnReleaseOnly.Checked == true)
			{
				MsgBoxLabel.Text = "Manage On Release Only – " + '\n'+ '\r'+ "if you check this box the Serial Numbers Reception window will not open automatically for this item in AP documents and other stock entry documents. Instead, the system will create successive serial numbers. - (Inventory Gen Entry)";
				globalD.flagRelease = true;
			}
			else
			{
				MsgBoxLabel.Text = "";
			}
			if (forceSerial.Checked == true)
			{
				MsgBoxLabel_1.Text = "Force Serial/Batch Numbers on Release - " + '\n'+ '\r'+ "check this box to block the generation of release documents, containing items with serial numbers management, for which serial numbers were not chosen. - (Inventory Gen Exit)";
				globalD.flagForce = true;
			}
			set_label_with_desc();
			return null;
		}
		
		public object set_label_with_desc()
		{
			itemKind.Text = "";
			if (globalD.flagBatch)
			{
				if (globalD.flagForce)
				{
					itemKind.Text = "(Batch with force)";
				}
				else
				{
					itemKind.Text = "(Batch without force)";
				}
			}
			if (globalD.flagManage)
			{
				if (globalD.flagForce)
				{
					if (globalD.flagRelease)
					{
						//   flagManage & flagRelease & flagForce --> "MH"
						itemKind.Text = "(MMH)";
					}
					else
					{
						//   flagManage & flagForce --> "MH"
						itemKind.Text = "(MH)";
					}
				}
				else
				{
					//   flagManage & flagRelease --> "MM"
					if (globalD.flagRelease)
					{
						itemKind.Text = "(MM)";
					}
				}
			}
			return null;
		}
		
		private void ItemIDText_TextChanged (System.Object sender, System.EventArgs e)
		{
			ItemNameText.Enabled = true;
		}
		
		private void NoneRadioButton_CheckedChanged (System.Object sender, System.EventArgs e)
		{
			if (NoneRadioButton.Checked == true)
			{
				OnReleaseOnly.Checked = false;
				forceSerial.Checked = false;
				OnReleaseOnly.Visible = false;
				forceSerial.Visible = false;
			}
		}
		
		private void manBatchRadioButton_CheckedChanged (System.Object sender, System.EventArgs e)
		{
			if (manBatchRadioButton.Checked == true)
			{
				OnReleaseOnly.Checked = false;
				forceSerial.Checked = false;
				OnReleaseOnly.Visible = false;
				forceSerial.Visible = true;
			}
		}
	}
	
}
