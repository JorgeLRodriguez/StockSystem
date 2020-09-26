using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ClientRepository : IGenericRepository<Cliente>
    {
        protected Repository _db;
        public ClientRepository()
        {
            _db = new Repository();
        }
        public Cliente Create(Cliente cliente)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Cliente> Get(Expression<Func<Cliente, bool>> whereExpression = null, Func<IQueryable<Cliente>, IOrderedQueryable<Cliente>> orderFunction = null, string includeModels = "")
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
