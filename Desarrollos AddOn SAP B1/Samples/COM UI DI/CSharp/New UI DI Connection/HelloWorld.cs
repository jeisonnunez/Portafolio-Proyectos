#define Win32
using Microsoft.VisualBasic;
using System.Data;
using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace Project1
{
	internal class HelloWorld
	{
		
		//  SAP MANAGE UIDI API 2007 SDK Sample
		//****************************************************************************
		//
		//  File:      HelloWorld.vb
		//
		//  Copyright (c) SAP MANAGE
		//
		// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		// PARTICULAR PURPOSE.
		//
		//****************************************************************************
				
		
		//**************************************************************************************************
		// BEFORE STARTING:
		// 1. Add reference to the "SAP Business One UI API"
		// 2. Add reference to the "SAP Business One Objects Bridge VERSION 2007"
		// 3. Insert the development connection string to the "Command Line Argument"
		//-----------------------------------------------------------------
		// 1.
		//    a. Project->References
		//    b. check the "SAP Business One UI API 2007" check box
		//
		// 2.
		//    a. Project->References
		//    b. check the "SAP Business One Objects Bridge VERSION 2007" check box
		//
		// 3.
		//     a. Project->Properties
		//     b. choose 'Make' tab folder
		//     c. place the following connection string in the 'Command Line Arguments' field
		// 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
		//
		//**************************************************************************************************
		
		
		//**********************************************************
		// This parameter will use us to manipulate the
		// SAP Business One Application a
		// and the Company on which we are working
		//**********************************************************
		
		private SAPbouiCOM.Application SBO_Application;
		private SAPbobsCOM.Company oCompany;
		
		private void SetApplication()
		{
			
			//*******************************************************************
			// Use an SboGuiApi object to establish connection
			// with the SAP Business One application and return an
			// initialized appliction object
			//*******************************************************************
			
			SAPbouiCOM.SboGuiApi SboGuiApi;
			string sConnectionString;
			
			SboGuiApi = new SAPbouiCOM.SboGuiApi();
			
			// by following the steps specified above, the following
			// statment should be suficient for either development or run mode
			
			sConnectionString = Environment.GetCommandLineArgs().GetValue(1).ToString();
			
			// connect to a running SBO Application
			
			SboGuiApi.Connect(sConnectionString);
			
			// get an initialized application object
			
			SBO_Application = SboGuiApi.GetApplication(1);
			
		}
		
		private void Class_Initialize_Renamed()
		{
			try
			{
				//*************************************************************
				// set SBO_Application with an initialized application object
				//*************************************************************
				
				SetApplication();
				
				//*************************************************************
				// Connect to DI
				//*************************************************************
				
				oCompany = new SAPbobsCOM.Company();
				
				//get DI company (via UI)
				
				oCompany = (SAPbobsCOM.Company) SBO_Application.Company.GetDICompany();
				
				
				//*************************************************************
				// send a message
				//*************************************************************
				
				SBO_Application.MessageBox("DI Connected To: " + oCompany.CompanyName + Constants.vbNewLine + "This is the new UI,DI connection", 1, "Ok", "", "");
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		public HelloWorld()
		{
			Class_Initialize_Renamed();
		}
	}
}
