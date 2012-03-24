using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jcl.Navigate.Services.Contracts
{

    [XmlRoot("ArrayOfLineStatus", Namespace = "http://webservices.lul.co.uk/")]
    public class LineStatusResponseDto
    {
        
        [XmlElement("LineStatus")]
        public LineStatusDto[] LineStatuses { get; set; }
    }
}
