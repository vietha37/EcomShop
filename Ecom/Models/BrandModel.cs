using System.ComponentModel.DataAnnotations;

namespace Ecom.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Mời nhập tên thương hiệu")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Mời nhập mô tả thương hiệu")]
        public string Description { get; set; }
        [Required]
        public string Slug { get; set; }
        public string Stautus { get; set; }
    }
}
