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

        /// <summary>
        /// Devuelve o establece el path donde se guardará el log de errores.
        /// </summary>
        public string LogPath { get; set; }
    }
}
