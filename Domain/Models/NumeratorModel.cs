using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class NumeratorModel
    {
        private int ID;
        private DateTime? createdOn;
        private string createdBy;
        private DateTime? changedOn;
        private string changedBy;
        private string id_tipo_comprobante;
        private string letra;
        private int sucursal;
        private int numero;
        public int ID1 { get => ID; set => ID = value; }
        public DateTime? CreatedOn { get => createdOn; set => createdOn = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime? ChangedOn { get => changedOn; set => changedOn = value; }
        public string ChangedBy { get => changedBy; set => changedBy = value; }
        public string Id_tipo_comprobante { get => id_tipo_comprobante; set => id_tipo_comprobante = value; }
        public string Letra { get => letra; set => letra = value; }
        public int Sucursal { get => sucursal; set => sucursal = value; }
        public int Numero { get => numero; set => numero = value; }

        private INumeratorRepository numeratorRepository;
        public NumeratorModel()
        {
            numeratorRepository = new NumeratorRepository();
        }
        public List<NumeratorModel> Get()
        {
            var numeratorDataModel = numeratorRepository.Get();
            var listNumerator = new List<NumeratorModel>();
            foreach (Numerador item in numeratorDataModel)
            {
                listNumerator.Add(new NumeratorModel
                {
                    id_tipo_comprobante = item.id_tipo_comprobante,
                    letra = item.letra,
                    sucursal = item.sucursal,
                    numero = item.numero,
                });
            }
            return listNumerator;
        }
        public NumeratorModel Get(string id_tipo_comprobante, string letra, int sucursal)
        {
            var numeratorDataModel = numeratorRepository.Get(id_tipo_comprobante, letra, sucursal);
            var numerator = new NumeratorModel();
            numerator.ID = numeratorDataModel.ID;
            numerator.id_tipo_comprobante = numeratorDataModel.id_tipo_comprobante;
            numerator.letra = numeratorDataModel.letra;
            numerator.sucursal = numeratorDataModel.sucursal;
            numerator.numero = numeratorDataModel.numero + 1;
            return numerator;
        }

        public void Update (NumeratorModel numerator)
        {
            Numerador numeratorDataModel = new Numerador();
            numeratorDataModel.ID = numerator.ID;
            numeratorDataModel.id_tipo_comprobante = numerator.id_tipo_comprobante;
            numeratorDataModel.letra = numerator.letra;
            numeratorDataModel.sucursal = numerator.sucursal;
            numeratorDataModel.numero = numerator.numero;
            numeratorDataModel.ChangedBy = Environment.UserName;
            numeratorDataModel.ChangedOn = DateTime.Now;

            numeratorRepository.Update(numeratorDataModel);
        }
    }
}
