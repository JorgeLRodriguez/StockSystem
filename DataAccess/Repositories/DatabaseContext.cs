using Entities;
using Entities.Bitacora;
using Entities.Infraestructure;
using Entities.Security;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccess.Repositories
{
    public class DatabaseContext : DatabaseContextDV
    {
        private static DatabaseContext _instance;
        public DatabaseContext() : base(ConfigurationManager.ConnectionStrings["cnn"].ToString(),new CalculadoraDVRepository())
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
        public IDbSet<Usuario> Usuario { get; set; }
        public IDbSet<Cliente> Cliente { get; set; }
        public IDbSet<Articulo> Articulo { get; set; }
        public IDbSet<Comprobante> Comprobante { get; set; }
        public IDbSet<ComprobanteDetalle> ComprobanteDetalle { get; set; }
        public IDbSet<Numerador> Numerador { get; set; }
        public IDbSet<Rol> Rol { get; set; }
        public IDbSet<Log> Log { get; set; }
        public IDbSet<Etiqueta> Etiqueta { get; set; }
        public IDbSet<Bitacora> Bitacora { get; set; }
        public IDbSet<DigitoVerificadorVertical> DigitoVerificadorVertical { get; set; }
        public IDbSet<RemitoStock> RemitoStock { get; set; }
        public IDbSet<Destinatario> Destinatario { get; set; }
    }
}