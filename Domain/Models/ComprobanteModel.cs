using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using Entities;
using Language;

namespace Domain.Models
{
    public class ComprobanteModel
    {
        private readonly IUnitOfWork unitOfWork;
        private Numerador numerador;
        public ComprobanteModel()
        {
            unitOfWork = new UnitOfWork();
            numerador = new Numerador();
        }

        public void Create(Comprobante comprobante)
        {
            if (comprobante.fecha_comprobante < DateTime.Today) throw new ApplicationException("No puede ingresar una fecha menor a la actual"); //agregar string
            if (String.IsNullOrEmpty(comprobante.nro_remito_cliente)) throw new Exception(strings.ErrorCampoVacio);
            if (comprobante.ComprobanteDetalle.Count == 0) throw new Exception("Debe ingresar líneas."); //agregar string
            foreach (var row in comprobante.ComprobanteDetalle)
            {
                if (row.id_articulo == -1 || row.cantidad == -1) throw new NullReferenceException(strings.ErrorCampoVacio);
            }

            try
            {
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
                //agregar log
            }
        }
        public Comprobante GetComprobante (string id_tipo_comprobante, string letra, string numero_comprobante, int sucursal)
        {
            return unitOfWork.ComprobanteRepository.GetById(2);
        }
    }
}