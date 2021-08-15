'//  SAP MANAGE DI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      Globals.bas
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
Module globals_Renamed

    Public Sub InitializeCompany()

        '// Initialize the Company Object.
        '// Create a new company object
        oCompany = New SAPbobsCOM.Company

        '// Set the mandatory properties for the connection to the database.
        '// here I bring only 2 of the 5 mandatory fields.
        '// To use a remote Db Server enter his name instead of the string "(local)"
        '// This string is used to work on a DB installed on your local machine
        '// the other mandatory fields are CompanyDB, UserName and Password
        '// I am setting those fields in the ChooseCompany Form

        oCompany.Server = "(local)"
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English

        '// Use Windows authentication for database server.
        '// True for NT server authentication,
        '// False for database server authentication.
        oCompany.UseTrusted = True

    End Sub


    Public oCompany As SAPbobsCOM.Company

    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer
End Module