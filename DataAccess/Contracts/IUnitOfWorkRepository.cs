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
        IComprobanteRepository ComprobanteRepository { get; }
        IGenericRepository<Articulo> ArticuloRepository { get; }
        IGenericRepository<Cliente> ClienteRepository { get; }
        IGenericRepository<RemitoStock> RemitoStockRepository { get; }
        IGenericRepository<Destinatario> DestinatarioRepository { get; }
        IIdiomaRepository IdiomaRepository { get; }
        IBitacoraRepository BitacoraRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        ICalculadoraIntegridadDVRepository CalculadoraIntegridadDVRepository { get; }
        void SaveChanges();
    }
}