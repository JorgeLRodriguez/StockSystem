using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Entities;

namespace Domain.Services
{
    public class ComprobanteService
    {
        private readonly ComprobanteModel comprobanteModel = new ComprobanteModel();
        public Comprobante Create(Comprobante comprobante)
        {
            comprobanteModel.Create(comprobante);
            return comprobante;
        }
        public Comprobante GetComprobanteByID (int ID)
        {
            return comprobanteModel.GetComprobanteByID(ID);
        }
    }
}