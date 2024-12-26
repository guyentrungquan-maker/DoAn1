using Flower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flower.Areas.Admin.Components
{
    [ViewComponent(Name = "AdminMenu")]
    public class AdminMenuComponent : ViewComponent
    {
        private readonly FlowerContext _context;

        public AdminMenuComponent(FlowerContext db)
        {
            _context = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var mnlist = _context.TbAdminMenus.Where(mn => mn.IsActive == true).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", mnlist));
        }
    }
}
