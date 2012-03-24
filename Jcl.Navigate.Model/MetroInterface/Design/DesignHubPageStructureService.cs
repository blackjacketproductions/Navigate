using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jcl.Common.DesignTime;

namespace Jcl.Navigate.Model.MetroInterface.Design
{
    [Export(typeof(IHubPageStructureService))]
    [DesignTimeExport(DesignTime = true)] 
    public class DesignHubPageStructureService : IHubPageStructureService
    {
       public HubPage LoadHubPage()
       {
           var designHubPage = new HubPage();

           var groups = new List<HubPageTileGroup>();
           var favGroup = new HubPageTileGroup();
           var favGroupTiles = new List<HubPageTileBase>();
           
           favGroupTiles.Add(new HubPageTileIcon() {Height = 1, Width = 1, Name ="Favourite1"});
           favGroupTiles.Add(new HubPageTileIcon() { Height = 1, Width = 1, Name = "Favourite2" });
           favGroupTiles.Add(new HubPageTileIcon() { Height = 1, Width = 1, Name = "Favourite3" });
           favGroupTiles.Add(new HubPageTileIcon() { Height = 1, Width = 1, Name = "Favourite4" });

           favGroup.Title = "Favourites";
           favGroup.Index = 0;
           favGroup.Tiles = favGroupTiles;
           
          groups.Add(favGroup);
           groups.Add(new HubPageTileGroup() { Title = "Bus" });
           groups.Add(new HubPageTileGroup() { Title = "Tube" });
           groups.Add(new HubPageTileGroup());
           groups.Add(new HubPageTileGroup());
           groups.Add(new HubPageTileGroup());

           designHubPage.TileGroups = groups;

           return designHubPage;

       }
    }
}
