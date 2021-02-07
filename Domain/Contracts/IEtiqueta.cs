using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IEtiqueta
    {
        void Create(Comprobante comprobante);
        IEnumerable<Etiqueta> GetbyIDComp(Comprobante comprobante);
    }
}
