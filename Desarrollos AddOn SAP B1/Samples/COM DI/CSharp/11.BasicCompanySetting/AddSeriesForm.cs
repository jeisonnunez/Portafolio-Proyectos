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
//  File:      AddSeriesForm.vb
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
// Creates new series to a specific document
//
//****************************************************************************


namespace FormWindowTemplateVb
{
	public class AddSeriesForm : System.Windows.Forms.Form
	{
		
		
		SAPbobsCOM.SeriesService oSeriesService;
		
		#region " Windows Form Designer generated code "
		
		public AddSeriesForm() {
			
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
		internal System.Windows.Forms.Button cmdAddSeries;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtSeriesName;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtGroupCode;
		internal System.Windows.Forms.TextBox txtInitialNumber;
		internal System.Windows.Forms.Label lblLastNumber;
		internal System.Windows.Forms.TextBox txtLastNumber;
		internal System.Windows.Forms.TextBox txtDocumentType;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtPeriod;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdAddSeries = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(AddSeries_Load);
			cmdAddSeries.Click += new System.EventHandler(cmdAddSeries_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtGroupCode = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtPeriod = new System.Windows.Forms.TextBox();
			this.txtSeriesName = new System.Windows.Forms.TextBox();
			this.txtInitialNumber = new System.Windows.Forms.TextBox();
			this.lblLastNumber = new System.Windows.Forms.Label();
			this.txtLastNumber = new System.Windows.Forms.TextBox();
			this.txtDocumentType = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdAddSeries
			//
			this.cmdAddSeries.Location = new System.Drawing.Point(240, 256);
			this.cmdAddSeries.Name = "cmdAddSeries";
			this.cmdAddSeries.Size = new System.Drawing.Size(88, 24);
			this.cmdAddSeries.TabIndex = 0;
			this.cmdAddSeries.Text = "Add Series";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.txtDocumentType);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.lblLastNumber);
			this.GroupBox1.Controls.Add(this.txtLastNumber);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtGroupCode);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtPeriod);
			this.GroupBox1.Controls.Add(this.txtSeriesName);
			this.GroupBox1.Controls.Add(this.txtInitialNumber);
			this.GroupBox1.Location = new System.Drawing.Point(16, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(312, 224);
			this.GroupBox1.TabIndex = 4;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Document Series";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(16, 160);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(88, 16);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "Initial Number";
			//
			//txtGroupCode
			//
			this.txtGroupCode.Location = new System.Drawing.Point(112, 128);
			this.txtGroupCode.Name = "txtGroupCode";
			this.txtGroupCode.Size = new System.Drawing.Size(96, 20);
			this.txtGroupCode.TabIndex = 11;
			this.txtGroupCode.Text = "1";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(16, 128);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(88, 16);
			this.Label5.TabIndex = 10;
			this.Label5.Text = "Group Code";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 66);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(88, 16);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Series Name";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(16, 96);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(88, 16);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Period Indicator";
			//
			//txtPeriod
			//
			this.txtPeriod.Location = new System.Drawing.Point(112, 96);
			this.txtPeriod.Name = "txtPeriod";
			this.txtPeriod.Size = new System.Drawing.Size(96, 20);
			this.txtPeriod.TabIndex = 1;
			this.txtPeriod.Text = "Default";
			//
			//txtSeriesName
			//
			this.txtSeriesName.Location = new System.Drawing.Point(112, 64);
			this.txtSeriesName.Name = "txtSeriesName";
			this.txtSeriesName.Size = new System.Drawing.Size(96, 20);
			this.txtSeriesName.TabIndex = 0;
			this.txtSeriesName.Text = "Series1";
			//
			//txtInitialNumber
			//
			this.txtInitialNumber.Location = new System.Drawing.Point(112, 160);
			this.txtInitialNumber.Name = "txtInitialNumber";
			this.txtInitialNumber.Size = new System.Drawing.Size(96, 20);
			this.txtInitialNumber.TabIndex = 13;
			this.txtInitialNumber.Text = "300";
			//
			//lblLastNumber
			//
			this.lblLastNumber.Location = new System.Drawing.Point(16, 192);
			this.lblLastNumber.Name = "lblLastNumber";
			this.lblLastNumber.Size = new System.Drawing.Size(88, 16);
			this.lblLastNumber.TabIndex = 14;
			this.lblLastNumber.Text = "Last Number";
			//
			//txtLastNumber
			//
			this.txtLastNumber.Location = new System.Drawing.Point(112, 192);
			this.txtLastNumber.Name = "txtLastNumber";
			this.txtLastNumber.Size = new System.Drawing.Size(96, 20);
			this.txtLastNumber.TabIndex = 15;
			this.txtLastNumber.Text = "350";
			//
			//txtDocumentType
			//
			this.txtDocumentType.Location = new System.Drawing.Point(112, 32);
			this.txtDocumentType.Name = "txtDocumentType";
			this.txtDocumentType.Size = new System.Drawing.Size(96, 20);
			this.txtDocumentType.TabIndex = 17;
			this.txtDocumentType.Text = "15 ";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 34);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 16);
			this.Label2.TabIndex = 16;
			this.Label2.Text = "Documnet Type";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(216, 32);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(80, 32);
			this.Label6.TabIndex = 18;
			this.Label6.Text = "(e.g.  Deliveries=15)";
			//
			//AddSeriesForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 293);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.cmdAddSeries);
			this.Name = "AddSeriesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Series";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void AddSeries_Load (System.Object sender, System.EventArgs e)
		{
			
			//initiate series service
			InitService();
			
		}
		
		
		private void InitService ()
		{
			
			MainModule.oCmpSrv = MainModule.oCompany.GetCompanyService();
			
			//get series service
			oSeriesService = (SAPbobsCOM.SeriesService) MainModule.oCmpSrv.GetBusinessService(ServiceTypes.SeriesService);
			
		}
		
		//the function gets a new series , set its properties ( name,document...)
		//and add it to the chosen document
		//before adding the series to the document check that the last property of the
		//last series has a value
		private void cmdAddSeries_Click (System.Object sender, System.EventArgs e)
		{
			
			Series oSeries;
			SeriesParams oSeriesParams;
			
			try
			{
				
				//get series
				oSeries = (SAPbobsCOM.Series) oSeriesService.GetDataInterface(SeriesServiceDataInterfaces.ssdiSeries);
				
				//set series name
				oSeries.Name = txtSeriesName.Text;
				
				//set doument type(e.g. Deliveries=15)
				oSeries.Document = txtDocumentType.Text;
				
				//set the period indicator
				oSeries.PeriodIndicator = txtPeriod.Text;
				
				//set the group code
				//(enum BoSeriesGroupEnum has all Group Enum)
				oSeries.GroupCode = (SAPbobsCOM.BoSeriesGroupEnum) System.Convert.ToInt32(txtGroupCode.Text);
				
				//set the first number
				oSeries.InitialNumber = System.Convert.ToInt32(txtInitialNumber.Text);
				
				//set last number
				oSeries.LastNumber = System.Convert.ToInt32(txtLastNumber.Text);
				
				//add series
				oSeriesParams = oSeriesService.AddSeries(oSeries);
				
				this.Close();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
		}
		
		
	}
	
}
