using Entities.Infraestructure;
using Entities.Security;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Pallet : IdentityBase, IDigitoVerificadorHorizontal
    {
        [Column("id_deposito"), Required, DatoSensible, RegularExpression("^[0-9]*$"), Range(1, int.MaxValue)]
        [Display(Name = ConstantesTexto.Deposito)]
        public int Deposito_ID { get; set; }
        [ForeignKey("Deposito_ID")]
        public virtual Deposito Deposito { get; set; }
        [Column("id_pasillo"), Required, DatoSensible, RegularExpression("^[0-9]*$"), Range(1, int.MaxValue)]
        [Display(Name = ConstantesTexto.Pasillo)]
        public int Pasillo_ID { get; set; }
        [ForeignKey("Pasillo_ID")]
        public virtual Pasillo Pasillo { get; set; }
        [Required, DatoSensible, RegularExpression("^[0-9]*$"), Range(1, int.MaxValue)]
        [Display(Name = ConstantesTexto.Columna)]
        public int columna { get; set; }
        [Required, DatoSensible, RegularExpression("^[0-9]*$"), Range(1, int.MaxValue)]
        [Display(Name = ConstantesTexto.Fila)]
        public int fila { get; set; }
        [Required, DatoSensible, StringLength(50, MinimumLength = 3)]
        [Display(Name = ConstantesTexto.Descripcion)]
        public string Descripcion { get; set; }
        public byte[] DVH { get; set; }
    }
}
