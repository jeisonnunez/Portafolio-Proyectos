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
//  File:      SeriesServiceForm.vb
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
// 1) Get the series of a document
// 2) Add Series
//****************************************************************************


namespace FormWindowTemplateVb
{
	public class SeriesServiceForm : System.Windows.Forms.Form
	{
		
		
		
		SAPbobsCOM.SeriesService oSeriesService;
		
		#region " Windows Form Designer generated code "
		
		public SeriesServiceForm() {
			
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
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button cmdGetSeries;
		internal System.Windows.Forms.TextBox txtDocType;
		internal System.Windows.Forms.Button cmdAddSeries;
		internal System.Windows.Forms.ColumnHeader First;
		internal System.Windows.Forms.ColumnHeader Next1;
		internal System.Windows.Forms.ColumnHeader Group;
		internal System.Windows.Forms.ColumnHeader PeriodInd;
		internal System.Windows.Forms.ListView lsvSeriesDoc;
		internal System.Windows.Forms.ColumnHeader Document;
		internal System.Windows.Forms.ColumnHeader Last;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdGetSeries = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(SeriesServiceForm_Load);
			cmdGetSeries.Click += new System.EventHandler(cmdGetSeries_Click);
			this.txtDocType = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmdAddSeries = new System.Windows.Forms.Button();
			cmdAddSeries.Click += new System.EventHandler(cmdAddSeries_Click);
			this.lsvSeriesDoc = new System.Windows.Forms.ListView();
			this.Document = new System.Windows.Forms.ColumnHeader();
			this.First = new System.Windows.Forms.ColumnHeader();
			this.Next1 = new System.Windows.Forms.ColumnHeader();
			this.Last = new System.Windows.Forms.ColumnHeader();
			this.Group = new System.Windows.Forms.ColumnHeader();
			this.PeriodInd = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			//
			//cmdGetSeries
			//
			this.cmdGetSeries.Location = new System.Drawing.Point(272, 24);
			this.cmdGetSeries.Name = "cmdGetSeries";
			this.cmdGetSeries.Size = new System.Drawing.Size(120, 24);
			this.cmdGetSeries.TabIndex = 0;
			this.cmdGetSeries.Text = "Get Document Series";
			//
			//txtDocType
			//
			this.txtDocType.Location = new System.Drawing.Point(136, 24);
			this.txtDocType.Name = "txtDocType";
			this.txtDocType.Size = new System.Drawing.Size(120, 20);
			this.txtDocType.TabIndex = 1;
			this.txtDocType.Text = "13";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(8, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 32);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Document Type      (e.g. SalesInvoice=13)";
			//
			//cmdAddSeries
			//
			this.cmdAddSeries.Location = new System.Drawing.Point(272, 208);
			this.cmdAddSeries.Name = "cmdAddSeries";
			this.cmdAddSeries.Size = new System.Drawing.Size(120, 24);
			this.cmdAddSeries.TabIndex = 4;
			this.cmdAddSeries.Text = "Add Series";
			//
			//lsvSeriesDoc
			//
			this.lsvSeriesDoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.Document, this.First, this.Next1, this.Last, this.Group, this.PeriodInd });
			this.lsvSeriesDoc.FullRowSelect = true;
			this.lsvSeriesDoc.GridLines = true;
			this.lsvSeriesDoc.Location = new System.Drawing.Point(16, 72);
			this.lsvSeriesDoc.Name = "lsvSeriesDoc";
			this.lsvSeriesDoc.Size = new System.Drawing.Size(376, 120);
			this.lsvSeriesDoc.TabIndex = 5;
			this.lsvSeriesDoc.View = System.Windows.Forms.View.Details;
			//
			//Document
			//
			this.Document.Text = "Document Type";
			this.Document.Width = 89;
			//
			//First
			//
			this.First.Text = "First";
			this.First.Width = 48;
			//
			//Next1
			//
			this.Next1.Text = "Next";
			this.Next1.Width = 47;
			//
			//Last
			//
			this.Last.Text = "Last";
			this.Last.Width = 46;
			//
			//Group
			//
			this.Group.Text = "Group";
			this.Group.Width = 47;
			//
			//PeriodInd
			//
			this.PeriodInd.Text = "Period Ind";
			this.PeriodInd.Width = 92;
			//
			//SeriesServiceForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 245);
			this.Controls.Add(this.lsvSeriesDoc);
			this.Controls.Add(this.cmdAddSeries);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtDocType);
			this.Controls.Add(this.cmdGetSeries);
			this.Name = "SeriesServiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Series Service";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void SeriesServiceForm_Load (System.Object sender, System.EventArgs e)
		{
			
			InitService();
			
		}
		
		//the function gets the list of series of the current document
		private void cmdGetSeries_Click (System.Object sender, System.EventArgs e)
		{
			
			SeriesCollection oSeriesCollection;
			//			Series oSeries;
			DocumentTypeParams oDocumentTypeParams;
			int i;
			
			//clear list view
			lsvSeriesDoc.Items.Clear();
			
			try
			{
				
				//get company service
				MainModule.oCmpSrv = MainModule.oCompany.GetCompanyService();
				
				//get series service
				oSeriesService = (SAPbobsCOM.SeriesService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.SeriesService);
				
				//get series collection
				oSeriesCollection = (SAPbobsCOM.SeriesCollection) oSeriesService.GetDataInterface(SeriesServiceDataInterfaces.ssdiSeriesCollection);
				
				//get Document Type Params
				oDocumentTypeParams = (SAPbobsCOM.DocumentTypeParams) oSeriesService.GetDataInterface(SeriesServiceDataInterfaces.ssdiDocumentTypeParams);
				
				//set the document type
				//(e.g. SaleInvoice=13 , BoObjectTypes has all document types)
				oDocumentTypeParams.Document = txtDocType.Text;
				
				//get series collection
				oSeriesCollection = oSeriesService.GetDocumentSeries(oDocumentTypeParams);
				
				for (i = 0; i <= oSeriesCollection.Count - 1; i++)
				{
					
					ListViewItem pItem = lsvSeriesDoc.Items.Add(oSeriesCollection.Item(i).Document);
					
					//add document type
					pItem.SubItems.Add(oSeriesCollection.Item(i).Name);
					//add first series number
					pItem.SubItems.Add(oSeriesCollection.Item(i).InitialNumber.ToString());
					//add next number
					pItem.SubItems.Add(oSeriesCollection.Item(i).NextNumber.ToString());
					//add last number
					pItem.SubItems.Add(oSeriesCollection.Item(i).LastNumber.ToString());
					//add period indicator
					pItem.SubItems.Add(oSeriesCollection.Item(i).PeriodIndicator);
					
				}
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
		
		//initiate the series service
		private void InitService ()
		{
			
			MainModule.oCmpSrv = MainModule.oCompany.GetCompanyService();
			
			//get series service
			
			oSeriesService = (SAPbobsCOM.SeriesService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.SeriesService);
			
		}
		
		private void cmdAddSeries_Click (System.Object sender, System.EventArgs e)
		{
			
			AddSeriesForm frm = new AddSeriesForm();
			
			frm.ShowDialog();
			
		}
		
	}
	
	
}
