using DataAccess.Contracts;
using Domain.Contracts;
using Entities.Bitacora;
using Entities.Infraestructure;
using System;

namespace Domain.Models
{
    public class UsuarioModel : IUsuario
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public UsuarioModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            if (String.IsNullOrEmpty(nombreUsuario) || String.IsNullOrEmpty(contraseña))
                throw new ApplicationException(ConstantesTexto.AtLogInEmptyorNull);
            var usuarioActual = SessionManager.Instance.UsuarioActual;
            try
            {
                var usuario = _unitOfWork.UsuarioRepository.GetByName(nombreUsuario);
                if (usuario != null)
                {
                    var esCorrecto = usuario.Contraseña.Equals(contraseña);
                    if (esCorrecto)
                        SessionManager.Instance.IniciarSesion(usuario);
                }

                usuarioActual = SessionManager.Instance.UsuarioActual;
                if (usuarioActual == null)
                {
                    //Registro el intento fallido de Login
                    BitacoraModel.Default.RegistrarEnBitacora(Evento.UsuarioFalloIngresandoCredenciales, Severidad.Advertencia,
                        nombreUsuario);
                }
            }
            catch(Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            return usuarioActual ?? throw new Exception(ConstantesTexto.AtLogInIncorrecto);
        }
        public Usuario FinalizarSesion()
        {
            var ultimoUsuarioEnLinea = SessionManager.Instance.UsuarioActual;
            SessionManager.Instance.FinalizarSesion();
            return ultimoUsuarioEnLinea;
        }
    }
}