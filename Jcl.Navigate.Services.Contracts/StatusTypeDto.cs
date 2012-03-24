using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Jcl.Navigate.Services.Contracts
{
    //[DataContract(Name = "StatusType", Namespace = "")]
    public class StatusTypeDto
    {
        [XmlAttribute("ID")]
        //[DataMember(Name = "ID")]
        public int Id { get; set; }

        [XmlAttribute("Description")]
        //[DataMember (Name = "Description")]
        public string Description { get; set; }
    }
}
