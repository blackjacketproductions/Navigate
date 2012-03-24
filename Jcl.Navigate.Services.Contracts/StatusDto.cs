using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jcl.Navigate.Services.Contracts
{
    public class StatusDto
    {
        [XmlAttribute("ID")]
        public string Id { get; set; }
        
        [XmlAttribute("CssClass")]
        public string CssClass { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }

        [XmlAttribute("IsActive")]
        public bool IsActive { get; set; }

        [XmlElement("StatusType")]
        public StatusTypeDto StatusType { get; set; }
    }
}
