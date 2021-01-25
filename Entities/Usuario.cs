using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario : IdentityBase
    {
        [Column("id_Rol")]
        public int Rol_ID { get; set; }
        [ForeignKey("Rol_ID"),Required]
        //public int id_Rol { get; set; }
        public virtual Rol Rol { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Nombres { get; set; }
        public string UsuarioRed { get; set; }
        public string RedLogIn { get; set; }
        public DateTime? ultimoLogIn { get; set; }
        public DateTime? ultimoLogOut { get; set; }
    }
}
