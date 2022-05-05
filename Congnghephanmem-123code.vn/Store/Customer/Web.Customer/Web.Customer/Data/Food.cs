using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Data
{
    public class Food
    {
        [Key]
        public int idFood { get; set; }
        public string name { get; set; }
        public int idCategoryFood { get; set; }
        public int price { get; set; }
        public string image { get; set; }
    }
}
