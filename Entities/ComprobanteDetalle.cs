﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ComprobanteDetalle : IdentityBase
    {
		public int id_comprobante { get; set; }
		public int linea { get; set; }
		public int id_articulo { get; set; }
		public int cantidad { get; set; }
		public int id_tipo_rechazo { get; set; }
		public int id_pallet { get; set; }

		[ForeignKey("id_comprobante")]
		public virtual Comprobante Comprobante { get; set; }
		[ForeignKey("id_articulo")]
		public virtual Articulo Articulo { get; set; }
	}
}
