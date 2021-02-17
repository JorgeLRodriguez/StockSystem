using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class ClienteModel : ICliente
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
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
                Log.Save(this, ex);
                throw ex;
            }
            return clientes ?? throw new Exception(ConstantesTexto.Cliente + ": " + ConstantesTexto.ErrorSinRegistros);
        }
        public Cliente GetByCuit(string cuit)
        {
            Cliente C;
            try
            {
                C = _unitOfWork.ClienteRepository.Get(filter: x => x.Cuit.Equals(cuit)).FirstOrDefault();
            }
            catch(Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            return C ?? throw new Exception(ConstantesTexto.Cliente + ": " + ConstantesTexto.ErrorSinRegistros);
        }
    }
}