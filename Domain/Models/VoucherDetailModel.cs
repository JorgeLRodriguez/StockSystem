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
    public class VoucherDetailModel
    {
        private int id;
        private DateTime? createdOn;
        private string createdBy;
        private DateTime? changedOn;
        private string changedBy;
        private int id_comprobante;
        private int linea;
        private int id_articulo;
        private int cantidad;
        private int id_tipo_rechazo;
        private int id_pallet;

        public int Id { get => id; set => id = value; }
        public DateTime? CreatedOn { get => createdOn; set => createdOn = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime? ChangedOn { get => changedOn; set => changedOn = value; }
        public string ChangedBy { get => changedBy; set => changedBy = value; }
        public int Id_comprobante { get => id_comprobante; set => id_comprobante = value; }
        public int Linea { get => linea; set => linea = value; }
        public int Id_articulo { get => id_articulo; set => id_articulo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_tipo_rechazo { get => id_tipo_rechazo; set => id_tipo_rechazo = value; }
        public int Id_pallet { get => id_pallet; set => id_pallet = value; }

        private IGenericRepository<ComprobanteDetalle> genericRepository;
        public VoucherDetailModel()
        {
            genericRepository = new GenericRepository<ComprobanteDetalle>();
        }
        public void Save(List<VoucherDetailModel> voucherDetail, int id_comprobante)
        {
            foreach (var item in voucherDetail)
            {
                ComprobanteDetalle comprobanteDetalle = new ComprobanteDetalle();

                comprobanteDetalle.id_comprobante = id_comprobante;
                comprobanteDetalle.id_tipo_rechazo = item.Id_tipo_rechazo;
                comprobanteDetalle.linea = item.Linea;
                comprobanteDetalle.id_articulo = item.Id_articulo;
                comprobanteDetalle.cantidad = item.Cantidad;
                comprobanteDetalle.id_pallet = item.Id_pallet;
                comprobanteDetalle.CreatedBy = Environment.UserName;
                comprobanteDetalle.CreatedOn = DateTime.Now;

                genericRepository.Create(comprobanteDetalle);
            }
        }
    }
}