using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Etiqueta:IdentityBase
    {
        public int id_comprobante { get; set; }
        public int id_articulo { get; set; }
        public int etiq_nro { get; set; }
        public int etiq_total { get; set; }
        [ForeignKey("id_comprobante")]
        public virtual Comprobante Comprobante { get; set; }
        [ForeignKey("id_articulo")]
        public virtual Articulo Articulo { get; set; }
    }
}
