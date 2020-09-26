using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        protected Repository _db;
        public Comprobante Create(Comprobante comprobante)
        {
            using (_db = new Repository())
            {
                _db.Set<Comprobante>().Add(comprobante);
                _db.SaveChanges();
                return comprobante;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comprobante> Get(Expression<Func<Comprobante, bool>> whereExpression = null, Func<IQueryable<Comprobante>, IOrderedQueryable<Comprobante>> orderFunction = null, string includeModels = "")
        {
            throw new NotImplementedException();
        }

        public Comprobante GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comprobante article)
        {
            throw new NotImplementedException();
        }
    }
}