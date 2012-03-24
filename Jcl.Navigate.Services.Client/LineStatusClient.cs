using System.IO;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Jcl.Navigate.Services.Contracts;

namespace Jcl.Navigate.Services.Client
{
    public class LineStatusClient : ILineStatus
    {
        public LineStatusResponseDto GetLineStatuses()
        {
            using (var client = new HttpClient())
            {

                var response = client.GetAsync("http://cloud.tfl.gov.uk//TrackerNet/LineStatus").Result;
                var s = new XmlSerializer(typeof(LineStatusResponseDto));
                object s2 = s.Deserialize(response.Content.ReadAsStreamAsync().Result);
                return ((LineStatusResponseDto)s2);
            }

             
        }

    }
}
