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
	sealed class SubMain
	{
		//  SAP MANAGE UIDI API 2007 SDK Sample
		//****************************************************************************
		//
		//  File:      SubMain.bas
		//
		//  Copyright (c) SAP MANAGE
		//
		// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
		// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
		// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
		// PARTICULAR PURPOSE.
		//
		//****************************************************************************
		
		
		public static void Main()
		{
			
			HelloWorld oHelloWorld;
			
			oHelloWorld = new HelloWorld();
			
			// Starting the Application
			System.Windows.Forms.Application.Run();
		}
	}
}
