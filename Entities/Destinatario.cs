using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Destinatario : IdentityBase
    {
        public string ApellidoNombre { get; set; }
        public string TipoDoc { get; set; }
        public string CodigoPostal { get; set; }
        public string Domicilio { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Observaciones { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Comprobante> Comprobantes { get; set; }
    }
}
