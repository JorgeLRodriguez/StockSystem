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
    public class SecurityModel
    {
        private readonly ISecurityRepository securityRepository;
        public SecurityModel()
        {
            securityRepository = new SecurityRepository();
        }
        public Usuario VerifyAccess(string user, string psw)
        {
            Usuario usr = new Usuario();

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(psw)) throw new ApplicationException("logInEmptyorNull");

            usr = (securityRepository.VerifyAccess(user, psw));

            if (usr == null)
            {
                throw new ApplicationException("LogInIncorrecto");
            }
            return usr;
        }
    }
}
