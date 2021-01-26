using Entities;

namespace Domain.Contracts
{
    /// <summary>
    /// Representa a un interesado para el servicio de traducciones
    /// </summary>
    public interface ISubscriptorCambioIdioma
    {
        void IdiomaCambiado(Idioma nuevoIdioma);
    }
}