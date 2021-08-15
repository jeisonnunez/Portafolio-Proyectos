'//  SAP MANAGE DI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      globalD.vb
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
Module globalD

    Public oCompany As New SAPbobsCOM.Company
    Public oItems As SAPbobsCOM.Items
    Public oInvGenEntry As SAPbobsCOM.Documents
    Public oInvGenExit As SAPbobsCOM.Documents
    Public ErrMsg As String
    Public ErrCode As Integer
    Public RetVal As Integer
    Public RetBool As SAPbobsCOM.BoYesNoEnum
    Public flagManage As Boolean
    Public flagRelease As Boolean
    Public flagForce As Boolean
    Public flagBatch As Boolean
    Public flag As Boolean
    Public tempStr As String
    Public manSerialNumber As String
    Public manBatchNumber As String
    Public totalNumber As Integer
    Public batchNum As String
    Public interSerNumber As String
End Module

