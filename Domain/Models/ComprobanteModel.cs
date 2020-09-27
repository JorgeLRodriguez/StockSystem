using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using Entities;

namespace Domain.Models
{
    public class ComprobanteModel
    {
        private readonly IUnitOfWork unitOfWork;
        public ComprobanteModel()
        {
            unitOfWork = new UnitOfWork();
        }

        public void Create(Comprobante comprobante)
        {
            //validaciones

            if (comprobante.fecha_comprobante < DateTime.Today) throw new ApplicationException("No puede ingresar una fecha menor a la actual");

            try
            {
                Numerador numerador = new Numerador();
                numerador = unitOfWork.NumeradorRepository.Get(filter: x => x.id_tipo_comprobante == comprobante.id_tipo_comprobante &&
                x.letra == comprobante.letra_comprobante && x.sucursal == comprobante.suc_comprobante).SingleOrDefault();
                comprobante.num_comprobante = numerador.numero + 1;
                numerador.numero = comprobante.num_comprobante;
                unitOfWork.ComprobanteRepository.Create(comprobante);
                unitOfWork.NumeradorRepository.Update(numerador);
                unitOfWork.SaveChanges();
            }
            catch (Exception)
            {

            }
        }
    }
}