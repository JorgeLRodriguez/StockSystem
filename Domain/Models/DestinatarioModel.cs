using DataAccess.Contracts;
using Domain.Contracts;
using Entities;
using Entities.Bitacora;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class DestinatarioModel : IDestinatario
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public DestinatarioModel(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Destinatario Create(Destinatario destinatario)
        {
            //try
            //{
            //    destinatario = _unitOfWork.DestinatarioRepository.Create(destinatario);
            //    BitacoraModel.Default.RegistrarEnBitacora
            //        (
            //        Evento.AltaDestinatario,
            //        Severidad.Informativo,
            //        destinatario.ApellidoNombre + " " +
            //        destinatario.Domicilio + " " +
            //        destinatario.CodigoPostal
            //        );
            //    return destinatario;
            //}
            //catch(Exception ex)
            //{
            //    Log.Save(this, ex);
            //    throw ex;
            //}
            return destinatario;
        }
        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Destinatario> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Destinatario destinatario)
        {
            throw new NotImplementedException();
        }
    }
}
