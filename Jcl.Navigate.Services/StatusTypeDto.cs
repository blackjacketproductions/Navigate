using System.Runtime.Serialization;

namespace Jcl.Navigate.Services.Contracts
{
    [DataContract]
    public class StatusTypeDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
