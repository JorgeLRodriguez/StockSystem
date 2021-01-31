using DataAccess.Contracts;
using DataAccess.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ClienteModel
    {
        private readonly IUnitOfWorkRepository unitOfWork;
        private readonly LogModel logModel;
        private IEnumerable<Cliente> clientes;
        private Log log;
        public ClienteModel()
        {
            //unitOfWork = new UnitOfWorkRepository();
            log = new Log();
        }

        public IEnumerable<Cliente> Get()
        {
            try
            {
                clientes = unitOfWork.ClienteRepository.Get();
            }
            catch (Exception ex)
            {
                logModel.Log(log, ex);
                throw new Exception(ex.Message);
            }
            if (clientes == null) throw new ApplicationException("strings.ErrorSinRegistros");
            return clientes;
        }
    }
}