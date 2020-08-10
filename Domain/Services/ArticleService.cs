using System;
using System.Collections.Generic;
using Domain.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ArticleService
    {
        ArticleModel articleModel = new ArticleModel();
        public List<ArticleModel> get()
        {
            return articleModel.GetArticles();
        }
    }
}