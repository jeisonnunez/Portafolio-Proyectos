﻿#pragma checksum "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1BB1CEC3AEA6B2CDB959C5BB66EBA9A2A94978E7F83A5558C2D1D1F40E0F9ED4"
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
    /// PortalRetencionesIVA
    /// </summary>
    public partial class PortalRetencionesIVA : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser webSite;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgleft;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgRight;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIr;
        
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
            System.Uri resourceLocater = new System.Uri("/Vista;component/informes%20fiscales/reportes%20wpf/portalretencionesiva.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
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
            
            #line 8 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
            ((Vista.PortalRetencionesIVA)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
            ((Vista.PortalRetencionesIVA)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.webSite = ((System.Windows.Controls.WebBrowser)(target));
            return;
            case 3:
            this.imgleft = ((System.Windows.Controls.Image)(target));
            
            #line 11 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
            this.imgleft.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.imgleft_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imgRight = ((System.Windows.Controls.Image)(target));
            
            #line 12 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
            this.imgRight.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.imgRight_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
            this.txtSearch.LostFocus += new System.Windows.RoutedEventHandler(this.textBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
            this.txtSearch.GotFocus += new System.Windows.RoutedEventHandler(this.textBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnIr = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Informes Fiscales\Reportes WPF\PortalRetencionesIVA.xaml"
            this.btnIr.Click += new System.Windows.RoutedEventHandler(this.btnIr_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

