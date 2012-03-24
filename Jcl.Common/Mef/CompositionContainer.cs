using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcl.Common.Mef
{
   public class CompositionContainer
{
    private readonly CompositionService _service;

    public CompositionContainer(CompositionService service)
    {
        _service = service;
    }

    public T GetExportedValue<T>()
    {
        var factoryProvider = new FactoryProvider<T>();
        _service.SatisfyImportsOnce(factoryProvider);
        return factoryProvider.Factory.CreateExport().Value;
    }

    private class FactoryProvider<T>
    {
        [Import]
        public ExportFactory<T> Factory;
    }
}
}
