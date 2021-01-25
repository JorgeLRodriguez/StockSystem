using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Etiqueta : IdentityBase
    {
        [Column("id_comprobante")]
        public int Comprobante_ID { get; set; }
        [ForeignKey("Comprobante_ID"), Required]
        public virtual Comprobante Comprobante { get; set; }
        [Column("id_articulo")]
        public int Articulo_ID { get; set; }

        [ForeignKey("Articulo_ID"),Required]
        public virtual Articulo Articulo { get; set; }
        public int etiq_nro { get; set; }
        public int etiq_total { get; set; }
    }
}
