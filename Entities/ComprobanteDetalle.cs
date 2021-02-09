using Entities.Security;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ComprobanteDetalle : IdentityBase, IDigitoVerificadorHorizontal
    {
		[Column("id_comprobante"), Required]
		public int Comprobante_ID { get; set; }
		[ForeignKey("Comprobante_ID"),Required]
        public virtual Comprobante Comprobante { get; set; }
        public int linea { get; set; }
		[Column("id_articulo"),DatoSensible]
		public int Articulo_ID { get; set; }
		[ForeignKey("Articulo_ID"),Required]
		public virtual Articulo Articulo { get; set; }
        [DatoSensible]
        public int cantidad { get; set; }
		//[DatoSensible]
		public int ?id_tipo_rechazo { get; set; }
		public int ?id_pallet { get; set; }
        public byte[] DVH { get; set; }
    }
}
