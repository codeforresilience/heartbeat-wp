﻿#pragma checksum "C:\Users\hanseh\Documents\Visual Studio 2010\Projects\HeartBeat\HeartBeat\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5491084BE5206FF00A97CD8C2765F273"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace HeartBeat {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard beat;
        
        internal System.Windows.Controls.Viewbox LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image image1;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.Button button2;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/HeartBeat;component/MainPage.xaml", System.UriKind.Relative));
            this.beat = ((System.Windows.Media.Animation.Storyboard)(this.FindName("beat")));
            this.LayoutRoot = ((System.Windows.Controls.Viewbox)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.image1 = ((System.Windows.Controls.Image)(this.FindName("image1")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.button2 = ((System.Windows.Controls.Button)(this.FindName("button2")));
        }
    }
}

