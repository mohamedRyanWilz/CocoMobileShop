using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocoMobileShopApp.ProjectClasses
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public int NumInStock { get; set; }
        [Required]
        public float BuyPrice { get; set; }
        [Required]
        public float SalePrice { get; set; }
        public DateTime? DateOfBuy { get; set; }
        public Category Category { get; set; }
    }
}
