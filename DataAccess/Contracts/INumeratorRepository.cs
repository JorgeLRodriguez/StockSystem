using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface INumeratorRepository : IGenericRepository<Numerador>
    {
        Numerador Get(string id_tipo_comprobante, string letra, int sucursal);
    }
}
