using System.ComponentModel.DataAnnotations;

namespace Ecom.Models
{
    public class ProductModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Mời nhập tên danh Sản Phẩm")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Mời nhập mô tả sản phẩm ")]
        public string Slug { get; set; }
        public string Description { get; set; }
        [Required, MinLength(4, ErrorMessage = "Mời nhập giá sản phẩm")]
        public decimal Price { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }

        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }
    }
}
