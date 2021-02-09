using System;

namespace DataAccess.Contracts
{
    public interface ICalculadoraIntegridadDVRepository
    {
        bool ComprobarIntegridad(Type tipoEntidad);
    }
}