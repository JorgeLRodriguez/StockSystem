using Entities.Infraestructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Bitacora
{
    /// <summary>
    /// Modela una entrada en la bitácora del sistema
    /// </summary>
    public class Bitacora
    {
        [Key, Required]
        public int Id { get; set; }
        public int Evento_ID { get; set; }
        [NotMapped]
        public Evento Evento { get; set; }
        [Required, EnumDataType(typeof(Severidad))]
        public Severidad Severidad { get; set; }
        public string Mensaje { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Usuario Usuario { get; set; }
    }
}
