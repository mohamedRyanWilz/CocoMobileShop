using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocoMobileShopApp.ProjectClasses
{
    public class Phone
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(11)]
        public string Value { get; set; }

    }
}
