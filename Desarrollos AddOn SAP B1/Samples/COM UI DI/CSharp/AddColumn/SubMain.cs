//  SAP MANAGE UI,DI API 2006 SDK Sample
//****************************************************************************
//
//  File:      SubMain.cs
//
//  Copyright (c) SAP MANAGE
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************

using System;
using System.Windows.Forms;
namespace Project1 {
    // following class was VB module
    [Microsoft.VisualBasic.CompilerServices.StandardModule]
    sealed public class SubMain { 
        
        public static void Main() { 
            
            AddColumn oAddColumn = null; 
            
            oAddColumn = new AddColumn(); 
            
            Application.Run(); 
        } 
        
    } 
    
} 
