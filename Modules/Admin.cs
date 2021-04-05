using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HatsApi.Modules
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [StringLength(255)] [Required][EmailAddress]
        public string AdminEmail { get; set; }

        [StringLength(255)][Required]
        public string AdminPassword { get; set; }

        [StringLength(255)][Required]
        public string AdminUserName { get; set; }

        public ICollection<Hat> Hats { get; set; }

        public ICollection<User> Users { get; set; }



    }
}
