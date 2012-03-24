using System.Xml.Serialization;

namespace Jcl.Navigate.Services.Contracts
{
    public class LineStatusDto
    {
        public LineStatusDto()
        {
            BranchDisruptions = new BranchDisruptionDto[0];
        }

        [XmlAttribute("StatusDetails")]
        public string StatusDetails { get; set; }

        [XmlAttribute("ID")]
        public int Id { get; set; }
        
        [XmlArray("BranchDisruptions")]
        [XmlArrayItem("BranchDisruption")]
        public BranchDisruptionDto[] BranchDisruptions { get; set; }

        [XmlElement("Line")]
        public LineDto Line { get; set; }

        [XmlElement("Status")]
        public StatusDto Status { get; set; }
        
    }
}
