#pragma checksum "..\..\..\Listas\ListaDateTXT.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "29AFB39E16F70634F109F559D7C596AC6E9F19580CEDF2B326BE7C7A885A2426"
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
    /// ListaDateTXT
    /// </summary>
    public partial class ListaDateTXT : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Listas\ListaDateTXT.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Listas\ListaDateTXT.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListDateTXT;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Listas\ListaDateTXT.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid col1;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Listas\ListaDateTXT.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid col2;
        
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
            System.Uri resourceLocater = new System.Uri("/Vista;component/listas/listadatetxt.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Listas\ListaDateTXT.xaml"
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
            
            #line 8 "..\..\..\Listas\ListaDateTXT.xaml"
            ((Vista.ListaDateTXT)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\Listas\ListaDateTXT.xaml"
            this.txtFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFilter_TextChanged);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Listas\ListaDateTXT.xaml"
            this.txtFilter.LostFocus += new System.Windows.RoutedEventHandler(this.txtFilter_LostFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Listas\ListaDateTXT.xaml"
            this.txtFilter.GotFocus += new System.Windows.RoutedEventHandler(this.txtFilter_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListDateTXT = ((System.Windows.Controls.ListView)(target));
            
            #line 20 "..\..\..\Listas\ListaDateTXT.xaml"
            this.ListDateTXT.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.ListDateTXT_Click));
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\Listas\ListaDateTXT.xaml"
            this.ListDateTXT.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListDateTXT_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.col1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.col2 = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

