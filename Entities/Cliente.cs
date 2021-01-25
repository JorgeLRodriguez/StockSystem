using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente : IdentityBase
    {
        [Required]
        public string Cuit { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }
        public virtual ICollection <Articulo> Articulos { get; set; }
        public virtual ICollection<Comprobante> Comprobantes { get; set; }
    }
}