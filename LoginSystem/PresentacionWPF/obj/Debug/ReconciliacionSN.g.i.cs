#pragma checksum "..\..\ReconciliacionSN.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02D1C032EE3FE59953285EE1728A0FDC9A8B373A83EB6E66DBBFB16CD5CA75EE"
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
    /// ReconciliacionSN
    /// </summary>
    public partial class ReconciliacionSN : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ReconciliacionSN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblEstado;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ReconciliacionSN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEstado;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ReconciliacionSN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblReconciliacion;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ReconciliacionSN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpReconciliacion;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ReconciliacionSN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReconciliar;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ReconciliacionSN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/Vista;component/reconciliacionsn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReconciliacionSN.xaml"
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
            
            #line 8 "..\..\ReconciliacionSN.xaml"
            ((Vista.ReconciliacionSN)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblEstado = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtEstado = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\ReconciliacionSN.xaml"
            this.txtEstado.LostFocus += new System.Windows.RoutedEventHandler(this.textBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\ReconciliacionSN.xaml"
            this.txtEstado.GotFocus += new System.Windows.RoutedEventHandler(this.textBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblReconciliacion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.dpReconciliacion = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.btnReconciliar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\ReconciliacionSN.xaml"
            this.btnReconciliar.Click += new System.Windows.RoutedEventHandler(this.btnReconciliar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ReconciliacionSN.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnWindow_Close);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

