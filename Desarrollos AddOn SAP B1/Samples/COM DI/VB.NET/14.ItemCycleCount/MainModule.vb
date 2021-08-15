'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      MainModule.vb
'
'  Copyright (c) SAP 
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************

'****************************************************************************
'
' Description:
' -------------
' 1) Log in to the company
' 2) Display how to add an existing Cycle Count to an existing item

'****************************************************************************

Imports SAPbobsCOM

Module MainModule
    Public oCompany As New SAPbobsCOM.Company
    Public oCmpSrv As SAPbobsCOM.CompanyService

    Sub Main()
        Dim frm As New StartupForm
        frm.ShowDialog()
    End Sub
    'init the service object
    Public Sub initCompanyService()
        'get company service
        oCmpSrv = oCompany.GetCompanyService
    End Sub
End Module
