using DataAccess.Contracts;
using DataAccess.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SecurityModel
    {
        private readonly ISecurityRepository securityRepository;
        LogModel logModel = new LogModel();
        Log log = new Log();
        public SecurityModel()
        {
            securityRepository = new SecurityRepository();
        }
        public Usuario VerifyAccess(string user, string psw)
        {
            Usuario usr = new Usuario();
            try
            {
                if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(psw)) throw new ApplicationException("logInEmptyorNull");

                usr = (securityRepository.VerifyAccess(user, psw));

                if (usr == null)
                {
                    throw new ApplicationException("LogInIncorrecto");
                }
            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new ApplicationException(ex.Message);
            }
            log.Mensaje = "El usuario "+ user+" ingresó al sistema.";
            log.Ubicacion = Environment.UserDomainName.ToString();
            logModel.Log(log, null);
            return usr;
        }
    }
}
