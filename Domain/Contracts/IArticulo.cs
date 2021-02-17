using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IArticulo
    {
        IEnumerable<Articulo> GetByClient(int? id_cliente = null);
        Articulo GetByID(int id);
        Articulo GetByFS(string codigoFS);
    }
}
