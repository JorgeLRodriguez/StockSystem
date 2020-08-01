using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Cliente : IdentityBase
    {
        //[Key]
        //public int IdCliente { get; set; }
        public string Cuit { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}