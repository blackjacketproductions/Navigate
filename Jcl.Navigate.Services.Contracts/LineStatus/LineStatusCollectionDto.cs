﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jcl.Navigate.Services.Contracts
{

    //[XmlRoot("ArrayOfLineStatus")]
    //[CollectionDataContract(Name = "ArrayOfLineStatus", Namespace = "http://webservices.lul.co.uk/")]
    public class LineStatusCollectionDto : List<LineStatusDto>
    {
    }
}
