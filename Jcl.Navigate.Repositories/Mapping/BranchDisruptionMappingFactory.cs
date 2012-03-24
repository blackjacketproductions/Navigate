using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jcl.Navigate.Domain;
using Jcl.Navigate.Services.Contracts;
using Glue;

namespace Jcl.Navigate.Repositories.Mapping
{
    public class BranchDisruptionMappingFactory : IMappingFactory<BranchDisruption, BranchDisruptionDto>
    {
        private readonly Mapping<Station, StationDto> _stationMapping;

        public BranchDisruptionMappingFactory(Mapping<Station, StationDto> stationMapping)
        {
            _stationMapping = stationMapping;
        }
        public Mapping<BranchDisruption, BranchDisruptionDto> GetMapping()
        {
            var mapping = new Mapping<BranchDisruption, BranchDisruptionDto>(x=> new BranchDisruption(), x=> new BranchDisruptionDto());
            mapping.AddConverter(_stationMapping);
            //mapping.Relate(domain => domain.StationFrom.Id, dto => dto.StationFrom.Id);
            //mapping.Relate(domain => domain.StationTo.Id, dto => dto.StationTo.Id);
            //mapping.Relate(domain => domain.StationFrom.Name, dto => dto.StationFrom.Name);
            //mapping.Relate(domain => domain.StationTo.Name, dto => dto.StationTo.Name);

            mapping.AutoRelateEqualNames();

            return mapping;

        }
    }
}
