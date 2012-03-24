using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jcl.Navigate.Services.Contracts;

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
            var xmlResponseString = Resources.TestLineStateXmlResponse;

            var s = new XmlSerializer(typeof(LineStatusResponseDto));
            byte[] byteArray = Encoding.ASCII.GetBytes(xmlResponseString);
            var stream = new MemoryStream(byteArray);

            object s2 = s.Deserialize(new XmlTextReader(stream));

            return ((LineStatusResponseDto) s2).LineStatuses;
        }
    }
}
