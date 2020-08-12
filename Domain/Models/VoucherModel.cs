using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Domain.Models
{
    public class VoucherModel
    {
        private int iD;
        private DateTime? createdOn;
        private string createdBy;
        private DateTime? changedOn;
        private string changedBy;
        private int id_cliente;
        private string id_tipo_comprobante;
        private string letra_comprobante;
        private int suc_comprobante;
        private int num_comprobante;
        private string nro_remito_cliente;
        private DateTime? fecha_comprobante;
        private char cierre;
        private int id_destinatario;
        private string observaciones;

        public int ID { get => iD; set => iD = value; }
        public DateTime? CreatedOn { get => createdOn; set => createdOn = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime? ChangedOn { get => changedOn; set => changedOn = value; }
        public string ChangedBy { get => changedBy; set => changedBy = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Id_tipo_comprobante { get => id_tipo_comprobante; set => id_tipo_comprobante = value; }
        public string Letra_comprobante { get => letra_comprobante; set => letra_comprobante = value; }
        public int Suc_comprobante { get => suc_comprobante; set => suc_comprobante = value; }
        public int Num_comprobante { get => num_comprobante; set => num_comprobante = value; }
        public string Nro_remito_cliente { get => nro_remito_cliente; set => nro_remito_cliente = value; }
        public DateTime? Fecha_comprobante { get => fecha_comprobante; set => fecha_comprobante = value; }
        public char Cierre { get => cierre; set => cierre = value; }
        public int Id_destinatario { get => id_destinatario; set => id_destinatario = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

        private IGenericRepository<Comprobante> genericRepository;
        public VoucherModel()
        {
            genericRepository = new GenericRepository<Comprobante>();
        }
        public int Save(VoucherModel voucherModel)
        {
            Comprobante comprobante = new Comprobante();

            comprobante.id_cliente = voucherModel.Id_cliente;
            comprobante.id_destinatario = voucherModel.Id_destinatario;
            comprobante.id_tipo_comprobante = voucherModel.Id_tipo_comprobante;
            comprobante.letra_comprobante = voucherModel.Letra_comprobante;
            comprobante.nro_remito_cliente = voucherModel.Nro_remito_cliente;
            comprobante.num_comprobante = voucherModel.Num_comprobante;
            comprobante.observaciones = voucherModel.Observaciones;
            comprobante.fecha_comprobante = voucherModel.Fecha_comprobante;
            comprobante.suc_comprobante = voucherModel.Suc_comprobante;
            comprobante.cierre = voucherModel.Cierre;
            comprobante.ChangedBy = voucherModel.ChangedBy;
            comprobante.ChangedOn = voucherModel.ChangedOn;
            comprobante.CreatedBy = voucherModel.CreatedBy;
            comprobante.CreatedOn = voucherModel.CreatedOn;

            genericRepository.Create(comprobante);
            return comprobante.ID;
        }
    }
}
