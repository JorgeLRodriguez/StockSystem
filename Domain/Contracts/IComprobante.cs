using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IComprobante
    {
        Comprobante Create(Comprobante comprobante);
        TipoRechazo[] GetTipoRechazo(ITraductor _traductor);
        IEnumerable<Comprobante> GetComprobanteScaneo();
    }
}
