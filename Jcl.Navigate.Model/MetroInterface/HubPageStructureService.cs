using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Jcl.Navigate.Model.MetroInterface
{
    [Export(typeof(IHubPageStructureService))]
    public class HubPageStructureService : IHubPageStructureService
    {
        public HubPage LoadHubPage()
        {
            var designHubPage = new HubPage();

            var groups = new List<HubPageTileGroup>();
            groups.Add(new HubPageTileGroup());
            groups.Add(new HubPageTileGroup());
            groups.Add(new HubPageTileGroup());

            designHubPage.TileGroups = groups;

            return designHubPage;
        }
    }
}