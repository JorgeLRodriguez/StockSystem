using Entities.Infraestructure;
using Entities.Security;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ComprobanteDetalle : IdentityBase, IDigitoVerificadorHorizontal
    {
		[Column("id_comprobante"), RegularExpression("^[0-9]*$")]
		[Display(Name = ConstantesTexto.Comprobante)]
		public int Comprobante_ID { get; set; }
		[ForeignKey("Comprobante_ID")]
        public virtual Comprobante Comprobante { get; set; }
		[Required, DatoSensible, RegularExpression("^[0-9]*$"), Range(1, int.MaxValue)]
		[Display(Name = ConstantesTexto.Linea)]
		public int linea { get; set; }
		[Column("id_articulo"), DatoSensible, RegularExpression("^[0-9]*$"), Range(1, int.MaxValue), Required]
        [Display(Name = ConstantesTexto.Articulo)]
        public int Articulo_ID { get; set; }
		[ForeignKey("Articulo_ID")]
		public virtual Articulo Articulo { get; set; }
        [DatoSensible, RegularExpression("^[0-9]*$"), Range(1, int.MaxValue)]
		[Display(Name = ConstantesTexto.Cantidad)]
        public int cantidad { get; set; }
		public int ?id_tipo_rechazo { get; set; }
		public int ?id_pallet { get; set; }
        public byte[] DVH { get; set; }
    }
}
