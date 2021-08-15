'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      SubMain.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************

Option Strict Off
Option Explicit On
Module SubMain

	Public Sub Main()
		
		Dim oComplexForm As ComplexForm
		
		oComplexForm = New ComplexForm
		
		'//*********************************************
		'// this is the message loop
		'// we use it to catch Events and dispatch them
        '// don't forget to terminate the Add On by 
        '// placing 'System.Windows.Forms.Application.Exit' at the required spot
		'//*********************************************
		
        System.Windows.Forms.Application.Run()
	End Sub
End Module