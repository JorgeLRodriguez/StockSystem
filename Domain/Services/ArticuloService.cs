using System.Collections.Generic;
using Domain.Models;
using Entities;

namespace Domain.Services
{
    public class ArticuloService
    {
        private readonly ArticuloModel articleModel = new ArticuloModel();
        public IEnumerable<Articulo> GetbyClient(int? id_cliente = null)
        {
            return articleModel.GetByClient(id_cliente);
        }
        public Articulo GetbyID (int id)
        {
            return articleModel.GetByID(id);
        }
    }
}