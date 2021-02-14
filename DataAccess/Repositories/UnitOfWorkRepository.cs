using DataAccess.Contracts;
using Entities;
using Entities.Infraestructure;
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
            ComprobanteRepository = new GenericRepository<Comprobante>(_db);
            ArticuloRepository = new GenericRepository<Articulo>(_db);
            ClienteRepository = new GenericRepository<Cliente>(_db);
            UsuarioRepository = new UsuarioRepository(_db);
            EtiquetaRepository = new GenericRepository<Etiqueta>(_db);
            IdiomaRepository = new IdiomaRepository();
            BitacoraRepository = new BitacoraRepository(_db);
            CalculadoraIntegridadDVRepository = new CalculadoraIntegridadDVRepository(_db);
        }
        public IGenericRepository<Numerador> NumeradorRepository { get; }
        public IGenericRepository<Comprobante> ComprobanteRepository { get; }
        public IGenericRepository<Articulo> ArticuloRepository { get; }
        public IGenericRepository<Cliente> ClienteRepository { get; }
        public IGenericRepository<Etiqueta> EtiquetaRepository { get; }
        public IIdiomaRepository IdiomaRepository { get; }
        public IBitacoraRepository BitacoraRepository { get; }
        public IUsuarioRepository UsuarioRepository { get; }
        public ICalculadoraIntegridadDVRepository CalculadoraIntegridadDVRepository { get; }
        public void Dispose() { _db.Dispose(); }
        public void SaveChanges() { _db.SaveChanges(); }
    }
}