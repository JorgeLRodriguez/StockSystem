using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        protected Repository _db;
        public VoucherRepository()
        {
            _db = new Repository();
        }
        public Comprobante Create(Comprobante article)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comprobante> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Comprobante article)
        {
            throw new NotImplementedException();
        }
    }
}