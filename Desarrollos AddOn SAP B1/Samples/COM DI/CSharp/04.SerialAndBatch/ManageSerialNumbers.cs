using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace WindowsApplication2
{
	public class ManageSerial : System.Windows.Forms.Form
	{	
		
		#region " Windows Form Designer generated code "
		
		public ManageSerial() {
			
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
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox manSerialNumberText;
		internal System.Windows.Forms.Button addButton;
		internal System.Windows.Forms.Label Total;
		internal System.Windows.Forms.Button CancelButton1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			base.Load += new System.EventHandler(ManageSerial_Load);
			this.Label5 = new System.Windows.Forms.Label();
			this.Total = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.manSerialNumberText = new System.Windows.Forms.TextBox();
			manSerialNumberText.TextChanged += new System.EventHandler(manSerialNumberText_TextChanged);
			this.addButton = new System.Windows.Forms.Button();
			addButton.Click += new System.EventHandler(addButton_Click);
			this.CancelButton1 = new System.Windows.Forms.Button();
			CancelButton1.Click += new System.EventHandler(CancelButton1_Click);
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Total);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Location = new System.Drawing.Point(24, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(320, 120);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			//
			//Label5
			//
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.Location = new System.Drawing.Point(24, 80);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(80, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Total Items:";
			//
			//Total
			//
			this.Total.BackColor = System.Drawing.SystemColors.Control;
			this.Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Total.Location = new System.Drawing.Point(128, 80);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(80, 16);
			this.Total.TabIndex = 5;
			//
			//Label2
			//
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Location = new System.Drawing.Point(24, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(80, 16);
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
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label3.Location = new System.Drawing.Point(128, 32);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(80, 16);
			this.Label3.TabIndex = 2;
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Location = new System.Drawing.Point(128, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(168, 16);
			this.Label4.TabIndex = 3;
			//
			//Label7
			//
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.Location = new System.Drawing.Point(24, 152);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(144, 16);
			this.Label7.TabIndex = 6;
			this.Label7.Text = "Manufacture Serial Number";
			//
			//manSerialNumberText
			//
			this.manSerialNumberText.BackColor = System.Drawing.SystemColors.Control;
			this.manSerialNumberText.Location = new System.Drawing.Point(176, 152);
			this.manSerialNumberText.Name = "manSerialNumberText";
			this.manSerialNumberText.Size = new System.Drawing.Size(96, 20);
			this.manSerialNumberText.TabIndex = 7;
			this.manSerialNumberText.Text = "";
			//
			//addButton
			//
			this.addButton.BackColor = System.Drawing.SystemColors.Control;
			this.addButton.Location = new System.Drawing.Point(48, 216);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(72, 24);
			this.addButton.TabIndex = 8;
			this.addButton.Text = "Add";
			//
			//CancelButton1
			//
			this.CancelButton1.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton1.Location = new System.Drawing.Point(168, 216);
			this.CancelButton1.Name = "CancelButton1";
			this.CancelButton1.Size = new System.Drawing.Size(72, 24);
			this.CancelButton1.TabIndex = 9;
			this.CancelButton1.Text = "Cancel";
			//
			//ManageSerial
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(400, 325);
			this.Controls.Add(this.CancelButton1);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.manSerialNumberText);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.GroupBox1);
			this.Name = "ManageSerial";
			this.Text = "Manage Serial Numbers";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		////  SAP MANAGE DI API 2007 SDK Sample
		////****************************************************************************
		////
		////  File:     ManageSerialNumbers.vb
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		private void ManageSerial_Load (System.Object sender, System.EventArgs e)
		{
			Label3.Text = globalD.oItems.ItemCode;
			Label4.Text = globalD.oItems.ItemName;
			Total.Text = globalD.totalNumber.ToString();
		}
		
		private void manSerialNumberText_TextChanged (System.Object sender, System.EventArgs e)
		{
			
		}
		
		private void addButton_Click (System.Object sender, System.EventArgs e)
		{
			globalD.manSerialNumber = manSerialNumberText.Text;
			ActiveForm.Dispose();
		}
		
		private void CancelButton1_Click (System.Object sender, System.EventArgs e)
		{
			ActiveForm.Dispose();
		}	
	}
}
