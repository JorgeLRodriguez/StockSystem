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
        private readonly IGenericRepository<Comprobante> genericRepository;

        //private readonly IVoucherRepository voucherRepository;
        //private readonly INumeratorRepository numeratorRepository;
        public VoucherModel()
        {
            //voucherRepository = new VoucherRepository();
            //numeratorRepository = new NumeratorRepository();
            genericRepository = new GenericRepository<Comprobante>();
        }
        public void Create(Comprobante comprobante)
        {
            //validaciones

            if (comprobante.fecha_comprobante < DateTime.Today) throw new ApplicationException("No puede ingresar una fecha menor a la actual");

            try
            {
                //Numerador numerador = new Numerador();
                //numerador = numeratorRepository.Get(comprobante.id_tipo_comprobante, comprobante.letra_comprobante, comprobante.suc_comprobante);
                //comprobante.num_comprobante = numerador.numero + 1;
                //voucherRepository.Create(comprobante);
                //numerador.numero = comprobante.num_comprobante;
                //numeratorRepository.Update(numerador);
            }
            catch (Exception)
            {

            }


        }
    }
}