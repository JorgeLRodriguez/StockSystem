using Domain.Models;
using Entities.Bitacora;
using Entities.Infraestructure;
using System;

namespace Domain
{
    /// <summary>
    /// Controla el estado de sesión de usuario
    /// </summary>
    public class SessionManager
    {
        #region "Singleton"

        private static readonly Lazy<SessionManager> DefaultInstance =
            new Lazy<SessionManager>(() => new SessionManager());

        public static SessionManager Instance
        {
            get { return DefaultInstance.Value; }
        }

        #endregion

        private Usuario _usuario;

        public Usuario UsuarioActual
        {
            get { return _usuario; }
            private set { _usuario = value; }
        }

        public void IniciarSesion(Usuario usuario)
        {
            UsuarioActual = usuario;
            BitacoraModel.Default.RegistrarEnBitacora(Evento.UsuarioIngresoAlSistema, usuario.Nombres);
        }

        public void FinalizarSesion()
        {
            var usuarioActual = this.UsuarioActual;
            UsuarioActual = null;
            BitacoraModel.Default.RegistrarEnBitacora(Evento.UsuarioSalioDelSistema, usuarioActual.Nombres);
        }
    }
}
