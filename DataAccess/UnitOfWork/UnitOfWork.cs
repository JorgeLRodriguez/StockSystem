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
        private protected DatabaseContext _db;
        private static UnitOfWork _instance;
        private IGenericRepository<Comprobante> _ComprobanteRepository;
        private IGenericRepository<Numerador> _NumeradorRepository;
        private IGenericRepository<Articulo> _ArticuloRepository;
        private IGenericRepository<Cliente> _ClienteRepository;
        private IGenericRepository<Usuario> _UsuarioRepository;
        private IGenericRepository<Etiqueta> _EtiquetaRepository;
        private ILogRepository _LogRepository;

        public UnitOfWork()
        {
            _db = DatabaseContext.Instance();
        }
        public static UnitOfWork Instance()
        {
            return _instance = _instance ?? new UnitOfWork();
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
        public IGenericRepository<Etiqueta> EtiquetaRepository
        {
            get
            {
                return _EtiquetaRepository = _EtiquetaRepository ?? new GenericRepository<Etiqueta>(_db);
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