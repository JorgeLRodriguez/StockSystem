using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface ICliente
    {
        IEnumerable<Cliente> Get();
        Cliente GetByCuit(string cuit);
    }
}
