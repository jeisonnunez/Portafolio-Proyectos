﻿#pragma checksum "..\..\GenerarTXTQuincenal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D3AA28185E171CDCAC4315E1D6DC689D17DF441D8A0996DE6A30B9EFC6320FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RootLibrary.WPF.Localization;
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
    /// GenerarTXTQuincenal
    /// </summary>
    public partial class GenerarTXTQuincenal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\GenerarTXTQuincenal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblPeriodo;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\GenerarTXTQuincenal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPeriodo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\GenerarTXTQuincenal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCrear;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\GenerarTXTQuincenal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\GenerarTXTQuincenal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblQuincena;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\GenerarTXTQuincenal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbQuincena;
        
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
            System.Uri resourceLocater = new System.Uri("/Vista;component/generartxtquincenal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GenerarTXTQuincenal.xaml"
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
            
            #line 8 "..\..\GenerarTXTQuincenal.xaml"
            ((Vista.GenerarTXTQuincenal)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\GenerarTXTQuincenal.xaml"
            ((Vista.GenerarTXTQuincenal)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblPeriodo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.cbPeriodo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\GenerarTXTQuincenal.xaml"
            this.cbPeriodo.LostFocus += new System.Windows.RoutedEventHandler(this.cbQuincena_LostFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\GenerarTXTQuincenal.xaml"
            this.cbPeriodo.GotFocus += new System.Windows.RoutedEventHandler(this.cbQuincena_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\GenerarTXTQuincenal.xaml"
            this.btnCrear.Click += new System.Windows.RoutedEventHandler(this.btnCrear_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\GenerarTXTQuincenal.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblQuincena = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.cbQuincena = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\GenerarTXTQuincenal.xaml"
            this.cbQuincena.LostFocus += new System.Windows.RoutedEventHandler(this.cbQuincena_LostFocus);
            
            #line default
            #line hidden
            
            #line 15 "..\..\GenerarTXTQuincenal.xaml"
            this.cbQuincena.GotFocus += new System.Windows.RoutedEventHandler(this.cbQuincena_GotFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

