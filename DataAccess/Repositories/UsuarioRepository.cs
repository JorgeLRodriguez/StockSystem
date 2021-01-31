using DataAccess.Contracts;
using Entities.Infraestructure;
using System;
using System.Linq;

namespace DataAccess.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DatabaseContext _context;
        public UsuarioRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Usuario GetByName(string nombreUsuario)
        {
            return _context.Set<Usuario>().SingleOrDefault(x => x.Username.Equals(nombreUsuario));
        }
    }
}
