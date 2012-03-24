using Glue;

namespace Jcl.Navigate.Model.Mapping.Dto
{
    public interface IMappingFactory<TDomainEntity, TDto>
    {
        Mapping<TDomainEntity, TDto> GetMapping();
    }
}
