using System.Collections.Generic;

namespace Jcl.Navigate.Domain
{
    public class LineStatus
    {
        public LineStatus()
        {
            Line = new Line();
            Status = new Status();
            BranchDisruptions = new List<BranchDisruption>();
        }

        public string StatusDetails { get; set; }

        public int Id { get; set; }

        public List<BranchDisruption> BranchDisruptions { get; set; }

        public Line Line { get; set; }

        public Status Status { get; set; }
    }
}
