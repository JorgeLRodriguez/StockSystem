using DataAccess.Contracts;
using Entities;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class IdiomaRepository : IIdiomaRepository
    {
        public IList<Idioma> ObtenerIdiomasSoportados()
        {
            return new List<Idioma>
            {
                new Idioma {CodigoIso = "es-AR", Nombre = "Español (Argentina)"},
                new Idioma {CodigoIso = "en-US", Nombre = "English (United States)"},
            };
        }
    }
}
