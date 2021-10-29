using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Models
{
    public class ReportData
    {
        public int orderNum { get; set; }
        public string Date { get; set; }

        public string  Category { get; set; }
        public string itemName { get; set; }
        public int itemQnty { get; set; }
        public double LineTotal { get; set; }

        public double subtotal { get; set; }
        public double gratuity { get; set; }
        public double Total { get; set; }
    }
}
