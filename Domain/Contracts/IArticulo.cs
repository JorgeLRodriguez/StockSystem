using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IArticulo
    {
        IEnumerable<Articulo> GetByClient(int? id_cliente = null);
        Articulo GetByID(int id);
    }
}
