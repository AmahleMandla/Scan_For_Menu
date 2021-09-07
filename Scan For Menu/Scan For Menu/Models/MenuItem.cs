using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Scan_For_Menu.Models
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }

        [DisplayName("Category Name")]
        [NotMapped]
        [Required]
        public string CategoryName { get; set; }

        [ForeignKey("CategoryId")]
        [Required]
        public int CategoryId { get; set; }

        [DisplayName("Name of Menu Item")]
        [Required]
        public string ItemName { get; set; }

        [Required]
        [DisplayName("Description of Menu Item")]
        public string ItemDescr { get; set; }

        [DisplayName("Uplaod Image")]
        [NotMapped]
        [Required]
        public IFormFile  Image { get; set; }

        [Required]
        public string ItemImage { get; set; }

        [DisplayName("Price")]
        [Required]
        [DataType(DataType.Currency)]
        public float ItemPrice { get; set; }

        [DisplayName("Meal Prep Estimate Time")]
        [Required]
        public int MealPrepTime { get; set; }
    }
}
