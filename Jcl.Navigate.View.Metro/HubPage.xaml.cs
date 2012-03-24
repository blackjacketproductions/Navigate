using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Jcl.Navigate.Model.TubeLine;
using Jcl.Navigate.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

namespace Jcl.Navigate.View.Metro
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class HubPage : Jcl.Navigate.View.Metro.Common.LayoutAwarePage
    {
        public HubPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property provides the grouped collection of items to be displayed.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           // lineStatusList.DataContext = new LineStatusViewModel(new LineStatusRepository());
            //this.DefaultViewModel["Groups"] = e.Parameter;
        }
    }
}
