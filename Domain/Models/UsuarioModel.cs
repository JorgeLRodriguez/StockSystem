using DataAccess.Repositories;
using Entities;
using Language;
using System;
using System.Linq;

namespace Domain.Models
{
    public class UsuarioModel
    {
        private Usuario usr;
        private Log log;
        private LogModel logModel;
        private UnitOfWork UnitOfWork;
        public UsuarioModel()
        {
            usr = new Usuario();
            log = new Log();
            logModel = new LogModel();
            UnitOfWork = new UnitOfWork();
        }

        public Usuario LogIn(string user, string psw)
        {
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(psw)) throw new ApplicationException(strings.logInEmptyorNull);
            try
            {
                usr = (UnitOfWork.UsuarioRepository.Get(filter: x => x.Username == user && x.Contraseña == psw, null, "Rol")).SingleOrDefault();
            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new ApplicationException(ex.Message);
            }
            if (usr == null) throw new ApplicationException(strings.LogInIncorrecto);
            log.Mensaje = user + strings.loginCorrecto;
            log.Ubicacion = Environment.UserDomainName.ToString();
            logModel.Log(log, null);
            return usr;
        }
    }
}
