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
//  File:      SendMsgForm.cs
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
// Send message to a recipient
//
//****************************************************************************


namespace FormWindowTemplateVb
{
	public class SendMsgForm : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public SendMsgForm() {
			
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button cmdSendMessage;
		internal System.Windows.Forms.TextBox txtSubject;
		internal System.Windows.Forms.TextBox txtText;
		internal System.Windows.Forms.TextBox txtRecipient;
		internal System.Windows.Forms.TextBox txtFirstColumn;
		internal System.Windows.Forms.TextBox txtFirstLine;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtObjectKey;
		internal System.Windows.Forms.TextBox txtObjectType;
		internal System.Windows.Forms.Label Label8;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.txtSubject = new System.Windows.Forms.TextBox();
			base.Load += new System.EventHandler(SendMsgForm_Load);
			this.txtText = new System.Windows.Forms.TextBox();
			this.txtRecipient = new System.Windows.Forms.TextBox();
			this.txtFirstColumn = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtFirstLine = new System.Windows.Forms.TextBox();
			this.cmdSendMessage = new System.Windows.Forms.Button();
			cmdSendMessage.Click += new System.EventHandler(cmdSendMessage_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtObjectKey = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtObjectType = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//txtSubject
			//
			this.txtSubject.Location = new System.Drawing.Point(128, 32);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(120, 20);
			this.txtSubject.TabIndex = 0;
			this.txtSubject.Text = "My Subject";
			//
			//txtText
			//
			this.txtText.Location = new System.Drawing.Point(128, 64);
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(120, 20);
			this.txtText.TabIndex = 1;
			this.txtText.Text = "My Text";
			//
			//txtRecipient
			//
			this.txtRecipient.Location = new System.Drawing.Point(128, 96);
			this.txtRecipient.Name = "txtRecipient";
			this.txtRecipient.Size = new System.Drawing.Size(120, 20);
			this.txtRecipient.TabIndex = 2;
			this.txtRecipient.Text = "Bill Johnson";
			//
			//txtFirstColumn
			//
			this.txtFirstColumn.Location = new System.Drawing.Point(128, 128);
			this.txtFirstColumn.Name = "txtFirstColumn";
			this.txtFirstColumn.Size = new System.Drawing.Size(120, 20);
			this.txtFirstColumn.TabIndex = 3;
			this.txtFirstColumn.Text = "Bp Code";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(104, 18);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Subject";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 66);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(104, 16);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Text";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(16, 97);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(104, 18);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Recipient Name";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(16, 129);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(104, 18);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "First Column Name";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(16, 161);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(104, 18);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "First Line Value";
			//
			//txtFirstLine
			//
			this.txtFirstLine.Location = new System.Drawing.Point(128, 160);
			this.txtFirstLine.Name = "txtFirstLine";
			this.txtFirstLine.Size = new System.Drawing.Size(120, 20);
			this.txtFirstLine.TabIndex = 9;
			this.txtFirstLine.Text = "HU1003";
			//
			//cmdSendMessage
			//
			this.cmdSendMessage.Location = new System.Drawing.Point(168, 312);
			this.cmdSendMessage.Name = "cmdSendMessage";
			this.cmdSendMessage.Size = new System.Drawing.Size(104, 24);
			this.cmdSendMessage.TabIndex = 10;
			this.cmdSendMessage.Text = "Send Message";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.txtObjectKey);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.txtObjectType);
			this.GroupBox1.Location = new System.Drawing.Point(16, 192);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(256, 104);
			this.GroupBox1.TabIndex = 15;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Link Line To Object";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(112, 16);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(112, 16);
			this.Label8.TabIndex = 19;
			this.Label8.Text = "(e.g. Bp Type=2)";
			//
			//txtObjectKey
			//
			this.txtObjectKey.Location = new System.Drawing.Point(112, 72);
			this.txtObjectKey.Name = "txtObjectKey";
			this.txtObjectKey.Size = new System.Drawing.Size(120, 20);
			this.txtObjectKey.TabIndex = 18;
			this.txtObjectKey.Text = "HU1003";
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(16, 72);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(92, 18);
			this.Label6.TabIndex = 17;
			this.Label6.Text = "Object Key";
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(16, 34);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(92, 14);
			this.Label7.TabIndex = 16;
			this.Label7.Text = "Object Type       ";
			//
			//txtObjectType
			//
			this.txtObjectType.Location = new System.Drawing.Point(112, 32);
			this.txtObjectType.Name = "txtObjectType";
			this.txtObjectType.Size = new System.Drawing.Size(120, 20);
			this.txtObjectType.TabIndex = 15;
			this.txtObjectType.Text = "2";
			//
			//SendMsgForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 349);
			this.Controls.Add(this.cmdSendMessage);
			this.Controls.Add(this.txtFirstLine);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtFirstColumn);
			this.Controls.Add(this.txtRecipient);
			this.Controls.Add(this.txtText);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.GroupBox1);
			this.Name = "SendMsgForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Send Message ";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		string sErrMsg;
		long lErrCode;
		
		private void SendMsgForm_Load (System.Object sender, System.EventArgs e)
		{
			
			
		}
		
		//The function sends internal message to a recipient
		private void cmdSendMessage_Click (System.Object sender, System.EventArgs e)
		{
			SAPbobsCOM.Message oMessage = null; 
			MessageDataColumns pMessageDataColumns = null; 
			MessageDataColumn pMessageDataColumn = null; 
			MessageDataLines oLines = null; 
			MessageDataLine oLine = null; 
			RecipientCollection oRecipientCollection = null; 
            
			try 
			{ 
                
				// get the data interface for the new message
				oMessage = ( ( SAPbobsCOM.Message )( MainModule.oMessageService.GetDataInterface( MessagesServiceDataInterfaces.msdiMessage ) ) ); 
                
				// fill subject
				oMessage.Subject = txtSubject.Text; 
                
				oMessage.Text = txtText.Text; 
                
				// Add Recipient 
				oRecipientCollection = oMessage.RecipientCollection; 
                
				oRecipientCollection.Add(); 
                
				// send internal message
				oRecipientCollection.Item( 0 ).SendInternal = BoYesNoEnum.tYES; 
                
				// add existing user name
				oRecipientCollection.Item( 0 ).UserCode = GetUserCode( txtRecipient.Text ); 
                
				// get columns data
				pMessageDataColumns = oMessage.MessageDataColumns; 
				// get column
				pMessageDataColumn = pMessageDataColumns.Add(); 
				// set column name
				pMessageDataColumn.ColumnName = txtFirstColumn.Text; 
                
				// set link to a real object in the application
				pMessageDataColumn.Link = BoYesNoEnum.tYES; 
                
				// get lines
				oLines = pMessageDataColumn.MessageDataLines; 
				// add new line
				oLine = oLines.Add(); 
				// set the line value
				oLine.Value = txtFirstLine.Text; 
                
				// set the link to BusinessPartner (the object type for Bp is 2)
				oLine.Object = txtObjectType.Text; 
				// set the Bp code
				oLine.ObjectKey = txtObjectKey.Text; 
                
				// send the message
				MainModule.oMessageService.SendMessage( oMessage ); 
                
				this.Close(); 
                
			} 
			catch ( Exception ex ) 
			{ 
                
				Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                
			} 
            
            
            
		}
		
		//The function is using the user name to return the user code
		private string GetUserCode(string sUserName)
		{
			
			Users oUsers;
			SAPbobsCOM.Recordset oRecordSet;
			
			try
			{
				//get users object
				oUsers = (SAPbobsCOM.Users) MainModule.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers);
				
				// Get a new Recordset object
				oRecordSet = (SAPbobsCOM.Recordset) MainModule.oCompany.GetBusinessObject(BoObjectTypes.BoRecordset);
				
				// Perform the SELECT statement.
				// The query result will be loaded
				// into the Recordset object
				oRecordSet.DoQuery("Select USER_CODE from OUSR");
				
				// Asign (link) the Recordset object
				// to the Browser.Recordset property
				oUsers.Browser.Recordset = oRecordSet;
				
				//find the username
				while (oUsers.Browser.EoF == false)
				{
					if (oUsers.UserName == sUserName)
					{
						break;
					}
					oUsers.Browser.MoveNext();
				}
				
				//return the User Code
				return oUsers.UserCode;
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
			return "";
		}
		
	}
	
}
