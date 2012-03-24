using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jcl.Navigate.Services.Contracts
{
    [DataContract]
    public class StatusDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CssClass { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public StatusTypeDto StatusType { get; set; }
    }
}
