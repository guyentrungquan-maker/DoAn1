using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Flower.Models;

namespace Flower.Controllers
{
    public class BlogController : Controller
    {
        private readonly FlowerContext _context;

        public BlogController(FlowerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/blog/{alias}-{id}.html")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TbBlogs == null)
            {
                return NotFound();
            }

            var blogs = await _context.TbBlogs.FirstOrDefaultAsync(m => m.BlogId == id);

            if (blogs == null)
            {
                return NotFound();
            }

            ViewBag.blogRelated =  _context.TbBlogs.Where(i=> i.BlogId != id).Take(4).ToList();

            return View(blogs);
        }
    }
}
