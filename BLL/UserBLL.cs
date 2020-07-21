using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DAL.DAO;
using DAL.Repositories;
using DAL.Entities;

namespace BLL
{
    public class UserBLL
    {
        UserRepository _db;
        public UserBLL()
        {
            _db = new UserRepository();
        }

        public bool UserlogIn(string user, string psw)
        {
            if (_db.GetLogIn(user, psw))
                { return true; }
            else
            {
                return false;
            }
        }

    }
}