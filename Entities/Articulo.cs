using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Articulo : IdentityBase
    {
        [Column("id_cliente")]
        public int Cliente_ID { get; set; }
        [ForeignKey("Cliente_ID"),Required]
        public virtual Cliente Cliente { get; set; }
        public string Codigo_fs { get; set; }
        public string Descripcion { get; set; }
        public string codigo_barra { get; set; }
        public bool tiene_codigo_barra { get; set; }
        public virtual ICollection<ComprobanteDetalle> ComprobanteDetalle { get; set; }
        public virtual ICollection<Etiqueta> Etiquetas { get; set; }
    }
}
