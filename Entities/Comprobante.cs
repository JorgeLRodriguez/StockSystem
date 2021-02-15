using Entities.Infraestructure;
using Entities.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Comprobante : IdentityBase , IDigitoVerificadorHorizontal
    {
        [Column("id_cliente"),Required, DatoSensible, RegularExpression("^[0-9]*$"), Range(1,int.MaxValue)]
        [Display(Name = ConstantesTexto.Cliente)]
        public int Cliente_ID { get; set; }
        [ForeignKey("Cliente_ID")]
        public virtual Cliente Cliente { get; set; }
        [Required, DatoSensible, StringLength(3, MinimumLength = 3)]
        [Display(Name = ConstantesTexto.Tipo)]
        public string id_tipo_comprobante { get; set; }
        [Required, DatoSensible, StringLength(3, MinimumLength = 1)]
        [Display(Name = ConstantesTexto.Letra)]
        public string letra_comprobante { get; set; }
        [Required, DatoSensible, Range(1, 1)]
        [Display(Name = ConstantesTexto.Sucursal)]
        public int suc_comprobante { get; set; }
        [Required, DatoSensible, Range(1, int.MaxValue)]
        [Display(Name = ConstantesTexto.NumeroComprobante)]
        public int num_comprobante { get; set; }
        [DatoSensible, StringLength(10, MinimumLength = 1), RegularExpression("^[0-9]*$"), Range(1, int.MaxValue)]
        [Display(Name = ConstantesTexto.Remito)]
        public string nro_remito_cliente { get; set; }
        [DatoSensible, Required]
        [Display(Name = ConstantesTexto.Fecha)]
        public DateTime? fecha_comprobante { get; set; }
        [DatoSensible]
        [Display(Name = ConstantesTexto.Cierre)]
        public char cierre { get; set; }
        [Column("id_destinatario"), RegularExpression("^[0-9]*$"), Range(0, int.MaxValue)]
        [Display(Name = ConstantesTexto.Destinatario)]
        public int Destinatario_ID { get; set; }
        [ForeignKey("Destinatario_ID")]
        public virtual Destinatario Destinatario { get; set; }
        [Display(Name = ConstantesTexto.Observacion)]
        public string observaciones { get; set; }
        public byte[] DVH { get; set; }
        [NotMapped]
        public string Descripcion {
            get 
            {
                return id_tipo_comprobante + " - " + suc_comprobante + " - " + letra_comprobante + " - " + ("0000000" + num_comprobante).Substring(("0000000" + num_comprobante).Length-7); 
            }
        } 
        public virtual ICollection<ComprobanteDetalle> ComprobanteDetalle { get; set; }
        public virtual ICollection<Etiqueta> Etiquetas { get; set; }
    }
}