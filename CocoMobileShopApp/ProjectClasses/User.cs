using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocoMobileShopApp.ProjectClasses
{
    public class User
    {

        public User()
        {
            Branches = new HashSet<Branch>();
            Phones = new HashSet<Phone>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        [MaxLength(255)]
        public string Password { get; set; }
        [Required]
        public int Role { get; set; }
        public ICollection<Branch> Branches { get; set; }
        [Required]
        public string Address { get; set; }
        public ICollection<Phone> Phones { get; set; }

 
    }
}
