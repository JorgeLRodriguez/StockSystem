using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Repositories;
using Entities;

namespace Domain.Models
{
    public class VoucherModel
    {
        private readonly IVoucherRepository voucherRepository;
        public VoucherModel()
        {
            voucherRepository = new VoucherRepository();
        }
        public void Create(Comprobante comprobante)
        {
            //validaciones
            voucherRepository.Create(comprobante);
        }
    }
}