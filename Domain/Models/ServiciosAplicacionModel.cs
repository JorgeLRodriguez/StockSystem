﻿using Domain.Contracts;
using Domain.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ServiciosAplicacionModel : IServiciosAplicacion
    {
        private ConfigGlobal _configGlobal;
        private readonly EnlazadorDeDependencias _enlazadorDeDependencias;

        public ServiciosAplicacionModel(ConfigGlobal configuracion)
        {
            _configGlobal = configuracion;
            _enlazadorDeDependencias = new EnlazadorDeDependencias();
        }
        public ITraductorUsuario TraductorUsuario
        {
            get { return _enlazadorDeDependencias.Resolver<ITraductorUsuario>(); }
        }
        public void Dispose()
        {
            _enlazadorDeDependencias?.Dispose();
        }
    }
}