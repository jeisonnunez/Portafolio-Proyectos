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
//  File:      StartupForm.cs
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
		private System.ComponentModel.Container components;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.Button cmdMsg;
		internal System.Windows.Forms.Button cmdLogOut;
		internal System.Windows.Forms.Button cmdLogIn;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdLogOut = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(StartupForm_Load);
			cmdLogOut.Click += new System.EventHandler(cmdLogOut_Click);
			this.cmdLogIn = new System.Windows.Forms.Button();
			cmdLogIn.Click += new System.EventHandler(cmdLogIn_Click);
			this.cmdMsg = new System.Windows.Forms.Button();
			cmdMsg.Click += new System.EventHandler(cmdMsg_Click);
			this.SuspendLayout();
			//
			//cmdLogOut
			//
			this.cmdLogOut.Location = new System.Drawing.Point(72, 128);
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
			//cmdMsg
			//
			this.cmdMsg.Location = new System.Drawing.Point(72, 72);
			this.cmdMsg.Name = "cmdMsg";
			this.cmdMsg.Size = new System.Drawing.Size(120, 40);
			this.cmdMsg.TabIndex = 0;
			this.cmdMsg.Text = "Message";
			//
			//StartupForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
			this.ClientSize = new System.Drawing.Size(272, 197);
			this.Controls.Add(this.cmdLogOut);
			this.Controls.Add(this.cmdMsg);
			this.Controls.Add(this.cmdLogIn);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
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
			
			InitCmdButtons(true, true, true);
		}
		
		private void cmdMsg_Click (System.Object sender, System.EventArgs e)
		{
			MessageForm frm = new MessageForm();
			
			//show message dialog
			frm.ShowDialog();
		}
		
		private void StartupForm_Load (System.Object sender, System.EventArgs e)
		{
			InitCmdButtons(true, false, false);
		}
		
		private void InitCmdButtons (bool bLogIn, bool bMsg, bool bLogOut)
		{
			cmdLogIn.Enabled = bLogIn;
			cmdMsg.Enabled = bMsg;
			cmdLogOut.Enabled = bLogOut;
		}
		
		private void cmdLogOut_Click (System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
