using Entities.Bitacora;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IBitacora
    {
        Entities.Bitacora.Evento[] ObtenerEventosDisponibles(ITraductor traductor);
        IEnumerable<Bitacora> ObtenerTodasLasEntradasEnBitacora(ITraductor traductor);
        IEnumerable<Bitacora> ObtenerTodasLasEntradasEnBitacora(ITraductor traductor, DateTime desde, DateTime hasta, Evento evento);
        void RegistrarEnBitacora(int tipoEvento, string mensaje);
        void RegistrarEnBitacora(int tipoEvento, Severidad severidad, string mensaje);
        void RegistrarEnBitacora(int tipoEvento, Severidad severidad, string mensaje, Usuario usuario);
        void RegistrarEnBitacora(Bitacora entradaEnBitacora);
    }
}
