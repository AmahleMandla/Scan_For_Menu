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
        public int StaffId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNum { get; set; }

        [Required]
        public string StaffType { get; set; }

    }
}
