using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        UserDAL UD = new UserDAL();
        public byte VerificarlogIn()
        {
            UD.LogIn("joro", "bado");
            return 1;
        }
    }
}
