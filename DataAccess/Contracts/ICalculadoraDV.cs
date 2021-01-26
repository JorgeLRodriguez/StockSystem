using Entities;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface ICalculadoraDV
    {
        bool EsValido(IDigitoVerificadorHorizontal entity);
        byte[] CalcularDigitoVerificadorParaEntidad(IDigitoVerificadorHorizontal entity);
        byte[] CalcularDigitoVerificadorDesdeMultiplesDigitos(IEnumerable<byte[]> crcs);
    }
}
