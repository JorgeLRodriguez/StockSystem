using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        protected Repository _db;
        public ArticleRepository()
        {
            _db = new Repository();
        }
        public Articulo Create(Articulo article)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Articulo> Get()
        {
            try
            {
                IQueryable<Articulo> query = _db.Set<Articulo>();
                return query.ToList();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void Update(Articulo article)
        {
            throw new NotImplementedException();
        }
    }
}
