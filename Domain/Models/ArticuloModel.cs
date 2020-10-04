using DataAccess.Contracts;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ArticuloModel
    {
        private readonly IUnitOfWork unitOfWork;
        private IEnumerable<Articulo> articulos;
        public ArticuloModel()
        {
            unitOfWork = new UnitOfWork();
        }
        public IEnumerable<Articulo> GetbyClient(int? id_cliente)
        {
            try
            {
                articulos = unitOfWork.ArticuloRepository.Get(filter: x => x.id_cliente == id_cliente);

            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            if (!articulos.Any()) throw new ApplicationException("No se encontraron registros.");
            return articulos;
        }
        public Articulo GetbyID (int id)
        {
            try
            {
                return unitOfWork.ArticuloRepository.GetById(id);
            }
            catch (Exception ex)
            {
                //log
                return null;
            }
        }
    }
}