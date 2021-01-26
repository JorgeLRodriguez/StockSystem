using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    /// <summary>
    /// Ofrece los servicios necesarios para la traducción de Constantes de texto
    /// </summary>
    public interface ITraductor
    {
        string Traducir(string constanteDeTexto);
        string TraducirConFormato(string constanteDeTexto, params object[] args);
    }
}
