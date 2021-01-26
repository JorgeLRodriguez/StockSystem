using DataAccess.Contracts;
using DataAccess.Repositories;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            For<IUnitOfWork>().Singleton();
            For<IIdiomaRepository>().Use(x => x.GetInstance<IdiomaRepository>());
        }
    }
}
