using DataAccess.Contracts;
using DataAccess.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserModel
    {
        //private int id;
        //private int idRol;
        //private string Username;
        //private string Contraseña;
        //private string Apellidos;
        //private string Nombre;
        //private string UsuarioRed;
        //private string RedLogIn;
        //private DateTime ultimoLogIn;
        //private DateTime ultimoLogOut;

        //private IUserRepository userRepository;

        //public int Id { get => id; set => id = value; }
        //public int IdRol { get => idRol; set => idRol = value; }
        //public string Username1 { get => Username; set => Username = value; }
        //public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        //public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        //public string Nombre1 { get => Nombre; set => Nombre = value; }
        //public string UsuarioRed1 { get => UsuarioRed; set => UsuarioRed = value; }
        //public string RedLogIn1 { get => RedLogIn; set => RedLogIn = value; }
        //public DateTime UltimoLogIn { get => ultimoLogIn; set => ultimoLogIn = value; }
        //public DateTime UltimoLogOut { get => ultimoLogOut; set => ultimoLogOut = value; }

        //public UserModel()
        //{
        //    userRepository = new UserRepository();
        //}

        private readonly IUserRepository userRepository;
        private readonly IRole role;
        public UserModel()
        {
            userRepository = new UserRepository();
            role = new RoleRepository();
        }
        //public Usuario VerifyAccess(string user, string psw)
        //{
        //    Usuario usr = new Usuario();
        //    Rol rol = new Rol();
        //    if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(psw)) throw new ApplicationException("logInEmptyorNull");

        //    usr = (userRepository.VerifyAccess(user, psw));

        //    if (usr == null)
        //    {
        //        throw new ApplicationException("LogInIncorrecto");
        //    }
        //    else
        //    {
        //        role.GetById(usr.id_Rol);
        //    }
        //    return usr;
        //}
    }
}
