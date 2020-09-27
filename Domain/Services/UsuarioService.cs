using Domain.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UsuarioService
    {
        private UsuarioModel Usuario;

        public UsuarioService()
        {
            Usuario = new UsuarioModel();
        }
        public Usuario LogIn (string usuario, string contraseña)
        {
            return Usuario.LogIn(usuario, contraseña);
        }
    }
}
