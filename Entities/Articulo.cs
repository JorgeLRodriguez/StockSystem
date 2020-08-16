using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Articulo : IdentityBase
    {
        public int id_cliente { get; set; }
        public string Codigo_fs { get; set; }
        public string Descripcion { get; set; }
        public string codigo_barra { get; set; }
        public bool tiene_codigo_barra { get; set; }
    }
}
