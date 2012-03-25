using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jcl.Navigate.Model.MetroInterface;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Jcl.Navigate.View.Metro
{
    public class HubPageTileTemplateSelector : DataTemplateSelector
    {
        public DataTemplate IconTileTemplate { get; set; }
        public DataTemplate LineStatusTileTemplate { get; set; }
       
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            HubPageTileBase tile = (HubPageTileBase)item;

            if (tile is HubPageTileIcon)
            {
                return IconTileTemplate;
            }

            if (tile is HubPageTileLive)
            {
                var liveTile = (HubPageTileLive)tile;
                switch (liveTile.Type)
                {
                    case LiveTileType.LineStatus:
                        return LineStatusTileTemplate;
                        break;

                }

            }

            //Default
            return base.SelectTemplateCore(item, container);
            
        }
    }
}
