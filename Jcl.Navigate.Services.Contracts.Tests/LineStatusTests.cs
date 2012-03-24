using System.IO;
using System.Resources;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Jcl.Navigate.Services.Contracts;
using Windows.ApplicationModel.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jcl.Navigate.Services.Contracts.Tests
{
    [TestClass]
    public class LineStatusTests
    {
        [TestMethod]
        public void TestDeserialisationOfLineStatus()
        {
            var lineStatuses = BuildStatuses();

            
                // Test the 8th element it has an instance of all elements/attributes
            var testLineStatus = lineStatuses[7];


            Assert.AreEqual(5, testLineStatus.Id, "LineStatus Id incorrect");
            Assert.AreEqual("No service between Camden Town and High Barnet / Mill Hill East due to planned engineering work. GOOD SERVICE on the rest of the line.", testLineStatus.StatusDetails, "Service Details are incorrect.");
            Assert.AreEqual(2, testLineStatus.BranchDisruptions.Length, "There should be 2 disruptions");

            var testDisruption = testLineStatus.BranchDisruptions[0];

            Assert.AreEqual(35, testDisruption.StationFrom.Id, "FromStation Id is incorrect");
            Assert.AreEqual("Camden Town", testDisruption.StationFrom.Name, "FromStation Name is incorrect");
            Assert.AreEqual(106, testDisruption.StationTo.Id, "ToStation Id is incorrect");
            Assert.AreEqual("High Barnet", testDisruption.StationTo.Name, "ToStation Name is incorrect");
        }

        private LineStatusDto[] BuildStatuses()
        {
            var rm = new ResourceLoader();
            var xmlResponseString =   rm.GetString("TestLineStateXmlResponse");

            var s = new XmlSerializer(typeof(LineStatusResponseDto));
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlResponseString);
            var stream = new MemoryStream(byteArray);
            object s2 = s.Deserialize(stream);

            return ((LineStatusResponseDto) s2).LineStatuses;
        }
    }
}
