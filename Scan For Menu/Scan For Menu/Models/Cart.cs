using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey("ItemId")]
        public int ItemId { get; set; }

        public string ItemName { get; set; }
        public int ItemQty { get; set; }
        public float ItemPrice { get; set; }

        [NotMapped]
        public string Category { get; set; }
    }
}
