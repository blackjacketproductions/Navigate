using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcl.Navigate.Model.MetroInterface
{
    public class HubPage
    {
        public string Title { get; set; }

        public IEnumerable<HubPageTileGroup> TileGroups { get; set; }
    }
}
