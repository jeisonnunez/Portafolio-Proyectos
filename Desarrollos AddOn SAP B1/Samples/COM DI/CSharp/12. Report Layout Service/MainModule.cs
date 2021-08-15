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
//  File:     MainModule.vb
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



namespace ReportService
{
	sealed class MainModule
	{
		
		public static SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
		public static SAPbobsCOM.CompanyService oCmpSrv;
		
		static public void Main ()
		{
			
			StartupForm frm = new StartupForm();
			
			frm.ShowDialog();
			
		}
		
		
	}
	
}
