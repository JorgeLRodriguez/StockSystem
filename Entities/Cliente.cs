using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente : IdentityBase
    {
        public string Cuit { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}