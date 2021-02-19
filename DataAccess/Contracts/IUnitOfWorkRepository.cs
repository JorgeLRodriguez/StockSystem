using Entities;
using System;

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
        IGenericRepository<Pasillo> PasilloRepository { get; }
        IGenericRepository<Deposito> DepositoRepository { get; }
        IGenericRepository<Pallet> PalletRepository { get; }
        IIdiomaRepository IdiomaRepository { get; }
        IBitacoraRepository BitacoraRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        ICalculadoraIntegridadDVRepository CalculadoraIntegridadDVRepository { get; }
        void SaveChanges();
    }
}