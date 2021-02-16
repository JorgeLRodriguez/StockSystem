using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class RemitoStock : IdentityBase
    {
		[Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:yyyy/MM/dd}")]
		public DateTime fecha_remito { get; set; }
		[Required, StringLength(11, MinimumLength = 11)]
		public string cuit_empresa { get; set; }
		[Required, StringLength(3, MinimumLength = 1)]
		public string letra_remito { get; set; }
		[Required, StringLength(4, MinimumLength = 1)]
		public string sucursal_remito { get; set; }
		[Required, StringLength(8, MinimumLength = 1), RegularExpression("^[0-9]*$")]
		public string numero_remito { get; set; }
		[Required, RegularExpression("^[0-9]*$"), Range(1,6)]
		public int regis_tipo_doc { get; set; }
		[Required, RegularExpression("^[0-9]*$"), StringLength(11, MinimumLength = 1)]
		public int numero_doc { get; set; }
		[Required, StringLength(50, MinimumLength = 1)]
		public string nombres_destinatario { get; set; }
		[Required, StringLength(50, MinimumLength = 1)]
		public string apellidos_destinatario { get; set; }
		[Required, StringLength(100, MinimumLength = 1)]
		public string domicilio_destinatario { get; set; }
		[Required, RegularExpression("^[0-9]*$")]
		public string codigo_postal_destinatario { get; set; }
		[Required, RegularExpression("^[0-9]*$"), StringLength(10, MinimumLength = 1)]
		public string te_linea_destinatario { get; set; }
		[Required, RegularExpression("^[0-9]*$"), StringLength(10, MinimumLength = 1)]
		public string te_celular_destinatario { get; set; }
		[Required, RegularExpression(@"\w + ([-+.’]\w +)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
		public string email_dest_destinatario { get; set; }
		[Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:yyyy/MM/dd}")]
		public DateTime fecha_entrega { get; set; }
		[Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:yyyy/MM/dd}")]
		public DateTime fecha_retiro { get; set; }
		public string franja_horario_entrega { get; set; }
		[Required, StringLength(100, MinimumLength = 1)]
		public string domicilio_retiro_Cliente { get; set; }
		[Required, RegularExpression("^[0-9]*$")]
		public string codigo_postal_retiro_Cliente { get; set; }
		[Required, RegularExpression("^[0-9]*$")]
		public int cantidad_bultos { get; set; }
		[Required]
		public string codigo_fs { get; set; }
		[RegularExpression("^[0-9]*$")]
		public int peso_kg { get; set; }
		[RegularExpression("^[0-9]*$")]
		public int ancho_cm { get; set; }
		[RegularExpression("^[0-9]*$")]
		public int largo_cm { get; set; }
		[RegularExpression("^[0-9]*$")]
		public int alto_cm { get; set; }
		public string nm_archivo { get; set; }
	}
}