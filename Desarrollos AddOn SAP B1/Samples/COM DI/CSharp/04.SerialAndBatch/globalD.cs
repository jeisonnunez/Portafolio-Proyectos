using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

////  SAP MANAGE DI API 2007 SDK Sample
////****************************************************************************
////
////  File:      globalD.vb
////
////  Copyright (c) SAP MANAGE
////
//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
////****************************************************************************
namespace WindowsApplication2
{
	sealed class globalD
	{
		
		public static SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
		public static SAPbobsCOM.Items oItems;
		public static SAPbobsCOM.Documents oInvGenEntry;
		public static SAPbobsCOM.Documents oInvGenExit;
		public static string ErrMsg;
		public static int ErrCode;
		public static int RetVal;
		public static SAPbobsCOM.BoYesNoEnum RetBool;
		public static bool flagManage;
		public static bool flagRelease;
		public static bool flagForce;
		public static bool flagBatch;
		public static bool flag;
		public static string tempStr = null;
		public static string manSerialNumber;
		public static string manBatchNumber;
		public static int totalNumber;
		public static string batchNum;
		public static string interSerNumber;
	}
	
	
}
