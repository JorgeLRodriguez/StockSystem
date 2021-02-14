using Domain.Contracts;
using Domain.Dependencies;

namespace Domain.Models
{
    public class ServiciosAplicacionModel : IServiciosAplicacion
    {
        private readonly ConfigGlobal _configGlobal;
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
        public IUsuario Usuario
        {
            get { return _enlazadorDeDependencias.Resolver<IUsuario>(); }
        }
        public ICliente Cliente
        {
            get { return _enlazadorDeDependencias.Resolver<ICliente>(); }
        }
        public IArticulo Articulo
        {
            get { return _enlazadorDeDependencias.Resolver<IArticulo>(); }
        }
        public IComprobante Comprobante
        {
            get { return _enlazadorDeDependencias.Resolver<IComprobante>(); }
        }
        public void Dispose()
        {
            _enlazadorDeDependencias?.Dispose();
        }
    }
}