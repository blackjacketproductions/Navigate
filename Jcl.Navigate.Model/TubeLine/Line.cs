using System;
using Windows.UI;

namespace Jcl.Navigate.Model.TubeLine
{
    public class Line
    {
       private ILineInfoProvider _lineInfoProvider;

       public Line()
       {
           _lineInfoProvider = new LineInfoProvider();
       }

       public Line(ILineInfoProvider lineInfoProvider)
        {
            _lineInfoProvider = lineInfoProvider;
        }

        public static LineName GetLineNameFromId(int id)
        {
            return (LineName)Enum.ToObject(typeof(LineName) , id);
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public Color AssociatedColor { get { return _lineInfoProvider.GetColorForLine(Line.GetLineNameFromId(Id)); } }
    }
}
