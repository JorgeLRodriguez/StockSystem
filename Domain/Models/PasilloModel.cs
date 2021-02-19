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
    public class PasilloModel : IPasillo
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public PasilloModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Pasillo Create(Pasillo Pasillo)
        {
            try
            {
                Pasillo = _unitOfWork.PasilloRepository.Create(Pasillo);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            return Pasillo;
        }
        public void Delete(int id)
        {
            try
            {
                _unitOfWork.PasilloRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
        }
        public void Edit(Pasillo Pasillo)
        {
            try
            {
                _unitOfWork.PasilloRepository.Update(Pasillo);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
        }
        public IEnumerable<Pasillo> GetAlL()
        {
            IEnumerable<Pasillo> pas;
            try
            {
                pas = _unitOfWork.PasilloRepository.Get();
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            if (pas.Equals(null) || pas.Count() == 0) throw new Exception(ConstantesTexto.ErrorSinRegistros);
            return pas;
        }
    }
}
