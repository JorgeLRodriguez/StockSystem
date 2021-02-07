using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class ArticuloModel : IArticulo
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        //private readonly LogModel logModel;
        public ArticuloModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //logModel = LogModel.Instance();
        }
        public IEnumerable<Articulo> GetByClient(int? id_cliente)
        {
            IEnumerable<Articulo> articulos;
            try
            {
                articulos = _unitOfWork.ArticuloRepository.Get(filter: x => x.Cliente_ID == id_cliente);

            }
            catch (Exception ex)
            {
                //logModel.Log(new Log(), ex);
                throw new Exception (ex.Message);
            }
            if (!articulos.Any()) throw new ApplicationException(ConstantesTexto.ErrorSinRegistros);
            return articulos;
        }
        public Articulo GetByID (int id)
        {
            try
            {
                return _unitOfWork.ArticuloRepository.GetById(id) ?? throw new Exception(ConstantesTexto.ErrorSinRegistros);
            }
            catch (Exception ex)
            {
                //_unitOfWork.Log(new Log(), ex);
                throw new Exception(ex.Message);
            }
        }
    }
}