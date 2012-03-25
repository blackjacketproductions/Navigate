using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Jcl.Navigate.View.Metro.Converters
{
    public class ColorToSolidColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var color = (Windows.UI.Color)value;

            return new SolidColorBrush { Color = color };


        }


        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }



    }
}
