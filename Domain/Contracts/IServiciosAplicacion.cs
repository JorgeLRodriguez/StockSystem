using System;

namespace Domain.Contracts
{
    public interface IServiciosAplicacion : IDisposable
    {
        //IControlDePatentes ControlDePatentes { get; }
        ITraductorUsuario TraductorUsuario { get; }
        //IBitacora Bitacora { get; }
        IUsuario Usuario { get; }
        ICliente Cliente { get; }
        IArticulo Articulo { get; }
        IComprobante Comprobante { get; }
    }
}
