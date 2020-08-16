using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ClientRepository : IClientRepository
    {
        protected Repository _db;
        public ClientRepository()
        {
            _db = new Repository();
        }
        public Cliente Create(Cliente article)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente article)
        {
            throw new NotImplementedException();
        }
    }
}
