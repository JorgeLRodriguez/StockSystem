using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ComprobanteDetalle : IdentityBase
    {
		[Column("id_comprobante")]
		public int Comprobante_ID { get; set; }
		[ForeignKey("Comprobante_ID"),Required]
        public virtual Comprobante Comprobante { get; set; }
        public int linea { get; set; }
		[Column("id_articulo")]
		public int Articulo_ID { get; set; }
		[ForeignKey("Articulo_ID"),Required]
		public virtual Articulo Articulo { get; set; }
		public int cantidad { get; set; }
		public int ?id_tipo_rechazo { get; set; }
		public int ?id_pallet { get; set; }
	}
}
