using DataAccess.Contracts;
using DataAccess.Repositories;
using Entities;
using System;
using Language;
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
        public SecurityModel()
        {
            securityRepository = new SecurityRepository();
        }
        public Usuario VerifyAccess(string user, string psw)
        {
            Usuario usr;
            Log log = new Log();
            LogModel logModel = new LogModel();

            try
            {
                usr = (securityRepository.VerifyAccess(user, psw));

                if (usr == null)
                {
                    throw new ApplicationException (strings.LogInIncorrecto);
                }
            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new ApplicationException(ex.Message);
            }
            log.Mensaje = user + strings.loginCorrecto;
            log.Ubicacion = Environment.UserDomainName.ToString();
            logModel.Log(log, null);
            return usr;
        }
    }
}