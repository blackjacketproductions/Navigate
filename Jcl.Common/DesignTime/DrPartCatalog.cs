using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;

namespace Jcl.Common.DesignTime
{
    public class DrPartCatalog : ComposablePartCatalog
    {

        private readonly ComposablePartCatalog _catalog;
        private readonly bool _designTime;
        public bool DesignTime
        {
            get
            {
                return _designTime;
            }
        }

        /// <summary> 
        /// Creates a new DRPartCatalog around an existing catalog. 
        /// The catalog that this class decorates is provides in the constructor 
        /// paramater "catalog". The "DesignTime" property is set to false.
        /// </summary> 
        public DrPartCatalog(ComposablePartCatalog catalog)
        {
            _catalog = catalog;
        }

        /// <summary> 
        /// Creates a new DRPartCatalog around an existing catalog. 
        /// The catalog that this class decorates is provides in the constructor 
        /// paramater "catalog". The "designTime" parameter controls sets the "DesignTime"
        /// property which is used to control the import satisfaction
        /// </summary> 
        public DrPartCatalog(ComposablePartCatalog catalog, bool designTime)
        {
            _designTime = designTime;
            _catalog = catalog;
        }

       

        /// <summary>
        /// Returns the exports in the catalog that match a given definition of an import.
        /// This method is called every time MEF tries to satisfy an import.
        ///</summary>
        public override IEnumerable<Tuple<ComposablePartDefinition, ExportDefinition>> GetExports(ImportDefinition importDef)
        {
            // If ImportMany is defined and we are at design-time the use the standard bahavior and return
            // all matching exports.
            if (importDef.Cardinality == ImportCardinality.ZeroOrMore && DesignTime)
            {
                return base.GetExports(importDef);
            }

            //otherwise we have to do our own logic
            IList<Tuple<ComposablePartDefinition, ExportDefinition>> result
                = new List<Tuple<ComposablePartDefinition, ExportDefinition>>();

            // Walk through all parts in that catalog...
            foreach (ComposablePartDefinition partDef in Parts)
            {
                // ... and for each part, examine if any export definition matches the
                // requested import definition.
                foreach (ExportDefinition exportDef in partDef.ExportDefinitions)
                {
                    if (importDef.IsConstraintSatisfiedBy(exportDef))
                    {
                        //ok the import definition is satisfied
                        var matchingExport = new Tuple<ComposablePartDefinition, ExportDefinition>(partDef, exportDef);
                        object designTimeMetadata;
                        exportDef.Metadata.TryGetValue("DesignTime", out designTimeMetadata);
                        //if DesignTimeAttribute is set then ToBool returns the assigend value
                        //ohterwise it returns false 
                        bool hasDesignTimeAttribute = ToBool(designTimeMetadata);

                        //If ImportMany is defined and we are at run-time then filter out
                        //design-time exports
                        if (importDef.Cardinality == ImportCardinality.ZeroOrMore)
                        {
                            if (DesignTime || !hasDesignTimeAttribute)
                                result.Add(matchingExport);
                        }
                        //If Import or Import(AllowDefault=true) then prioritize design-time exports
                        //at design-time
                        else
                        {
                            if (DesignTime)
                            {
                                if (result.Count == 0) //also allow run-time exports at design-time
                                    result.Add(matchingExport);
                                else if (hasDesignTimeAttribute) //but prioritize design time data at design time
                                {
                                    result.Clear();
                                    result.Add(matchingExport);
                                }
                            }
                            else
                            {
                                if (!hasDesignTimeAttribute) //only allow run-time exports at run-time
                                    result.Add(matchingExport);
                            }
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Converts an untyped value into a bool. If the object is null
        /// or cannot be converted to an bool, returns false.
        /// </summary>
        protected static bool ToBool(object value)
        {
            if (value == null)
            {
                return false;
            }

            bool result;
            bool.TryParse(value.ToString(), out result);
            return result;
        }

        public override IEnumerator<ComposablePartDefinition> GetEnumerator()
        {
            return _catalog.GetEnumerator();
        }

        public IEnumerable<ComposablePartDefinition> Parts
        {
            get
            {
                var iterator = GetEnumerator();
                while (iterator.MoveNext())
                {
                    yield return iterator.Current;
                }
            }
        }
        
    }
}
