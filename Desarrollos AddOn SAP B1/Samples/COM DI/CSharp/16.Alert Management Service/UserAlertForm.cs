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
//  File:     UserAlertForm.vb
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
// Add a new User Alert
//
//****************************************************************************

namespace FormWindowTemplateVb
{
	public class UserAlertForm : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public UserAlertForm() {
			
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
		internal System.Windows.Forms.Button cmdAddAlert;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.TextBox txtQuery;
		internal System.Windows.Forms.TextBox txtUserCode;
		internal System.Windows.Forms.CheckBox chkActive;
		internal System.Windows.Forms.ComboBox cboPriority;
		internal System.Windows.Forms.CheckBox chkSendInternal;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox cboFreqType;
		internal System.Windows.Forms.TextBox txtFreqIntrvls;
		internal System.Windows.Forms.Label Label6;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdAddAlert = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(ApprovalTemplateForm_Load);
			cmdAddAlert.Click += new System.EventHandler(cmdAddAlert_Click);
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtQuery = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.chkSendInternal = new System.Windows.Forms.CheckBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtUserCode = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.chkActive = new System.Windows.Forms.CheckBox();
			this.cboPriority = new System.Windows.Forms.ComboBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.txtFreqIntrvls = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cboFreqType = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdAddAlert
			//
			this.cmdAddAlert.Location = new System.Drawing.Point(192, 320);
			this.cmdAddAlert.Name = "cmdAddAlert";
			this.cmdAddAlert.Size = new System.Drawing.Size(88, 24);
			this.cmdAddAlert.TabIndex = 0;
			this.cmdAddAlert.Text = "Add ";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(120, 8);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(128, 20);
			this.txtName.TabIndex = 2;
			this.txtName.Text = "Alert 1";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 16);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Alert Name";
			//
			//txtQuery
			//
			this.txtQuery.Location = new System.Drawing.Point(120, 56);
			this.txtQuery.Name = "txtQuery";
			this.txtQuery.Size = new System.Drawing.Size(128, 20);
			this.txtQuery.TabIndex = 4;
			this.txtQuery.Text = "34";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 16);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "Query ID  ";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.chkSendInternal);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtUserCode);
			this.GroupBox1.Location = new System.Drawing.Point(16, 200);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(264, 88);
			this.GroupBox1.TabIndex = 15;
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
			this.Label5.Size = new System.Drawing.Size(96, 16);
			this.Label5.TabIndex = 16;
			this.Label5.Text = "User Code";
			//
			//txtUserCode
			//
			this.txtUserCode.Location = new System.Drawing.Point(104, 24);
			this.txtUserCode.Name = "txtUserCode";
			this.txtUserCode.Size = new System.Drawing.Size(128, 20);
			this.txtUserCode.TabIndex = 14;
			this.txtUserCode.Text = "1";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(16, 90);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(96, 16);
			this.Label4.TabIndex = 17;
			this.Label4.Text = "Priority ";
			//
			//chkActive
			//
			this.chkActive.Checked = true;
			this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkActive.Location = new System.Drawing.Point(24, 296);
			this.chkActive.Name = "chkActive";
			this.chkActive.Size = new System.Drawing.Size(80, 16);
			this.chkActive.TabIndex = 19;
			this.chkActive.Text = "Active  ";
			//
			//cboPriority
			//
			this.cboPriority.Items.AddRange(new object[] { "High", "Low", "Normal" });
			this.cboPriority.Location = new System.Drawing.Point(120, 88);
			this.cboPriority.Name = "cboPriority";
			this.cboPriority.Size = new System.Drawing.Size(128, 21);
			this.cboPriority.TabIndex = 20;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.txtFreqIntrvls);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.cboFreqType);
			this.GroupBox2.Location = new System.Drawing.Point(16, 120);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(264, 72);
			this.GroupBox2.TabIndex = 21;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Frequency";
			//
			//txtFreqIntrvls
			//
			this.txtFreqIntrvls.Location = new System.Drawing.Point(64, 24);
			this.txtFreqIntrvls.Name = "txtFreqIntrvls";
			this.txtFreqIntrvls.Size = new System.Drawing.Size(32, 20);
			this.txtFreqIntrvls.TabIndex = 23;
			this.txtFreqIntrvls.Text = "1";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(8, 24);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(48, 16);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Every";
			//
			//cboFreqType
			//
			this.cboFreqType.Items.AddRange(new object[] { "Hours", "Minutes" });
			this.cboFreqType.Location = new System.Drawing.Point(104, 24);
			this.cboFreqType.Name = "cboFreqType";
			this.cboFreqType.Size = new System.Drawing.Size(128, 21);
			this.cboFreqType.TabIndex = 22;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(16, 32);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(288, 16);
			this.Label6.TabIndex = 22;
			this.Label6.Text = "Query ID (add a user query in order to use this sample)";
			//
			//UserAlertForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 351);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.cboPriority);
			this.Controls.Add(this.chkActive);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.txtQuery);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmdAddAlert);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserAlertForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alert Management";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		
		AlertManagementService oAlertTemplatesService;
		private void ApprovalTemplateForm_Load (System.Object sender, System.EventArgs e)
		{
			
			InitService();
			
			InitCtrls();
			
		}
		
		private void InitCtrls ()
		{
			
			cboPriority.SelectedIndex = 1;
			
			cboFreqType.SelectedIndex = 1;
			
		}
		
		private void AddAlert ()
		{
			
			try
			{
				
				AlertManagement oAlertTemplate;
				AlertManagementParams oAlertTemplateParams;
				AlertManagementRecipients oAlertTemplateRecipients;
				AlertManagementRecipient oAlertRecipient;
				
				
				//get alert template
				oAlertTemplate = (SAPbobsCOM.AlertManagement) oAlertTemplatesService.GetDataInterface(AlertManagementServiceDataInterfaces.atsdiAlertManagement);
				
				//set alert name
				oAlertTemplate.Name = txtName.Text;
				
				//set query
				oAlertTemplate.QueryID = System.Convert.ToInt32(txtQuery.Text);
				
				oAlertTemplate.Active = (SAPbobsCOM.BoYesNoEnum) (Interaction.IIf(chkActive.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO));
				
				//set priority
				oAlertTemplate.Priority = GetPriority(cboPriority.SelectedItem.ToString());
				
				//set the FrequencyType (minutes,hours...)
				oAlertTemplate.FrequencyType = GetFrequencyType(cboFreqType.SelectedItem.ToString());
				
				//set intervals
				oAlertTemplate.FrequencyInterval = System.Convert.ToInt32(txtFreqIntrvls.Text);
				
				//get Recipients collection
				oAlertTemplateRecipients = oAlertTemplate.AlertManagementRecipients;
				
				//add recipient
				oAlertRecipient = oAlertTemplateRecipients.Add();
				
				//set recipient code(manager=1)
				oAlertRecipient.UserCode = System.Convert.ToInt32(txtUserCode.Text);
				
				//set internal message
				oAlertRecipient.SendInternal = (SAPbobsCOM.BoYesNoEnum) (Interaction.IIf(chkSendInternal.Checked, BoYesNoEnum.tYES, BoYesNoEnum.tNO));
				
				//add alert template
				oAlertTemplateParams = oAlertTemplatesService.AddAlertManagement(oAlertTemplate);
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		
		//return the Frequency type
		private AlertManagementFrequencyType GetFrequencyType(string sFrequencyType)
		{
			
			try
			{
				
				switch (sFrequencyType)
				{
					case "Minutes":
						
						return (AlertManagementFrequencyType.atfi_Minutes);
//						case "Hours":
//						
//						return (AlertManagementFrequencyType.atfi_Hours);
				}
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return 0;
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
		
		private void cmdAddAlert_Click (System.Object sender, System.EventArgs e)
		{
			
			AddAlert();
			
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
		
		
	}
	
}
