using Ecom.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
            if (!_context.Products.Any())
            {
                CategoryModel macOs = new CategoryModel {Name="Apple", Description= "Apple is luxury brand", Slug= "apple", Stautus= "Active"};
                CategoryModel pc = new CategoryModel { Name = "Samsung", Description = "Samsung is luxury brand", Slug = "samsung", Stautus = "Active" };
                BrandModel apple = new BrandModel { Name = "Táo", Description = "Apple is luxury brand", Slug = "apple", Stautus = "Active" };
                BrandModel samsung = new BrandModel { Name = "Hàn Xẻng", Description = "Samsung is luxury brand", Slug = "samsung", Stautus = "Active" };
                _context.Products.AddRange(
                    new ProductModel { Name = "alo", Slug = "alo", Description = "alo", Price = 1000, Brand = apple, Category = macOs, Image = "https://example.com/image1.jpg" },
                    new ProductModel { Name = "alo2", Slug = "alo2", Description = "alo2", Price = 1050, Brand = samsung, Category = pc, Image = "https://example.com/image1.jpg" }
                );
                _context.SaveChanges();
            }

        }
    }
}
