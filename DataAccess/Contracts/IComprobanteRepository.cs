using Entities;

namespace DataAccess.Contracts
{
    public interface IComprobanteRepository : IGenericRepository<Comprobante>
    {
        TipoRechazo[] GetTiposRechazo();
    }
}
