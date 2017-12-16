using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocoMobileShopApp.ProjectClasses
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public float Price { get; set; }
        public Product Product { get; set; }
        public int NumOfItems { get; set; }
        public DateTime? DateOfSale { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string CustomerName { get; set; }
    }
}
