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

            For<IUsuario>().Use<UsuarioModel>();
            For<ICliente>().Use<ClienteModel>();
            For<IArticulo>().Use<ArticuloModel>();
            For<IComprobante>().Use<ComprobanteModel>();
            For<IDestinatario>().Use<DestinatarioModel>();
            For<IRemitoStock>().Use<RemitoStockModel>();
            For<IDeposito>().Use<DepositoModel>();
            For<IPasillo>().Use<PasilloModel>();
            For<IPallet>().Use<PalletModel>();
            For<ITraductorUsuario>().Singleton();
            For<ITraductor>().Use(ctx => ctx.GetInstance<ITraductorUsuario>());
            For<ICriptografia>().Use(() => Criptografia.Default);
            For<IBitacora>().Use(() => BitacoraModel.Default);
        }
    }
}