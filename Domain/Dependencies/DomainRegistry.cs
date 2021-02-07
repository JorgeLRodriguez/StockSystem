using Domain.Contracts;
using Domain.Models;
using Services.Crypto;
using StructureMap;

namespace Domain.Dependencies
{
    internal class DomainRegistry : Registry
    {
        public DomainRegistry()
        {
            Scan(x =>
            {
                x.TheCallingAssembly();
                x.WithDefaultConventions();
            });

            //For<IArticulo>().Use(() => new ArticuloModel());
            //For<ICliente>().Use(() => new ClienteModel());
            //For<IComprobante>().Use(() => new ComprobanteModel());
            //For<IEtiqueta>().Use(() => new EtiquetaModel());
            For<IUsuario>().Use<UsuarioModel>();
            For<ICliente>().Use<ClienteModel>();
            For<IArticulo>().Use<ArticuloModel>();
            For<IComprobante>().Use<ComprobanteModel>();
            For<IEtiqueta>().Use<EtiquetaModel>();
            For<ITraductorUsuario>().Singleton();
            For<ITraductor>().Use(ctx => ctx.GetInstance<ITraductorUsuario>());
            For<ICriptografia>().Use(() => Criptografia.Default);
            For<IBitacora>().Use(() => BitacoraModel.Default);
        }
    }
}
