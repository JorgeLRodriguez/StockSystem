using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IDeposito
    {
        IEnumerable<Deposito> GetAlL();
        Deposito Create(Deposito deposito);
        void Edit(Deposito deposito);
        void Delete(int id);
    }
}
