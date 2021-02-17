using Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IRemitoStock
    {
        void Create(List<RemitoStock> remitoStock);
    }
}