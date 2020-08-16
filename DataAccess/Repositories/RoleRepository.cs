using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RoleRepository : IRole
    {
        protected Repository _db;
        public RoleRepository()
        {
            _db = new Repository();
        }
        public Rol Create(Rol article)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rol> Get()
        {
            throw new NotImplementedException();
        }

        public Rol GetById(int id)
        {
            Rol rol  = new Rol();
            using (_db)
            {
                var query = from u in _db.Rol
                            where u.ID == id
                            select u;
                rol.ID = query.FirstOrDefault<Rol>().ID;
                rol.Descripcion = query.FirstOrDefault<Rol>().Descripcion;
                rol.NivelAcceso = query.FirstOrDefault<Rol>().NivelAcceso;
            }
            return rol;
        }

        public void Update(Rol article)
        {
            throw new NotImplementedException();
        }
    }
}
