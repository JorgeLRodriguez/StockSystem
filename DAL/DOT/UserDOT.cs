using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DOT
{
    class UserDOT
    {
		private int _IdUsuario;
		private int _IdRol;
		private string _UserName;
		private string _Apellidos;
		private string _Nombres;
		private string _UsuarioRed;
		private string _Contraseña;
		private string _RedLogIn;
		private int _Intentos;
		private DateTime _UltimoLogIn;
		private DateTime _UltimoLogOut;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string UserName { get => _UserName; set => _UserName = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string UsuarioRed { get => _UsuarioRed; set => _UsuarioRed = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string RedLogIn { get => _RedLogIn; set => _RedLogIn = value; }
        public int Intentos { get => _Intentos; set => _Intentos = value; }
        public DateTime UltimoLogIn { get => _UltimoLogIn; set => _UltimoLogIn = value; }
        public DateTime UltimoLogOut { get => _UltimoLogOut; set => _UltimoLogOut = value; }
    }
}
