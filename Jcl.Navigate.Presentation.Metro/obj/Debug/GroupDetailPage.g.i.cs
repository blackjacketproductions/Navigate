﻿

#pragma checksum "C:\Users\Jonathon\documents\visual studio 11\Projects\Jcl.Navigate.Services\Jcl.Navigate.Presentation.Metro\GroupDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "400B7DB5F94813F50930D55EF5C383EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Jcl.Navigate.Presentation.Metro
{
    public partial class GroupDetailPage : Jcl.Navigate.Presentation.Metro.Common.LayoutAwarePage
    {
        private Jcl.Navigate.Presentation.Metro.Common.LayoutAwarePage pageRoot;
        private Windows.UI.Xaml.Data.CollectionViewSource itemsViewSource;
        private Windows.UI.Xaml.Controls.ScrollViewer gridScrollViewer;
        private Windows.UI.Xaml.Controls.ScrollViewer snappedScrollViewer;
        private Windows.UI.Xaml.Controls.StackPanel gridLayoutPanel;
        private Windows.UI.Xaml.Controls.Button backButton;
        private Windows.UI.Xaml.Controls.TextBlock pageTitle;
        private Windows.UI.Xaml.VisualState FullScreenLandscape;
        private Windows.UI.Xaml.VisualState Filled;
        private Windows.UI.Xaml.VisualState FullScreenPortrait;
        private Windows.UI.Xaml.VisualState Snapped;
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-appx:///GroupDetailPage.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (Jcl.Navigate.Presentation.Metro.Common.LayoutAwarePage)this.FindName("pageRoot");
            itemsViewSource = (Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("itemsViewSource");
            gridScrollViewer = (Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("gridScrollViewer");
            snappedScrollViewer = (Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("snappedScrollViewer");
            gridLayoutPanel = (Windows.UI.Xaml.Controls.StackPanel)this.FindName("gridLayoutPanel");
            backButton = (Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            pageTitle = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
            FullScreenLandscape = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenLandscape");
            Filled = (Windows.UI.Xaml.VisualState)this.FindName("Filled");
            FullScreenPortrait = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenPortrait");
            Snapped = (Windows.UI.Xaml.VisualState)this.FindName("Snapped");
        }
    }
}



