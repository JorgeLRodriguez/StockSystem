using System;

namespace DataAccess.Contracts
{
    interface ICalculadoraIntegridadDV
    {
        bool ComprobarIntegridad(Type tipoEntidad);
    }
}