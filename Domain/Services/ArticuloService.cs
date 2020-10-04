﻿using System;
using System.Collections.Generic;
using Domain.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Domain.Services
{
    public class ArticuloService
    {
        private readonly ArticuloModel articleModel = new ArticuloModel();
        public IEnumerable<Articulo> GetbyClient(int? id_cliente = null)
        {
            return articleModel.GetbyClient(id_cliente);
        }
        public Articulo GetbyID (int id)
        {
            return articleModel.GetbyID(id);
        }
    }
}