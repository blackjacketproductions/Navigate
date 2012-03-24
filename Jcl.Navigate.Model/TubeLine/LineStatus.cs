using System.Collections.Generic;
using Jcl.Navigate.Model;
using Windows.UI;

namespace Jcl.Navigate.Model.TubeLine
{
    public class LineStatus
    {
        private ILineInfoProvider _lineInfoProvider;

        public LineStatus(ILineInfoProvider lineInfoProvider)
        {
            _lineInfoProvider = lineInfoProvider;
            Line = new Line();
            Status = new Status();
            BranchDisruptions = new List<BranchDisruption>();
        }

        public LineStatus() :this(new LineInfoProvider())
        {
           
        }

        public string StatusDetails { get; set; }

        public int Id { get; set; }

        public List<BranchDisruption> BranchDisruptions { get; set; }

        public Line Line { get; set; }

        public Status Status { get; set; }

        public Color Color { get { return _lineInfoProvider.GetColorForLine((LineName)Line.Id); } }
    }
}
