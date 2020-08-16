using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface INumeratorRepository
    {
        Numerador Get(string id_tipo_comprobante, string letra, int sucursal);
        List<Numerador> Get();
        //T GetById(int id);
        Numerador Create(Numerador article);
        void Update(Numerador article);
        void Delete(int id);
    }
}
