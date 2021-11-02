using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Scan_For_Menu.Models
{
    public class Staff
    {
        [Key]
        [Required(ErrorMessage ="Invalid staff ID")]
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Invalid password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNum { get; set; }

        public string StaffType { get; set; }
    }
}
