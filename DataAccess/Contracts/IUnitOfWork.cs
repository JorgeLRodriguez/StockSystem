using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IUnitOfWork
    {
        IGenericRepository<Numerador> NumeradorRepository { get; }
        IGenericRepository<Comprobante> ComprobanteRepository { get; }
        IGenericRepository<Articulo> ArticuloRepository { get; }
        IGenericRepository<Cliente> ClienteRepository { get; }
        IGenericRepository<Usuario> UsuarioRepository { get; }
        IGenericRepository<Etiqueta> EtiquetaRepository { get; }
        ILogRepository LogRepository { get; }
        IIdiomaRepository IdiomaRepository { get; }
        void SaveChanges();
    }
}