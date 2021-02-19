using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public virtual Deposito Deposito { get; set; }
        public virtual ICollection <Articulo> Articulos { get; set; }
        public virtual ICollection<Comprobante> Comprobantes { get; set; }
    }
}