using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Entities;

namespace Domain.Services
{
    public class VoucherService
    {
        VoucherModel VoucherModel = new VoucherModel();
        public Comprobante Create(Comprobante comprobante)
        {
            VoucherModel.Create(comprobante);
            return comprobante;
        }
    }
}