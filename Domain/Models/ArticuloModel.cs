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
    public class ArticuloModel
    {
        private int Id;
        private string codigo_fs;
        private string descripcion;
        private int idCliente;
        private string codigo_barra;
        private bool tiene_codigo_barra;

        public int ID { get => Id; set => Id = value; }
        public string Codigo_fs { get => codigo_fs; set => codigo_fs = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Codigo_barra { get => codigo_barra; set => codigo_barra = value; }
        public bool Tiene_codigo_barra { get => tiene_codigo_barra; set => tiene_codigo_barra = value; }

        //private readonly IGenericRepository <Articulo> genericRepository;
        //public ArticleModel()
        //{
        //    genericRepository = new GenericRepository<Articulo>();
        //}
        private readonly IUnitOfWork unitOfWork;
        public ArticuloModel()
        {
            unitOfWork = new UnitOfWork();
        }
        public List<ArticuloModel> Get()
        {
            //var articleDataModel = genericRepository.Get();
            var articleDataModel = unitOfWork.ArticuloRepository.Get();
            var listArticles = new List<ArticuloModel>();
            foreach (Articulo item in articleDataModel)
            {
                listArticles.Add(new ArticuloModel
                {
                    ID = item.ID,
                    codigo_fs = item.Codigo_fs,
                    descripcion = item.Descripcion,
                    idCliente = item.id_cliente,
                    codigo_barra = item.codigo_barra,
                    tiene_codigo_barra = item.tiene_codigo_barra
                });
            }
            return listArticles;
        }
    }
}