'//**************************************************************************************************
'// BEFORE STARTING:
'// 1. Add reference to the "SAP Business One UI API"
'// 2. Add reference to the "SAP Business One Objects Bridge VERSION 2007"
'// 3. Insert the development connection string to the "Command Line Argument"
'//-----------------------------------------------------------------
'// 1.
'//    a. Project->References
'//    b. check the "SAP Business One UI API 2007" check box
'//
'// 2.
'//    a. Project->References
'//    b. check the "SAP Business One Objects Bridge VERSION 2007" check box
'//
'// 3.
'//     a. Project->Properties
'//     b. choose 'Make' tab folder
'//     c. place the following connection string in the 'Command Line Arguments' field
'// 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
'//
'//**************************************************************************************************

Option Explicit On 
Option Strict Off

Module VidsMain

    Sub main()
        ' Creating a vids object
        Dim oVids As Vids

        oVids = New Vids

        ' Start Message Loop
        System.Windows.Forms.Application.Run()
    End Sub

End Module
