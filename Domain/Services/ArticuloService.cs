using System;
using System.Collections.Generic;
using Domain.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ArticuloService
    {
        private readonly ArticuloModel articleModel = new ArticuloModel();
        public List<ArticuloModel> Get()
        {
            return articleModel.Get();
        }
    }
}