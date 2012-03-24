using Jcl.Navigate.Services.Contracts;
using Glue;

namespace Jcl.Navigate.Model.Mapping.Dto
{
    public class StationMappingFactory : IMappingFactory<Station, StationDto>
    {
        public Mapping<Station, StationDto> GetMapping()
        {
            var mapping = new Mapping<Station, StationDto>();
            mapping.AutoRelateEqualNames();

            return mapping;
        }
    }
}
