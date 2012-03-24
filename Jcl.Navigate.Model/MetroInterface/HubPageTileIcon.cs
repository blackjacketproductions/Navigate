using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Jcl.Navigate.Model.MetroInterface
{
    public class HubPageTileIcon : HubPageTileBase
    {
        public string ImagePath { get; set; }
        
        public ImageSource Image
        {
            get
            {
                return new BitmapImage(new Uri("ms-appx://" + this.ImagePath));
            }
        }
    }
}
