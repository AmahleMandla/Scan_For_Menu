using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Models
{
    public class PayOnline
    {
        [Required(ErrorMessage ="Enter valid card number")]
        [DataType(DataType.CreditCard)]           
        public int cardNum { get; set; }
       
        public string name { get; set; }

        [Required(ErrorMessage = "CVV should be 3 digits long")]
        public int cvv { get; set; }

        [Required(ErrorMessage = "Expiry year should be 4 digits long")]        
        public int expiryYear { get; set; }
    }
}
