using System.Runtime.Serialization;


namespace Jcl.Navigate.Services.Contracts
{
    [DataContract]
    public class LineStatusDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string StatusDetails { get; set; }

        [DataMember]
        public LineDto Line { get; set; }

        [DataMember]
        public StatusDto Status { get; set; }

        // Not currently used
        [IgnoreDataMember]
        public BranchDisruptionDto[] BranchDisruptions { get; set; }

        
    }
}
