﻿#pragma checksum "..\..\AddScene2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "465A6B21C5D66E95C62B22D0AD29B5DFFD67330C5A2F8CD7714F901C165629D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IHCProject;
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


namespace IHCProject {
    
    
    /// <summary>
    /// AddScene2
    /// </summary>
    public partial class AddScene2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\AddScene2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image sw1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddScene2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image sw2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddScene2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image sw3;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddScene2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image sw4;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddScene2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddScene2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b2;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddScene2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b3;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddScene2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b4;
        
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
            System.Uri resourceLocater = new System.Uri("/IHCProject;component/addscene2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddScene2.xaml"
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
            this.sw1 = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.sw2 = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.sw3 = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.sw4 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            
            #line 22 "..\..\AddScene2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToStats);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 23 "..\..\AddScene2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToRooms);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 24 "..\..\AddScene2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goHome);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 25 "..\..\AddScene2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goBack);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 26 "..\..\AddScene2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goNext);
            
            #line default
            #line hidden
            return;
            case 10:
            this.b1 = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AddScene2.xaml"
            this.b1.Click += new System.Windows.RoutedEventHandler(this.act1);
            
            #line default
            #line hidden
            return;
            case 11:
            this.b2 = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AddScene2.xaml"
            this.b2.Click += new System.Windows.RoutedEventHandler(this.act2);
            
            #line default
            #line hidden
            return;
            case 12:
            this.b3 = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\AddScene2.xaml"
            this.b3.Click += new System.Windows.RoutedEventHandler(this.act3);
            
            #line default
            #line hidden
            return;
            case 13:
            this.b4 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AddScene2.xaml"
            this.b4.Click += new System.Windows.RoutedEventHandler(this.act4);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
