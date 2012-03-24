using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Jcl.Navigate.Services.Contracts
{

    public class LineDto
    {
        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
    }
}
