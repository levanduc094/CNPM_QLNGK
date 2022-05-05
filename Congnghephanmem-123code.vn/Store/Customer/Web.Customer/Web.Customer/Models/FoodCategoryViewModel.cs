using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Models
{
    public class FoodCategoryViewModel
    {
        public int idFoodCategory { get; set; }
        [Display]
        public string name { get; set; }

    }
}
