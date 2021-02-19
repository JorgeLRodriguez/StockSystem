using Entities.Infraestructure;
using Entities.Security;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Pasillo : IdentityBase, IDigitoVerificadorHorizontal
    {
        [Required, DatoSensible, StringLength(50, MinimumLength = 3)]
        [Display(Name = ConstantesTexto.Descripcion)]
        public string Descripcion { get; set; }
        public byte[] DVH { get; set; }
        public virtual ICollection<Pallet> Pallet { get; set; }
    }
}
