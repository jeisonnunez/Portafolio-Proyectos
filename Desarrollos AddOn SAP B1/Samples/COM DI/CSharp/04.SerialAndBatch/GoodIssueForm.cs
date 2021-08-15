using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace WindowsApplication2
{
	public class GoodI : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public GoodI() {
			
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
		internal System.Windows.Forms.Button CancelButton1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label MsgBoxLabel;
		internal System.Windows.Forms.Button addButton;
		internal System.Windows.Forms.GroupBox InventoryGenEntry;
		internal System.Windows.Forms.Label TotalItemsLabel;
		internal System.Windows.Forms.ComboBox CurrencyComboBox;
		internal System.Windows.Forms.Label Currency;
		internal System.Windows.Forms.Label Discount;
		internal System.Windows.Forms.TextBox DiscountText;
		internal System.Windows.Forms.Label Quantity;
		internal System.Windows.Forms.TextBox QuantityText;
		internal System.Windows.Forms.Label Price;
		internal System.Windows.Forms.TextBox PriceText;
		internal System.Windows.Forms.Label TotalPrice;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.CancelButton1 = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(GoodI_Load);
			CancelButton1.Click += new System.EventHandler(CancelButton1_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.MsgBoxLabel = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			addButton.Click += new System.EventHandler(addButton_Click);
			this.InventoryGenEntry = new System.Windows.Forms.GroupBox();
			this.TotalPrice = new System.Windows.Forms.Label();
			this.TotalItemsLabel = new System.Windows.Forms.Label();
			this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
			this.Currency = new System.Windows.Forms.Label();
			this.Discount = new System.Windows.Forms.Label();
			this.DiscountText = new System.Windows.Forms.TextBox();
			this.Quantity = new System.Windows.Forms.Label();
			this.QuantityText = new System.Windows.Forms.TextBox();
			QuantityText.Leave += new System.EventHandler(QuantityText_Leave);
			this.Price = new System.Windows.Forms.Label();
			this.PriceText = new System.Windows.Forms.TextBox();
			PriceText.Leave += new System.EventHandler(PriceText_Leave);
			this.GroupBox1.SuspendLayout();
			this.InventoryGenEntry.SuspendLayout();
			this.SuspendLayout();
			//
			//CancelButton1
			//
			this.CancelButton1.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton1.Location = new System.Drawing.Point(160, 368);
			this.CancelButton1.Name = "CancelButton1";
			this.CancelButton1.Size = new System.Drawing.Size(64, 32);
			this.CancelButton1.TabIndex = 27;
			this.CancelButton1.Text = "Cancel";
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Location = new System.Drawing.Point(56, 32);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(288, 96);
			this.GroupBox1.TabIndex = 24;
			this.GroupBox1.TabStop = false;
			//
			//Label2
			//
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Location = new System.Drawing.Point(24, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(64, 16);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Item Name:";
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Location = new System.Drawing.Point(24, 32);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 16);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Item ID:";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.Location = new System.Drawing.Point(128, 32);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(136, 16);
			this.Label3.TabIndex = 2;
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.Location = new System.Drawing.Point(128, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(136, 16);
			this.Label4.TabIndex = 3;
			//
			//MsgBoxLabel
			//
			this.MsgBoxLabel.BackColor = System.Drawing.SystemColors.Control;
			this.MsgBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.MsgBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((byte)(192)),((byte)(0)),((byte)(0)));
			this.MsgBoxLabel.Location = new System.Drawing.Point(380, 360);
			this.MsgBoxLabel.Name = "MsgBoxLabel";
			this.MsgBoxLabel.Size = new System.Drawing.Size(160, 64);
			this.MsgBoxLabel.TabIndex = 28;
			//
			//addButton
			//
			this.addButton.BackColor = System.Drawing.SystemColors.Control;
			this.addButton.Location = new System.Drawing.Point(64, 368);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(72, 32);
			this.addButton.TabIndex = 26;
			this.addButton.Text = "Add";
			//
			//InventoryGenEntry
			//
			this.InventoryGenEntry.BackColor = System.Drawing.SystemColors.Control;
			this.InventoryGenEntry.Controls.Add(this.TotalPrice);
			this.InventoryGenEntry.Controls.Add(this.TotalItemsLabel);
			this.InventoryGenEntry.Controls.Add(this.CurrencyComboBox);
			this.InventoryGenEntry.Controls.Add(this.Currency);
			this.InventoryGenEntry.Controls.Add(this.Discount);
			this.InventoryGenEntry.Controls.Add(this.DiscountText);
			this.InventoryGenEntry.Controls.Add(this.Quantity);
			this.InventoryGenEntry.Controls.Add(this.QuantityText);
			this.InventoryGenEntry.Controls.Add(this.Price);
			this.InventoryGenEntry.Controls.Add(this.PriceText);
			this.InventoryGenEntry.Location = new System.Drawing.Point(60, 160);
			this.InventoryGenEntry.Name = "InventoryGenEntry";
			this.InventoryGenEntry.Size = new System.Drawing.Size(480, 160);
			this.InventoryGenEntry.TabIndex = 25;
			this.InventoryGenEntry.TabStop = false;
			this.InventoryGenEntry.Text = "InventoryGenEntry";
			//
			//TotalPrice
			//
			this.TotalPrice.BackColor = System.Drawing.SystemColors.Control;
			this.TotalPrice.Location = new System.Drawing.Point(368, 24);
			this.TotalPrice.Name = "TotalPrice";
			this.TotalPrice.Size = new System.Drawing.Size(80, 16);
			this.TotalPrice.TabIndex = 15;
			//
			//TotalItemsLabel
			//
			this.TotalItemsLabel.BackColor = System.Drawing.SystemColors.Control;
			this.TotalItemsLabel.Location = new System.Drawing.Point(272, 24);
			this.TotalItemsLabel.Name = "TotalItemsLabel";
			this.TotalItemsLabel.Size = new System.Drawing.Size(80, 16);
			this.TotalItemsLabel.TabIndex = 14;
			this.TotalItemsLabel.Text = "Total Price:";
			//
			//CurrencyComboBox
			//
			this.CurrencyComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.CurrencyComboBox.Location = new System.Drawing.Point(120, 120);
			this.CurrencyComboBox.Name = "CurrencyComboBox";
			this.CurrencyComboBox.Size = new System.Drawing.Size(88, 21);
			this.CurrencyComboBox.TabIndex = 13;
			//
			//Currency
			//
			this.Currency.BackColor = System.Drawing.SystemColors.Control;
			this.Currency.Location = new System.Drawing.Point(16, 120);
			this.Currency.Name = "Currency";
			this.Currency.Size = new System.Drawing.Size(80, 16);
			this.Currency.TabIndex = 12;
			this.Currency.Text = "Currency:";
			//
			//Discount
			//
			this.Discount.BackColor = System.Drawing.SystemColors.Control;
			this.Discount.Location = new System.Drawing.Point(16, 88);
			this.Discount.Name = "Discount";
			this.Discount.Size = new System.Drawing.Size(80, 16);
			this.Discount.TabIndex = 10;
			this.Discount.Text = "Discount %:";
			//
			//DiscountText
			//
			this.DiscountText.BackColor = System.Drawing.SystemColors.Window;
			this.DiscountText.Location = new System.Drawing.Point(120, 88);
			this.DiscountText.Name = "DiscountText";
			this.DiscountText.Size = new System.Drawing.Size(88, 20);
			this.DiscountText.TabIndex = 9;
			this.DiscountText.Text = "";
			//
			//Quantity
			//
			this.Quantity.BackColor = System.Drawing.SystemColors.Control;
			this.Quantity.Location = new System.Drawing.Point(16, 24);
			this.Quantity.Name = "Quantity";
			this.Quantity.Size = new System.Drawing.Size(80, 16);
			this.Quantity.TabIndex = 8;
			this.Quantity.Text = "Quantity:";
			//
			//QuantityText
			//
			this.QuantityText.BackColor = System.Drawing.SystemColors.Window;
			this.QuantityText.Location = new System.Drawing.Point(120, 24);
			this.QuantityText.Name = "QuantityText";
			this.QuantityText.Size = new System.Drawing.Size(88, 20);
			this.QuantityText.TabIndex = 5;
			this.QuantityText.Text = "";
			//
			//Price
			//
			this.Price.BackColor = System.Drawing.SystemColors.Control;
			this.Price.Location = new System.Drawing.Point(16, 56);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(80, 16);
			this.Price.TabIndex = 6;
			this.Price.Text = "Price:";
			//
			//PriceText
			//
			this.PriceText.BackColor = System.Drawing.SystemColors.Window;
			this.PriceText.Location = new System.Drawing.Point(120, 56);
			this.PriceText.Name = "PriceText";
			this.PriceText.Size = new System.Drawing.Size(88, 20);
			this.PriceText.TabIndex = 7;
			this.PriceText.Text = "";
			//
			//GoodI
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(576, 469);
			this.Controls.Add(this.CancelButton1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.MsgBoxLabel);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.InventoryGenEntry);
			this.Name = "GoodI";
			this.Text = "Good Issue Form";
			this.GroupBox1.ResumeLayout(false);
			this.InventoryGenEntry.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		////  SAP MANAGE DI API 2007 SDK Sample
		////****************************************************************************
		////
		////  File:      GoodIssueForm.vb
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		private void GoodI_Load (System.Object sender, System.EventArgs e)
		{
			Label3.Text = globalD.oItems.ItemCode;
			Label4.Text = globalD.oItems.ItemName;
			//   fill the combo box with the currency group, when the dialog box is being loading
			CurrencyComboBox.Items.Add("USD");
			CurrencyComboBox.Items.Add("CAN");
			CurrencyComboBox.Items.Add("EUR");
			CurrencyComboBox.SelectedIndex = 0;
			DiscountText.Text = "0";
			PriceText.Text = "0";
			QuantityText.Text = "1";
		}
		
		private void addButton_Click (System.Object sender, System.EventArgs e)
		{
			//   the quantity has to be greater than 0
			if (System.Convert.ToDouble(QuantityText.Text) <= 0)
			{
				MsgBoxLabel.Text = "quantity number is invalid - the quantity is less than 1";
				return;
			}
			//   the price has to be greater than 0
			if (System.Convert.ToDouble(PriceText.Text) <= 0)
			{
				MsgBoxLabel.Text = "price number is invalid - the price is less than 0";
				return;
			}
			TotalPrice.Text = System.Convert.ToString(System.Convert.ToDouble(PriceText.Text) * System.Convert.ToDouble(QuantityText.Text));
			globalD.oInvGenExit = (SAPbobsCOM.Documents) globalD.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit);
			int i;
			
			if (globalD.flagBatch && globalD.flagForce)
			{
				// check if the item is being manage with batch numbers & force.
				// in the good issue only force popup the dialog box
				manageBatch manageBatch = new manageBatch();
				globalD.manBatchNumber = "xyz";
				globalD.totalNumber = (int) (System.Convert.ToDouble(QuantityText.Text));
				manageBatch.ShowDialog();
				//   fill the BatchNumbers object with the data which was inserted in the dialog.
				//   BatchNumbers is a business object that represents the batch
				//   numbers of an item in the Inventory and Production module of
				//   the SAP Business One application.
				for (i = 0; i <= globalD.totalNumber - 1; i++)
				{
					globalD.oInvGenExit.Lines.BatchNumbers.Quantity = 1;
					globalD.oInvGenExit.Lines.BatchNumbers.ManufacturerSerialNumber = globalD.manBatchNumber;
					globalD.oInvGenExit.Lines.BatchNumbers.InternalSerialNumber = globalD.interSerNumber;
					globalD.oInvGenExit.Lines.BatchNumbers.BatchNumber = globalD.batchNum+ i.ToString();
					globalD.oInvGenExit.Lines.BatchNumbers.SetCurrentLine(i);
					globalD.oInvGenExit.Lines.BatchNumbers.Add();
				}
			}
			else
			{
				if (globalD.flag) //If it is a "MH" or "MMH" item
				{
					//   Only if it is a "MH" or "MMH" item, popup the manage serial numbers.
					//   fill the SerialNumbers object with the data which was inserted
					//   SerialNumbers is a business object that represents the the serial
					//   numbers and additional tracking information of items
					ManageSerial manageSerial = new ManageSerial();
					globalD.manSerialNumber = "xyz";
					globalD.totalNumber = (int) (System.Convert.ToDouble(QuantityText.Text));
					manageSerial.ShowDialog();
					for (i = 0; i <= globalD.totalNumber - 1; i++)
					{
						globalD.oInvGenExit.Lines.SerialNumbers.SystemSerialNumber = System.Convert.ToInt32(System.Convert.ToString(i + 1));
						globalD.oInvGenExit.Lines.SerialNumbers.ManufacturerSerialNumber = globalD.manSerialNumber + "_" + i.ToString();
						globalD.oInvGenExit.Lines.SerialNumbers.InternalSerialNumber = System.Convert.ToString(i + 3);
						globalD.oInvGenExit.Lines.SerialNumbers.SetCurrentLine(i);
						globalD.oInvGenExit.Lines.SerialNumbers.Add();
					}
				}
			}
			//   fill the other data into the oInventoryGenExit object
			globalD.oInvGenExit.Lines.ItemCode = globalD.oItems.ItemCode;
			globalD.oInvGenExit.Lines.ItemDescription = globalD.oItems.ItemName;
			globalD.oInvGenExit.Lines.Currency = CurrencyComboBox.SelectedItem.ToString();
			globalD.oInvGenExit.Lines.Price = System.Convert.ToDouble(PriceText.Text);
			globalD.oInvGenExit.Lines.ShipDate = DateTime.Now;
			globalD.oInvGenExit.Lines.Quantity = System.Convert.ToDouble(QuantityText.Text);
			globalD.oInvGenExit.Lines.DiscountPercent = System.Convert.ToDouble(DiscountText.Text);
			globalD.oInvGenExit.PaymentGroupCode = - 1;
			globalD.RetVal = globalD.oInvGenExit.Add();
			string temp_string = globalD.tempStr;
			globalD.oCompany.GetNewObjectCode(out temp_string);
			if (globalD.RetVal != 0)
			{
				int temp_int = globalD.ErrCode;
				string temp_string2 = globalD.ErrMsg;
				globalD.oCompany.GetLastError(out temp_int, out temp_string2);
				MsgBoxLabel.Text = globalD.ErrCode + " " + temp_string2;
			}
			else
			{
				MsgBoxLabel.Text = "The document of: " + globalD.oItems.ItemCode + " with Quantity=" + QuantityText.Text + " , price=" + PriceText.Text + " was added successfully";
			}
		}
		
		private void CancelButton1_Click (System.Object sender, System.EventArgs e)
		{
			ActiveForm.Dispose();
		}
		
		
		private void PriceText_Leave (object sender, System.EventArgs e)
		{
			TotalPrice.Text = System.Convert.ToString(System.Convert.ToDouble(PriceText.Text) * System.Convert.ToDouble(QuantityText.Text));
		}
		
		private void QuantityText_Leave (object sender, System.EventArgs e)
		{
			TotalPrice.Text = System.Convert.ToString(System.Convert.ToDouble(PriceText.Text) * System.Convert.ToDouble(QuantityText.Text));
		}
		
	}
	
}
