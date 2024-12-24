using Flower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Flower.ViewComponents
{
    public class CatergoryViewComponent : ViewComponent
    {   
        public readonly FlowerContext _context;
        public CatergoryViewComponent(FlowerContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbCategories.Where(m => m.IsActive == true)
                .ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }

    }

}
