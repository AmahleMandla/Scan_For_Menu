using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Scan_For_Menu.Models
{
    public class CustomerOrder
    {
        [Key]
        public int OrderId { get; set; }

        [DisplayName("Slect Table Number")]
        [Required]
        public int TableNr { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal OrderTotal { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public bool OrderState { get; set; }

        [Required]
        public bool OrderPaid { get; set; }

        [DataType(DataType.Currency)]
        public decimal GratuityAmt { get; set; }

        [NotMapped]
        public Dictionary<MenuItem,int> orderItems { get; set; }




        public CustomerOrder()
        {
               
        }
    }
}
