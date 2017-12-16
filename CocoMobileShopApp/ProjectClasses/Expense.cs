using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocoMobileShopApp.ProjectClasses
{
    public class Expense
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime? DateOfPay { get; set; }
        [Required]
        public float Value { get; set; }
        public Branch Branch { get; set; }

    }
}
