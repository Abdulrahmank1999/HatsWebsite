using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HatsApi.Modules
{
    public class Hat
    {
        [Key]
        public int HatId { get; set; }

        [StringLength(255)][Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [MaxLength(600)]
        public string Des { get; set; }

        [ForeignKey("AdminID")]
        public Admin Admin { get; set; }

        [MaxLength(300)]
        public string ImageUrl { get; set; }

        public virtual ICollection<User> Users { get; set; }


    }
}
