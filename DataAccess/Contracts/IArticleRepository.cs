using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IArticleRepository
    {
        List<Articulo> Get();
        //T GetById(int id);
        Articulo Create(Articulo article);
        void Update(Articulo article);
        void Delete(int id);
    }
}
