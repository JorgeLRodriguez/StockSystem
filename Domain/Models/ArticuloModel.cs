using DataAccess.Contracts;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using Entities;
using Language;
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
        private readonly LogModel logModel;
        private IEnumerable<Articulo> articulos;
        private Articulo articulo;
        private Log log;
        public ArticuloModel()
        {
            unitOfWork = UnitOfWork.instance();
            logModel = LogModel.instance();
            log = new Log();
        }
        public IEnumerable<Articulo> GetbyClient(int? id_cliente)
        {
            try
            {
                articulos = unitOfWork.ArticuloRepository.Get(filter: x => x.id_cliente == id_cliente);

            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new Exception (ex.Message);
            }
            if (!articulos.Any()) throw new ApplicationException(strings.ErrorSinRegistros);
            return articulos;
        }
        public Articulo GetbyID (int id)
        {
            try
            {
                articulo = unitOfWork.ArticuloRepository.GetById(id);
            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            if (articulo == null) throw new ApplicationException(strings.ErrorSinRegistros);
            return articulo;
        }
    }
}