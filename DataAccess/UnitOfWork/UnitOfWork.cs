using DataAccess.Contracts;
using DataAccess.UnitOfWork;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected Repository _db;
        private GenericRepository<Comprobante> _ComprobanteRepository;
        private GenericRepository<Numerador> _NumeradorRepository;
        private GenericRepository<Articulo> _ArticuloRepository;
        private GenericRepository<Cliente> _ClienteRepository;
        private GenericRepository<Usuario> _UsuarioRepository;
        public UnitOfWork()
        {
            _db = new Repository();
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
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}