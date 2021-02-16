using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using Entities.Bitacora;
using Entities.Infraestructure;

namespace Domain.Models
{
    public class ComprobanteModel : IComprobante
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public ComprobanteModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Comprobante Create(Comprobante comprobante)
        {
            Numerador numerador;
            if (comprobante.fecha_comprobante < DateTime.Today) throw new Exception(ConstantesTexto.ErrorFechaMenAct);
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

                numerador.numero += 1;
                comprobante.num_comprobante = numerador.numero;

                ValidateModel<Comprobante>.Default.Validar(comprobante);
                ValidateModel<ComprobanteDetalle>.Default.Validar(comprobante.ComprobanteDetalle.ToList());

                _unitOfWork.SaveChanges();

                if (comprobante.id_tipo_comprobante.Equals(TipoComprobante.SIR.ToString()))
                    comprobante.Etiquetas = GetEtiquetas(comprobante);

                comprobante = _unitOfWork.ComprobanteRepository.Create(comprobante);
                _unitOfWork.NumeradorRepository.Update(numerador);
                _unitOfWork.SaveChanges();

                BitacoraModel.Default.RegistrarEnBitacora
                    (
                    Evento.ComprobanteGenerado,
                    Severidad.Informativo,
                    comprobante.id_tipo_comprobante + " - " +
                    comprobante.letra_comprobante + " - " +
                    comprobante.suc_comprobante + " - " +
                    comprobante.num_comprobante
                    );

                return comprobante;
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
        }
        public TipoRechazo[] GetTipoRechazo(ITraductor _traductor)
        {
            var tiposRechazos = _unitOfWork.ComprobanteRepository.GetTiposRechazo();

            foreach (var item in tiposRechazos)
                item.Descripcion = _traductor.Traducir (item.Descripcion);

            return tiposRechazos;
        }
        public IEnumerable<Comprobante> GetComprobanteScaneo()
        {
            var C = _unitOfWork.ComprobanteRepository
                .Get(
                filter: x => x.id_tipo_comprobante.Equals(TipoComprobante.SIR.ToString()) &&
                x.cierre.Equals(null) ||
                x.id_tipo_comprobante.Equals(TipoComprobante.SPK.ToString())
                )
                .OrderByDescending(
                x => x.ID
                );
            if (C.Count() == 0) throw new Exception(ConstantesTexto.ErrorSinRegistros);
            return C; 
        }
        public void Update(Comprobante comprobante)
        {
            try
            {
                _unitOfWork.ComprobanteRepository.Update(comprobante);
                _unitOfWork.SaveChanges();
            }
            catch(Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
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