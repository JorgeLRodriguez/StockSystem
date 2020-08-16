using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IClientRepository
    {
        List<Cliente> Get();
        //T GetById(int id);
        Cliente Create(Cliente article);
        void Update(Cliente article);
        void Delete(int id);
    }
}
