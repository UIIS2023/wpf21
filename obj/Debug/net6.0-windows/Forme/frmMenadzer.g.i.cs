﻿#pragma checksum "..\..\..\..\Forme\frmMenadzer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A4A064013BA84E8683417A0BC4318A4A99157339"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Restoran.Forme;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Restoran.Forme {
    
    
    /// <summary>
    /// frmMenadzer
    /// </summary>
    public partial class frmMenadzer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Forme\frmMenadzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImeMenadzera;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Forme\frmMenadzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtSacuvaj;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Forme\frmMenadzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtOtkazi;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Forme\frmMenadzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrezimeMenadzera;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Forme\frmMenadzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKontaktMenadzera;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Restoran;V1.0.0.0;component/forme/frmmenadzer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forme\frmMenadzer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtImeMenadzera = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtSacuvaj = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Forme\frmMenadzer.xaml"
            this.txtSacuvaj.Click += new System.Windows.RoutedEventHandler(this.txtSacuvaj_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtOtkazi = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Forme\frmMenadzer.xaml"
            this.txtOtkazi.Click += new System.Windows.RoutedEventHandler(this.txtOtkazi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtPrezimeMenadzera = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtKontaktMenadzera = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

