using Flower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flower.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly FlowerContext _context;

        public BlogViewComponent(FlowerContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbBlogs.Where(m => m.IsActive == true).ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }
    }
}
