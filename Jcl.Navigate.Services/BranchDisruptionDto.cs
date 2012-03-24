using System.Runtime.Serialization;

namespace Jcl.Navigate.Services.Contracts
{
    [DataContract]
    public class BranchDisruptionDto
    {
        // TODO: Investigate Branch Disruptions are these used elsewhere ?? (Not used in line status feed)
        [DataMember]
        public string Description { get; set; }
    }
}
