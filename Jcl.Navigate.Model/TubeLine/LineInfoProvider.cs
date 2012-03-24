using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Jcl.Navigate.Model.TubeLine
{
    public class LineInfoProvider : ILineInfoProvider
    {
        public Color GetColorForLine(LineName lineName)
        {
            switch (lineName)
            {
                case LineName.Bakerloo:
                    return new Color {R = 137, G = 78, B = 36, A = 100 };
                    break;
                case LineName.Central:
                    return new Color {R = 220, G = 36, B = 31, A = 100 };
                    break;
                case LineName.Circle:
                    return new Color {R = 255, G = 206, B = 0, A = 100 };
                    break;
                case LineName.District:
                    return new Color {R = 0, G = 114, B = 41, A = 100 };
                    break;
                case LineName.HammersmithCity:
                    return new Color {R = 215, G = 153, B = 175, A = 100 };
                    break;
                case LineName.Jubilee:
                    return new Color {R = 134, G = 143, B = 152, A = 100 };
                    break;
                case LineName.Metropolitan:
                    return new Color {R = 117, G = 16, B = 86, A = 100 };
                    break;
                case LineName.Northern:
                    return new Color {R = 0, G = 0, B = 0, A = 100 };
                    break;
                case LineName.Piccadilly:
                    return new Color {R = 0, G = 25, B = 168, A = 100 };
                    break;
                case LineName.Victoria:
                    return new Color { R = 0, G = 160, B = 226, A = 100 };
                    break;
                case LineName.WaterlooCity:
                    return new Color { R = 118, G = 208, B = 189, A = 100 };
                    break;
                case LineName.Overground:
                    return new Color { R = 232, G = 106, B = 16, A = 100 };
                    break;
                case LineName.Dlr:
                    return new Color { R = 0, G = 175, B = 173, A = 100 };
                    break;
                default:
                    // Shouldn't get here
                    return new Color { R = 255, G = 255, B = 255 };


            }
        }

       


    }
}
