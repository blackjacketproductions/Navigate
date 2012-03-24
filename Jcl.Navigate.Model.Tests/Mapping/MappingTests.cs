using System.Linq;
using Jcl.Navigate.Model;
using Jcl.Navigate.Model.Mapping.Dto;
using Jcl.Navigate.Model.TubeLine;
using Jcl.Navigate.Services.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jcl.Navigate.Model.Tests.Mapping
{
    [TestClass]
    public class MappingTests
    {
        private readonly Mappings _mappings = new Mappings();

        [TestMethod]
        public void TestLineStatusMapping()
        {
            var mapping = (_mappings.LineStatusMapping);

            var verification = mapping.GetMapperVerification();
            verification.AssertMapsCorrectlyTowards(new LineStatus());


        }

        [TestMethod]
        public void TestLineMapping()
        {
            var mapping = _mappings.LineMapping;

            var verification = mapping.GetMapperVerification();
            verification.AssertMapsCorrectlyTowards(new Line());
        }

        [TestMethod]
        public void TestBranchDisruptionMapping()
        {
            var mapping = _mappings.BranchDisruptionMapping;

            var verification = mapping.GetMapperVerification();
            verification.AssertMapsCorrectlyTowards(new BranchDisruption());
        }

        [TestMethod]
        public void TestSationMapping()
        {
            var mapping = _mappings.StationMapping;

            var verification = mapping.GetMapperVerification();
            verification.AssertMapsCorrectlyTowards(new Station());
        }

        [TestMethod]
        public void TestStatusMapping()
        {
            var mapping = _mappings.StatusMapping;

            var verification = mapping.GetMapperVerification();
            verification.AssertMapsCorrectlyTowards(new Status());
        }

        [TestMethod]
        public void TestStatusTypeMapping()
        {
            var mapping = _mappings.StatusTypeMapping;

            var verification = mapping.GetMapperVerification();
            verification.AssertMapsCorrectlyTowards(new StatusType());
        }

        [TestMethod]
        public void TestLineStatusResponseMapping()
        {
            var mapping = _mappings.LineStatusResponseMapping;

            var verification = mapping.GetMapperVerification();
            verification.AssertMapsCorrectlyTowards(new LineStatusResponse());
        }

        [TestMethod]
        public void TestCompleteNestedMapping()
        {
            var dtoDesponse = BuildResponseDto();
            
            var domainResponse = new LineStatusResponse();
            _mappings.LineStatusResponseMapping.Map(dtoDesponse, domainResponse);

            // Check Domain object
            Assert.IsTrue(domainResponse.LineStatuses.Count() == 2);

            var ls1 = domainResponse.LineStatuses[0];

            Assert.AreEqual(5, ls1.Id);
            Assert.AreEqual("No service between Camden Town and High Barnet / Mill Hill East due to planned engineering work. GOOD SERVICE on the rest of the line.", ls1.StatusDetails);
            Assert.IsTrue(ls1.BranchDisruptions.Count == 2);

            var dis1 = ls1.BranchDisruptions[0];
            Assert.AreEqual(35, dis1.StationFrom.Id);
            Assert.AreEqual("Camden Town", dis1.StationFrom.Name);
            Assert.AreEqual(106, dis1.StationTo.Id);
            Assert.AreEqual("High Barnet", dis1.StationTo.Name);

            var dis2 = ls1.BranchDisruptions[1];
            Assert.AreEqual(35, dis2.StationFrom.Id);
            Assert.AreEqual("Camden Town", dis2.StationFrom.Name);
            Assert.AreEqual(147, dis2.StationTo.Id);
            Assert.AreEqual("Mill Hill East", dis2.StationTo.Name);

            Assert.AreEqual(5, ls1.Line.Id);
            Assert.AreEqual("Northern", ls1.Line.Name);
            Assert.AreEqual("PC", ls1.Status.Id);
            Assert.AreEqual("Part Closure", ls1.Status.Description);
            Assert.AreEqual("DisruptedService", ls1.Status.CssClass);
            Assert.AreEqual(true, ls1.Status.IsActive);
            Assert.AreEqual(1, ls1.Status.StatusType.Id);
            Assert.AreEqual("Line", ls1.Status.StatusType.Description);

            var ls2 = domainResponse.LineStatuses[1];

            Assert.AreEqual(0, ls2.Id);
            Assert.AreEqual("", ls2.StatusDetails);
            Assert.IsTrue(ls2.BranchDisruptions.Count == 0);
            
            Assert.AreEqual(1, ls2.Line.Id);
            Assert.AreEqual("Bakerloo", ls2.Line.Name);
            Assert.AreEqual("GS", ls2.Status.Id);
            Assert.AreEqual("Good Service", ls2.Status.Description);
            Assert.AreEqual("GoodService", ls2.Status.CssClass);
            Assert.AreEqual(true, ls2.Status.IsActive);
            Assert.AreEqual(1, ls2.Status.StatusType.Id);
            Assert.AreEqual("Line", ls2.Status.StatusType.Description);

        }


        private LineStatusResponseDto BuildResponseDto()
        {
            var response = new LineStatusResponseDto
            {
                LineStatuses = new[]
              {
                 new LineStatusDto
                 {
                    Id = 5,
                    StatusDetails = "No service between Camden Town and High Barnet / Mill Hill East due to planned engineering work. GOOD SERVICE on the rest of the line.",
                    BranchDisruptions = new[]
                    {
                        new BranchDisruptionDto
                            {
                                StationFrom = new StationDto {Id = 35, Name = "Camden Town"},
                                StationTo = new StationDto {Id = 106, Name = "High Barnet"}
                            }, 
                        new BranchDisruptionDto
                            {
                                StationFrom = new StationDto {Id = 35, Name = "Camden Town"},
                                StationTo =  new StationDto {Id = 147, Name = "Mill Hill East"}
                            }, 
                    },
                    Line = new LineDto {Id = 5, Name = "Northern"},
                    Status = new StatusDto
                                 {
                                    Id = "PC",
                                    CssClass = "DisruptedService",
                                    Description = "Part Closure",
                                    IsActive = true,
                                    StatusType = new StatusTypeDto { Id = 1, Description = "Line"}
                                 }
                 },
                 new LineStatusDto
                 {
                    Id = 0,
                    StatusDetails = "",
                    Line = new LineDto {Id = 1, Name = "Bakerloo"},
                    Status = new StatusDto
                                 {
                                    Id = "GS",
                                    CssClass = "GoodService",
                                    Description = "Good Service",
                                    IsActive = true,
                                    StatusType = new StatusTypeDto { Id = 1, Description = "Line"}
                                 }
                 }

            }

            };
            return response;

        }
    }


}
