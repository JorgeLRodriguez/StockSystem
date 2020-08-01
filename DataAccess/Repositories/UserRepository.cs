using DataAccess.Contracts;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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

        public bool GetLogIn(string user, string pass)
        {
            using (_db)
            {
                var query = from u in _db.Usuario
                        where u.Username == user && u.Contraseña == pass
                        select u;
                if (query.Count()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public List<ValidationResult> ValidateModel(Usuario model)
        {
            throw new NotImplementedException();
        }
    }
}
