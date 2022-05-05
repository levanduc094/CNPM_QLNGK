using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Data
{
    public class FoodCategory
    {
        [Key]
        public int idCategoryFood { get; set; }
        public string name { get; set; }
    }
}
