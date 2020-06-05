using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL : Connection
    {
        public bool LogIn(string user, string psw)
        {
            user = "joro";
            psw = "bado";
            using (var cnn = getConnection())
            {
                cnn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT COUNT (0) FROM USUARIO WHERE USERNAME =@user AND PASSWORD=@psw";
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@psw", psw);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
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
    }
}