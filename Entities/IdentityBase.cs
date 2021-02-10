using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class IdentityBase
    {
        [Key, Required]
        public int ID { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }
        [StringLength(20)]
        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ChangedOn { get; set; }
        [StringLength(20)]
        public string ChangedBy { get; set; }
    }
}