using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

//  SAP DI API 2006 SDK Sample
//****************************************************************************
//
//  File:      StartupForm.vb
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
// main menu
//
//****************************************************************************


namespace FormWindowTemplateVb
{
	public class StartupForm : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public StartupForm() {
			
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
		internal System.Windows.Forms.Button cmdSeries;
		internal System.Windows.Forms.Button cmdLogOut;
		internal System.Windows.Forms.Button cmdLogIn;
		internal System.Windows.Forms.Button cmdAccount;
		internal System.Windows.Forms.Button cmdBp;
		internal System.Windows.Forms.Button cmdCompany;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdSeries = new System.Windows.Forms.Button();
			cmdSeries.Click += new System.EventHandler(cmdSeries_Click);
			base.Load += new System.EventHandler(StartupForm_Load);
			this.cmdLogOut = new System.Windows.Forms.Button();
			cmdLogOut.Click += new System.EventHandler(cmdLogOut_Click);
			this.cmdLogIn = new System.Windows.Forms.Button();
			cmdLogIn.Click += new System.EventHandler(cmdLogIn_Click);
			this.cmdAccount = new System.Windows.Forms.Button();
			cmdAccount.Click += new System.EventHandler(cmdAccount_Click);
			this.cmdBp = new System.Windows.Forms.Button();
			cmdBp.Click += new System.EventHandler(cmdBp_Click);
			this.cmdCompany = new System.Windows.Forms.Button();
			cmdCompany.Click += new System.EventHandler(cmdCompany_Click);
			this.SuspendLayout();
			//
			//cmdSeries
			//
			this.cmdSeries.Location = new System.Drawing.Point(72, 184);
			this.cmdSeries.Name = "cmdSeries";
			this.cmdSeries.Size = new System.Drawing.Size(120, 40);
			this.cmdSeries.TabIndex = 0;
			this.cmdSeries.Text = "Series Service";
			//
			//cmdLogOut
			//
			this.cmdLogOut.Location = new System.Drawing.Point(72, 296);
			this.cmdLogOut.Name = "cmdLogOut";
			this.cmdLogOut.Size = new System.Drawing.Size(120, 40);
			this.cmdLogOut.TabIndex = 0;
			this.cmdLogOut.Text = "Exit";
			//
			//cmdLogIn
			//
			this.cmdLogIn.Location = new System.Drawing.Point(72, 16);
			this.cmdLogIn.Name = "cmdLogIn";
			this.cmdLogIn.Size = new System.Drawing.Size(120, 40);
			this.cmdLogIn.TabIndex = 0;
			this.cmdLogIn.Text = "Log In Company";
			//
			//cmdAccount
			//
			this.cmdAccount.Location = new System.Drawing.Point(72, 72);
			this.cmdAccount.Name = "cmdAccount";
			this.cmdAccount.Size = new System.Drawing.Size(120, 40);
			this.cmdAccount.TabIndex = 0;
			this.cmdAccount.Text = "Account Service";
			//
			//cmdBp
			//
			this.cmdBp.Location = new System.Drawing.Point(72, 128);
			this.cmdBp.Name = "cmdBp";
			this.cmdBp.Size = new System.Drawing.Size(120, 40);
			this.cmdBp.TabIndex = 0;
			this.cmdBp.Text = "Bp Service";
			//
			//cmdCompany
			//
			this.cmdCompany.Location = new System.Drawing.Point(72, 240);
			this.cmdCompany.Name = "cmdCompany";
			this.cmdCompany.Size = new System.Drawing.Size(120, 40);
			this.cmdCompany.TabIndex = 1;
			this.cmdCompany.Text = "Company Service";
			//
			//StartupForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
			this.ClientSize = new System.Drawing.Size(264, 357);
			this.Controls.Add(this.cmdCompany);
			this.Controls.Add(this.cmdLogOut);
			this.Controls.Add(this.cmdSeries);
			this.Controls.Add(this.cmdBp);
			this.Controls.Add(this.cmdAccount);
			this.Controls.Add(this.cmdLogIn);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Name = "StartupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Basic Company Setting";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		
		private void cmdLogIn_Click (System.Object sender, System.EventArgs e)
		{
			LogInForm frm = new LogInForm();
			frm.ShowDialog();
		}
		
		private void cmdAccount_Click (System.Object sender, System.EventArgs e)
		{
			AccountServiceForm frm = new AccountServiceForm();
			frm.Show();
		}
		
		private void cmdBp_Click (System.Object sender, System.EventArgs e)
		{
			BpSeviceForm frm = new BpSeviceForm();
			frm.Show();
		}
		
		private void cmdSeries_Click (System.Object sender, System.EventArgs e)
		{
			SeriesServiceForm frm = new SeriesServiceForm();
			frm.Show();
		}
		
		private void cmdCompany_Click (System.Object sender, System.EventArgs e)
		{
			CompanyServiceForm frm = new CompanyServiceForm();
			frm.Show();
		}
		
		private void cmdLogOut_Click (System.Object sender, System.EventArgs e)
		{
			
			//oCompany.Disconnect()
			this.Close();
			
		}
		
		private void StartupForm_Load (System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
