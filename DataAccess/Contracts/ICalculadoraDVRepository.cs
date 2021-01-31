using Entities.Security;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface ICalculadoraDVRepository
    {
        bool EsValido(IDigitoVerificadorHorizontal entity);
        byte[] CalcularDigitoVerificadorParaEntidad(IDigitoVerificadorHorizontal entity);
        byte[] CalcularDigitoVerificadorDesdeMultiplesDigitos(IEnumerable<byte[]> crcs);
    }
}
