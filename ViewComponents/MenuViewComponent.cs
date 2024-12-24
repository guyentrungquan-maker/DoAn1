using Flower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flower.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly FlowerContext _context;

        public MenuViewComponent(FlowerContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbMenus.Where(m => m.IsActive == true)
                .ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }
    }
}
