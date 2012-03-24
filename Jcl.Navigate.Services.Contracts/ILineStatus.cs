using System.ServiceModel;
using System.Threading.Tasks;

//using System.ServiceModel.Web;

namespace Jcl.Navigate.Services.Contracts
{
    [ServiceContract]
    [XmlSerializerFormat]
    public interface ILineStatus
    {
        [OperationContract]
        LineStatusResponseDto GetLineStatuses();
    }
}
