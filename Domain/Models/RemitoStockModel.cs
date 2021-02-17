using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class RemitoStockModel : IRemitoStock
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        private readonly ICliente _cliente;
        private readonly IArticulo _articulo;
        private readonly IComprobante _comprobante;
        public RemitoStockModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _cliente = new ClienteModel(unitOfWork);
            _articulo = new ArticuloModel(unitOfWork);
            _comprobante = new ComprobanteModel(unitOfWork);
        }
        public void Create(List<RemitoStock> remitoStock)
        {
            Comprobante C = null;
            List<Comprobante> Cs = new List<Comprobante>();
            int linea = 0;
            int count = 0;
            remitoStock.ForEach(x => ValidateModel<RemitoStock>.Default.Validar(x));
            remitoStock.ForEach(x => _cliente.GetByCuit(x.cuit_empresa));
            try
            {
                foreach (var remito in remitoStock)
                {
                    linea += 1;
                    count++;
                    int idArticulo = _articulo.GetByFS(remito.codigo_fs).ID;
                    if (C != null && C.nro_remito_cliente.Equals(remito.numero_remito))
                    {
                        C.ComprobanteDetalle.Add(GetCD(remito, C, idArticulo,linea));
                        if (count.Equals(remitoStock.Count())) Cs.Add(C);
                        continue;
                    }
                    else
                    {
                        linea = 1;
                        if (C != null) Cs.Add(C);
                    }
                    C = new Comprobante()
                    {
                        Cliente_ID = _cliente.GetByCuit(remito.cuit_empresa).ID,
                        Destinatario = new Destinatario()
                        {
                            ApellidoNombre = remito.apellidos_destinatario + " " + remito.nombres_destinatario,
                            Celular = remito.te_celular_destinatario,
                            CodigoPostal = remito.codigo_postal_destinatario,
                            Documento = remito.numero_doc,
                            Domicilio = remito.domicilio_destinatario,
                            Email = remito.email_dest_destinatario,
                            Telefono = remito.te_linea_destinatario,
                            TipoDoc = remito.regis_tipo_doc
                        },
                        fecha_comprobante = remito.fecha_remito,
                        id_tipo_comprobante = TipoComprobante.SPK.ToString(),
                        letra_comprobante = "X",
                        nro_remito_cliente = remito.numero_remito,
                        suc_comprobante = 1,
                    };
                    List<ComprobanteDetalle> CD = new List<ComprobanteDetalle>();
                    CD.Add(GetCD(remito, C, idArticulo, linea));
                    C.ComprobanteDetalle = CD;
                    if (count.Equals(remitoStock.Count())) Cs.Add(C);
                }
                remitoStock.ForEach(x => _unitOfWork.RemitoStockRepository.Create(x));
                Cs.ForEach(x => _comprobante.Create(x));
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
        }
        private ComprobanteDetalle GetCD (RemitoStock remito, Comprobante C, int idArticulo, int linea)
        {
            return new ComprobanteDetalle()
            {
                Articulo_ID = idArticulo,
                cantidad = remito.cantidad_bultos,
                linea = linea
            };
        }
    }
}
