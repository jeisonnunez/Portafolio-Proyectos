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
//  File:      ReportLayoutForm.vb
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
// Add a new Report Layout based on an existing layout
//
//****************************************************************************




namespace ReportService
{
	public class ReportLayoutForm : System.Windows.Forms.Form
	{
		
		
		
		ReportLayoutsService oReportLayoutService;
		
		
		#region " Windows Form Designer generated code "
		
		public ReportLayoutForm() {
			
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
		internal System.Windows.Forms.Button cmdAddReport;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtReportRemarks;
		internal System.Windows.Forms.TextBox txtReportAuthor;
		internal System.Windows.Forms.TextBox txtReportName;
		internal System.Windows.Forms.TextBox txtDocumentCode;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox TextBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdAddReport = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(ReportLayoutForm_Load);
			cmdAddReport.Click += new System.EventHandler(cmdAddReport_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtReportRemarks = new System.Windows.Forms.TextBox();
			this.txtReportAuthor = new System.Windows.Forms.TextBox();
			this.txtReportName = new System.Windows.Forms.TextBox();
			this.txtDocumentCode = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdAddReport
			//
			this.cmdAddReport.Location = new System.Drawing.Point(304, 272);
			this.cmdAddReport.Name = "cmdAddReport";
			this.cmdAddReport.Size = new System.Drawing.Size(88, 24);
			this.cmdAddReport.TabIndex = 0;
			this.cmdAddReport.Text = "Add Report";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtReportRemarks);
			this.GroupBox1.Controls.Add(this.txtReportAuthor);
			this.GroupBox1.Controls.Add(this.txtReportName);
			this.GroupBox1.Controls.Add(this.txtDocumentCode);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(384, 240);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Report Layout Properties";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(248, 86);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(128, 24);
			this.Label5.TabIndex = 23;
			this.Label5.Text = "(e.g.   POR2=PurchaseOrder)";
			//
			//txtReportRemarks
			//
			this.txtReportRemarks.Location = new System.Drawing.Point(136, 168);
			this.txtReportRemarks.Name = "txtReportRemarks";
			this.txtReportRemarks.Size = new System.Drawing.Size(112, 20);
			this.txtReportRemarks.TabIndex = 22;
			this.txtReportRemarks.Text = "My Remarks";
			//
			//txtReportAuthor
			//
			this.txtReportAuthor.Location = new System.Drawing.Point(136, 128);
			this.txtReportAuthor.Name = "txtReportAuthor";
			this.txtReportAuthor.Size = new System.Drawing.Size(112, 20);
			this.txtReportAuthor.TabIndex = 21;
			this.txtReportAuthor.Text = "My Author";
			//
			//txtReportName
			//
			this.txtReportName.Location = new System.Drawing.Point(136, 48);
			this.txtReportName.Name = "txtReportName";
			this.txtReportName.Size = new System.Drawing.Size(112, 20);
			this.txtReportName.TabIndex = 20;
			this.txtReportName.Text = "My Report  Layout";
			//
			//txtDocumentCode
			//
			this.txtDocumentCode.Location = new System.Drawing.Point(136, 88);
			this.txtDocumentCode.Name = "txtDocumentCode";
			this.txtDocumentCode.Size = new System.Drawing.Size(112, 20);
			this.txtDocumentCode.TabIndex = 18;
			this.txtDocumentCode.Text = "POR2";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(8, 176);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(100, 16);
			this.Label4.TabIndex = 16;
			this.Label4.Text = "Report Remarks";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(8, 130);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(100, 16);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "Report Author";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(8, 50);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(100, 16);
			this.Label2.TabIndex = 12;
			this.Label2.Text = "Report Name";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(8, 90);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 16);
			this.Label1.TabIndex = 10;
			this.Label1.Text = "Document Type Code";
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(16, 128);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(100, 16);
			this.Label6.TabIndex = 15;
			this.Label6.Text = "Report Author";
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(16, 48);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(100, 16);
			this.Label7.TabIndex = 13;
			this.Label7.Text = "Report Name";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(16, 88);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(120, 16);
			this.Label8.TabIndex = 11;
			this.Label8.Text = "Document Type Code";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(144, 88);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(112, 20);
			this.TextBox1.TabIndex = 17;
			this.TextBox1.Text = "POR2";
			//
			//ReportLayoutForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 309);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.cmdAddReport);
			this.Name = "ReportLayoutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report Layout";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void ReportLayoutForm_Load (System.Object sender, System.EventArgs e)
		{
			
			InitService();
			
		}
		
		
		//init the service object
		public void InitService ()
		{
			
			
			//get company service
			MainModule.oCmpSrv = MainModule.oCompany.GetCompanyService();
			
			//get report service
			oReportLayoutService = (SAPbobsCOM.ReportLayoutsService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.ReportLayoutsService);
			
			
		}
		
		//the function adds new layout to a specific document type
		//to add a layout you must get an existing layout
		//and make the changes on this layout and than add the layout
		private void cmdAddReport_Click (System.Object sender, System.EventArgs e)
		{
			
			try
			{
				
				ReportLayout oReportLayout;
				ReportParams oReportParam;
				
				//get report layout service
				oReportLayoutService = (SAPbobsCOM.ReportLayoutsService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.ReportLayoutsService);
				
				//get report params
				oReportParam = (SAPbobsCOM.ReportParams) oReportLayoutService.GetDataInterface(ReportLayoutsServiceDataInterfaces.rlsdiReportParams);
				
				//report code is the document type code (POR2=PurchaseOrder)
				oReportParam.ReportCode = txtDocumentCode.Text;
				
				//get the default layout of the specific document
				oReportLayout = oReportLayoutService.GetDefaultReportLayout(oReportParam);
				
				//set the new layout name
				oReportLayout.Name = txtReportName.Text;
				
				//set the new author name
				oReportLayout.Author = txtReportAuthor.Text;
				
				//set the remarks
				oReportLayout.Remarks = txtReportRemarks.Text;
				
				//add the new layout to the specific document
				oReportLayoutService.AddReportLayout(oReportLayout);
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		
	}
	
}
