using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcl.Navigate.Model.MetroInterface
{
    public class HubPageTileBase : IResizable
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
