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
' 2) Display the messages : Inbox , Outbox, SendMessages
' 3) Display how to send a message  

'****************************************************************************

Imports SAPbobsCOM


Module MainModule
    Public oCompany As New SAPbobsCOM.Company
    Public oCmpSrv As SAPbobsCOM.CompanyService
    Public oMessageService As MessagesService

    Sub Main()

        Dim frm As New StartupForm

        frm.ShowDialog()

    End Sub

    'init the service object
    Public Sub InitService()


        'get company service
        oCmpSrv = oCompany.GetCompanyService

        'get msg service
        oMessageService = oCmpSrv.GetBusinessService(ServiceTypes.MessagesService)


    End Sub

End Module
