using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IArticulo
    {
        IEnumerable<Articulo> GetByClient(Cliente cliente);
        Articulo GetByID(int id);
        Articulo GetByFS(string codigoFS);
    }
}
