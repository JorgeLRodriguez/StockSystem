using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class EtiquetaModel : IEtiqueta
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        //private readonly LogModel logModel;
        //private Log log;
        private int count = 0;
        public EtiquetaModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //unitOfWork = UnitOfWorkRepository.Instance;
            //logModel = LogModel.Instance();
            //log = new Log();
        }
        public void Create(Comprobante comprobante)
        {
            Etiqueta etiqueta;
            try
            {
                foreach (var cbtedet in comprobante.ComprobanteDetalle)
                {
                    count = 1;
                    for (int i = 1; i <= cbtedet.cantidad; i++)
                    {
                        etiqueta = new Etiqueta()
                        {
                            Comprobante_ID = comprobante.ID,
                            Articulo_ID = cbtedet.Articulo_ID,
                            etiq_nro = count,
                            etiq_total = cbtedet.cantidad
                        };
                        _unitOfWork.EtiquetaRepository.Create(etiqueta);
                        count++;
                    }
                }
                _unitOfWork.SaveChanges();
            }
            catch(Exception ex)
            {
                //logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            //log.Mensaje = "strings.EtiquetasGeneradas.ToLower()" + ": " + "strings.Comprobante" + " " + comprobante.id_tipo_comprobante + " " + comprobante.letra_comprobante + " " + comprobante.suc_comprobante + " " + comprobante.num_comprobante.ToString();
            //log.Ubicacion = Environment.UserDomainName.ToString();
            //logModel.Log(log, null);
        }
        public IEnumerable<Etiqueta> GetbyIDComp (Comprobante comprobante)
        {
            IEnumerable<Etiqueta> etiquetas;
            try
            {
                etiquetas = _unitOfWork.EtiquetaRepository.Get(filter: x => x.Comprobante_ID == comprobante.ID);
            }
            catch(Exception ex)
            {
                //logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            if (!etiquetas.Any()) throw new Exception(ConstantesTexto.ErrorSinRegistros);
            return etiquetas;
        }
    }
}