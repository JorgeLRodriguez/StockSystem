using DataAccess.Contracts;
using Entities.Bitacora;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    internal class BitacoraRepository : IBitacoraRepository
    {
        private readonly DatabaseContext _context;
        public BitacoraRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Evento[] EventosDisponibles
        {
            get
            {
                //Enumero por reflexión los tipos de eventos disponibles en el sistema
                var camposDeEvento = typeof(Evento).GetFields();
                return camposDeEvento
                    .Select(campo => new Evento
                    {
                        Id = (int)campo.GetRawConstantValue(),
                        Descripcion = campo.Name
                    })
                    .ToArray();
            }
        }
        public IEnumerable<Bitacora> ObtenerTodasLasEntradasEnBitacora()
        {
            return _context.Set<Bitacora>()
                .Include("Usuario")
                .AsNoTracking()
                .ToList();
        }

        public void RegistrarEnBitacora(Bitacora entradaEnBitacora)
        {
            _context.Set<Bitacora>().Add(entradaEnBitacora);
        }
    }
}