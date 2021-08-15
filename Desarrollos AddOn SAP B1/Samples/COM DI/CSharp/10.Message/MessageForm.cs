using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using SAPbobsCOM;

//  SAP DI API 2006 SDK Sample
//****************************************************************************
//
//  File:      MessageForm.cs
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
// Display all messages : Inbox , Outbox, SentMessages
//
//****************************************************************************


namespace FormWindowTemplateVb
{
	public class MessageForm : System.Windows.Forms.Form
	{
		
		
		#region " Windows Form Designer generated code "
		
		public MessageForm() {
			
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
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.ListView lsvInbox;
		internal System.Windows.Forms.ColumnHeader Subject;
		internal System.Windows.Forms.ColumnHeader MsgDate;
		internal System.Windows.Forms.ColumnHeader From;
		internal System.Windows.Forms.ColumnHeader Status;
		internal System.Windows.Forms.ColumnHeader Attachment;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.TabControl LsvSendbox;
		internal System.Windows.Forms.ListView LsvOutbox;
		internal System.Windows.Forms.ListView LsvSendMsg;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.Button cmdSendMsg;
		internal System.Windows.Forms.ListView lswInboxDetails;
		internal System.Windows.Forms.ColumnHeader BPCODE;
		internal System.Windows.Forms.ColumnHeader ContactPerson;
		internal System.Windows.Forms.ColumnHeader Telephone;
		internal System.Windows.Forms.ColumnHeader Remarks;
		internal System.Windows.Forms.ListView lswOutboxDetails;
		internal System.Windows.Forms.ColumnHeader ToName;
		internal System.Windows.Forms.ColumnHeader DateEmail;
		internal System.Windows.Forms.ColumnHeader TimeEmail;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader11;
		internal System.Windows.Forms.ColumnHeader ColumnHeader12;
		internal System.Windows.Forms.ListView lsvDetailsSent;
		internal System.Windows.Forms.Button cmdRefresh;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.LsvSendbox = new System.Windows.Forms.TabControl();
			base.Load += new System.EventHandler(MessageForm_Load);
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.lswInboxDetails = new System.Windows.Forms.ListView();
			lswInboxDetails.SelectedIndexChanged += new System.EventHandler(lswInboxDetails_SelectedIndexChanged);
			this.BPCODE = new System.Windows.Forms.ColumnHeader();
			this.ContactPerson = new System.Windows.Forms.ColumnHeader();
			this.Telephone = new System.Windows.Forms.ColumnHeader();
			this.Remarks = new System.Windows.Forms.ColumnHeader();
			this.lsvInbox = new System.Windows.Forms.ListView();
			lsvInbox.Click += new System.EventHandler(lsvInbox_Click);
			this.Subject = new System.Windows.Forms.ColumnHeader();
			this.MsgDate = new System.Windows.Forms.ColumnHeader();
			this.From = new System.Windows.Forms.ColumnHeader();
			this.Status = new System.Windows.Forms.ColumnHeader();
			this.Attachment = new System.Windows.Forms.ColumnHeader();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.lswOutboxDetails = new System.Windows.Forms.ListView();
			this.ToName = new System.Windows.Forms.ColumnHeader();
			this.DateEmail = new System.Windows.Forms.ColumnHeader();
			this.TimeEmail = new System.Windows.Forms.ColumnHeader();
			this.LsvOutbox = new System.Windows.Forms.ListView();
			LsvOutbox.Click += new System.EventHandler(LsvOutbox_Click);
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.lsvDetailsSent = new System.Windows.Forms.ListView();
			this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.LsvSendMsg = new System.Windows.Forms.ListView();
			LsvSendMsg.Click += new System.EventHandler(LsvSendMsg_Click);
			this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.cmdSendMsg = new System.Windows.Forms.Button();
			cmdSendMsg.Click += new System.EventHandler(cmdSendMsg_Click);
			this.cmdRefresh = new System.Windows.Forms.Button();
			cmdRefresh.Click += new System.EventHandler(cmdRefresh_Click);
			this.LsvSendbox.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.SuspendLayout();
			//
			//LsvSendbox
			//
			this.LsvSendbox.Controls.Add(this.TabPage1);
			this.LsvSendbox.Controls.Add(this.TabPage2);
			this.LsvSendbox.Controls.Add(this.TabPage3);
			this.LsvSendbox.Location = new System.Drawing.Point(16, 16);
			this.LsvSendbox.Name = "LsvSendbox";
			this.LsvSendbox.SelectedIndex = 0;
			this.LsvSendbox.Size = new System.Drawing.Size(408, 344);
			this.LsvSendbox.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.lswInboxDetails);
			this.TabPage1.Controls.Add(this.lsvInbox);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new System.Drawing.Size(400, 318);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Inbox";
			//
			//lswInboxDetails
			//
			this.lswInboxDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.BPCODE, this.ContactPerson, this.Telephone, this.Remarks });
			this.lswInboxDetails.GridLines = true;
			this.lswInboxDetails.Location = new System.Drawing.Point(16, 168);
			this.lswInboxDetails.Name = "lswInboxDetails";
			this.lswInboxDetails.Size = new System.Drawing.Size(360, 120);
			this.lswInboxDetails.TabIndex = 1;
			this.lswInboxDetails.View = System.Windows.Forms.View.Details;
			//
			//BPCODE
			//
			this.BPCODE.Text = "BP CODE";
			this.BPCODE.Width = 80;
			//
			//ContactPerson
			//
			this.ContactPerson.Text = "Contact Person";
			this.ContactPerson.Width = 90;
			//
			//Telephone
			//
			this.Telephone.Text = "Telephone";
			this.Telephone.Width = 77;
			//
			//Remarks
			//
			this.Remarks.Text = "Remarks";
			this.Remarks.Width = 80;
			//
			//lsvInbox
			//
			this.lsvInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.Subject, this.MsgDate, this.From, this.Status, this.Attachment });
			this.lsvInbox.FullRowSelect = true;
			this.lsvInbox.GridLines = true;
			this.lsvInbox.Location = new System.Drawing.Point(16, 16);
			this.lsvInbox.Name = "lsvInbox";
			this.lsvInbox.Size = new System.Drawing.Size(360, 120);
			this.lsvInbox.TabIndex = 0;
			this.lsvInbox.View = System.Windows.Forms.View.Details;
			//
			//Subject
			//
			this.Subject.Text = "Subject";
			this.Subject.Width = 80;
			//
			//MsgDate
			//
			this.MsgDate.Text = "Date";
			//
			//From
			//
			this.From.Text = "From";
			//
			//Status
			//
			this.Status.Text = "Status";
			//
			//Attachment
			//
			this.Attachment.Text = "Attachment";
			this.Attachment.Width = 80;
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.lswOutboxDetails);
			this.TabPage2.Controls.Add(this.LsvOutbox);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new System.Drawing.Size(400, 318);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "OutBox";
			//
			//lswOutboxDetails
			//
			this.lswOutboxDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ToName, this.DateEmail, this.TimeEmail });
			this.lswOutboxDetails.GridLines = true;
			this.lswOutboxDetails.Location = new System.Drawing.Point(16, 176);
			this.lswOutboxDetails.Name = "lswOutboxDetails";
			this.lswOutboxDetails.Size = new System.Drawing.Size(360, 120);
			this.lswOutboxDetails.TabIndex = 2;
			this.lswOutboxDetails.View = System.Windows.Forms.View.Details;
			//
			//ToName
			//
			this.ToName.Text = "To";
			this.ToName.Width = 80;
			//
			//DateEmail
			//
			this.DateEmail.Text = "Date";
			//
			//TimeEmail
			//
			this.TimeEmail.Text = "Time";
			this.TimeEmail.Width = 80;
			//
			//LsvOutbox
			//
			this.LsvOutbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4 });
			this.LsvOutbox.GridLines = true;
			this.LsvOutbox.Location = new System.Drawing.Point(8, 16);
			this.LsvOutbox.Name = "LsvOutbox";
			this.LsvOutbox.Size = new System.Drawing.Size(360, 120);
			this.LsvOutbox.TabIndex = 1;
			this.LsvOutbox.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.Text = "Subject";
			this.ColumnHeader1.Width = 80;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "Date";
			//
			//ColumnHeader3
			//
			this.ColumnHeader3.Text = "Time";
			//
			//ColumnHeader4
			//
			this.ColumnHeader4.Text = "Attachment";
			this.ColumnHeader4.Width = 80;
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.lsvDetailsSent);
			this.TabPage3.Controls.Add(this.LsvSendMsg);
			this.TabPage3.Location = new System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new System.Drawing.Size(400, 318);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "Sent Messages";
			//
			//lsvDetailsSent
			//
			this.lsvDetailsSent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader5, this.ColumnHeader11, this.ColumnHeader12 });
			this.lsvDetailsSent.GridLines = true;
			this.lsvDetailsSent.Location = new System.Drawing.Point(16, 168);
			this.lsvDetailsSent.Name = "lsvDetailsSent";
			this.lsvDetailsSent.Size = new System.Drawing.Size(360, 120);
			this.lsvDetailsSent.TabIndex = 3;
			this.lsvDetailsSent.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader5
			//
			this.ColumnHeader5.Text = "To";
			this.ColumnHeader5.Width = 80;
			//
			//ColumnHeader11
			//
			this.ColumnHeader11.Text = "Date";
			//
			//ColumnHeader12
			//
			this.ColumnHeader12.Text = "Time";
			this.ColumnHeader12.Width = 80;
			//
			//LsvSendMsg
			//
			this.LsvSendMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader6, this.ColumnHeader7, this.ColumnHeader8, this.ColumnHeader9 });
			this.LsvSendMsg.FullRowSelect = true;
			this.LsvSendMsg.GridLines = true;
			this.LsvSendMsg.Location = new System.Drawing.Point(8, 16);
			this.LsvSendMsg.Name = "LsvSendMsg";
			this.LsvSendMsg.Size = new System.Drawing.Size(368, 120);
			this.LsvSendMsg.TabIndex = 1;
			this.LsvSendMsg.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader6
			//
			this.ColumnHeader6.Text = "Subject";
			this.ColumnHeader6.Width = 80;
			//
			//ColumnHeader7
			//
			this.ColumnHeader7.Text = "Date";
			//
			//ColumnHeader8
			//
			this.ColumnHeader8.Text = "Time";
			//
			//ColumnHeader9
			//
			this.ColumnHeader9.Text = "Attachment";
			this.ColumnHeader9.Width = 80;
			//
			//cmdSendMsg
			//
			this.cmdSendMsg.Location = new System.Drawing.Point(312, 384);
			this.cmdSendMsg.Name = "cmdSendMsg";
			this.cmdSendMsg.Size = new System.Drawing.Size(112, 24);
			this.cmdSendMsg.TabIndex = 1;
			this.cmdSendMsg.Text = "Send Massage";
			//
			//cmdRefresh
			//
			this.cmdRefresh.Location = new System.Drawing.Point(192, 384);
			this.cmdRefresh.Name = "cmdRefresh";
			this.cmdRefresh.Size = new System.Drawing.Size(112, 24);
			this.cmdRefresh.TabIndex = 2;
			this.cmdRefresh.Text = "Refresh";
			//
			//MessageForm
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 429);
			this.Controls.Add(this.cmdRefresh);
			this.Controls.Add(this.cmdSendMsg);
			this.Controls.Add(this.LsvSendbox);
			this.Name = "MessageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Message ";
			this.LsvSendbox.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		
		private void MessageForm_Load (System.Object sender, System.EventArgs e)
		{
			
			MainModule.InitService();
			
			FillAllViews();
			
		}
		
		private void FillAllViews ()
		{
			
			//fill inbox
			FillInboxView();
			
			//fill outbox
			FillOutboxView();
			
			//fill sent messages
			FillSendMsgView();
			
		}
		
		//fill Sent Messages
		private void FillSendMsgView ()
		{
            
			SAPbobsCOM.CompanyService oCmpSrv = null; 
			MessagesService oMessageService = null; 
			MessageHeaders oUserSendMsg = null; 
			MessageHeader oMessageHeader = null; 
			SAPbobsCOM.Message oMessage = null; 
			int iAttachment = 0; 
			string sAttachmentPath = null; 
            
			// get company service
			oCmpSrv = MainModule.oCompany.GetCompanyService(); 
            
			// get msg service
			oMessageService = ( ( SAPbobsCOM.MessagesService )( oCmpSrv.GetBusinessService( ServiceTypes.MessagesService ) ) ); 
            
			// get Sent Messages
			oUserSendMsg = oMessageService.GetSentMessages(); 
            
            
			int i = 0; 
            
			for ( i=0; i<=oUserSendMsg.Count - 1; i++ ) 
			{ 
                
				// get first message header
				oMessageHeader = oUserSendMsg.Item( i ); 
                
				// get the first message
				oMessage = oMessageService.GetMessage( oMessageHeader ); 
                
				ListViewItem pItem = new ListViewItem( oMessage.Subject ); 
                
				// insert date
				pItem.SubItems.Add( oMessageHeader.SentDate.ToShortDateString() ); 
                
				// insert time
				pItem.SubItems.Add( oMessageHeader.SentTime.ToShortTimeString() ); 
                
				// get attachement 
				iAttachment = oMessage.Attachment; 
                
				// add attachment
				if ( iAttachment == 0 ) 
				{ 
					// no attachment
					pItem.SubItems.Add( "No Attachment" ); 
				} 
				else 
				{ 
					// get attachment path    
					sAttachmentPath = GetAttachmentPath( iAttachment ); 
					// add the attachment path 
					pItem.SubItems.Add( sAttachmentPath ); 
				} 
                
				LsvSendMsg.Items.Add( pItem ); 
                
			} 
            
		}
		
		//fill the message inbox
		private void FillInboxView ()
		{
            
			MessageHeaders oUserInbox = null; 
			MessageHeader oMessageHeader = null; 
			SAPbobsCOM.Message oMessage = null; 
			string sUserName = null; 
			int iAttachment = 0; 
			int i = 0; 
			string sAttachmentPath = null; 
            
			// get inbox
			oUserInbox = MainModule.oMessageService.GetInbox(); 
            
			for ( i=0; i<=oUserInbox.Count - 1; i++ ) 
			{ 
                
				// get first message header
				oMessageHeader = oUserInbox.Item( i ); 
                
				// get the first message
				oMessage = MainModule.oMessageService.GetMessage( oMessageHeader ); 
                
				// insert subject
				ListViewItem pItem = new ListViewItem( oMessage.Subject ); 
                
				// insert Date
				pItem.SubItems.Add( oMessageHeader.ReceivedDate.ToString() ); 
                
				//pItem.SubItems.Add( 
				
				// get the user's name
				sUserName = GetUserName( oMessage.User ); 
                
				// insert user name
				pItem.SubItems.Add( sUserName ); 
                
				// insert email status (opened/not opened)
				if ( oMessageHeader.Read == BoYesNoEnum.tYES ) 
				{ 
					pItem.SubItems.Add( "Opened" ); 
				} 
				else 
				{ 
					pItem.SubItems.Add( "Not Opened" ); 
				} 
                
				// get attachement 
				iAttachment = oMessage.Attachment; 
                
				// add attachment
				if ( iAttachment == 0 ) 
				{ 
					// no attachment
					pItem.SubItems.Add( "No Attachment" ); 
				} 
				else 
				{ 
					// get attachment path    
					sAttachmentPath = GetAttachmentPath( iAttachment ); 
					// add the attachment path 
					pItem.SubItems.Add( sAttachmentPath ); 
				} 
                
				// add the message to the inbox list view
				lsvInbox.Items.Add( pItem ); 
                
			} 
            
                      
		}
		
		//The function return the user name
		private string GetUserName(int iAttachment)
		{
			
			Users oUsers;
			string sUserName;
			
			try
			{
				
				//get users
				oUsers = (SAPbobsCOM.Users) MainModule.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers);
				
				bool bGetByKey;
				
				//get the user
				bGetByKey = oUsers.GetByKey(iAttachment);
				
				//get user name
				sUserName = oUsers.UserName;
				
				return sUserName;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			
			return "";
		}
		
		
		//The function return the path of the attachment file
		private string GetAttachmentPath(int iAttachment)
		{
			
			Attachments2 oAttachment;
			
			try
			{
				
				
				//get attachment object
				oAttachment = (SAPbobsCOM.Attachments2) MainModule.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oAttachments2);
				
				bool bGetByKey;
				
				//get the specific attachmnet
				bGetByKey = oAttachment.GetByKey(iAttachment);
				
				string sAttachment;
				
				//get the path to the attachment
				sAttachment = oAttachment.Lines.SourcePath + "\\" + oAttachment.Lines.FileName + "." + oAttachment.Lines.FileExtension;
				
				return sAttachment;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return "";
		}
		
		//fill outbox view
		private void FillOutboxView ()
		{
            
			MessageHeaders oUserOutbox = null; 
			MessageHeader oMessageHeader = null; 
			SAPbobsCOM.Message oMessage = null; 
			int iAttachment = 0; 
			string sAttachmentPath = null; 
			int i = 0; 
            
			// get inbox
			oUserOutbox = MainModule.oMessageService.GetOutbox(); 
            
            
			// insert all messages to the inbox view
			for ( i=0; i<=oUserOutbox.Count - 1; i++ ) 
			{ 
                
				// get first message header
				oMessageHeader = oUserOutbox.Item( i ); 
                
				// get the first message
				oMessage = MainModule.oMessageService.GetMessage( oMessageHeader ); 
                
				// insert subject
				ListViewItem pItem = new ListViewItem( oMessage.Subject ); 
                
				// insert date
				pItem.SubItems.Add( oMessageHeader.SentDate.ToShortDateString() ); 
                
				// insert time
				pItem.SubItems.Add( oMessageHeader.SentTime.ToShortTimeString() ); 
                
				// get attachement 
				iAttachment = oMessage.Attachment; 
                
				// add attachment
				if ( iAttachment == 0 ) 
				{ 
					// no attachment
					pItem.SubItems.Add( "No Attachment" ); 
				} 
				else 
				{ 
					// get attachment path    
					sAttachmentPath = GetAttachmentPath( iAttachment ); 
					// add the attachment path 
					pItem.SubItems.Add( sAttachmentPath ); 
				} 
                
				LsvOutbox.Items.Add( pItem ); 
                
			} 
            
		}
		
		//open send dialog
		private void cmdSendMsg_Click (System.Object sender, System.EventArgs e)
		{
			
			SendMsgForm pSendMsgForm = new SendMsgForm();
			
			pSendMsgForm.ShowDialog();
			
			
		}
		
		//show the inbox details according to the message that was clicked
		private void lsvInbox_Click (object sender, System.EventArgs e)
		{
			MessageHeader oMessageHeader = null; 
			SAPbobsCOM.Message oMessage = null; 
			MessageHeaders oUserInbox = null; 
			MessageDataColumns oMessageDataColumns = null; 
			ListView.SelectedListViewItemCollection oLvwSelectedItems = null; 
			MessageDataLines oMessageDataLines = null; 
			MessageDataLine oMessageDataLine = null; 
			MessageDataColumn oMessageDataColumn = null; 
			int iIndex = 0; 
			int j = 0; 
			int i = 0; 
            
			try 
			{ 
                
                
				oLvwSelectedItems = lsvInbox.SelectedItems; 
                
				// get selected item from list view
				iIndex = oLvwSelectedItems[ 0 ].Index; 
                
				// get inbox
				oUserInbox = MainModule.oMessageService.GetInbox(); 
                
				// get message by index
				oMessageHeader = oUserInbox.Item( iIndex ); 
                
				// get the first message
				oMessage = MainModule.oMessageService.GetMessage( oMessageHeader ); 
                
				// get all columns data
				oMessageDataColumns = oMessage.MessageDataColumns; 
                
				// clear all items in details view
				lswInboxDetails.Items.Clear(); 
                
				// insert data to all columns
				// the insert is by columns and not by rows
				for ( i=0; i<=oMessageDataColumns.Count - 1; i++ ) 
				{ 
					// get column
					oMessageDataColumn = oMessageDataColumns.Item( i ); 
					// get all column lines(getting all column data and not row)
					oMessageDataLines = oMessageDataColumn.MessageDataLines; 
                    
					for ( j=0; j<=oMessageDataLines.Count - 1; j++ ) 
					{ 
                        
						if ( i == 0 ) 
						{ 
							// get column data line
							oMessageDataLine = oMessageDataLines.Item( j ); 
							// insert data to the first column
							lswInboxDetails.Items.Add( oMessageDataLine.Value ); 
						} 
						else 
						{ 
							// get column data line
							oMessageDataLine = oMessageDataLines.Item( j ); 
                            
							if ( oMessageDataLine.Value != "" ) 
							{ 
								ListViewItem pItem = null; 
								// get item from list view
								pItem = lswInboxDetails.Items[ j ]; 
								// insert data
								pItem.SubItems.Add( oMessageDataLine.Value ); 
							} 
                            
						} 
					} 
                    
				} 
                
			} 
			catch ( Exception ex ) 
			{ 
                
				Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                
			} 
            
		}
		
		//show the Sent Massages details according to the message that was clicked
		private void LsvSendMsg_Click (object sender, System.EventArgs e)
		{
            
			MessageHeader oMessageHeader = null; 
			SAPbobsCOM.Message oMessage = null; 
			MessageHeaders oUserSentMsg = null; 
			ListView.SelectedListViewItemCollection oLvwSelectedItems = null; 
			int iIndex = 0; 
			int iAttachment = 0; 
			string sRecipientName = null; 
			ListViewItem pListItem = null; 
            
			try 
			{ 
                
                
				oLvwSelectedItems = LsvSendMsg.SelectedItems; 
                
				// get selected item from list view
				iIndex = oLvwSelectedItems[ 0 ].Index; 
                
				// get inbox
				oUserSentMsg = MainModule.oMessageService.GetSentMessages(); 
                
				// get message by index
				oMessageHeader = oUserSentMsg.Item( iIndex ); 
                
				// get the first message
				oMessage = MainModule.oMessageService.GetMessage( oMessageHeader ); 
                
				// clear all items in details view
				lsvDetailsSent.Items.Clear(); 
                
				// get the recipient name(TO)
				RecipientCollection oRecipientCollection = null; 
                
				// get Recipient collection
				oRecipientCollection = oMessage.RecipientCollection; 
                
				// get name
				sRecipientName = oRecipientCollection.Item( 0 ).NameTo; 
                
				// add Recipient Name to list
				pListItem = lsvDetailsSent.Items.Add( sRecipientName ); 
                
				// add Received Date 
				pListItem.SubItems.Add( oMessageHeader.ReceivedDate.ToShortDateString() ); 
                
				// add Received Time 
				pListItem.SubItems.Add( oMessageHeader.ReceivedTime.ToShortTimeString() ); 
                
			} 
			catch ( Exception ex ) 
			{ 
                
				Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                
			} 
            
		}
		
		//show the Outbox details according to the message that was clicked
		private void LsvOutbox_Click (object sender, System.EventArgs e)
		{
			MessageHeader oMessageHeader = null; 
			SAPbobsCOM.Message oMessage = null; 
			MessageHeaders oOutBoxMsg = null; 
			ListView.SelectedListViewItemCollection oLvwSelectedItems = null; 
			int iIndex = 0; 
			int iAttachment = 0; 
			string sRecipientName = null; 
			ListViewItem pListItem = null; 
            
			try 
			{ 
                
                
				oLvwSelectedItems = LsvOutbox.SelectedItems; 
                
				// get selected item from list view
				iIndex = oLvwSelectedItems[ 0 ].Index; 
                
				// get inbox
				oOutBoxMsg = MainModule.oMessageService.GetSentMessages(); 
                
				// get message by index
				oMessageHeader = oOutBoxMsg.Item( iIndex ); 
                
				// get the first message
				oMessage = MainModule.oMessageService.GetMessage( oMessageHeader ); 
                
				// clear all items in details view
				lswOutboxDetails.Items.Clear(); 
                
				// get the recipient name(TO)
				RecipientCollection oRecipientCollection = null; 
                
				// get Recipient collection
				oRecipientCollection = oMessage.RecipientCollection; 
                
				// get name
				sRecipientName = oRecipientCollection.Item( 0 ).NameTo; 
                
				// add Recipient Name to list
				pListItem = lswOutboxDetails.Items.Add( sRecipientName ); 
                
				// add Received Date
				pListItem.SubItems.Add( oMessageHeader.ReceivedDate.ToShortDateString() ); 
                
				// add Received Time
				pListItem.SubItems.Add( oMessageHeader.ReceivedTime.ToShortTimeString() ); 
                
			} 
			catch ( Exception ex ) 
			{ 
                
				Interaction.MsgBox( ex.Message, (Microsoft.VisualBasic.MsgBoxStyle)(0), null ); 
                
			} 
		}
		
		
		private void lswInboxDetails_SelectedIndexChanged (System.Object sender, System.EventArgs e)
		{
			
		}
		
		private void cmdRefresh_Click (System.Object sender, System.EventArgs e)
		{
			
			try
			{
				
				//clear all items in views
				lsvInbox.Items.Clear();
				LsvOutbox.Items.Clear();
				LsvSendMsg.Items.Clear();
				
				//refresh the list views: inbox , outbox ,sentmessages
				FillAllViews();
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
				
			}
			
		}
	}
	
}
