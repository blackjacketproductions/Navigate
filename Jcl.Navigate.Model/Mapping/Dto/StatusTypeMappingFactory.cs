using Jcl.Navigate.Services.Contracts;
using Glue;

namespace Jcl.Navigate.Model.Mapping.Dto
{
    public class StatusTypeMappingFactory : IMappingFactory<StatusType, StatusTypeDto>
    {
        public Mapping<StatusType, StatusTypeDto> GetMapping()
        {
            var mapping = new Mapping<StatusType, StatusTypeDto>(x=> new StatusType(), x=> new StatusTypeDto());
            mapping.AutoRelateEqualNames();

            return mapping;
        }
    }
}
