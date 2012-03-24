using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Jcl.Navigate.Model.TubeLine
{
    public interface ILineInfoProvider
    {
        Color GetColorForLine(LineName lineName);
       
    }
}
