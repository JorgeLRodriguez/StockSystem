using DataAccess.Contracts;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private protected Repository _db;
        private static UnitOfWork _instance = null;
        private GenericRepository<Comprobante> _ComprobanteRepository;
        private GenericRepository<Numerador> _NumeradorRepository;
        private GenericRepository<Articulo> _ArticuloRepository;
        private GenericRepository<Cliente> _ClienteRepository;
        private GenericRepository<Usuario> _UsuarioRepository;
        private LogRepository _LogRepository;

        public static UnitOfWork instance()
        {
            return _instance = _instance ?? new UnitOfWork();
        }
        public UnitOfWork()
        {
            _db = Repository.instance();
        }
        public IGenericRepository<Numerador> NumeradorRepository
        {
            get
            {
                return _NumeradorRepository = _NumeradorRepository ?? new GenericRepository<Numerador>(_db);
            }
        }
        public IGenericRepository<Comprobante> ComprobanteRepository
        {
            get
            {
                return _ComprobanteRepository = _ComprobanteRepository ?? new GenericRepository<Comprobante>(_db);
            }
        }
        public IGenericRepository<Articulo> ArticuloRepository
        {
            get
            {
                return _ArticuloRepository = _ArticuloRepository ?? new GenericRepository<Articulo>(_db);
            }
        }
        public IGenericRepository<Cliente> ClienteRepository
        {
            get
            {
                return _ClienteRepository = _ClienteRepository ?? new GenericRepository<Cliente>(_db);
            }
        }
        public IGenericRepository<Usuario> UsuarioRepository
        {
            get
            {
                return _UsuarioRepository = _UsuarioRepository ?? new GenericRepository<Usuario>(_db);
            }
        }
        public ILogRepository LogRepository
        {
            get
            {
                return _LogRepository = _LogRepository ?? new LogRepository(_db);
            }
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}