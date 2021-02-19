using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DepositoModel : IDeposito
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public DepositoModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Deposito Create(Deposito deposito)
        {
            try
            {
                deposito = _unitOfWork.DepositoRepository.Create(deposito);
            }
            catch(Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            return deposito;
        }
        public void Delete(int id)
        {
            try
            {
                _unitOfWork.DepositoRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
        }
        public void Edit(Deposito deposito)
        {
            try
            {
                _unitOfWork.DepositoRepository.Update(deposito);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
        }
        public IEnumerable<Deposito> GetAlL()
        {
            IEnumerable<Deposito> dep;
            try
            {
                dep =_unitOfWork.DepositoRepository.Get();
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            if (dep.Equals(null) || dep.Count() == 0) throw new Exception(ConstantesTexto.ErrorSinRegistros);
            return dep;
        }
    }
}
