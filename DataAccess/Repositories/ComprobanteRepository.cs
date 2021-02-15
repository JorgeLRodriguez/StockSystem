using DataAccess.Contracts;
using Entities;
using System.Linq;

namespace DataAccess.Repositories
{
    public class ComprobanteRepository : GenericRepository<Comprobante> , IComprobanteRepository
    {
        private readonly DatabaseContext _db;
        public ComprobanteRepository(DatabaseContext db):base(db)
        {
            _db = db;
        }
        public TipoRechazo[] GetTiposRechazo()
        {
            //Enumero por reflexión los tipos de rechazo disponibles en el sistema
            var camposDeEvento = typeof(TipoRechazo).GetFields();
            return camposDeEvento
                .Select(campo => new TipoRechazo
                {
                    ID = (int)campo.GetRawConstantValue(),
                    Descripcion = campo.Name
                })
                .ToArray();
        }
    }
}
