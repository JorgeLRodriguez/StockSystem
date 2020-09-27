using Domain.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ClienteService
    {
        private ClienteModel CM;
        public ClienteService()
        {
            CM = new ClienteModel();
        }
        public IEnumerable<Cliente> Get()
        {
            return CM.Get();
        }
    }
}
