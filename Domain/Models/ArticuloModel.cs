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
        public ArticuloModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
                Log.Save(this, ex);
                throw ex;
            }
            if (!articulos.Any()) throw new Exception(ConstantesTexto.Articulo + ": " + ConstantesTexto.ErrorSinRegistros);
            return articulos;
        }
        public Articulo GetByID (int id)
        {
            Articulo A = null;
            try
            {
                A = _unitOfWork.ArticuloRepository.GetById(id);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            return A ?? throw new Exception(ConstantesTexto.Articulo + ": " + ConstantesTexto.ErrorSinRegistros);
        }
        public Articulo GetByFS (string codigoFS)
        {
            Articulo A = null;
            try
            {
                A = _unitOfWork.ArticuloRepository.Get(filter: x => x.Codigo_fs.Equals(codigoFS)).FirstOrDefault();
                    
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            return A ?? throw new Exception(ConstantesTexto.Articulo + ": " + ConstantesTexto.ErrorSinRegistros);
        }
    }
}