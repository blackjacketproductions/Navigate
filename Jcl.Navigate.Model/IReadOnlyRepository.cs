using System.Collections.Generic;
using Jcl.Navigate.Model.Specification;

namespace Jcl.Navigate.Model
{
    public interface IReadOnlyRepository<T, V> where V : class 
    {
        IEnumerable<V> FindAll();
        V Find(T key);
        IList<T> FindBySpec(ISpecification<V> specification);
    }
    
}
