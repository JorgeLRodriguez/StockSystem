using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    public class VoucherService
    {
        VoucherModel VoucherModel = new VoucherModel();
        VoucherDetailModel VoucherModelDetail = new VoucherDetailModel();
        NumeratorModel NumeratorModel = new NumeratorModel();

        public void Save (VoucherModel voucherModel, List<VoucherDetailModel> voucherModelDetail)
        {
            var NumeratorDataModel = NumeratorModel.Get
                (voucherModel.Id_tipo_comprobante, voucherModel.Letra_comprobante, voucherModel.Suc_comprobante);

            voucherModel.Num_comprobante = NumeratorDataModel.Numero;

            //voucherModel.Num_comprobante = NumeratorDataModel.Numero;

            //int id_comprobante = VoucherModel.Save(voucherModel);
            //VoucherModelDetail.Save(voucherModelDetail, id_comprobante);
            VoucherModelDetail.Save(voucherModelDetail, VoucherModel.Save(voucherModel));
            NumeratorModel.Update(NumeratorDataModel);
        }
    }
}
