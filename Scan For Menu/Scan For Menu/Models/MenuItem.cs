using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Scan_For_Menu.Models
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }

        [ForeignKey("CategoryId")]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string ItemName { get; set; }

        public string ItemDescr { get; set; }

        [Required]
        public string ItemImage { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float ItemPrice { get; set; }

        [Required]
        public int MealPrepTime { get; set; }

    }
}
