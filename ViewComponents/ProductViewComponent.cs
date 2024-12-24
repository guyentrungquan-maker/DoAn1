using Flower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flower.ViewComponents
{
    public class ProductViewComponent : ViewComponent
{
    public readonly FlowerContext _context;
    public ProductViewComponent(FlowerContext context)
    {
        _context = context;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var items = _context.TbProducts.Where(m => m.IsActive == true)
            .ToList();
        return await Task.FromResult<IViewComponentResult>(View(items));
    }

}

}