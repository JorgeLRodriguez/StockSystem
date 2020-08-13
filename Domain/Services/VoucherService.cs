using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using DataAccess.Entities;

namespace Domain.Services
{
    public class VoucherService
    {
        VoucherModel VoucherModel = new VoucherModel();
        VoucherDetailModel VoucherModelDetail = new VoucherDetailModel();
        NumeratorModel NumeratorModel = new NumeratorModel();
        public void Save (VoucherModel voucherModel, List<VoucherDetailModel> voucherModelDetail)
        {
            var NumeratorDataModel = NumeratorModel.Get("SIR", "X", 1);

            voucherModel.Num_comprobante = NumeratorDataModel.Numero;

            int id_comprobante = VoucherModel.Save(voucherModel);
            VoucherModelDetail.Save(voucherModelDetail, id_comprobante);

            NumeratorDataModel.Update(NumeratorDataModel);
        }
    }
}
