using Flower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flower.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly Bainhom1Context _context;

        public MenuViewComponent(Bainhom1Context context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbMenu.Where(m => (bool)m.IsActive)
                .ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }
    }
}
