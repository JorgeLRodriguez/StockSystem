using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserEntity
    {
        public int idRol { get; set; }
        public string USR { get; set; }
        public string PSW { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string UsuarioRed { get; set; }
        public string RedLogIn { get; set; }
        public DateTime ultimoLogIn { get; set; }
        public DateTime ultimoLogOut { get; set; }
    }
}