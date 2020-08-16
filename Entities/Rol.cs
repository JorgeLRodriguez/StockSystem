using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rol : IdentityBase
    {
        public string Descripcion { get; set; }
        public Int16 NivelAcceso { get; set; }
    }
}