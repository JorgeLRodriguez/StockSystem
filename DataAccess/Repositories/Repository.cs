using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class Repository : DbContext
    {
        public Repository() : base (ConfigurationManager.ConnectionStrings["cnn"].ToString())
        {
            Database.SetInitializer<Repository>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<Comprobante> Comprobante { get; set; }
        public virtual DbSet<ComprobanteDetalle> ComprobanteDetalle { get; set; }
    }
}