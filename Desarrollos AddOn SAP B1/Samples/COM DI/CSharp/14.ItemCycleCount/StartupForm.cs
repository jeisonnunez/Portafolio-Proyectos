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

namespace ItemCycleCount
{
	public class StartupForm : System.Windows.Forms.Form
	{
		
		[STAThread]
		static void Main()
		{
			Application.Run(new StartupForm());
		}
		
		#region " Windows Form Designer generated code "
		
		public StartupForm() {
			//This call is required by the Windows Form Designer.
			InitializeComponent();
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
		internal System.Windows.Forms.Button cmdItemCycle;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.cmdLogOut = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(StartupForm_Load);
			cmdLogOut.Click += new System.EventHandler(cmdLogOut_Click);
			this.cmdItemCycle = new System.Windows.Forms.Button();
			cmdItemCycle.Click += new System.EventHandler(cmdItemCycle_Click);
			this.cmdLogIn = new System.Windows.Forms.Button();
			cmdLogIn.Click += new System.EventHandler(cmdLogIn_Click);
			this.SuspendLayout();
			
			//cmdLogOut
			this.cmdLogOut.Location = new System.Drawing.Point(86, 144);
			this.cmdLogOut.Name = "cmdLogOut";
			this.cmdLogOut.Size = new System.Drawing.Size(120, 40);
			this.cmdLogOut.TabIndex = 4;
			this.cmdLogOut.Text = "Exit";
			
			//cmdItemCycle
			this.cmdItemCycle.Location = new System.Drawing.Point(86, 85);
			this.cmdItemCycle.Name = "cmdItemCycle";
			this.cmdItemCycle.Size = new System.Drawing.Size(120, 40);
			this.cmdItemCycle.TabIndex = 2;
			this.cmdItemCycle.Text = "Item Cycle Count";
			
			//cmdLogIn
			this.cmdLogIn.Location = new System.Drawing.Point(86, 29);
			this.cmdLogIn.Name = "cmdLogIn";
			this.cmdLogIn.Size = new System.Drawing.Size(120, 40);
			this.cmdLogIn.TabIndex = 3;
			this.cmdLogIn.Text = "Log In Company";
			
			//StartupForm
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 207);
			this.Controls.Add(this.cmdLogOut);
			this.Controls.Add(this.cmdItemCycle);
			this.Controls.Add(this.cmdLogIn);
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
			
			InitCmdButtons(true, true, true);
			
		}
		
		
		private void StartupForm_Load (System.Object sender, System.EventArgs e)
		{
			
			InitCmdButtons(true, false, false);
			
		}
		
		private void InitCmdButtons (bool bLogIn, bool bItemCycle, bool bLogOut)
		{
			
			cmdLogIn.Enabled = bLogIn;
			cmdItemCycle.Enabled = bItemCycle;
			cmdLogOut.Enabled = bLogOut;
			
		}
		
		private void cmdLogOut_Click (System.Object sender, System.EventArgs e)
		{
			
			this.Close();
			
		}
		
		private void cmdItemCycle_Click (System.Object sender, System.EventArgs e)
		{
			
			ItemCycleCountForm frm = new ItemCycleCountForm();
			
			//show message dialog
			frm.ShowDialog();
			
		}
	}
	
}
