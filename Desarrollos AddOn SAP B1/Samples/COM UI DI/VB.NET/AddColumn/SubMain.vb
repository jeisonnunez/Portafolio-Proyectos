'//  SAP MANAGE UI,DI API 2006 SDK Sample
'//****************************************************************************
'//
'//  File:      SubMain.bas
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
		
        Dim oAddColumn As AddColumn
		
        oAddColumn = New AddColumn

        Application.Run()
	End Sub
End Module