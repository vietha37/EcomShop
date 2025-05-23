﻿using System.ComponentModel.DataAnnotations;

namespace Ecom.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(4,ErrorMessage = "Mời nhập tên danh mục")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Mời nhập mô tả danh mục")]
        public string Description { get; set; }
        [Required]
        public string Slug { get; set; }
        public string Stautus { get; set; }
    }
}
