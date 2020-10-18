﻿using System;
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
        private readonly ComprobanteModel VoucherModel = new ComprobanteModel();
        public Comprobante Create(Comprobante comprobante)
        {
            VoucherModel.Create(comprobante);
            return comprobante;
        }
        public Comprobante GetComprobante (string id_tipo_comprobante, string letra, int numero_comprobante, int sucursal)
        {
            return VoucherModel.GetComprobante("A","ASD","ASD",1);
        }
    }
}