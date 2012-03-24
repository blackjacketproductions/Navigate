using System.Collections.Generic;

namespace Jcl.Navigate.Repositories
{
    public interface IReadOnlyRepository<T, V> where V : class 
    {
        IEnumerable<V> FindAll();
        V Find(T key);
        IList<T> FindBySpec(ISpecification<V> specification);
    }
    
}
