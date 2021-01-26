using DataAccess.Contracts;
using Entities;
using Services.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class CalculadoraDV : ICalculadoraDV
    {
        private readonly Hash _hash = new Hash();

        public bool EsValido(IDigitoVerificadorHorizontal entidad)
        {
            var calculatedHash = this.CalcularDigitoVerificadorParaEntidad(entidad);
            var currentHash = entidad.DVH ?? new byte[0];
            return calculatedHash.SequenceEqual(currentHash);
        }

        public byte[] CalcularDigitoVerificadorDesdeMultiplesDigitos(IEnumerable<byte[]> crcs)
        {
            return _hash.CreateHash(crcs);
        }

        public byte[] CalcularDigitoVerificadorParaEntidad(IDigitoVerificadorHorizontal entidad)
        {
            var seed = new StringBuilder();
            var tipoEntidad = entidad.GetType();
            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(tipoEntidad))
            {
                var fieldMarkedForRc = propertyDescriptor.Attributes
                    .OfType<DigitoVerificadorVertical>()
                    .FirstOrDefault();

                if (fieldMarkedForRc != null)
                {
                    //TODO: Verificar el orden del armado de la semilla, mientras sea la misma version de la clase no importa
                    var propertyValueSerialized = Convert.ToString(propertyDescriptor.GetValue(entidad) ?? string.Empty);
                    seed.Append(propertyValueSerialized);
                }
            }

            return _hash.CreateHash(seed.ToString());
        }
    }
}
