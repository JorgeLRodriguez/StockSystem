using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IPallet
    {
        IEnumerable<Pallet> GetAlL();
        Pallet Create(Pallet deposito);
        void Edit(Pallet deposito);
        void Delete(int id);
    }
}
