using Flower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flower.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly Bainhom1Context _context;

        public BlogViewComponent(Bainhom1Context context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbBlogs.Where(m => (bool)m.IsActive)
                .ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }
    }
}
