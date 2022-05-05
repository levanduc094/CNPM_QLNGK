using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Models
{
    public class TableEditViewModel {
        public int idTable { get; set; }
        [Display]
        public string name { get; set; }
        [Display]
        public bool status { get; set; }
    }
    
}
