using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocoMobileShopApp.ProjectClasses
{
   public class Branch
    {

        public Branch()
        {
            Users = new HashSet<User>();
            Phones = new HashSet<Phone>();
            Expenses = new HashSet<Expense>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
