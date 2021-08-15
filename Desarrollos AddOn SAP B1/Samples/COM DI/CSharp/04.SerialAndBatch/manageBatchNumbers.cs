using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace WindowsApplication2
{
	public class manageBatch : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public manageBatch() {
			
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
		internal System.Windows.Forms.Button addButton;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Total;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Button CancelButton1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label NumberOfBatches;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox batchNumber;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox manBatchNumberText;
		internal System.Windows.Forms.TextBox InternalSerialNumber;
		internal System.Windows.Forms.Label Label10;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.addButton = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(manageBatch_Load);
			addButton.Click += new System.EventHandler(addButton_Click);
			this.manBatchNumberText = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.NumberOfBatches = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Total = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.CancelButton1 = new System.Windows.Forms.Button();
			CancelButton1.Click += new System.EventHandler(CancelButton1_Click);
			this.Label8 = new System.Windows.Forms.Label();
			this.batchNumber = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.InternalSerialNumber = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//addButton
			//
			this.addButton.Location = new System.Drawing.Point(104, 288);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(72, 24);
			this.addButton.TabIndex = 20;
			this.addButton.Text = "Add";
			//
			//manBatchNumberText
			//
			this.manBatchNumberText.Location = new System.Drawing.Point(240, 216);
			this.manBatchNumberText.Name = "manBatchNumberText";
			this.manBatchNumberText.Size = new System.Drawing.Size(96, 20);
			this.manBatchNumberText.TabIndex = 16;
			this.manBatchNumberText.Text = "";
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.GroupBox1.Controls.Add(this.NumberOfBatches);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Total);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Location = new System.Drawing.Point(48, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(360, 152);
			this.GroupBox1.TabIndex = 10;
			this.GroupBox1.TabStop = false;
			//
			//NumberOfBatches
			//
			this.NumberOfBatches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.NumberOfBatches.Location = new System.Drawing.Point(128, 104);
			this.NumberOfBatches.Name = "NumberOfBatches";
			this.NumberOfBatches.Size = new System.Drawing.Size(80, 16);
			this.NumberOfBatches.TabIndex = 7;
			this.NumberOfBatches.Text = "1";
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(24, 104);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(128, 16);
			this.Label6.TabIndex = 6;
			this.Label6.Text = "Number Of Batches:";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(24, 80);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(80, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Total Items:";
			//
			//Total
			//
			this.Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Total.Location = new System.Drawing.Point(128, 80);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(80, 16);
			this.Total.TabIndex = 5;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(24, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(80, 16);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Item Name:";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 32);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 16);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Item ID:";
			//
			//Label3
			//
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label3.Location = new System.Drawing.Point(128, 32);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(80, 16);
			this.Label3.TabIndex = 2;
			//
			//Label4
			//
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Location = new System.Drawing.Point(128, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(168, 16);
			this.Label4.TabIndex = 3;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(80, 216);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(144, 16);
			this.Label7.TabIndex = 11;
			this.Label7.Text = "Manufacture Serial Number";
			//
			//CancelButton1
			//
			this.CancelButton1.Location = new System.Drawing.Point(224, 288);
			this.CancelButton1.Name = "CancelButton1";
			this.CancelButton1.Size = new System.Drawing.Size(72, 24);
			this.CancelButton1.TabIndex = 21;
			this.CancelButton1.Text = "Cancel";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(80, 192);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(144, 16);
			this.Label8.TabIndex = 15;
			this.Label8.Text = "Batch";
			//
			//batchNumber
			//
			this.batchNumber.Location = new System.Drawing.Point(240, 192);
			this.batchNumber.Name = "batchNumber";
			this.batchNumber.Size = new System.Drawing.Size(96, 20);
			this.batchNumber.TabIndex = 12;
			this.batchNumber.Text = "";
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(80, 248);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(144, 16);
			this.Label9.TabIndex = 17;
			this.Label9.Text = "Internal Serial Number";
			//
			//InternalSerialNumber
			//
			this.InternalSerialNumber.Location = new System.Drawing.Point(240, 240);
			this.InternalSerialNumber.Name = "InternalSerialNumber";
			this.InternalSerialNumber.Size = new System.Drawing.Size(96, 20);
			this.InternalSerialNumber.TabIndex = 18;
			this.InternalSerialNumber.Text = "";
			//
			//Label10
			//
			this.Label10.Location = new System.Drawing.Point(368, 192);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(144, 16);
			this.Label10.TabIndex = 22;
			this.Label10.Text = "+ 0,1,2,3,... (to be unique)";
			//
			//manageBatch
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 445);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.InternalSerialNumber);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.batchNumber);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.manBatchNumberText);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.CancelButton1);
			this.Name = "manageBatch";
			this.Text = "Manage Batch Numbers";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		////  SAP MANAGE DI API 2007 SDK Sample
		////****************************************************************************
		////
		////  File:      manageBatchNumbers.vb
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		private void manageBatch_Load (System.Object sender, System.EventArgs e)
		{
			Label3.Text = globalD.oItems.ItemCode;
			Label4.Text = globalD.oItems.ItemName;
			Total.Text = globalD.totalNumber.ToString();
			manBatchNumberText.Text = "";
			InternalSerialNumber.Text = "";
			batchNumber.Text = "";
		}
		
		private void addButton_Click (System.Object sender, System.EventArgs e)
		{
			globalD.batchNum = batchNumber.Text;
			globalD.manBatchNumber = manBatchNumberText.Text;
			globalD.interSerNumber = InternalSerialNumber.Text;
			ActiveForm.Dispose();
		}
		
		private void CancelButton1_Click (System.Object sender, System.EventArgs e)
		{
			ActiveForm.Dispose();
		}
		
	}
	
}
