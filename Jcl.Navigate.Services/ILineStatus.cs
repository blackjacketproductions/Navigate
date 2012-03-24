using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web

using System.Text;
using System.Threading.Tasks;

namespace Jcl.Navigate.Services.Contracts
{
    [ServiceContract]
    public interface ILineStatus
    {
        [OperationContract]
        [WebGet(UriTemplate = "/TrackerNet/LineStatus")]
        System.ServiceModel.Web.WebInvokeAttribute


        public LineStatusDto[] GetLineStatuses();
    }
}
