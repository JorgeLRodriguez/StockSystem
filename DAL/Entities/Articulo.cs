using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }
        public string Codigo_fs { get; set; }
        public string Descripcion { get; set; }
        public int IdCliente { get; set; }
        public string codigo_barra { get; set; }
        public bool tiene_codigo_barra { get; set; }
    }
}
