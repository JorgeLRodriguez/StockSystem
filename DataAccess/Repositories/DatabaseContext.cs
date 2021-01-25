using DataAccess.DigitosVerificadores;
using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class DatabaseContext : DbContext
    {
        private static DatabaseContext _instance;
        public DatabaseContext() : base(ConfigurationManager.ConnectionStrings["cnn"].ToString())
        {
            Database.SetInitializer<DatabaseContext>(null);
        }
        public static DatabaseContext Instance()
        {
            return _instance = _instance ?? new DatabaseContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public IDbSet <Usuario> Usuario { get; set; }
        public IDbSet<Cliente> Cliente { get; set; }
        public IDbSet<Articulo> Articulo { get; set; }
        public IDbSet<Comprobante> Comprobante { get; set; }
        public IDbSet<ComprobanteDetalle> ComprobanteDetalle { get; set; }
        public IDbSet<Numerador> Numerador { get; set; }
        public IDbSet<Rol> Rol { get; set; }
        public IDbSet<Log> Log { get; set; }
        public IDbSet<Etiqueta> Etiqueta { get; set; }
    }
}