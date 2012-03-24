using System;
using System.Collections.Generic;
using Jcl.Navigate.Model;
using Jcl.Navigate.Model.Mapping.Dto;
using Jcl.Navigate.Model.Specification;
using Jcl.Navigate.Services.Client;

namespace Jcl.Navigate.Model.TubeLine
{
    public class LineStatusRepository : ILineStatusRepository
    {
        private readonly Mappings _mappings;

        public LineStatusRepository()
        {
            _mappings = new Mappings();
        }

        public LineStatusRepository(Mappings mappings)
        {
            _mappings = mappings;
        }
        
        public IEnumerable<LineStatus> FindAll()
        {
            return GetAllLineStatuses();
        }

        public LineStatus Find(int lineId)
        {
            throw new NotImplementedException();
        }


        public IList<int> FindBySpec(ISpecification<LineStatus> specification)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<LineStatus> GetAllLineStatuses()
        {
            var lineStatusClient = new LineStatusClient();

            var lineStatusResponseDto = lineStatusClient.GetLineStatuses();
            
            var lineStatusResponse = new LineStatusResponse();

            _mappings.LineStatusResponseMapping.Map(lineStatusResponseDto, lineStatusResponse);

            return lineStatusResponse.LineStatuses;

        }
    }
}
