using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Repositories;
using Entities;
using Language;

namespace Domain.Models
{
    public class ComprobanteModel
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly LogModel logModel;
        private Comprobante comprobante;
        private Numerador numerador;
        private Log log;
        public ComprobanteModel()
        {
            unitOfWork = UnitOfWork.Instance();
            logModel = LogModel.Instance();
            log = new Log();
        }

        public void Create(Comprobante comprobante)
        {
            if (comprobante.fecha_comprobante < DateTime.Today) throw new ApplicationException(strings.ErrorFechaMenAct);
            if (String.IsNullOrEmpty(comprobante.nro_remito_cliente)) throw new Exception(strings.ErrorCampoVacio);
            if (comprobante.ComprobanteDetalle.Count == 0) throw new Exception(strings.ErrorFaltanLineas);
            foreach (var row in comprobante.ComprobanteDetalle)
            {
                if (row.Articulo_ID == -1 || row.cantidad == -1) throw new NullReferenceException(strings.ErrorCampoVacio);
            }
            try
            {
                numerador = unitOfWork.NumeradorRepository.Get(filter: x => x.id_tipo_comprobante == comprobante.id_tipo_comprobante &&
                x.letra == comprobante.letra_comprobante && x.sucursal == comprobante.suc_comprobante).SingleOrDefault()
                ?? unitOfWork.NumeradorRepository.Create
                (
                    new Numerador()
                    {
                        id_tipo_comprobante = comprobante.id_tipo_comprobante,
                        letra = comprobante.letra_comprobante,
                        sucursal = comprobante.suc_comprobante,
                        numero = 0
                    }
                );
                unitOfWork.SaveChanges();
                
                comprobante.num_comprobante = numerador.numero + 1;
                numerador.numero = comprobante.num_comprobante;
                unitOfWork.ComprobanteRepository.Create(comprobante);
                unitOfWork.NumeradorRepository.Update(numerador);
                unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            log.Mensaje = strings.Comprobante + " " + comprobante.ID + " " + comprobante.letra_comprobante + " " + comprobante.suc_comprobante + " " + comprobante.num_comprobante.ToString() + " " + strings.Generado.ToLower();
            log.Ubicacion = Environment.UserDomainName.ToString();
            logModel.Log(log, null);
        }
        public Comprobante GetComprobanteByID(int ID)
        {
            try
            {
                comprobante = unitOfWork.ComprobanteRepository.GetById(ID);
            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            if (comprobante == null) throw new ApplicationException(strings.ErrorSinRegistros);
            return comprobante;
        }
    }
}