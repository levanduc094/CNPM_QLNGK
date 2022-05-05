using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Data
{
    public class DrinkCategory
    {
        [Key]
        public int idCategoryDrink { get; set; }
        public string name { get; set; }
    }
}
