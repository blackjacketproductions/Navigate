using System.Xml.Serialization;

namespace Jcl.Navigate.Services.Contracts
{
    public class StationDto
    {
        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
    }
}
