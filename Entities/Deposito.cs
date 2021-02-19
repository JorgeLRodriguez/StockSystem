using Entities.Infraestructure;
using Entities.Security;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Deposito : IdentityBase , IDigitoVerificadorHorizontal
    {
        [Column("id_cliente"), DatoSensible, RegularExpression("^[0-9]*$"), Range(1, int.MaxValue)]
        [Display(Name = ConstantesTexto.Cliente)]
        public int Cliente_ID { get; set; }
        //[ForeignKey("Cliente_ID")]
        public virtual Cliente Cliente { get; set; }
        [Required, DatoSensible, StringLength(50, MinimumLength = 3)]
        [Display(Name = ConstantesTexto.Descripcion)]
        public string NombreDeposito { get; set; }
        [Required, DatoSensible, StringLength(100, MinimumLength = 3)]
        [Display(Name = ConstantesTexto.Domicilio)]
        public string Domicilio { get; set; }
        public byte[] DVH { get; set; }
        public virtual ICollection<Pallet> Pallet { get; set; }
    }
}
