using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class ClienteModel : ICliente
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        //private readonly LogModel logModel;
        public ClienteModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Cliente> Get()
        {
            IEnumerable<Cliente> clientes;
            try
            {
                clientes = _unitOfWork.ClienteRepository.Get();
            }
            catch (Exception ex)
            {
                //logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            if (clientes == null) throw new Exception(ConstantesTexto.ErrorSinRegistros);
            return clientes;
        }
    }
}