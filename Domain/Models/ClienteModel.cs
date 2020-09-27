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
        private int idCliente;
        private string cuit;
        private string descripcion;
        private bool activo;
        public int Id {  get => idCliente; set => idCliente = value; }
        public string Cuit { private get => cuit; set => cuit = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Activo { private get => activo; set => activo = value; }

        private readonly IUnitOfWork clienteRepository;
        public ClienteModel()
        {
            clienteRepository = new UnitOfWork();
        }

        public List<ClienteModel> Get()
        {
            var clientDataModel = clienteRepository.ClienteRepository.Get();
            var listClients = new List<ClienteModel>();
            foreach (Cliente item in clientDataModel)
            {
                listClients.Add(new ClienteModel
                {
                    idCliente = item.ID,
                    cuit = item.Cuit,
                    descripcion = item.Descripcion,
                    activo = item.Activo
                });
            }
            return listClients;
        }
    }
}