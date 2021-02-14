using DataAccess.Contracts;
using DataAccess.Repositories;
using Domain.Contracts;
using Entities.Bitacora;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Domain.Models
{
    public class BitacoraModel : IBitacora
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        #region "Singleton"
        private static Lazy<IBitacora> _default = new Lazy<IBitacora>(() => new BitacoraModel(UnitOfWorkRepository.Default));

        public static IBitacora Default
        {
            get { return _default.Value; }
        }
        #endregion
        public BitacoraModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Evento[] ObtenerEventosDisponibles(ITraductor traductor)
        {
            var eventos = _unitOfWork.BitacoraRepository.EventosDisponibles;
            foreach (var evento in eventos)
                evento.Descripcion = this.TraducirEvento(traductor, evento.Descripcion);

            return eventos;
        }
        public IEnumerable<Bitacora> ObtenerTodasLasEntradasEnBitacora(ITraductor traductor)
        {
            var entradas = _unitOfWork.BitacoraRepository.ObtenerTodasLasEntradasEnBitacora()
                .OrderByDescending(b => b.CreatedOn)
                .ToList();

            //Realizo la traducción del evento segun el idioma de preferencia
            foreach (var entradaEnBitacora in entradas)
            {
                //var eventoId = entradaEnBitacora.Evento.Id;
                var eventoId = entradaEnBitacora.Evento_ID;
                var field = typeof(Evento).GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Single(f => (int)f.GetValue(null) == eventoId);

                entradaEnBitacora.Evento.Descripcion = this.TraducirEvento(traductor, field.Name);
            }
            return entradas;
        }

        private string TraducirEvento(ITraductor traductor, string nombreEvento)
        {
            return traductor.Traducir("Evento" + nombreEvento);
        }

        public IEnumerable<Bitacora> ObtenerTodasLasEntradasEnBitacora(ITraductor traductor, DateTime desde, DateTime hasta, Evento evento)
        {
            if (evento != null && evento.Id < 0)
                evento = null;

            return this.ObtenerTodasLasEntradasEnBitacora(traductor)
                .Where(l => l.CreatedOn >= desde && l.CreatedOn <= hasta)
                .Where(l => evento == null || evento.Id.Equals(l.Evento.Id));
        }

        public void RegistrarEnBitacora(int tipoEvento, string mensaje)
        {
            this.RegistrarEnBitacora(tipoEvento, Severidad.Informativo, mensaje);
        }

        public void RegistrarEnBitacora(int tipoEvento, Severidad severidad, string mensaje)
        {
            this.RegistrarEnBitacora(tipoEvento, severidad, mensaje, SessionManager.Instance.UsuarioActual);
        }

        public void RegistrarEnBitacora(int tipoEvento, Severidad severidad, string mensaje, Usuario usuario)
        {
            var entradaEnBitacora = new Bitacora
            {
                CreatedOn = DateTime.Now,
                Evento_ID = tipoEvento,
                Severidad = severidad,
                Mensaje = mensaje,
                Usuario = usuario,
            };
            this.RegistrarEnBitacora(entradaEnBitacora);
        }
        public void RegistrarEnBitacora(Bitacora entradaEnBitacora)
        {
            _unitOfWork.BitacoraRepository.RegistrarEnBitacora(entradaEnBitacora);
            _unitOfWork.SaveChanges();
        }
    }
}