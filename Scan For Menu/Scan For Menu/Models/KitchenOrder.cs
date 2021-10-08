using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Models
{
    public class KitchenOrder
    {
        public int OrderNum { get; set; }
        public int tableNum { get; set; }
        public List<Cart> orders { get; set; }
    }
}
