using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

//  SAP DI API 2006 Sample
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
		internal System.Windows.Forms.Button cmdLogOut;
		internal System.Windows.Forms.Button cmdLogIn;
		internal System.Windows.Forms.Button cmdUpdateSystemAlrt;
		internal System.Windows.Forms.Button cmdUserAlrt;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdLogOut = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(StartupForm_Load);
			cmdLogOut.Click += new System.EventHandler(cmdLogOut_Click);
			this.cmdLogIn = new System.Windows.Forms.Button();
			cmdLogIn.Click += new System.EventHandler(cmdLogIn_Click);
			this.cmdUserAlrt = new System.Windows.Forms.Button();
			cmdUserAlrt.Click += new System.EventHandler(cmdMsg_Click);
			this.cmdUpdateSystemAlrt = new System.Windows.Forms.Button();
			cmdUpdateSystemAlrt.Click += new System.EventHandler(cmdUpdateSystemAlrt_Click);
			this.SuspendLayout();
			//
			//cmdLogOut
			//
			this.cmdLogOut.Location = new System.Drawing.Point(72, 184);
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
			//cmdUserAlrt
			//
			this.cmdUserAlrt.Location = new System.Drawing.Point(72, 72);
			this.cmdUserAlrt.Name = "cmdUserAlrt";
			this.cmdUserAlrt.Size = new System.Drawing.Size(120, 40);
			this.cmdUserAlrt.TabIndex = 0;
			this.cmdUserAlrt.Text = "Add User Alert ";
			//
			//cmdUpdateSystemAlrt
			//
			this.cmdUpdateSystemAlrt.Location = new System.Drawing.Point(72, 128);
			this.cmdUpdateSystemAlrt.Name = "cmdUpdateSystemAlrt";
			this.cmdUpdateSystemAlrt.Size = new System.Drawing.Size(120, 40);
			this.cmdUpdateSystemAlrt.TabIndex = 1;
			this.cmdUpdateSystemAlrt.Text = "Update System Alert";
			//
			//StartupForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
			this.ClientSize = new System.Drawing.Size(272, 247);
			this.Controls.Add(this.cmdUpdateSystemAlrt);
			this.Controls.Add(this.cmdLogOut);
			this.Controls.Add(this.cmdUserAlrt);
			this.Controls.Add(this.cmdLogIn);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StartupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void cmdLogIn_Click (System.Object sender, System.EventArgs e)
		{
			
			LogInForm frm = new LogInForm();
			
			//show log in dialog
			frm.ShowDialog();
			
			InitCmdButtons(true, true, true, true);
			
		}
		
		private void cmdMsg_Click (System.Object sender, System.EventArgs e)
		{
			
			UserAlertForm frm = new UserAlertForm();
			
			//show message dialog
			frm.ShowDialog();
			
		}
		
		private void StartupForm_Load (System.Object sender, System.EventArgs e)
		{
			
			InitCmdButtons(true, false, false, false);
			
		}
		
		private void InitCmdButtons (bool bLogIn, bool bUserAlrt, bool bUpdate, bool bLogOut)
		{
			
			cmdLogIn.Enabled = bLogIn;
			cmdUserAlrt.Enabled = bUserAlrt;
			cmdUpdateSystemAlrt.Enabled = bUpdate;
			cmdLogOut.Enabled = bLogOut;
			
		}
		
		private void cmdLogOut_Click (System.Object sender, System.EventArgs e)
		{
			
			this.Close();
			
		}
		
		private void cmdUpdateSystemAlrt_Click (System.Object sender, System.EventArgs e)
		{
			
			SystemAlertForm frm = new SystemAlertForm();
			
			//show message dialog
			frm.ShowDialog();
			
		}
		
	}
	
	
}
