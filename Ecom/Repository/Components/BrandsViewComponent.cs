using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Repository.Components
{
    public class BrandsViewComponent: ViewComponent
    {
        private readonly DataContext _context;
        public BrandsViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()=> View(await _context.Brands.ToListAsync());
    }
}
