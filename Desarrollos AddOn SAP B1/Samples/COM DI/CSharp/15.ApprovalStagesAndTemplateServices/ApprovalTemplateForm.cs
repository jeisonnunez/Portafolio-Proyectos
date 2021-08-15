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
//  File:     ApprovalTemplateForm.vb
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
// Add a new Approval Template
//
//****************************************************************************



namespace FormWindowTemplateVb
{
	public class ApprovalTemplateForm : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public ApprovalTemplateForm() {
			
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
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.CheckBox chkQuotation;
		internal System.Windows.Forms.CheckBox chkReturns;
		internal System.Windows.Forms.CheckBox chkArInvoice;
		internal System.Windows.Forms.CheckBox chkPurchase;
		internal System.Windows.Forms.CheckBox chkGoodsReturn;
		internal System.Windows.Forms.CheckBox ChkDelivery;
		internal System.Windows.Forms.CheckBox chkArCredit;
		internal System.Windows.Forms.CheckBox chkGoodsRecPo;
		internal System.Windows.Forms.CheckBox chkSalesOrder;
		internal System.Windows.Forms.CheckBox chkApInvoice;
		internal System.Windows.Forms.CheckBox chkCreditMemo;
		internal System.Windows.Forms.GroupBox gbDocuments;
		internal System.Windows.Forms.CheckBox chkIncludeTerms;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.TextBox txtUserCode;
		internal System.Windows.Forms.TextBox txtStageCode;
		internal System.Windows.Forms.TextBox txtTermValue;
		internal System.Windows.Forms.ComboBox cboConditions;
		internal System.Windows.Forms.ComboBox cboOperation;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdAdd = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(ApprovalTemplateForm_Load);
			cmdAdd.Click += new System.EventHandler(cmdAdd_Click);
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUserCode = new System.Windows.Forms.TextBox();
			this.txtStageCode = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.gbDocuments = new System.Windows.Forms.GroupBox();
			this.chkCreditMemo = new System.Windows.Forms.CheckBox();
			this.chkApInvoice = new System.Windows.Forms.CheckBox();
			this.chkSalesOrder = new System.Windows.Forms.CheckBox();
			this.chkGoodsRecPo = new System.Windows.Forms.CheckBox();
			this.chkArCredit = new System.Windows.Forms.CheckBox();
			this.ChkDelivery = new System.Windows.Forms.CheckBox();
			this.chkGoodsReturn = new System.Windows.Forms.CheckBox();
			this.chkPurchase = new System.Windows.Forms.CheckBox();
			this.chkArInvoice = new System.Windows.Forms.CheckBox();
			this.chkReturns = new System.Windows.Forms.CheckBox();
			this.chkQuotation = new System.Windows.Forms.CheckBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTermValue = new System.Windows.Forms.TextBox();
			this.cboOperation = new System.Windows.Forms.ComboBox();
			this.cboConditions = new System.Windows.Forms.ComboBox();
			this.chkIncludeTerms = new System.Windows.Forms.CheckBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.gbDocuments.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdAdd
			//
			this.cmdAdd.Location = new System.Drawing.Point(344, 424);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(104, 24);
			this.cmdAdd.TabIndex = 0;
			this.cmdAdd.Text = "Add";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(144, 16);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(144, 20);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "My Template";
			//
			//txtUserCode
			//
			this.txtUserCode.Location = new System.Drawing.Point(144, 48);
			this.txtUserCode.Name = "txtUserCode";
			this.txtUserCode.Size = new System.Drawing.Size(144, 20);
			this.txtUserCode.TabIndex = 2;
			this.txtUserCode.Text = "2";
			//
			//txtStageCode
			//
			this.txtStageCode.Location = new System.Drawing.Point(152, 216);
			this.txtStageCode.Name = "txtStageCode";
			this.txtStageCode.Size = new System.Drawing.Size(144, 20);
			this.txtStageCode.TabIndex = 5;
			this.txtStageCode.Text = "1";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 15);
			this.Label1.Name = "Label1";
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Template Name";
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(24, 216);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(120, 23);
			this.Label9.TabIndex = 13;
			this.Label9.Text = "Approval Stage Code";
			//
			//Label10
			//
			this.Label10.Location = new System.Drawing.Point(16, 47);
			this.Label10.Name = "Label10";
			this.Label10.TabIndex = 10;
			this.Label10.Text = "User Code";
			//
			//gbDocuments
			//
			this.gbDocuments.Controls.Add(this.chkCreditMemo);
			this.gbDocuments.Controls.Add(this.chkApInvoice);
			this.gbDocuments.Controls.Add(this.chkSalesOrder);
			this.gbDocuments.Controls.Add(this.chkGoodsRecPo);
			this.gbDocuments.Controls.Add(this.chkArCredit);
			this.gbDocuments.Controls.Add(this.ChkDelivery);
			this.gbDocuments.Controls.Add(this.chkGoodsReturn);
			this.gbDocuments.Controls.Add(this.chkPurchase);
			this.gbDocuments.Controls.Add(this.chkArInvoice);
			this.gbDocuments.Controls.Add(this.chkReturns);
			this.gbDocuments.Controls.Add(this.chkQuotation);
			this.gbDocuments.Location = new System.Drawing.Point(8, 88);
			this.gbDocuments.Name = "gbDocuments";
			this.gbDocuments.Size = new System.Drawing.Size(440, 120);
			this.gbDocuments.TabIndex = 17;
			this.gbDocuments.TabStop = false;
			this.gbDocuments.Text = "Documents";
			//
			//chkCreditMemo
			//
			this.chkCreditMemo.Location = new System.Drawing.Point(328, 56);
			this.chkCreditMemo.Name = "chkCreditMemo";
			this.chkCreditMemo.Size = new System.Drawing.Size(96, 16);
			this.chkCreditMemo.TabIndex = 12;
			this.chkCreditMemo.Text = "A/P Credit Memo";
			//
			//chkApInvoice
			//
			this.chkApInvoice.Checked = true;
			this.chkApInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkApInvoice.Location = new System.Drawing.Point(328, 32);
			this.chkApInvoice.Name = "chkApInvoice";
			this.chkApInvoice.Size = new System.Drawing.Size(88, 16);
			this.chkApInvoice.TabIndex = 11;
			this.chkApInvoice.Text = "A/P Invoice";
			//
			//chkSalesOrder
			//
			this.chkSalesOrder.Location = new System.Drawing.Point(8, 56);
			this.chkSalesOrder.Name = "chkSalesOrder";
			this.chkSalesOrder.Size = new System.Drawing.Size(96, 16);
			this.chkSalesOrder.TabIndex = 10;
			this.chkSalesOrder.Text = "Sales Order";
			//
			//chkGoodsRecPo
			//
			this.chkGoodsRecPo.Location = new System.Drawing.Point(208, 56);
			this.chkGoodsRecPo.Name = "chkGoodsRecPo";
			this.chkGoodsRecPo.Size = new System.Drawing.Size(120, 16);
			this.chkGoodsRecPo.TabIndex = 8;
			this.chkGoodsRecPo.Text = "Goods Receipt PO";
			//
			//chkArCredit
			//
			this.chkArCredit.Location = new System.Drawing.Point(112, 80);
			this.chkArCredit.Name = "chkArCredit";
			this.chkArCredit.Size = new System.Drawing.Size(80, 16);
			this.chkArCredit.TabIndex = 7;
			this.chkArCredit.Text = "A/R Credit Memo";
			//
			//ChkDelivery
			//
			this.ChkDelivery.Location = new System.Drawing.Point(8, 80);
			this.ChkDelivery.Name = "ChkDelivery";
			this.ChkDelivery.Size = new System.Drawing.Size(72, 16);
			this.ChkDelivery.TabIndex = 6;
			this.ChkDelivery.Text = "Delivery";
			//
			//chkGoodsReturn
			//
			this.chkGoodsReturn.Location = new System.Drawing.Point(208, 80);
			this.chkGoodsReturn.Name = "chkGoodsReturn";
			this.chkGoodsReturn.Size = new System.Drawing.Size(96, 16);
			this.chkGoodsReturn.TabIndex = 5;
			this.chkGoodsReturn.Text = "Goods Returns";
			//
			//chkPurchase
			//
			this.chkPurchase.Checked = true;
			this.chkPurchase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPurchase.Location = new System.Drawing.Point(208, 32);
			this.chkPurchase.Name = "chkPurchase";
			this.chkPurchase.Size = new System.Drawing.Size(72, 16);
			this.chkPurchase.TabIndex = 4;
			this.chkPurchase.Text = "Purchase Order";
			//
			//chkArInvoice
			//
			this.chkArInvoice.Location = new System.Drawing.Point(112, 56);
			this.chkArInvoice.Name = "chkArInvoice";
			this.chkArInvoice.Size = new System.Drawing.Size(88, 16);
			this.chkArInvoice.TabIndex = 3;
			this.chkArInvoice.Text = "A/R Invoice";
			//
			//chkReturns
			//
			this.chkReturns.Checked = true;
			this.chkReturns.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkReturns.Location = new System.Drawing.Point(112, 32);
			this.chkReturns.Name = "chkReturns";
			this.chkReturns.Size = new System.Drawing.Size(72, 16);
			this.chkReturns.TabIndex = 1;
			this.chkReturns.Text = "Returns";
			//
			//chkQuotation
			//
			this.chkQuotation.Checked = true;
			this.chkQuotation.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkQuotation.Location = new System.Drawing.Point(8, 32);
			this.chkQuotation.Name = "chkQuotation";
			this.chkQuotation.Size = new System.Drawing.Size(104, 16);
			this.chkQuotation.TabIndex = 0;
			this.chkQuotation.Text = "Sales Quotation";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.txtTermValue);
			this.GroupBox2.Controls.Add(this.cboOperation);
			this.GroupBox2.Controls.Add(this.cboConditions);
			this.GroupBox2.Controls.Add(this.chkIncludeTerms);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.Label11);
			this.GroupBox2.Controls.Add(this.Label14);
			this.GroupBox2.Location = new System.Drawing.Point(16, 248);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(432, 160);
			this.GroupBox2.TabIndex = 19;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Approval Template Terms";
			//
			//txtTermValue
			//
			this.txtTermValue.Location = new System.Drawing.Point(136, 128);
			this.txtTermValue.Name = "txtTermValue";
			this.txtTermValue.Size = new System.Drawing.Size(144, 20);
			this.txtTermValue.TabIndex = 26;
			this.txtTermValue.Text = "30";
			//
			//cboOperation
			//
			this.cboOperation.Items.AddRange(new object[] { "Greater than", "Greateror Equal", "Less than", "Less or Equel", "Equel", "Does not Equel", "In Range", "Not in Range" });
			this.cboOperation.Location = new System.Drawing.Point(136, 96);
			this.cboOperation.Name = "cboOperation";
			this.cboOperation.Size = new System.Drawing.Size(144, 21);
			this.cboOperation.TabIndex = 25;
			//
			//cboConditions
			//
			this.cboConditions.Items.AddRange(new object[] { "Deviation from Credit Limit", "Deviation from Commitment", "Gross Profit %", "Discount %", "Deviation from Budget", "Total Document" });
			this.cboConditions.Location = new System.Drawing.Point(136, 64);
			this.cboConditions.Name = "cboConditions";
			this.cboConditions.Size = new System.Drawing.Size(144, 21);
			this.cboConditions.TabIndex = 24;
			//
			//chkIncludeTerms
			//
			this.chkIncludeTerms.Checked = true;
			this.chkIncludeTerms.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIncludeTerms.Location = new System.Drawing.Point(8, 24);
			this.chkIncludeTerms.Name = "chkIncludeTerms";
			this.chkIncludeTerms.Size = new System.Drawing.Size(128, 16);
			this.chkIncludeTerms.TabIndex = 23;
			this.chkIncludeTerms.Text = "Include Terms";
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(8, 64);
			this.Label6.Name = "Label6";
			this.Label6.TabIndex = 20;
			this.Label6.Text = "Condition Type";
			//
			//Label11
			//
			this.Label11.Location = new System.Drawing.Point(8, 128);
			this.Label11.Name = "Label11";
			this.Label11.TabIndex = 22;
			this.Label11.Text = "Value";
			//
			//Label14
			//
			this.Label14.Location = new System.Drawing.Point(8, 96);
			this.Label14.Name = "Label14";
			this.Label14.TabIndex = 21;
			this.Label14.Text = "OperationType";
			//
			//ApprovalTemplateForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 455);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.gbDocuments);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtStageCode);
			this.Controls.Add(this.txtUserCode);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmdAdd);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label10);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ApprovalTemplateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Approval Template ";
			this.gbDocuments.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		ApprovalTemplatesService oApprovalTemplateService;
		
		private void ApprovalTemplateForm_Load (System.Object sender, System.EventArgs e)
		{
			try
			{
				
				InitService();
				
				InitCtrls();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
		}
		
		//init combo
		private void InitCtrls ()
		{
			try
			{
				
				//default condition
				cboConditions.SelectedIndex = 3;
				
				//default operation
				cboOperation.SelectedIndex = 0;
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		//add checked documents
		private void AddCheckedDocumnets (ApprovalTemplate oApprovalTemplate)
		{
			
			try
			{
				Control oControl;
				CheckBox oCheckBox;
				
				foreach (Control tempLoopVar_oControl in gbDocuments.Controls)
				{
					oControl = tempLoopVar_oControl;
					
					if (Information.TypeName(oControl) == "CheckBox")
					{
						
						oCheckBox = (System.Windows.Forms.CheckBox) oControl;
						
						if (oCheckBox.Checked == true)
						{
							AddDocumnetTypeToTemplate(oCheckBox.Text, oApprovalTemplate);
						}
						
					}
					
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		
		// add document type to Template
		private ApprovalTemplatesDocumentTypeEnum AddDocumnetTypeToTemplate(string sDocument, ApprovalTemplate oApprovalTemplate)
		{
			
			try
			{
				
				switch (sDocument)
				{
					case "Sales Quotation":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtQuotation;
						break;
						
					case "Sales Order":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtOrder;
						break;
						
					case "Delivery":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtDelivery;
						break;
						
					case "Returns":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtReturns;
						break;
						
					case "A/R Invoice":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtArInvoice;
						break;
						
					case "A/R Credit Memo":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtArCreditMemo;
						break;
						
					case "Purchase Order":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtPurchaseOrder;
						break;
						
					case "Goods Receipt PO":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtGoodsReceiptPO;
						break;
						
					case "Goods Returns":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtGoodsReturns;
						break;
						
					case "A/P Invoice":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtApInvoice;
						break;
						
					case "A/P Credit Memo":
						
						
						oApprovalTemplate.ApprovalTemplateDocuments.Add().DocumentType = ApprovalTemplatesDocumentTypeEnum.atdtApCreditMemo;
						break;
						
				}
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return 0;
		}
		
		//return the Condition type
		private ApprovalTemplateConditionTypeEnum GetCondition(string sCondition)
		{
			
			try
			{
				
				switch (sCondition)
				{
					case "Deviation from Credit Limit":
						
						
						return (ApprovalTemplateConditionTypeEnum.atctDeviationFromCreditLine);
						
//						case "Deviation from Commitment":
//						
						
//						return (ApprovalTemplateConditionTypeEnum.atctDeviationFromObligo);
						
//						case "Gross Profit %":
//						
						
//						return (ApprovalTemplateConditionTypeEnum.atctGrossProfitPercent);
						
//						case "Discount %":
//						
						
//						return (ApprovalTemplateConditionTypeEnum.atctDiscountPercent);
						
//						case "Deviation from Budget":
//						
						
//						return (ApprovalTemplateConditionTypeEnum.atctDeviationFromBudget);
						
//						case "Total Document":
//						
						
//						return (ApprovalTemplateConditionTypeEnum.atctTotalDocument);
						
				}
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return 0;
		}
		
		//return the Operation type
		private ApprovalTemplateOperationTypeEnum GetOperation(string sOperation)
		{
			
			
			try
			{
				
				switch (sOperation)
				{
					case "Greater than":
						
						
						return (ApprovalTemplateOperationTypeEnum.opcodeGreaterThan);
						
//						case "Greater or Equal":
//						
						
//						return (ApprovalTemplateOperationTypeEnum.opcodeGreaterOrEqual);
						
//						case "Less than":
//						
						
//						return (ApprovalTemplateOperationTypeEnum.opcodeLessThan);
						
//						case "Less or Equel":
//						
						
//						return (ApprovalTemplateOperationTypeEnum.opcodeLessOrEqual);
						
//						case "Equel":
//						
						
//						return (ApprovalTemplateOperationTypeEnum.opcodeEqual);
						
//						case "Does not Equel":
//						
						
//						return (ApprovalTemplateOperationTypeEnum.opcodeDoesNotEqual);
						
//						case "In Range":
//						
						
//						return (ApprovalTemplateOperationTypeEnum.opcodeInRange);
						
//						case "Not in Range":
//						
						
//						return (ApprovalTemplateOperationTypeEnum.opcodeNotInRange);
						
				}
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return 0;
		}
		//initialize the services
		private void InitService ()
		{
			
			try
			{
				MainModule.initCompanyService();
				
				//get Approval Stages Service
				oApprovalTemplateService = (SAPbobsCOM.ApprovalTemplatesService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.ApprovalTemplatesService);
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		
		private void cmdAdd_Click (System.Object sender, System.EventArgs e)
		{
			
			ApprovalTemplateStage oApprovalTemplateStage;
			ApprovalTemplate oApprovalTemplate;
			ApprovalTemplateParams oApprovalTemplateParams;
			ApprovalTemplateTerm oApprovalTemplateTerm;
			
			
			try
			{
				
				//get new Approval Stage
				oApprovalTemplate = (SAPbobsCOM.ApprovalTemplate) oApprovalTemplateService.GetDataInterface(ApprovalTemplatesServiceDataInterfaces.atsdiApprovalTemplate);
				
				//set the name of the Approval Template
				oApprovalTemplate.Name = txtName.Text;
				
				//add the user that need the approval(userId=3 is "Fred")
				oApprovalTemplate.ApprovalTemplateUsers.Add().UserID = System.Convert.ToInt32(txtUserCode.Text);
				
				//Add the checked documnets
				AddCheckedDocumnets(oApprovalTemplate);
				
				//get Approval Stages
				oApprovalTemplateStage = oApprovalTemplate.ApprovalTemplateStages.Add();
				
				//set the code of an existing stage(e.g code=1 the stage name is Accounting)
				oApprovalTemplateStage.ApprovalStageCode = System.Convert.ToInt32(txtStageCode.Text);
				
				//include terms in the template
				oApprovalTemplate.UseTerms = (SAPbobsCOM.BoYesNoEnum) (Interaction.IIf(chkIncludeTerms.Checked == true, BoYesNoEnum.tYES, BoYesNoEnum.tNO));
				
				//add new term
				oApprovalTemplateTerm = oApprovalTemplate.ApprovalTemplateTerms.Add();
				
				//set the condition
				oApprovalTemplateTerm.ConditionType = GetCondition(cboConditions.SelectedItem.ToString());
				
				//set the Operation Type
				oApprovalTemplateTerm.OperationType = GetOperation(cboOperation.SelectedItem.ToString());
				
				//set the value
				oApprovalTemplateTerm.Value = txtTermValue.Text;
				
				//add Approval Template
				oApprovalTemplateParams = oApprovalTemplateService.AddApprovalTemplate(oApprovalTemplate);
				
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
		}
		
	}
	
}
