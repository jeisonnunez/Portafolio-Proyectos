// TRANSINFO: Option Strict Off
// TRANSINFO: Option Explicit On
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace Project1 {
    internal class HelloWorld  { 
        // //  SAP MANAGE UIDI API 2007 SDK Sample
        // //****************************************************************************
        // //
        // //  File:      HelloWorld.cls
        // //
        // //  Copyright (c) SAP MANAGE
        // //
        // // THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
        // // ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
        // // THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
        // // PARTICULAR PURPOSE.
        // //
        // //****************************************************************************
        
        
        
        // //**************************************************************************************************
        // // BEFORE STARTING:
        // // 1. Add reference to the "SAP Business One UI API"
        // // 2. Add reference to the "SAP Business One Objects Bridge VERSION 2007"
        // // 3. Insert the development connection string to the "Command Line Argument"
        // //-----------------------------------------------------------------
        // // 1.
        // //    a. Project->References
        // //    b. check the "SAP Business One UI API 2007" check box
        // //
        // // 2.
        // //    a. Project->References
        // //    b. check the "SAP Business One Objects Bridge VERSION 2007" check box
        // //
        // // 3.
        // //     a. Project->Properties
        // //     b. choose 'Make' tab folder
        // //     c. place the following connection string in the 'Command Line Arguments' field
        // // 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
        // //
        // //**************************************************************************************************
        
        
        // //**********************************************************
        // // This parameter will use us to manipulate the
        // // SAP Business One Application a
        // // and the Company on which we are working
        // //**********************************************************
        
        private /* TRANSINFO: WithEvents */ SAPbouiCOM.Application SBO_Application; 
        private SAPbobsCOM.Company oCompany; 
        
        private void SetApplication() { 
            
            // *******************************************************************
            // // Use an SboGuiApi object to establish connection
            // // with the SAP Business One application and return an
            // // initialized appliction object
            // *******************************************************************
            
            SAPbouiCOM.SboGuiApi SboGuiApi = null; 
            string sConnectionString = null; 
            
            SboGuiApi = new SAPbouiCOM.SboGuiApi(); 
            
            // // by following the steps specified above, the following
            // // statment should be suficient for either development or run mode
            
            sConnectionString = System.Convert.ToString( Environment.GetCommandLineArgs().GetValue( 1 ) ); 
            
            // // connect to a running SBO Application
            
            SboGuiApi.Connect( sConnectionString ); 
            
            // // get an initialized application object
            
            SBO_Application = SboGuiApi.GetApplication( -1 ); 
            
        } 
        
        
        private int SetConnectionContext() { 
            int setConnectionContextReturn = 0;
            
            string sCookie = null; 
            string sConnectionContext = null; 
            int lRetCode = 0; 
            
            // // First initialize the Company object
            
            oCompany = new SAPbobsCOM.Company(); 
            
            // // Acquire the connection context cookie from the DI API.
            sCookie = oCompany.GetContextCookie(); 
            
            // // Retrieve the connection context string from the UI API using the
            // // acquired cookie.
            sConnectionContext = SBO_Application.Company.GetConnectionContext( sCookie ); 
            
            // // before setting the SBO Login Context make sure the company is not
            // // connected
            
            if ( oCompany.Connected == true ) { 
                oCompany.Disconnect(); 
            } 
            
            // // Set the connection context information to the DI API.
            setConnectionContextReturn = oCompany.SetSboLoginContext( sConnectionContext ); 
            
            return setConnectionContextReturn;
        } 
        
        
        private int ConnectToCompany() { 
            int connectToCompanyReturn = 0;
            
            // // Establish the connection to the company database.
            connectToCompanyReturn = oCompany.Connect(); 
            
            return connectToCompanyReturn;
        } 
        
        // UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
        private void Class_Initialize_Renamed() { 
            
            // //*************************************************************
            // // set SBO_Application with an initialized application object
            // //*************************************************************
            
            SetApplication(); 
            
            // //*************************************************************
            // // Set The Connection Context
            // //*************************************************************
            
            if ( !( SetConnectionContext() == 0 ) ) { 
                SBO_Application.MessageBox( "Failed setting a connection to DI API", 1, "Ok", "", "" ); 
                System.Environment.Exit( 0 ); //  Terminating the Add-On Application
            } 
            
            
            // //*************************************************************
            // // Connect To The Company Data Base
            // //*************************************************************
            
            if ( !( ConnectToCompany() == 0 ) ) { 
                SBO_Application.MessageBox( "Failed connecting to the company's Data Base", 1, "Ok", "", "" ); 
                System.Environment.Exit( 0 ); //  Terminating the Add-On Application
            } 
            
            // //*************************************************************
            // // send an "hello world" message
            // //*************************************************************
            
            SBO_Application.MessageBox( "DI Connected To: " + oCompany.CompanyName + Constants.vbNewLine + "Hello World!", 1, "Ok", "", "" ); 
            
        } 
        
        public HelloWorld() : base() { 
            
            Class_Initialize_Renamed(); 
        } 
    } 
    
} 
