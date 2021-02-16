using Entities.Infraestructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Etiqueta
    {
        [Key, Required]
        public int ID { get; set; }
        [Column("id_comprobante")]
        [Display(Name = ConstantesTexto.Comprobante)]
        public int Comprobante_ID { get; set; }
        [ForeignKey("Comprobante_ID"), Required]
        public virtual Comprobante Comprobante { get; set; }
        [Column("id_articulo"),Required]
        [Display(Name = ConstantesTexto.Articulo)]
        public int Articulo_ID { get; set; }

        [ForeignKey("Articulo_ID")]
        public virtual Articulo Articulo { get; set; }
        public int etiq_nro { get; set; }
        public int etiq_total { get; set; }
    }
}
