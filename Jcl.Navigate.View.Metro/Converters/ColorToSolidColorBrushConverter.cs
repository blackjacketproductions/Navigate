using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Data;
using System.Globalization;
using Windows.UI;

namespace Jcl.Navigate.View.Metro.Converters
{

    public class ColorToSolidColorBrushConverter : IValueConverter
    {
               public object Convert(object value, Type targetType, object parameter, string language)
            {
                var color = (Color)value;

                return new SolidColorBrush {Color = color};

           
             }


               public object ConvertBack(object value, Type targetType, object parameter, string language)
               {
                   return null;
               }


               
    }
}
