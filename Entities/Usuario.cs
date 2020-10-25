using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario : IdentityBase
    {
        public int id_Rol { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string UsuarioRed { get; set; }
        public string RedLogIn { get; set; }
        public DateTime? ultimoLogIn { get; set; }
        public DateTime? ultimoLogOut { get; set; }

        //Relaciones
        [ForeignKey("id_Rol")]
        public virtual Rol Rol { get; set; }
    }
}
