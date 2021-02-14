using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using Entities.Infraestructure;

namespace Domain.Models
{
    public class ComprobanteModel : IComprobante
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        //private readonly LogModel logModel;
        //private Log log;
        public ComprobanteModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //unitOfWork = UnitOfWorkRepository.Instance;
            //logModel = LogModel.Instance();
            //log = new Log();
        }
        public Comprobante Create(Comprobante comprobante)
        {
            Numerador numerador;
            if (comprobante.fecha_comprobante < DateTime.Today) throw new Exception(ConstantesTexto.ErrorFechaMenAct);
            foreach (var row in comprobante.ComprobanteDetalle)
            {
                if (row.Articulo_ID == -1 || row.cantidad == -1) throw new NullReferenceException(ConstantesTexto.ErrorCampoVacio);
            }
            try
            {
                numerador = 
                    _unitOfWork.NumeradorRepository
                    .Get(filter: x => x.id_tipo_comprobante == comprobante.id_tipo_comprobante &&
                    x.letra == comprobante.letra_comprobante &&
                    x.sucursal == comprobante.suc_comprobante)
                    .SingleOrDefault() 
                    ?? _unitOfWork.NumeradorRepository.Create
                (
                    new Numerador()
                    {
                        id_tipo_comprobante = comprobante.id_tipo_comprobante,
                        letra = comprobante.letra_comprobante,
                        sucursal = comprobante.suc_comprobante,
                        numero = 0
                    }
                );
                _unitOfWork.SaveChanges();

                numerador.numero = numerador.numero + 1;
                comprobante.num_comprobante = numerador.numero;
                comprobante.Etiquetas = GetEtiquetas(comprobante);

                ValidateModel<Comprobante>.Default.Validar(comprobante);
                ValidateModel<ComprobanteDetalle>.Default.Validar(comprobante.ComprobanteDetalle.ToList());

                comprobante = _unitOfWork.ComprobanteRepository.Create(comprobante);
                _unitOfWork.NumeradorRepository.Update(numerador);
                _unitOfWork.SaveChanges();
                return comprobante;
            }
            catch (Exception ex)
            {
                //logModel.Log(log, ex);
                throw ex;
            }
            //log.Mensaje = "strings.Comprobante" + " " + comprobante.ID + " " + comprobante.letra_comprobante + " " + comprobante.suc_comprobante + " " + comprobante.num_comprobante.ToString() + " " + "strings.Generado.ToLower()";
            //log.Ubicacion = Environment.UserDomainName.ToString();
            //logModel.Log(log, null);
        }
        public Comprobante GetComprobanteByID(int ID)
        {
            Comprobante comprobante;
            try
            {
                comprobante = _unitOfWork.ComprobanteRepository.GetById(ID);
            }
            catch (Exception ex)
            {
                //logModel.Log(log, ex);
                throw ex;
            }
            if (comprobante == null) throw new ApplicationException(ConstantesTexto.ErrorSinRegistros);
            return comprobante;
        }
        private List<Etiqueta> GetEtiquetas(Comprobante comprobante)
        {
            List<Etiqueta> etiquetas = new List<Etiqueta>();

            foreach (var cbtedet in comprobante.ComprobanteDetalle)
            {
                for (int i = 1; i <= cbtedet.cantidad; i++)
                {
                    etiquetas.Add(new Etiqueta()
                    {
                        Comprobante_ID = comprobante.ID,
                        Articulo_ID = cbtedet.Articulo_ID,
                        etiq_nro = i,
                        etiq_total = cbtedet.cantidad
                    });
                }
            }
            return etiquetas;
        }
    }
}