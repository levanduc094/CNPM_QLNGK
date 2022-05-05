using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using System.ComponentModel.DataAnnotations;

namespace Web.Customer.Models
{
    public class TableViewModel
    {
        public TableViewModel() { }
        public TableViewModel(Table table)
        {
            idTable = table.idTable;
            name = table.name;
            status = table.status;
        }
        public int idTable { get; set; }
        [Display]
        public string name { get; set; }
        [Display]
        public bool status { get; set; }

        public Table ToModel()
        {
            var op = new Table
            {
                idTable = idTable,
                name = name,
                status = status,

            };
            return op;
        }
    }
}
