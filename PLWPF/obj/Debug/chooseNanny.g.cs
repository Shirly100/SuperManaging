﻿#pragma checksum "..\..\chooseNanny.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CA649C179751981CBC401C9C5813BBE46EA5D7D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF;
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


namespace PLWPF {
    
    
    /// <summary>
    /// chooseNanny
    /// </summary>
    public partial class chooseNanny : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\chooseNanny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox range;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\chooseNanny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox age;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\chooseNanny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox vocations;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\chooseNanny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chage;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\chooseNanny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox nannies;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\chooseNanny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button choose;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\chooseNanny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button find;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/choosenanny.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\chooseNanny.xaml"
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
            this.range = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.age = ((System.Windows.Controls.CheckBox)(target));
            
            #line 36 "..\..\chooseNanny.xaml"
            this.age.Checked += new System.Windows.RoutedEventHandler(this.age_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.vocations = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.chage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.nannies = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.choose = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\chooseNanny.xaml"
            this.choose.Click += new System.Windows.RoutedEventHandler(this.choose_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.find = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\chooseNanny.xaml"
            this.find.Click += new System.Windows.RoutedEventHandler(this.find_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

