﻿using DataAccess.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        IGenericRepository<Numerador> NumeradorRepository { get; }
        //IGenericRepository<Comprobante> ComprobanteRepository { get; }
        IComprobanteRepository ComprobanteRepository { get; }
        IGenericRepository<Articulo> ArticuloRepository { get; }
        IGenericRepository<Cliente> ClienteRepository { get; }
        IGenericRepository<Etiqueta> EtiquetaRepository { get; }
        IIdiomaRepository IdiomaRepository { get; }
        IBitacoraRepository BitacoraRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        ICalculadoraIntegridadDVRepository CalculadoraIntegridadDVRepository { get; }
        void SaveChanges();
    }
}