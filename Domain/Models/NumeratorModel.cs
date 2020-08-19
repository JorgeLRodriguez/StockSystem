using DataAccess.Contracts;
using Entities;
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
        private readonly INumeratorRepository numeratorRepository;
        public NumeratorModel()
        {
            numeratorRepository = new NumeratorRepository();
        }
        public List<Numerador> Get()
        {
            var numeratorDataModel = numeratorRepository.Get();
            var listNumerator = new List<Numerador>();
            foreach (Numerador item in numeratorDataModel)
            {
                Numerador numerador = new Numerador();
                numerador.ID = item.ID;
                numerador.id_tipo_comprobante = item.id_tipo_comprobante;
                numerador.letra = item.letra;
                numerador.sucursal = item.sucursal;
                numerador.numero = item.numero;
                listNumerator.Add(numerador);
            }
            return listNumerator;
        }
        public Numerador Get(string id_tipo_comprobante, string letra, int sucursal)
        {
            var numerador = numeratorRepository.Get(id_tipo_comprobante, letra, sucursal);
            return numerador;
        }

        public void Update (Numerador numerador)
        {
            numerador.ChangedBy = Environment.UserName;
            numerador.ChangedOn = DateTime.Now;
            numeratorRepository.Update(numerador);
        }
    }
}
