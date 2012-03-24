using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcl.Common.DesignTime
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DesignTimeExportAttribute : ExportAttribute
    {
        #region Constructors
        public DesignTimeExportAttribute()
        {
            DesignTime = false;
        }

        public DesignTimeExportAttribute(Type contractType)
            : base(contractType)
        {
            DesignTime = false;
        }

        public DesignTimeExportAttribute(string contractName)
            : base(contractName)
        {
            DesignTime = false;
        }

        public DesignTimeExportAttribute(string contractName, Type contractType)
            : base(contractName, contractType)
        {
            DesignTime = false;
        }
        #endregion

        [DefaultValue(false)]
        public bool DesignTime
        {
            get;
            set;
        }
    }
}
