using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DAL.DAO;

namespace BLL
{
    public class UserBLL
    {
        UserDAO UD = new UserDAO();
        public bool UserlogIn(string user, string psw)
        {
            if (UD.login(user, psw))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}