using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    /// <summary>
    /// Agrega servicios necesarios para soportar el sistema de traducciones
    /// </summary>
    public interface ITraductorUsuario : ITraductor
    {
        Idioma IdiomaPreferido { get; set; }
        IList<Idioma> IdiomasSoportados { get; }
        void Subscribirse(ISubscriptorCambioIdioma nuevoSubscriptor);
        void Desubscribirse(ISubscriptorCambioIdioma subscriptor);
    }
}
