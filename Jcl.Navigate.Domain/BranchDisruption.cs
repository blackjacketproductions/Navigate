﻿namespace Jcl.Navigate.Domain
{
    public class BranchDisruption
    {
        public BranchDisruption()
        {
            StationTo = new Station();
            StationFrom = new Station();
        }

        public Station StationTo { get; set; }

        public Station StationFrom { get; set; }
    }
}
