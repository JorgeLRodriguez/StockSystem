using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IPasillo
    {
        IEnumerable<Pasillo> GetAlL();
        Pasillo Create(Pasillo deposito);
        void Edit(Pasillo deposito);
        void Delete(int id);
    }
}
