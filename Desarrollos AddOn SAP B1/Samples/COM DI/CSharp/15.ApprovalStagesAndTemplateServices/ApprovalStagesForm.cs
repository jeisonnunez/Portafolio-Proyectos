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
//  File:     ApprovalStagesForm.vb
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
// Add a new Approval Stage
//
//****************************************************************************


namespace FormWindowTemplateVb
{
	public class ApprovalStagesForm : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public ApprovalStagesForm() {
			
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
		internal System.Windows.Forms.TextBox txtStageName;
		internal System.Windows.Forms.TextBox txtStageDescription;
		internal System.Windows.Forms.TextBox txtNumOfReqApprovals;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label label;
		internal System.Windows.Forms.TextBox txtSecondUser;
		internal System.Windows.Forms.TextBox txtFirstUser;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdAdd = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(ApprovalStagesForm_Load);
			cmdAdd.Click += new System.EventHandler(cmdAdd_Click);
			this.txtStageName = new System.Windows.Forms.TextBox();
			this.txtStageDescription = new System.Windows.Forms.TextBox();
			this.txtNumOfReqApprovals = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.txtSecondUser = new System.Windows.Forms.TextBox();
			this.txtFirstUser = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdAdd
			//
			this.cmdAdd.Location = new System.Drawing.Point(192, 248);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(80, 24);
			this.cmdAdd.TabIndex = 0;
			this.cmdAdd.Text = "Add ";
			//
			//txtStageName
			//
			this.txtStageName.Location = new System.Drawing.Point(136, 16);
			this.txtStageName.Name = "txtStageName";
			this.txtStageName.Size = new System.Drawing.Size(120, 20);
			this.txtStageName.TabIndex = 1;
			this.txtStageName.Text = "My Approval ";
			//
			//txtStageDescription
			//
			this.txtStageDescription.Location = new System.Drawing.Point(136, 56);
			this.txtStageDescription.Name = "txtStageDescription";
			this.txtStageDescription.Size = new System.Drawing.Size(120, 20);
			this.txtStageDescription.TabIndex = 2;
			this.txtStageDescription.Text = "My Description";
			//
			//txtNumOfReqApprovals
			//
			this.txtNumOfReqApprovals.Location = new System.Drawing.Point(136, 96);
			this.txtNumOfReqApprovals.Name = "txtNumOfReqApprovals";
			this.txtNumOfReqApprovals.Size = new System.Drawing.Size(120, 20);
			this.txtNumOfReqApprovals.TabIndex = 3;
			this.txtNumOfReqApprovals.Text = "1";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Stage Name";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(24, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 16);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "Stage Description";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(24, 96);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(112, 32);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "Number Of Req Approvals";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.label);
			this.GroupBox1.Controls.Add(this.txtSecondUser);
			this.GroupBox1.Controls.Add(this.txtFirstUser);
			this.GroupBox1.Location = new System.Drawing.Point(24, 136);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(248, 96);
			this.GroupBox1.TabIndex = 12;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Approvers";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(8, 58);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(96, 16);
			this.Label5.TabIndex = 15;
			this.Label5.Text = "Second User";
			//
			//label
			//
			this.label.Location = new System.Drawing.Point(8, 26);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(96, 16);
			this.label.TabIndex = 14;
			this.label.Text = "First User";
			//
			//txtSecondUser
			//
			this.txtSecondUser.Location = new System.Drawing.Point(112, 56);
			this.txtSecondUser.Name = "txtSecondUser";
			this.txtSecondUser.Size = new System.Drawing.Size(120, 20);
			this.txtSecondUser.TabIndex = 13;
			this.txtSecondUser.Text = "2";
			//
			//txtFirstUser
			//
			this.txtFirstUser.Location = new System.Drawing.Point(112, 24);
			this.txtFirstUser.Name = "txtFirstUser";
			this.txtFirstUser.Size = new System.Drawing.Size(120, 20);
			this.txtFirstUser.TabIndex = 12;
			this.txtFirstUser.Text = "1";
			//
			//ApprovalStagesForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 287);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtNumOfReqApprovals);
			this.Controls.Add(this.txtStageDescription);
			this.Controls.Add(this.txtStageName);
			this.Controls.Add(this.cmdAdd);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ApprovalStagesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Approval Stages";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		ApprovalStagesService oApprovalStagesService;
		
		
		private void ApprovalStagesForm_Load (System.Object sender, System.EventArgs e)
		{
			
			InitService();
			
		}
		
		private void InitService ()
		{
			
			try
			{
				MainModule.initCompanyService();
				
				//get Approval Stages Service
				oApprovalStagesService = (SAPbobsCOM.ApprovalStagesService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.ApprovalStagesService);
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		
		
		private void cmdAdd_Click (System.Object sender, System.EventArgs e)
		{
			
			ApprovalStage oApprovalStage;
			ApprovalStageApprovers oApprovalStageApprovers;
			ApprovalStageApprover oFirstApprover;
			ApprovalStageApprover oSecondApprover;
			ApprovalStageParams oApprovalStageParams;
			
			
			try
			{
				
				//get new Approval Stage
				oApprovalStage = (SAPbobsCOM.ApprovalStage) oApprovalStagesService.GetDataInterface(ApprovalStagesServiceDataInterfaces.assdiApprovalStage);
				
				//set the name
				oApprovalStage.Name = txtStageName.Text;
				
				oApprovalStage.Remarks = txtStageDescription.Text;
				
				//get ApprovalStageApprovers collection
				oApprovalStageApprovers = oApprovalStage.ApprovalStageApprovers;
				
				//add new Approver
				oFirstApprover = oApprovalStageApprovers.Add();
				
				//set the approver id(manager)
				oFirstApprover.UserID = System.Convert.ToInt32(txtFirstUser.Text);
				
				//add new Approver
				oSecondApprover = oApprovalStageApprovers.Add();
				
				//set the approver id
				oSecondApprover.UserID = System.Convert.ToInt32(txtSecondUser.Text);
				
				//set the number of required approvers
				oApprovalStage.NoOfApproversRequired = System.Convert.ToInt32(txtNumOfReqApprovals.Text);
				
				//add Approval Stage
				oApprovalStageParams = oApprovalStagesService.AddApprovalStage(oApprovalStage);
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
			
		}
	}
	
}
