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
        public SecurityRepository()
        {
            _db = new Repository();
        }
        public Usuario VerifyAccess(string user, string pass)
        {
            //Usuario usr = new Usuario();
            //Rol rol = new Rol();

            using (_db)
            {
                try
                {
                    _db.Configuration.LazyLoadingEnabled = true;

                    var query = _db.Usuario.Where(x => x.Username == user && x.Contraseña == pass).FirstOrDefault();
                    if (query != null)
                    {
                        Usuario usr = new Usuario();
                        usr.ID = query.ID;
                        usr.id_Rol = query.id_Rol;
                        usr.Username = query.Username;
                        usr.Contraseña = query.Contraseña;
                        usr.Apellidos = query.Apellidos;
                        usr.Nombres = query.Nombres;
                        usr.UsuarioRed = query.UsuarioRed;
                        usr.RedLogIn = Environment.MachineName;
                        usr.ultimoLogIn = DateTime.Now;
                        usr.Rol = new Rol();
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
                catch (Exception ex)
                {
                    throw new ApplicationException(ex.Message);
                    //log de errores
                }
            }
        }
    }
}
