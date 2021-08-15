using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;


//****************************************************************************
//  SAP MANAGE DI API 2007 SDK Sample
//****************************************************************************
//
//  Copyright (c) SAP MANAGE
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************
// In this sample the SAP Business one order form is imitated via DI 2005
//****************************************************************************

namespace ord
{
	sealed class OrderApp
	{
		public static DataTable TableLines = null; // the datasource of the datagrid called DataLines.
		public static SAPbobsCOM.Documents oOrder = null; // Order object
		public static SAPbobsCOM.Documents oInvoice = null; // Invoice Object
		public static SAPbobsCOM.Recordset oRecordSet; // A recordset object
		public static SAPbobsCOM.Company oCompany; // The company object
		
		//****************************************************************************
		// This is the application entry point
		//****************************************************************************
		public static void Main ()
		{
			frmPermission fMain; // The main form object
			fMain = new frmPermission(); // allocating a new form
			fMain.ShowDialog(); // showing the form
			fMain.Dispose(); // destroy the form object
			fMain = null;
		}
	}
	
}
