using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ENTIDAD;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class UserDAO : Connection
    {
        public bool login (string user, string pasw)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select COUNT (0) From Usuario Where Username = @User";
                    command.Parameters.AddWithValue("@User", user);
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Close();
                        command.CommandText = "Select * From Usuario Where Username = @User and Contraseña = @Contraseña";
                        command.Parameters.AddWithValue("@Contraseña", pasw);
                        sqlDataReader = command.ExecuteReader();

                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                UserEntity UE = new UserEntity();
                                UE.idRol = sqlDataReader.GetInt32(1);
                                UE.USR = sqlDataReader.GetString(2);
                                UE.Apellidos = sqlDataReader.GetString(3);
                                UE.Nombre = sqlDataReader.GetString(4);
                                UE.UsuarioRed = sqlDataReader.GetString(5);
                            }
                            return true;
                        }
                        else
                        {
                            //sumar intentos
                            return false;
                        }
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
