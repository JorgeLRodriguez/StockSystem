using DataAccess.Contracts;
using DataAccess.Repositories;
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
        private readonly IUnitOfWork _unitOfWork;
        private readonly LogModel logModel;
        public ArticuloModel()
        {
            _unitOfWork = UnitOfWork.Instance();
            logModel = LogModel.Instance();
        }
        public IEnumerable<Articulo> GetbyClient(int? id_cliente)
        {
            IEnumerable<Articulo> articulos;
            try
            {
                articulos = _unitOfWork.ArticuloRepository.Get(filter: x => x.Cliente_ID == id_cliente);

            }
            catch (Exception ex)
            {
                logModel.Log(new Log(), ex);
                throw new Exception (ex.Message);
            }
            if (!articulos.Any()) throw new ApplicationException(strings.ErrorSinRegistros);
            return articulos;
        }
        public Articulo GetbyID (int id)
        {
            try
            {
                return _unitOfWork.ArticuloRepository.GetById(id) ?? throw new Exception(strings.ErrorSinRegistros);
            }
            catch (Exception ex)
            {
                logModel.Log(new Log(), ex);
                throw new Exception(ex.Message);
            }
        }
        public object Read(int id)
        {
            try
            {
                return _unitOfWork.ArticuloRepository.GetById(id) ?? throw new Exception(strings.ErrorSinRegistros);
            }
            catch (Exception ex)
            {
                logModel.Log(new Log(), ex);
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<object> ReadAll(int? id_cliente)
        {
            IEnumerable<Articulo> articulos;
            try
            {
                articulos = _unitOfWork.ArticuloRepository.Get(filter: x => x.Cliente_ID == id_cliente);

            }
            catch (Exception ex)
            {
                logModel.Log(new Log(), ex);
                throw new Exception(ex.Message);
            }
            if (!articulos.Any()) throw new ApplicationException(strings.ErrorSinRegistros);
            return articulos;
        }
    }
}