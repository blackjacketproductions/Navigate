using System;
using System.Collections.Generic;
using Jcl.Navigate.Domain;
using Jcl.Navigate.Repositories.Mapping;
using Jcl.Navigate.Services.Clients;

namespace Jcl.Navigate.Repositories
{
    public class LineStatusRepository : ILineStatusRepository
    {
        private readonly Mappings _mappings;

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
            lineStatusClient.Close();
            
            var lineStatusResponse = new LineStatusResponse();

            _mappings.LineStatusResponseMapping.Map(lineStatusResponseDto, lineStatusResponse);

            return lineStatusResponse.LineStatuses;

        }
    }
}
