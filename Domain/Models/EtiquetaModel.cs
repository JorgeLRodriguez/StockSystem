using DataAccess.UnitOfWork;
using Entities;
using Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EtiquetaModel
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly LogModel logModel;
        private IEnumerable<Etiqueta> etiquetas;
        private Etiqueta etiqueta;
        private Log log;
        private int count = 0;
        public EtiquetaModel()
        {
            unitOfWork = UnitOfWork.Instance();
            logModel = LogModel.Instance();
            log = new Log();
        }
        public void Create(Comprobante comprobante)
        {
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
                        unitOfWork.EtiquetaRepository.Create(etiqueta);
                        count++;
                    }
                }
                unitOfWork.SaveChanges();
            }
            catch(Exception ex)
            {
                logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            log.Mensaje = strings.EtiquetasGeneradas.ToLower() + ": " + strings.Comprobante + " " + comprobante.id_tipo_comprobante + " " + comprobante.letra_comprobante + " " + comprobante.suc_comprobante + " " + comprobante.num_comprobante.ToString();
            log.Ubicacion = Environment.UserDomainName.ToString();
            logModel.Log(log, null);
        }
        public IEnumerable<Etiqueta> GetbyIDComp (Comprobante comprobante)
        {
            try
            {
                etiquetas = unitOfWork.EtiquetaRepository.Get(filter: x => x.Comprobante_ID == comprobante.ID);
            }
            catch(Exception ex)
            {
                logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            if (!etiquetas.Any()) throw new ApplicationException(strings.ErrorSinRegistros);
            return etiquetas;
        }
    }
}