﻿#pragma checksum "..\..\Empresa.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "206B0C689A37072B5CC5BFF425C0FDAE255F75E72D5810862B28897A4DD9FB3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Vista;


namespace Vista {
    
    
    /// <summary>
    /// Empresa
    /// </summary>
    public partial class Empresa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Empresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmpresa;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Empresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblEmpresa;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Empresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCrearEmpresa;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Empresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblDatabase;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Empresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDatabase;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Empresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Empresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblPeriodo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Empresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPeriodos;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vista;component/empresa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Empresa.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\Empresa.xaml"
            ((Vista.Empresa)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtEmpresa = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\Empresa.xaml"
            this.txtEmpresa.LostFocus += new System.Windows.RoutedEventHandler(this.textBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\Empresa.xaml"
            this.txtEmpresa.GotFocus += new System.Windows.RoutedEventHandler(this.textBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblEmpresa = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.btnCrearEmpresa = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Empresa.xaml"
            this.btnCrearEmpresa.Click += new System.Windows.RoutedEventHandler(this.btnCrearEmpresa_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblDatabase = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtDatabase = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\Empresa.xaml"
            this.txtDatabase.LostFocus += new System.Windows.RoutedEventHandler(this.textBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\Empresa.xaml"
            this.txtDatabase.GotFocus += new System.Windows.RoutedEventHandler(this.textBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Empresa.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnWindow_Close);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblPeriodo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.btnPeriodos = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Empresa.xaml"
            this.btnPeriodos.Click += new System.Windows.RoutedEventHandler(this.btnPeriodos_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

