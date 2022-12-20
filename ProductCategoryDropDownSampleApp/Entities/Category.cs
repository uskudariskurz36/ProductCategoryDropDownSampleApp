﻿using System.ComponentModel.DataAnnotations;

namespace ProductCategoryDropDownSampleApp.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
