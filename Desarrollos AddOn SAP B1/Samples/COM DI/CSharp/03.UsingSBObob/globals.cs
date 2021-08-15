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
	sealed class globals_Renamed
	{
		////  SAP MANAGE DI API 2007 SDK Sample
		////****************************************************************************
		////
		////  File:      Globals.bas
		////
		////  Copyright (c) SAP MANAGE
		////
		//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		//// PARTICULAR PURPOSE.
		////
		////****************************************************************************
		
		
		public static void InitializeCompany ()
		{
			
			//// Initialize the Company Object.
			//// Create a new company object
			oCompany = new SAPbobsCOM.Company();
			
			//// Set the mandatory properties for the connection to the database.
			//// here I bring only 2 of the 5 mandatory fields.
			//// To use a remote Db Server enter his name instead of the string "(local)"
			//// This string is used to work on a DB installed on your local machine
			//// the other mandatory fields are CompanyDB, UserName and Password
			//// I am setting those fields in the ChooseCompany Form
			
			oCompany.Server = "(local)";
			oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English;
			
			//// Use Windows authentication for database server.
			//// True for NT server authentication,
			//// False for database server authentication.
			oCompany.UseTrusted = true;
			
		}
		
		
		
		public static SAPbobsCOM.Company oCompany;
		
		public static string sErrMsg = null;
		public static int lErrCode = 0;
		public static int lRetCode;
	}
}
