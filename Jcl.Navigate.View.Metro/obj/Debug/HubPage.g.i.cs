﻿

#pragma checksum "C:\Users\Jonathon\documents\visual studio 11\Projects\Jcl.Navigate.Services\Jcl.Navigate.View.Metro\HubPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2408F963151839A5125C1F0FF7C5A3BA"
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

namespace Jcl.Navigate.View.Metro
{
    public partial class HubPage : Jcl.Navigate.View.Metro.Common.LayoutAwarePage
    {
        private Jcl.Navigate.View.Metro.Common.LayoutAwarePage pageRoot;
        private Windows.UI.Xaml.Data.CollectionViewSource groupedItemsViewSource;
        private Windows.UI.Xaml.Controls.ScrollViewer itemGridScrollViewer;
        private Windows.UI.Xaml.Controls.ScrollViewer itemListScrollViewer;
        private Windows.UI.Xaml.Controls.ListView itemListView;
        private Windows.UI.Xaml.Controls.GridView itemGridView;
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
            Application.LoadComponent(this, new System.Uri("ms-appx:///HubPage.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (Jcl.Navigate.View.Metro.Common.LayoutAwarePage)this.FindName("pageRoot");
            groupedItemsViewSource = (Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("groupedItemsViewSource");
            itemGridScrollViewer = (Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("itemGridScrollViewer");
            itemListScrollViewer = (Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("itemListScrollViewer");
            itemListView = (Windows.UI.Xaml.Controls.ListView)this.FindName("itemListView");
            itemGridView = (Windows.UI.Xaml.Controls.GridView)this.FindName("itemGridView");
            backButton = (Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            pageTitle = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
            FullScreenLandscape = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenLandscape");
            Filled = (Windows.UI.Xaml.VisualState)this.FindName("Filled");
            FullScreenPortrait = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenPortrait");
            Snapped = (Windows.UI.Xaml.VisualState)this.FindName("Snapped");
        }
    }
}



