using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Models
{
    public class FoodViewModel
    {
        public int idFood { get; set; }
        [Display]
        public string Name { get; set; }
        [Display]
        public int idCategoryFood { get; set; }
        [Display]
        public float price { get; set; }
        [Display]
        public string image { get; set; }
    }
}
