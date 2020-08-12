using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Articulo : IdentityBase
    {
        public string Codigo_fs { get; set; }
        public string Descripcion { get; set; }
        public int id_cliente { get; set; }
        public string codigo_barra { get; set; }
        public bool tiene_codigo_barra { get; set; }
    }
}
