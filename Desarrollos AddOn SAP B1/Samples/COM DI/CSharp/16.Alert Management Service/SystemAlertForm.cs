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
//  File:     SystemAlertForm.vb
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
// Update System Alert
//
//****************************************************************************
namespace FormWindowTemplateVb
{
	public class SystemAlertForm : System.Windows.Forms.Form
	{
		
		
		
		#region " Windows Form Designer generated code "
		
		public SystemAlertForm() {
			
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
		internal System.Windows.Forms.Button cmdUpdate;
		internal System.Windows.Forms.ComboBox cboPriority;
		internal System.Windows.Forms.CheckBox chkActive;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.CheckBox chkSendInternal;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtUserCode;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.TextBox txtCode;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox cboDocument;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtConditions;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdUpdate = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(SystemAlertForm_Load);
			cmdUpdate.Click += new System.EventHandler(cmdUpdate_Click);
			this.cboPriority = new System.Windows.Forms.ComboBox();
			this.chkActive = new System.Windows.Forms.CheckBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.chkSendInternal = new System.Windows.Forms.CheckBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtUserCode = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cboDocument = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtConditions = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdUpdate
			//
			this.cmdUpdate.Location = new System.Drawing.Point(168, 312);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(120, 24);
			this.cmdUpdate.TabIndex = 2;
			this.cmdUpdate.Text = "Update System Alert";
			//
			//cboPriority
			//
			this.cboPriority.Items.AddRange(new object[] { "High", "Low", "Normal" });
			this.cboPriority.Location = new System.Drawing.Point(132, 79);
			this.cboPriority.Name = "cboPriority";
			this.cboPriority.Size = new System.Drawing.Size(148, 21);
			this.cboPriority.TabIndex = 29;
			//
			//chkActive
			//
			this.chkActive.Checked = true;
			this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkActive.Location = new System.Drawing.Point(24, 287);
			this.chkActive.Name = "chkActive";
			this.chkActive.Size = new System.Drawing.Size(80, 16);
			this.chkActive.TabIndex = 28;
			this.chkActive.Text = "Active  ";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(28, 81);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(96, 16);
			this.Label4.TabIndex = 27;
			this.Label4.Text = "Priority ";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.chkSendInternal);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtUserCode);
			this.GroupBox1.Location = new System.Drawing.Point(24, 184);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(264, 88);
			this.GroupBox1.TabIndex = 26;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Recipients ";
			//
			//chkSendInternal
			//
			this.chkSendInternal.Checked = true;
			this.chkSendInternal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSendInternal.Location = new System.Drawing.Point(8, 56);
			this.chkSendInternal.Name = "chkSendInternal";
			this.chkSendInternal.Size = new System.Drawing.Size(96, 16);
			this.chkSendInternal.TabIndex = 17;
			this.chkSendInternal.Text = "Send Internal";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(8, 26);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(80, 16);
			this.Label5.TabIndex = 16;
			this.Label5.Text = "User Code";
			//
			//txtUserCode
			//
			this.txtUserCode.Location = new System.Drawing.Point(104, 24);
			this.txtUserCode.Name = "txtUserCode";
			this.txtUserCode.Size = new System.Drawing.Size(148, 20);
			this.txtUserCode.TabIndex = 14;
			this.txtUserCode.Text = "1";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(28, 49);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 16);
			this.Label2.TabIndex = 25;
			this.Label2.Text = "Alert Code";
			//
			//txtCode
			//
			this.txtCode.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtCode.Location = new System.Drawing.Point(132, 47);
			this.txtCode.Name = "txtCode";
			this.txtCode.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(148, 20);
			this.txtCode.TabIndex = 24;
			this.txtCode.Text = "-5";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(28, 17);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 16);
			this.Label1.TabIndex = 23;
			this.Label1.Text = "Alert Name";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(132, 15);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(148, 20);
			this.txtName.TabIndex = 22;
			this.txtName.Text = "Deviation from Discount (in %)";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(28, 120);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(96, 16);
			this.Label3.TabIndex = 30;
			this.Label3.Text = "Document";
			//
			//cboDocument
			//
			this.cboDocument.Items.AddRange(new object[] { "Sales Quotations", "Sales Orders", "Deliveries", "Returns", "A/R Invoices", "A/R Credit Memos" });
			this.cboDocument.Location = new System.Drawing.Point(132, 112);
			this.cboDocument.Name = "cboDocument";
			this.cboDocument.Size = new System.Drawing.Size(148, 21);
			this.cboDocument.TabIndex = 31;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(28, 152);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(104, 16);
			this.Label6.TabIndex = 32;
			this.Label6.Text = "Discount %";
			//
			//txtConditions
			//
			this.txtConditions.Location = new System.Drawing.Point(132, 152);
			this.txtConditions.Name = "txtConditions";
			this.txtConditions.Size = new System.Drawing.Size(148, 20);
			this.txtConditions.TabIndex = 33;
			this.txtConditions.Text = "15";
			//
			//SystemAlertForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(312, 343);
			this.Controls.Add(this.txtConditions);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.cboDocument);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.cboPriority);
			this.Controls.Add(this.chkActive);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmdUpdate);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SystemAlertForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "System Alert";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		AlertManagementService oAlertTemplatesService;
		private void SystemAlertForm_Load (System.Object sender, System.EventArgs e)
		{
			
			InitService();
			
			InitCtrls();
			
		}
		
		private void InitCtrls ()
		{
			
			cboPriority.SelectedIndex = 1;
			
			cboDocument.SelectedIndex = 1;
			
		}
		
		private void InitService ()
		{
			
			try
			{
				MainModule.initCompanyService();
				
				//get Approval Stages Service
				oAlertTemplatesService = (SAPbobsCOM.AlertManagementService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.AlertManagementService);
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		//return the priority type
		private AlertManagementPriorityEnum GetPriority(string sPriority)
		{
			
			try
			{
				
				switch (sPriority)
				{
					case "High":
						
						
						return (AlertManagementPriorityEnum.atp_High);
						
//						case "Low":
//						
						
//						return (AlertManagementPriorityEnum.atp_Low);
						
//						case "Normal":
//						
						
//						return (AlertManagementPriorityEnum.atp_Normal);
						
				}
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return 0;
		}
		
		//return the document type
		private AlertManagementDocumentEnum GetDocumentType(string sDocument)
		{
			
			try
			{
				
				switch (sDocument)
				{
					case "Sales Quotations":
						
						
						return (AlertManagementDocumentEnum.atd_Quotations);
						
//						case "Sales Orders":
//						
						
//						return (AlertManagementDocumentEnum.atd_Orders);
						
//						case "Deliveries":
//						
						
//						return (AlertManagementDocumentEnum.atd_DeliveryNotes);
						
//						case "Returns":
//						
						
//						return (AlertManagementDocumentEnum.atd_Returns);
						
//						case "A/R Invoices":
//						
						
//						return (AlertManagementDocumentEnum.atd_Invoices);
						
//						case "A/R Credit Memos":
//						
						
//						return (AlertManagementDocumentEnum.atd_RevertInvoice);
						
				}
				
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
			return 0;
		}
		
		private void cmdUpdate_Click (System.Object sender, System.EventArgs e)
		{
			try
			{
				
				AlertManagement oAlertTemplate;
				AlertManagementParams oAlertTemplateParams;
				AlertManagementRecipients oAlertTemplateRecipients;
				AlertManagementRecipient oAlertRecipient;
				int j;
				
				//get alert template params
				oAlertTemplateParams = (SAPbobsCOM.AlertManagementParams) oAlertTemplatesService.GetDataInterface(AlertManagementServiceDataInterfaces.atsdiAlertManagementParams);
				
				//set system alert code
				oAlertTemplateParams.Code = System.Convert.ToInt32(txtCode.Text);
				
				//get alert template
				oAlertTemplate = oAlertTemplatesService.GetAlertManagement(oAlertTemplateParams);
				
				//set alert name
				oAlertTemplate.Name = txtName.Text;
				
				oAlertTemplate.Active = (SAPbobsCOM.BoYesNoEnum) (Interaction.IIf(chkActive.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO));
				
				//set % Discount
				oAlertTemplate.Param = txtConditions.Text;
				
				//set priority
				oAlertTemplate.Priority = GetPriority(cboPriority.SelectedItem.ToString());
				
				//update selected document
				for (j = 0; j <= oAlertTemplate.AlertManagementDocuments.Count - 1; j++)
				{
					if (oAlertTemplate.AlertManagementDocuments.Item(j).Document == GetDocumentType(cboDocument.SelectedItem.ToString()))
					{
						oAlertTemplate.AlertManagementDocuments.Item(j).Active = BoYesNoEnum.tYES;
						break;
					}
				}
				
				//get recipient collection
				oAlertTemplateRecipients = oAlertTemplate.AlertManagementRecipients;
				
				//add recipient
				oAlertRecipient = oAlertTemplateRecipients.Add();
				
				//set recipient code(manager=1)
				oAlertRecipient.UserCode = System.Convert.ToInt32(txtUserCode.Text);
				
				//set internal message
				oAlertRecipient.SendInternal = (SAPbobsCOM.BoYesNoEnum) (Interaction.IIf(chkSendInternal.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO));
				
				//update alert
				oAlertTemplatesService.UpdateAlertManagement(oAlertTemplate);
				
				
				
				
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
		}
	}
	
}
