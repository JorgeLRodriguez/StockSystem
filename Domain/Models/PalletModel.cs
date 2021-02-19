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
    public class PalletModel : IPallet
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public PalletModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Pallet Create(Pallet Pallet)
        {
            try
            {
                Pallet = _unitOfWork.PalletRepository.Create(Pallet);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            return Pallet;
        }
        public void Delete(int id)
        {
            try
            {
                _unitOfWork.PalletRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
        }
        public void Edit(Pallet Pallet)
        {
            try
            {
                _unitOfWork.PalletRepository.Update(Pallet);
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
        }
        public IEnumerable<Pallet> GetAlL()
        {
            IEnumerable<Pallet> pal;
            try
            {
                pal = _unitOfWork.PalletRepository.Get();
            }
            catch (Exception ex)
            {
                Log.Save(this, ex);
                throw ex;
            }
            if (pal.Equals(null) || pal.Count() == 0) throw new Exception(ConstantesTexto.ErrorSinRegistros);
            return pal;
        }
    }
}
