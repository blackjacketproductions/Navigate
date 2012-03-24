using Jcl.Navigate.Domain;
using Jcl.Navigate.Services.Contracts;
using Glue;
namespace Jcl.Navigate.Repositories.Mapping
{
    public class StatusMappingFactory : IMappingFactory<Status, StatusDto>
    {
        private readonly Mapping<StatusType, StatusTypeDto> _statusTypeMapping;
        public StatusMappingFactory(Mapping<StatusType, StatusTypeDto> statusTypeMapping)
        {
            _statusTypeMapping = statusTypeMapping;
        }

        public Mapping<Status, StatusDto> GetMapping()
        {
            var mapping = new Mapping<Status, StatusDto>(x=> new Status(), x=> new StatusDto());
            mapping.AddConverter(_statusTypeMapping);

            mapping.AutoRelateEqualNames();

            return mapping;
        }
    }
}
