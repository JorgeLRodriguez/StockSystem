using System;

namespace DataAccess.Contracts
{
    interface ICalculadoraIntegridadDVRepository
    {
        bool ComprobarIntegridad(Type tipoEntidad);
    }
}