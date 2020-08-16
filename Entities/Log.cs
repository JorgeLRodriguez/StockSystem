using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Log
    {
        [Key]
        public int ID { get; set; }
        public int id_tipolog { get; set; }
        public string Mensaje { get; set; }
        public string Ubicacion { get; set; } 
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
