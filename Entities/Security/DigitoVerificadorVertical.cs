using System.ComponentModel.DataAnnotations;

namespace Entities.Security
{
    public class DigitoVerificadorVertical
    {
        [Key, Required]
        //public int ID { get; set; }
        public string Entidad { get; set; }
        public byte[] Checksum { get; set; }
    }
}