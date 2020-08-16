using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IVoucherRepository
    {
        List<Comprobante> Get();
        //T GetById(int id);
        Comprobante Create(Comprobante article);
        void Update(Comprobante article);
        void Delete(int id);
    }
}
