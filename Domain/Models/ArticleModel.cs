using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ArticleModel
    {
        private int id_articulo;
        private string codigo_fs;
        private string descripcion;
        private int idCliente;
        private string codigo_barra;
        private bool tiene_codigo_barra;

        public int Id_articulo { get => id_articulo; set => id_articulo = value; }
        public string Codigo_fs { get => codigo_fs; set => codigo_fs = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Codigo_barra { get => codigo_barra; set => codigo_barra = value; }
        public bool Tiene_codigo_barra { get => tiene_codigo_barra; set => tiene_codigo_barra = value; }

        private IGenericRepository<Articulo> genericRepository;
        public ArticleModel()
        {
            genericRepository = new GenericRepository<Articulo>();
        }
        public List<ArticleModel> GetArticles()
        {
            var articleDataModel = genericRepository.Get();
            var listArticles = new List<ArticleModel>();
            foreach (Articulo item in articleDataModel)
            {
                listArticles.Add(new ArticleModel
                {
                    Id_articulo = item.Id,
                    codigo_fs = item.Codigo_fs,
                    descripcion = item.Descripcion,
                    idCliente = item.IdCliente,
                    codigo_barra = item.codigo_barra,
                    tiene_codigo_barra = item.tiene_codigo_barra
                });
            }
            return listArticles;
        }
    }
}
