using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Jcl.Navigate.Services.Contracts
{
    public class BranchDisruptionDto
    {
        [XmlElement("StationTo")]
        public StationDto StationTo { get; set; }

        [XmlElement("StationFrom")]
        public StationDto StationFrom { get; set; }
    }
}
