'//  SAP MANAGE UI API 6.5 SDK Sample
'//****************************************************************************
'//
'//  File:      MessageAPIs.vb
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
Module MessageAPIs


    '//****************************************************************
    '// API Declarations
    '// Enable us to process a message loop in Sub Main()
    '//
    '// A developer should copy this module 'as is' and create
    '// an object of your class in Sub Main()
    '//****************************************************************

    '// Part of the MSG structure - receives the location of the mouse
    Public Structure POINTAPI
        Dim X As Integer
        Dim Y As Integer
    End Structure

    '// The message structure
    Public Structure ApiMsg
        Dim hwnd As Integer
        Dim message As Integer
        Dim wParam As Integer
        Dim lParam As Integer
        Dim Time As Integer
        Dim pt As POINTAPI
    End Structure

    '// Retrieves messages sent to the calling thread's message queue
    Public Declare Function GetMessage Lib "user32" Alias "GetMessageA" (ByRef lpMsg As ApiMsg, ByVal hwnd As Integer, ByVal wMsgFilterMin As Integer, ByVal wMsgFilterMax As Integer) As Integer

    '// Translates virtual-key messages into character messages
    Public Declare Function TranslateMessage Lib "user32" (ByRef lpMsg As ApiMsg) As Integer

    '// Forwards the message on to the window represented by the
    '// hWnd member of the Msg structure
    Public Declare Function DispatchMessage Lib "user32" Alias "DispatchMessageA" (ByRef lpMsg As ApiMsg) As Integer

    Public Msg As ApiMsg
End Module