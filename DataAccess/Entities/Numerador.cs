﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Numerador : IdentityBase
    {
        public string id_tipo_comprobante { get; set; }
        public string letra { get; set; }
        public int sucursal { get; set; }
        public int numero { get; set; }
    }
}