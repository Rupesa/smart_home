﻿#pragma checksum "..\..\AddFavourite1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B2C1E76074585F08BAF7BCA14AF3BFDE296AB49682E000AC5FF448B0B7E1E8DD"
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
    /// AddFavourite1
    /// </summary>
    public partial class AddFavourite1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\AddFavourite1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddFavourite1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image im1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddFavourite1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button2;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AddFavourite1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button3;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\AddFavourite1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button4;
        
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
            System.Uri resourceLocater = new System.Uri("/IHCProject;component/addfavourite1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddFavourite1.xaml"
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
            
            #line 17 "..\..\AddFavourite1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToStats);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\AddFavourite1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToRooms);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\AddFavourite1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goBack);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 20 "..\..\AddFavourite1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goBack2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AddFavourite1.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.addFavourite);
            
            #line default
            #line hidden
            return;
            case 6:
            this.im1 = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.button2 = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AddFavourite1.xaml"
            this.button2.Click += new System.Windows.RoutedEventHandler(this.addFavourite);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button3 = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\AddFavourite1.xaml"
            this.button3.Click += new System.Windows.RoutedEventHandler(this.addFavourite);
            
            #line default
            #line hidden
            return;
            case 9:
            this.button4 = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\AddFavourite1.xaml"
            this.button4.Click += new System.Windows.RoutedEventHandler(this.addFavourite);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

