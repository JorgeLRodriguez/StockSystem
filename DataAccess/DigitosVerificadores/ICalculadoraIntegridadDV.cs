using System;

namespace DataAccess.DigitosVerificadores
{
    interface ICalculadoraIntegridadDV
    {
        bool ComprobarIntegridad(Type tipoEntidad);
    }
}