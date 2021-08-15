using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;


//****************************************************************************
//  SAP MANAGE DI API 2007 SDK Sample
//****************************************************************************
//
//  Copyright (c) SAP MANAGE
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************
// In this sample the SAP Business one order form is imitated via DI 2005
//****************************************************************************


namespace ord
{
	public class SelectCustomer : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public SelectCustomer() {
			
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
		internal System.Windows.Forms.Label lblCustomer;
		internal System.Windows.Forms.ListBox cmbCustomer;
		internal System.Windows.Forms.ListBox cmbName;
		internal System.Windows.Forms.ListBox lstChoose;
		internal System.Windows.Forms.Button cmdSelect;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
			this.lblCustomer = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(SelectCustomer_Load);
			base.Resize += new System.EventHandler(SelectCustomer_Resize);
			this.cmbCustomer = new System.Windows.Forms.ListBox();
			this.cmbName = new System.Windows.Forms.ListBox();
			this.lstChoose = new System.Windows.Forms.ListBox();
			lstChoose.SelectedIndexChanged += new System.EventHandler(lstChoose_SelectedIndexChanged);
			this.cmdSelect = new System.Windows.Forms.Button();
			cmdSelect.Click += new System.EventHandler(cmdSelect_Click);
			this.SuspendLayout();
			//
			//lblCustomer
			//
			this.lblCustomer.Location = new System.Drawing.Point(8, 8);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(88, 23);
			this.lblCustomer.TabIndex = 45;
			this.lblCustomer.Text = "Customer";
			//
			//cmbCustomer
			//
			this.cmbCustomer.Location = new System.Drawing.Point(104, 8);
			this.cmbCustomer.Name = "cmbCustomer";
			this.cmbCustomer.Size = new System.Drawing.Size(24, 17);
			this.cmbCustomer.TabIndex = 49;
			this.cmbCustomer.Visible = false;
			//
			//cmbName
			//
			this.cmbName.Location = new System.Drawing.Point(136, 8);
			this.cmbName.Name = "cmbName";
			this.cmbName.Size = new System.Drawing.Size(32, 17);
			this.cmbName.TabIndex = 50;
			this.cmbName.Visible = false;
			//
			//lstChoose
			//
			this.lstChoose.Location = new System.Drawing.Point(8, 32);
			this.lstChoose.MultiColumn = System.Convert.ToBoolean(configurationAppSettings.GetValue("lstChoose.MultiColumn", typeof(System.Boolean)));
			this.lstChoose.Name = "lstChoose";
			this.lstChoose.Size = new System.Drawing.Size(256, 199);
			this.lstChoose.TabIndex = 52;
			//
			//cmdSelect
			//
			this.cmdSelect.Location = new System.Drawing.Point(8, 240);
			this.cmdSelect.Name = "cmdSelect";
			this.cmdSelect.TabIndex = 54;
			this.cmdSelect.Text = "Choose";
			//
			//SelectCustomer
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(272, 269);
			this.ControlBox = false;
			this.Controls.Add(this.cmdSelect);
			this.Controls.Add(this.lstChoose);
			this.Controls.Add(this.cmbName);
			this.Controls.Add(this.cmbCustomer);
			this.Controls.Add(this.lblCustomer);
			this.Name = "SelectCustomer";
			this.Text = "SelectCustomer";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		public string BPName;
		public string BPCode;
		public int iSelectedIndex;
		
		
		//****************************************************************************
		// This procedure is called when the form is loaded
		//****************************************************************************
		private void SelectCustomer_Load (System.Object sender, System.EventArgs e)
		{
			LoadList();
		}
		//****************************************************************************
		// This procedure loads the customer list
		//****************************************************************************
		private void LoadList ()
		{
			SAPbobsCOM.SBObob oObj;
			SAPbobsCOM.Recordset rs;
			
			oObj = (SAPbobsCOM.SBObob) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
			rs = (SAPbobsCOM.Recordset) OrderApp.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
			
			// Set the Customer Name and Customer Code Combo Boxes
			rs = oObj.GetBPList(SAPbobsCOM.BoCardTypes.cCustomer);
			rs.MoveFirst();
			while (!(rs.EoF))
			{
				cmbCustomer.Items.Add(rs.Fields.Item(0).Value);
				cmbName.Items.Add(rs.Fields.Item(1).Value);
				rs.MoveNext();
			}
			if (cmbCustomer.Items.Count > 0)
			{
				cmbCustomer.SelectedIndex = 0;
				cmbName.SelectedIndex = 0;
			}
			
			int i;
			for (i = 0; i <= cmbCustomer.Items.Count - 1; i++)
			{
				lstChoose.Items.Add(cmbCustomer.Items[i] + ", " + cmbName.Items[i]);
			}
		}
		
		//****************************************************************************
		// This procedure sets the customer name and code lists by the user's choice
		//****************************************************************************
		private void lstChoose_SelectedIndexChanged (System.Object sender, System.EventArgs e)
		{
			cmbName.SelectedIndex = lstChoose.SelectedIndex;
			cmbCustomer.SelectedIndex = lstChoose.SelectedIndex;
		}
		
		//****************************************************************************
		// This procedure is called when the "select" button is clicked.
		// It puts values in the SelectCustomer class members, and closes the form.
		//****************************************************************************
		private void cmdSelect_Click (System.Object sender, System.EventArgs e)
		{
			BPName = cmbName.Items[cmbName.SelectedIndex].ToString();
			BPCode = cmbCustomer.Items[cmbCustomer.SelectedIndex].ToString();
			iSelectedIndex = cmbName.SelectedIndex;
			this.Close();
		}
		
		//****************************************************************************
		// This procedure is called when the form is resized.
		// It sets the size of the customer list by the size of the form.
		//****************************************************************************
		private void SelectCustomer_Resize (object sender, System.EventArgs e)
		{
			lstChoose.Width = this.Width - lstChoose.Left - 15;
			lstChoose.Height = this.Height - lstChoose.Top - 60;
			cmdSelect.Top = this.Height - cmdSelect.Height - 35;
		}
	}
	
}
