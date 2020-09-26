using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IUserRepository : IGenericRepository<Usuario>
    {
        //List<Usuario> Get();
        ////T GetById(int id);
        //Usuario Create(Usuario usuario);
        //void Update(Usuario usuario);
        //void Delete(int id);
    }
}