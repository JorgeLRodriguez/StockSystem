using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ComprobanteDetalle : IdentityBase
    {
		public int id_comprobante { get; set; }
		public int linea { get; set; }
		public int id_articulo { get; set; }
		public int cantidad { get; set; }
		public int id_tipo_rechazo { get; set; }
		public int id_pallet { get; set; }
    }
}
