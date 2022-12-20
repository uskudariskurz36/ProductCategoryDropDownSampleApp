using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ProductCategoryDropDownSampleApp.Models
{
    public class ProductCreateViewModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public SelectList? Categories { get; set; }
    }
}
