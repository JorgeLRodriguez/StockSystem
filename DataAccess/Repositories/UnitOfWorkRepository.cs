using DataAccess.Contracts;
using Entities;
using System;

namespace DataAccess.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        #region "Singleton"
        private static readonly Lazy<IUnitOfWorkRepository> _default = new Lazy<IUnitOfWorkRepository>(() => new UnitOfWorkRepository(new DatabaseContext()));

        public static IUnitOfWorkRepository Default
        {
            get { return _default.Value; }
        }
        #endregion
        private readonly DatabaseContext _db;
        public UnitOfWorkRepository(DatabaseContext _context)
        {
            _db = _context;
            NumeradorRepository = new GenericRepository<Numerador>(_db);
            ComprobanteRepository = new ComprobanteRepository(_db);
            ArticuloRepository = new GenericRepository<Articulo>(_db);
            ClienteRepository = new GenericRepository<Cliente>(_db);
            DestinatarioRepository = new GenericRepository<Destinatario>(_db);
            RemitoStockRepository = new GenericRepository<RemitoStock>(_db);
            UsuarioRepository = new UsuarioRepository(_db);
            IdiomaRepository = new IdiomaRepository();
            BitacoraRepository = new BitacoraRepository(_db);
            CalculadoraIntegridadDVRepository = new CalculadoraIntegridadDVRepository(_db);
            PasilloRepository = new GenericRepository<Pasillo>(_db);
            PalletRepository = new GenericRepository<Pallet>(_db);
            DepositoRepository = new GenericRepository<Deposito>(_db);
        }
        public IGenericRepository<Numerador> NumeradorRepository { get; }
        public IComprobanteRepository ComprobanteRepository { get; }
        public IGenericRepository<Articulo> ArticuloRepository { get; }
        public IGenericRepository<Cliente> ClienteRepository { get; }
        public IGenericRepository<Destinatario> DestinatarioRepository { get; }
        public IGenericRepository<RemitoStock> RemitoStockRepository { get; }
        public IIdiomaRepository IdiomaRepository { get; }
        public IBitacoraRepository BitacoraRepository { get; }
        public IUsuarioRepository UsuarioRepository { get; }
        public ICalculadoraIntegridadDVRepository CalculadoraIntegridadDVRepository { get; }
        public IGenericRepository<Pasillo> PasilloRepository { get; }
        public IGenericRepository<Deposito> DepositoRepository { get; }
        public IGenericRepository<Pallet> PalletRepository { get; }
        public void Dispose() { _db.Dispose(); }
        public void SaveChanges() { _db.SaveChanges(); }
    }
}