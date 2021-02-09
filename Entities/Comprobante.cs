using Entities.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Comprobante : IdentityBase , IDigitoVerificadorHorizontal
    {
        [Column("id_cliente"),Required, DatoSensible]
        public int Cliente_ID { get; set; }
        [ForeignKey("Cliente_ID")]
        public virtual Cliente Cliente { get; set; }
        [Required, DatoSensible]
        public string id_tipo_comprobante { get; set; }
        [Required, DatoSensible]
        public string letra_comprobante { get; set; }
        [Required, DatoSensible]
        public int suc_comprobante { get; set; }
        [Required, DatoSensible]
        public int num_comprobante { get; set; }
        [DatoSensible]
        public string nro_remito_cliente { get; set; }
        [DatoSensible]
        public DateTime? fecha_comprobante { get; set; }
        [DatoSensible]
        public char cierre { get; set; }
        [Column("id_destinatario")]
        public int Destinatario_ID { get; set; }
        [ForeignKey("Destinatario_ID")]
        public virtual Destinatario Destinatario { get; set; }
        public string observaciones { get; set; }
        //[DatoSensible]
        public byte[] DVH { get; set; }
        public virtual ICollection<ComprobanteDetalle> ComprobanteDetalle { get; set; }
        public virtual ICollection<Etiqueta> Etiquetas { get; set; }
    }
}