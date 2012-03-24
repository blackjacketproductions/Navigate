using Jcl.Navigate.Domain;
using Jcl.Navigate.Services.Contracts;
using Glue;

namespace Jcl.Navigate.Repositories.Mapping
{
    public class Mappings
    {
        private Mapping<LineStatus, LineStatusDto> _lineStatusMapping;
        private Mapping<Line, LineDto> _lineMapping;
        private Mapping<BranchDisruption, BranchDisruptionDto> _branchDisruptionMapping;
        private Mapping<Station, StationDto> _stationMapping;
        private Mapping<Status, StatusDto> _statusMapping;
        private Mapping<StatusType, StatusTypeDto> _statusTypeMapping;
        private Mapping<LineStatusResponse, LineStatusResponseDto> _lineStatusResponseMapping; 

        public Mappings()
        {
            PopulateMappings();
        }

        private void PopulateMappings()
        {
            _lineMapping = new LineMappingFactory().GetMapping();
            
            
            _stationMapping = new StationMappingFactory().GetMapping();
            _statusTypeMapping = new StatusTypeMappingFactory().GetMapping();
            _statusMapping = new StatusMappingFactory(_statusTypeMapping).GetMapping();

            _branchDisruptionMapping = new BranchDisruptionMappingFactory(_stationMapping).GetMapping();
            _lineStatusMapping = new LineStatusMappingFactory(_branchDisruptionMapping, _statusMapping, _lineMapping).GetMapping();
            _lineStatusResponseMapping = new LineStatusResponseMappingFactory(_lineStatusMapping).GetMapping();
        }

        public Mapping<LineStatus, LineStatusDto> LineStatusMapping{ get { return _lineStatusMapping; }}
        public Mapping<Line, LineDto> LineMapping { get { return _lineMapping;} }
        public Mapping<BranchDisruption, BranchDisruptionDto> BranchDisruptionMapping { get { return _branchDisruptionMapping; } }
        public Mapping<Station, StationDto> StationMapping { get { return _stationMapping; } }
        public Mapping<Status, StatusDto> StatusMapping { get { return _statusMapping; } }
        public Mapping<StatusType, StatusTypeDto> StatusTypeMapping { get { return _statusTypeMapping; } }
        public Mapping<LineStatusResponse, LineStatusResponseDto> LineStatusResponseMapping { get { return _lineStatusResponseMapping; } }
    }
}
