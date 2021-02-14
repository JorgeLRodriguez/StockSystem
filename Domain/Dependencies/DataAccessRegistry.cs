using DataAccess.Contracts;
using DataAccess.Repositories;
using StructureMap;

namespace Domain.Dependencies
{
    internal class DataAccessRegistry : Registry
    {
        public DataAccessRegistry()
        {
            this.Scan(x =>
            {
                x.TheCallingAssembly();
                x.WithDefaultConventions();
            });
            For<IUnitOfWorkRepository>().Use(() => UnitOfWorkRepository.Default);
            For<IIdiomaRepository>().Use(x => x.GetInstance<IdiomaRepository>());
            For<IBitacoraRepository>().Singleton();
        }
    }
}
