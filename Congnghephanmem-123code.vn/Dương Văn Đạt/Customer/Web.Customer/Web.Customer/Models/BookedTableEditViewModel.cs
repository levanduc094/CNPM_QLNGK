using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Models
{
    public class BookedTableEditViewModel
    {
        [Key]
        public int idTable { get; set; }
        [Required]
        
        [StringLength(60, ErrorMessage = "Name length can't be more than 8.")]
        public string CustomerName { get; set; }
        [Required]
        [Phone]
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string BookDate { get; set; }
        public string BookTimeStart { get; set; }
        public string BookTimeEnd { get; set; }

        public  BookedTable ToModel()
        {
            var op = new BookedTable
            {
                idTable = idTable,
                CustomerName = CustomerName,
                CustomerPhone= CustomerPhone,
                CustomerAddress= CustomerAddress,
                BookDate= BookDate,
                BookTimeStart= BookTimeStart,
                BookTimeEnd= BookTimeEnd
            };
            return op;
        }

    }
}
