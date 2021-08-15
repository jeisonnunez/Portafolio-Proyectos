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
// In this sample the SAP Business one order form is imitated via DI
//****************************************************************************

namespace BGT
{
	sealed class DownPayment
	{
		public static SAPbobsCOM.Recordset oRecordSet; // A recordset object
		
		//****************************************************************************
		// This is the application entry point
		//****************************************************************************
		public static void Main ()
		{
			frmMain fMain; // The main form object
			fMain = new frmMain(); // allocating a new form
			fMain.ShowDialog(); // showing the form
			fMain.Dispose(); // destroy the form object
			fMain = null;
		}
	}
	
}
