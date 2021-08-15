using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using SAPbobsCOM;


//  SAP DI API 2006 SDK Sample
//****************************************************************************
//
//  File:     ItemCycleCountForm.vb
//
//  Copyright (c) SAP
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************
//****************************************************************************
//
// Description:
// ------------
// Add an existing Cycle Count to an existing item
//
//****************************************************************************


namespace ItemCycleCount
{
	public class ItemCycleCountForm : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public ItemCycleCountForm() {
			
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
		internal System.Windows.Forms.Button cmdAdd;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtItemCode;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txtUserCode;
		internal System.Windows.Forms.TextBox txtCycleCode;
		internal System.Windows.Forms.Label lblUserCode;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox cboWareHouse;
		internal System.Windows.Forms.CheckBox chkAlert;
		internal System.Windows.Forms.Label Label4;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdAdd = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(ItemCycleCountForm_Load);
			cmdAdd.Click += new System.EventHandler(cmdAdd_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.txtItemCode = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.chkAlert = new System.Windows.Forms.CheckBox();
			this.txtUserCode = new System.Windows.Forms.TextBox();
			this.txtCycleCode = new System.Windows.Forms.TextBox();
			this.lblUserCode = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.cboWareHouse = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdAdd
			//
			this.cmdAdd.Location = new System.Drawing.Point(200, 288);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(80, 24);
			this.cmdAdd.TabIndex = 0;
			this.cmdAdd.Text = "Add";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(104, 24);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Item Code";
			//
			//txtItemCode
			//
			this.txtItemCode.Location = new System.Drawing.Point(128, 16);
			this.txtItemCode.Name = "txtItemCode";
			this.txtItemCode.Size = new System.Drawing.Size(104, 20);
			this.txtItemCode.TabIndex = 6;
			this.txtItemCode.Text = "X0003";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.chkAlert);
			this.GroupBox1.Controls.Add(this.txtUserCode);
			this.GroupBox1.Controls.Add(this.txtCycleCode);
			this.GroupBox1.Controls.Add(this.lblUserCode);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Location = new System.Drawing.Point(8, 96);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(272, 136);
			this.GroupBox1.TabIndex = 12;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Cycle Count ";
			//
			//chkAlert
			//
			this.chkAlert.Checked = true;
			this.chkAlert.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAlert.Location = new System.Drawing.Point(16, 96);
			this.chkAlert.Name = "chkAlert";
			this.chkAlert.Size = new System.Drawing.Size(96, 24);
			this.chkAlert.TabIndex = 17;
			this.chkAlert.Text = "Alert";
			//
			//txtUserCode
			//
			this.txtUserCode.Location = new System.Drawing.Point(120, 64);
			this.txtUserCode.Name = "txtUserCode";
			this.txtUserCode.Size = new System.Drawing.Size(104, 20);
			this.txtUserCode.TabIndex = 15;
			this.txtUserCode.Text = "1";
			//
			//txtCycleCode
			//
			this.txtCycleCode.Location = new System.Drawing.Point(120, 32);
			this.txtCycleCode.Name = "txtCycleCode";
			this.txtCycleCode.Size = new System.Drawing.Size(104, 20);
			this.txtCycleCode.TabIndex = 14;
			this.txtCycleCode.Text = "1";
			//
			//lblUserCode
			//
			this.lblUserCode.Location = new System.Drawing.Point(16, 65);
			this.lblUserCode.Name = "lblUserCode";
			this.lblUserCode.Size = new System.Drawing.Size(104, 18);
			this.lblUserCode.TabIndex = 13;
			this.lblUserCode.Text = "User Code";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 33);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(104, 18);
			this.Label2.TabIndex = 12;
			this.Label2.Text = "Cycle Code";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(16, 56);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(104, 24);
			this.Label3.TabIndex = 13;
			this.Label3.Text = "Item WareHouse";
			//
			//cboWareHouse
			//
			this.cboWareHouse.Items.AddRange(new object[] { "01", "02", "03", "04" });
			this.cboWareHouse.Location = new System.Drawing.Point(128, 56);
			this.cboWareHouse.Name = "cboWareHouse";
			this.cboWareHouse.Size = new System.Drawing.Size(104, 21);
			this.cboWareHouse.TabIndex = 30;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(8, 240);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(272, 40);
			this.Label4.TabIndex = 31;
			this.Label4.Text = "Before adding an item cycle count make sure you have an item and a cycle count";
			//
			//ItemCycleCountForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 325);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.cboWareHouse);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.txtItemCode);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cmdAdd);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ItemCycleCountForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item Cycle Count";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void ItemCycleCountForm_Load (System.Object sender, System.EventArgs e)
		{
			//select the first warehouse
			cboWareHouse.SelectedIndex = 0;
			
		}
		private void cmdAdd_Click (System.Object sender, System.EventArgs e)
		{
			try
			{
				
				//				SAPbobsCOM.ItemCycleCount oAlertTemplate;
				Items oItem;
				ItemWarehouseInfo oWhareHouse;
				
				oItem = (SAPbobsCOM.Items) MainModule.oCompany.GetBusinessObject(BoObjectTypes.oItems);
				
				//get item
				oItem.GetByKey(txtItemCode.Text);
				
				//get the selected wharehouse
				oWhareHouse = GetWareHouse(cboWareHouse.SelectedItem.ToString(), oItem);
				
				//an existind cycle count (e.g CycleCode=1 : CycleName:"Weekly on Tuesday" ,OCYC table)
				oWhareHouse.ItemCycleCount.CycleCode = System.Convert.ToInt32(txtCycleCode.Text);
				
				//set alert
				oWhareHouse.ItemCycleCount.Alert = (SAPbobsCOM.BoYesNoEnum) (Interaction.IIf(chkAlert.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO));
				
				//set user
				oWhareHouse.ItemCycleCount.DestinationUser = System.Convert.ToInt32(txtUserCode.Text);
				
				//update item with new Cycle Count
				oItem.Update();
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
		}
		
		//return the the selected warehouse
		private ItemWarehouseInfo GetWareHouse(string sWarehouse, Items oItem)
		{
			
			try
			{
				
				switch (sWarehouse)
				{
					case "01":
						
						
						return (oItem.WhsInfo);
						
//						case "02":
//						
//						oItem.WhsInfo.SetCurrentLine(1);
//						return (oItem.WhsInfo);
						
//						case "03":
//						
//						oItem.WhsInfo.SetCurrentLine(2);
//						return (oItem.WhsInfo);
						
//						case "04":
//						
//						oItem.WhsInfo.SetCurrentLine(3);
//						return (oItem.WhsInfo);
						
				}
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return null;
		}
		
		
		
	}
	
}
