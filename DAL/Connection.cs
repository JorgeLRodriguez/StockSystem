using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public abstract class Connection
    {
        private readonly string cnn;

        public Connection()
        {
            cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        }
        protected SqlConnection getConnection()
        {
            return new SqlConnection(cnn);
        }
    }
}