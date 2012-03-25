using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jcl.Navigate.Model.MetroInterface;
using Jcl.Navigate.Model.MetroInterface.Design;
using Jcl.Navigate.Model.TubeLine;
using Jcl.Navigate.ViewModel.Common;
using Jcl.Navigate.ViewModel.Design;
using Windows.UI.Xaml;

namespace Jcl.Navigate.ViewModel
{
    [Export(ViewModelTypes.HubPageViewModel)]
    public class HubPageViewModel : BindableBase
    {
        public HubPageViewModel()
        {
            //detect design-time
            bool designTime = Windows.ApplicationModel.DesignMode.DesignModeEnabled;

            if (designTime)
                HubPageStructureService = new DesignHubPageStructureService();
            else
                HubPageStructureService = new DesignHubPageStructureService();

            _hubPage = HubPageStructureService.LoadHubPage();

            var lineStatusRepository = new LineStatusRepository();
            LineStatusViewModel = new LineStatusViewModel(lineStatusRepository);

            Groups = _hubPage.TileGroups.ToList();
        }
        private HubPage _hubPage;
        private List<HubPageTileGroup> _groups;
        public IHubPageStructureService HubPageStructureService { get; set; }
        public LineStatusViewModel LineStatusViewModel { get; set; }
       

        public List<HubPageTileGroup> Groups
        {
            get { return _groups; }
            set { SetProperty(ref _groups, value); }
        }

        // Using a DependencyProperty as the backing store for LineStatuses.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GroupsProperty =
            DependencyProperty.Register("Groups", typeof(List<HubPageTileGroup>), typeof(HubPageViewModel), null);



        public void OnImportsSatisfied()
        {
            _hubPage = HubPageStructureService.LoadHubPage();
            Groups = _hubPage.TileGroups.ToList();
        }
    }
}
