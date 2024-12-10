using Flower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Flower.ViewComponents
{
    public class CatergoryViewComponent : ViewComponent
    {   
        public readonly Bainhom1Context _context;
        public CatergoryViewComponent(Bainhom1Context context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbCategories.Where(m => (bool)m.IsActive)
                .ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }

    }

}
