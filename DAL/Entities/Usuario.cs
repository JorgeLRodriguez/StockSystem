using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string UsuarioRed { get; set; }
        public string RedLogIn { get; set; }
        public DateTime ultimoLogIn { get; set; }
        public DateTime ultimoLogOut { get; set; }
    }
}
