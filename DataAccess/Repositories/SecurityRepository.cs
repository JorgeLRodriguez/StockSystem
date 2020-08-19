using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class SecurityRepository : ISecurityRepository
    {
        protected Repository _db;
        public Usuario VerifyAccess(string user, string pass)
        {
            using (_db = new Repository())
            {
                _db.Configuration.LazyLoadingEnabled = true;

                var query = _db.Usuario.Where(x => x.Username == user && x.Contraseña == pass).FirstOrDefault();
                if (query != null)
                {
                    Usuario usr = new Usuario
                    {
                        ID = query.ID,
                        id_Rol = query.id_Rol,
                        Username = query.Username,
                        Contraseña = query.Contraseña,
                        Apellidos = query.Apellidos,
                        Nombres = query.Nombres,
                        UsuarioRed = query.UsuarioRed,
                        RedLogIn = Environment.MachineName,
                        ultimoLogIn = DateTime.Now,
                        Rol = new Rol()
                    };
                    usr.Rol.ID = query.Rol.ID;
                    usr.Rol.Descripcion = query.Rol.Descripcion;
                    usr.Rol.NivelAcceso = query.Rol.NivelAcceso;
                    return usr;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
