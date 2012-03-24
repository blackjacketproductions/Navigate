using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcl.Navigate.Model.MetroInterface
{
    public class HubPageTileGroup
    {
        public int Index { get; set; }
        public string Title { get; set; }

        public IEnumerable<HubPageTileBase> Tiles { get; set; }


    }
}
