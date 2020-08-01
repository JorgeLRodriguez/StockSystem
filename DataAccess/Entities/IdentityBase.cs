using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class IdentityBase
    {
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public string ChangedBy { get; set; }

        [Key]
        public int Id { get; set; }
    }
}