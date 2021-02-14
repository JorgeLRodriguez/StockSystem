using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IValidateModel<T>
    {
        void Validar(T entity);
        void Validar(List<T> list);
    }
}
