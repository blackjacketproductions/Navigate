using Jcl.Navigate.Domain;
using Jcl.Navigate.Services.Contracts;
using Glue;

namespace Jcl.Navigate.Repositories.Mapping
{
    public class LineStatusResponseMappingFactory : IMappingFactory<LineStatusResponse, LineStatusResponseDto>
    {
        private readonly Mapping<LineStatus, LineStatusDto> _lineStatusMapping;

        public LineStatusResponseMappingFactory(Mapping<LineStatus, LineStatusDto> lineStatusMapping)
        {
            _lineStatusMapping = lineStatusMapping;
        }

        public Mapping<LineStatusResponse, LineStatusResponseDto> GetMapping()
        {
            var mapping = new Mapping<LineStatusResponse, LineStatusResponseDto>();
            mapping.Relate(domain => domain.LineStatuses, dto => dto.LineStatuses, _lineStatusMapping);
            mapping.AutoRelateEqualNames();

            return mapping;
        }
    }
}
