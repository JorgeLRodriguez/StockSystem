using Entities.Bitacora;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IBitacoraRepository
    {
        Evento[] EventosDisponibles { get; }
        IEnumerable<Bitacora> ObtenerTodasLasEntradasEnBitacora();
        void RegistrarEnBitacora(Bitacora entradaEnBitacora);
    }
}
