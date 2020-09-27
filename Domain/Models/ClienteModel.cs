using DataAccess.Contracts;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
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
        private readonly IUnitOfWork clienteRepository;
        public ClienteModel()
        {
            clienteRepository = new UnitOfWork();
        }

        public IEnumerable<Cliente> Get()
        {
            return clienteRepository.ClienteRepository.Get();
        }
    }
}