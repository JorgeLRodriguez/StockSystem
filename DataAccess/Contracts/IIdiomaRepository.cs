using Entities;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IIdiomaRepository
    {
        IList<Idioma> ObtenerIdiomasSoportados();
    }
}
