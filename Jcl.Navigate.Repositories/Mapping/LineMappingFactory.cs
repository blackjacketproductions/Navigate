using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glue;
using Jcl.Navigate.Domain;
using Jcl.Navigate.Services.Contracts;

namespace Jcl.Navigate.Repositories.Mapping
{
    public class LineMappingFactory : IMappingFactory<Line, LineDto>
    {
        public Mapping<Line, LineDto> GetMapping()
        {
            var mapping = new Mapping<Line, LineDto>();
            mapping.AutoRelateEqualNames();

            return mapping;
        }
    }
}
