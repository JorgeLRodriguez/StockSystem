using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository 
    {
        protected Repository _db;
        public UserRepository()
        {
            _db = new Repository();
        }
        public Usuario Create(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Usuario> Get(Expression<Func<Usuario, bool>> whereExpression = null, Func<IQueryable<Usuario>, IOrderedQueryable<Usuario>> orderFunction = null, string includeModels = "")
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
