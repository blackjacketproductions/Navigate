using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glue;
using Jcl.Navigate.Services.Contracts;
using Jcl.Navigate.Model.TubeLine;

namespace Jcl.Navigate.Model.Mapping.Dto
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
