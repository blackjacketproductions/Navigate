using System.Runtime.Serialization;

namespace Jcl.Navigate.Services.Contracts
{
    [DataContract]
    public class LineDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
