using DataAccess.Contracts;
using DataAccess.Repositories;
using Domain.Contracts;
using Domain.Language;
using Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace Domain.Models
{
    /// <summary>
    /// Implementa el patron "Observador" gestionando los subscriptores y notificando los cambios de idioma
    /// </summary>
    public class TraductorUsuario : ITraductorUsuario
    {
        private Idioma _idiomaPreferido;

        private readonly IIdiomaRepository _idioma;
        private readonly IList<ISubscriptorCambioIdioma> _subscriptores = new List<ISubscriptorCambioIdioma>();

        public TraductorUsuario()
            : this(new IdiomaRepository())
        {
        }

        public TraductorUsuario(IIdiomaRepository idioma)
        {
            _idioma = idioma;
        }

        public Idioma IdiomaPreferido
        {
            get { return _idiomaPreferido; }
            set
            {
                _idiomaPreferido = value;
                this.NotificarIdiomaCambiado(_idiomaPreferido);
            }
        }

        public IList<Idioma> IdiomasSoportados
        {
            get { return _idioma.ObtenerIdiomasSoportados(); }
        }

        public void Subscribirse(ISubscriptorCambioIdioma nuevoSubscriptor)
        {
            _subscriptores.Add(nuevoSubscriptor);
            //Notifico al nuevo subscriptor la configuración actual
            nuevoSubscriptor.IdiomaCambiado(this.IdiomaPreferido);
        }

        public void Desubscribirse(ISubscriptorCambioIdioma subscriptor)
        {
            _subscriptores.Remove(subscriptor);
        }

        public string Traducir(string constanteDeTexto)
        {
            return 
                new ResourceManager
                ("Domain.Language.strings", this.GetType().Assembly)
                .GetString(constanteDeTexto, CultureInfo.GetCultureInfo(this.IdiomaPreferido.CodigoIso)
                );
        }

        public string TraducirConFormato(string constanteDeTexto, params object[] args)
        {
            var traduccion = this.Traducir(constanteDeTexto);
            return string.Format(traduccion, args);
        }

        private void NotificarIdiomaCambiado(Idioma nuevoIdioma)
        {
            //Notifico a la colección de subscriptores
            lock (_subscriptores)
            {
                foreach (var subscriptor in _subscriptores)
                    subscriptor.IdiomaCambiado(nuevoIdioma);
            }
        }
    }
}
