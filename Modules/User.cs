using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HatsApi.Modules
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [ForeignKey("AdminID")]
        public Admin Admin { get; set; }

        [EmailAddress][Required][StringLength(255)]
        public string UserEmail { get; set; }

        [StringLength(255)][Required]
        public string UserName { get; set; }

        [StringLength(255)][Required]
        public string UserPassword { get; set; }

        public virtual ICollection<Hat> Hats { get; set; }
    }
}
