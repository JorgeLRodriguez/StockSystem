using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Cuit { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}