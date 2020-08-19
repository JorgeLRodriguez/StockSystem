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
        NumeratorModel NumeratorModel = new NumeratorModel();
        public Comprobante Create(Comprobante comprobante)
        {
            try
            {
                Numerador numerador = new Numerador();
                numerador = NumeratorModel.Get(comprobante.id_tipo_comprobante, comprobante.letra_comprobante, comprobante.suc_comprobante);
                comprobante.num_comprobante = numerador.numero;
                VoucherModel.Create(comprobante);
                numerador.numero = comprobante.num_comprobante;
                NumeratorModel.Update(numerador);
            }
            catch (Exception ex)
            {
                Log log = new Log();
                LogModel.Instance.Log(log, ex);
                //agregar return
            }
            return comprobante;

        }
    }
}