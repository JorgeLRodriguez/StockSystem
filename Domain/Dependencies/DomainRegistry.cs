using Domain.Contracts;
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

            For<ITraductorUsuario>().Singleton();
            For<ITraductor>().Use(ctx => ctx.GetInstance<ITraductorUsuario>());
            For<ICriptografia>().Use(() => Criptografia.Default);
            //this.For<IBitacora>().Use(() => Bitacora.Default);
        }
    }
}
