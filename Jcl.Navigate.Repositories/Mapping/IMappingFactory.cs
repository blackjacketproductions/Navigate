using Glue;

namespace Jcl.Navigate.Repositories.Mapping
{
    public interface IMappingFactory<TDomainEntity, TDto>
    {
        Mapping<TDomainEntity, TDto> GetMapping();
    }
}
