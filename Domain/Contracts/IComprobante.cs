using Entities;

namespace Domain.Contracts
{
    public interface IComprobante
    {
        Comprobante Create(Comprobante comprobante);
        Comprobante GetComprobanteByID(int ID);
    }
}
