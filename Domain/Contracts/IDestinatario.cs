using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IDestinatario
    {
        Destinatario Create(Destinatario destinatario);
        void Update(Destinatario destinatario);
        void Delete(int ID);
        IEnumerable<Destinatario> Get();
    }
}
