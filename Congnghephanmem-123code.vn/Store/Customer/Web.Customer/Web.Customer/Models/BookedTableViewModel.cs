using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Models
{
    public class BookedTableViewModel
    {       
        public int idTable { get; }
        public string CustomerName { get;}
        public string CustomerPhone { get;}
        public string CustomerAddress { get;}
        public string BookDate { get; }
        public string BookTimeStart { get;}
        public string BookTimeEnd { get;}
    }
}
