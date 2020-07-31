using DAL.Contracts;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ClientModel
    {
        private int idCliente;
        private string cuit;
        private string descripcion;
        private bool activo;
        public int Id {  get => idCliente; set => idCliente = value; }
        public string Cuit { private get => cuit; set => cuit = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Activo { private get => activo; set => activo = value; }

        private IGenericRepository<Cliente> genericRepository;
        public ClientModel()
        {
            genericRepository = new GenericRepository<Cliente>();
        }

        public List<ClientModel> GetClients()
        {
            var clientDataModel = genericRepository.Get();
            var listClients = new List<ClientModel>();
            foreach (Cliente item in clientDataModel)
            {
                listClients.Add(new ClientModel
                {
                    idCliente = item.IdCliente,
                    cuit = item.Cuit,
                    descripcion = item.Descripcion,
                    activo = item.Activo
                });
            }
            return listClients;
        }
    }
}