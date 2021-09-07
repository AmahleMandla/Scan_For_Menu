using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Scan_For_Menu.Models
{
    public class FoodCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [DisplayName("Category Name")]
        [Required]
        public string CategoryName { get; set; }
        public string CategoryDescr { get; set; }
    }
}
