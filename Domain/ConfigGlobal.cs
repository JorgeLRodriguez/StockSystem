using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ConfigGlobal
    {
        #region "Singleton"

        private static readonly Lazy<ConfigGlobal> DefaultInstance = new Lazy<ConfigGlobal>(() => new ConfigGlobal());

        public static ConfigGlobal Instance
        {
            get { return DefaultInstance.Value; }
        }

        #endregion
    }
}
