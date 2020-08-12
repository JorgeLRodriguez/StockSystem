﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Comprobante : IdentityBase
    {
        public int id_cliente { get; set; }
        public string id_tipo_comprobante { get; set; }
        public string letra_comprobante { get; set; }
        public int suc_comprobante { get; set; }
        public int num_comprobante {get;set;}
        public string nro_remito_cliente { get; set; }
        public DateTime? fecha_comprobante { get; set; }
        public char cierre { get; set; }
        public int id_destinatario {get;set;}
        public string observaciones { get; set; }
    }
}