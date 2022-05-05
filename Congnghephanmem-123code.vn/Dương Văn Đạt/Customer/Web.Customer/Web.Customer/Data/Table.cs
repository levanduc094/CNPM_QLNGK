using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Data
{
    public class Table
    {
        [Key]
        public int idTable { get; set; }
        public string name  { get; set; }
        public bool status { get; set; }
    }
}
