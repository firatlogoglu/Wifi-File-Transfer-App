﻿#pragma checksum "..\..\..\Pages\TransferDonePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ACDB1D265A364CE89D3A7F5A4E9D002002A60F7BED0B5404164E5F1AC69D9C11"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FileSharingApp_Desktop.Pages;
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


namespace FileSharingApp_Desktop.Pages {
    
    
    /// <summary>
    /// TransferDonePage
    /// </summary>
    public partial class TransferDonePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\TransferDonePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView list_Files;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\TransferDonePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_MainMenu;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\TransferDonePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_OpenFolder;
        
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
            System.Uri resourceLocater = new System.Uri("/FileSharingApp_Desktop;component/pages/transferdonepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TransferDonePage.xaml"
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
            this.list_Files = ((System.Windows.Controls.ListView)(target));
            
            #line 20 "..\..\..\Pages\TransferDonePage.xaml"
            this.list_Files.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.list_Files_ItemTapped);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_MainMenu = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Pages\TransferDonePage.xaml"
            this.btn_MainMenu.Click += new System.Windows.RoutedEventHandler(this.btn_MainMenu_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_OpenFolder = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\TransferDonePage.xaml"
            this.btn_OpenFolder.Click += new System.Windows.RoutedEventHandler(this.btn_OpenFolder_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
