using DataAccess.Contracts;
using DataAccess.Repositories;
using Entities;
using System;
using System.Linq;

namespace Domain.Models
{
    public class UsuarioModel
    {
        private Usuario usr;
        private Log log;
        private readonly LogModel logModel;
        private readonly IUnitOfWork unitOfWork;
        public UsuarioModel()
        {
            log = new Log();
            unitOfWork = UnitOfWork.Instance();
            logModel = LogModel.Instance();
        }

        public Usuario LogIn(string user, string psw)
        {
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(psw)) throw new ApplicationException("strings.logInEmptyorNull");
            try
            {
                usr = (unitOfWork.UsuarioRepository.Get(filter: x => x.Username == user && x.Contraseña == psw, null, "Rol")).SingleOrDefault();
            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new ApplicationException(ex.Message);
            }
            //if (usr == null) throw new ApplicationException(strings.LogInIncorrecto);
            //log.Mensaje = user + " " + strings.loginCorrecto;
            log.Ubicacion = Environment.UserDomainName.ToString();
            logModel.Log(log, null);
            return usr;
        }
    }
}