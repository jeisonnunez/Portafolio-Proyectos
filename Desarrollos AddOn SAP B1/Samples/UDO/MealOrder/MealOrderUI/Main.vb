
'  SAP MANAGE UI API 2007 SDK Sample
'****************************************************************************
'
'  File:      SubMain.vb
'
'  Copyright (c) SAP MANAGE
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************
Option Strict Off
Option Explicit On 
Module Main

    Public Sub Main()

        ' Creating an object
        Dim oMealOrder As MealOrder

        oMealOrder = New MealOrder

        ' Starting the Application
        System.Windows.Forms.Application.Run()
    End Sub
End Module
