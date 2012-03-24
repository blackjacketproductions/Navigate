using Jcl.Navigate.Domain;
using Jcl.Navigate.Services.Contracts;
using Glue;

namespace Jcl.Navigate.Repositories.Mapping
{
    public class LineStatusMappingFactory : IMappingFactory<LineStatus, LineStatusDto>
    {
        private readonly Mapping<BranchDisruption, BranchDisruptionDto> _branchDisruptionMapping;
        private readonly Mapping<Status, StatusDto> _statusMapping;
        private readonly Mapping<Line, LineDto> _lineMapping;

        public LineStatusMappingFactory(Mapping<BranchDisruption, BranchDisruptionDto> branchDisruptionMapping,
                                        Mapping<Status, StatusDto> statusMapping,
                                        Mapping<Line, LineDto> lineMapping)
        {
            _branchDisruptionMapping = branchDisruptionMapping;
            _statusMapping = statusMapping;
            _lineMapping = lineMapping;
        }

        public Mapping<LineStatus, LineStatusDto> GetMapping()
      {
          var mapping = new Mapping<LineStatus, LineStatusDto>(x=> new LineStatus(), x=> new LineStatusDto());
          mapping.AddConverter(_lineMapping);
          mapping.AddConverter(_statusMapping);
          mapping.Relate(domain => domain.BranchDisruptions, dto => dto.BranchDisruptions, _branchDisruptionMapping);
          mapping.AutoRelateEqualNames();

          return mapping;
      }
    }
}
