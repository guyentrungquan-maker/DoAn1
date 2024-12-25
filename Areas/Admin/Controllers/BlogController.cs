using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Flower.Models;

namespace Flower.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly FlowerContext _context;

        public BlogController(FlowerContext context)
        {
            _context = context;
        }

        // GET: Admin/Blog
        public async Task<IActionResult> Index()
        {
            var flowerContext = _context.TbBlogs.Include(t => t.Category);
            return View(await flowerContext.ToListAsync());
        }

        // GET: Admin/Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbBlog = await _context.TbBlogs
                .Include(t => t.Category)
                .FirstOrDefaultAsync(m => m.BlogId == id);
            if (tbBlog == null)
            {
                return NotFound();
            }

            return View(tbBlog);
        }

        // GET: Admin/Blog/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.TbCategories, "CategoryId", "CategoryId");
            return View();
        }

        // POST: Admin/Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogId,Title,Alias,CategoryId,Description,Detail,Image,SeoTitle,SeoDescription,SeoKeywords,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,AccountId,IsActive")] TbBlog tbBlog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbBlog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.TbCategories, "CategoryId", "CategoryId", tbBlog.CategoryId);
            return View(tbBlog);
        }

        // GET: Admin/Blog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbBlog = await _context.TbBlogs.FindAsync(id);
            if (tbBlog == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.TbCategories, "CategoryId", "CategoryId", tbBlog.CategoryId);
            return View(tbBlog);
        }

        // POST: Admin/Blog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BlogId,Title,Alias,CategoryId,Description,Detail,Image,SeoTitle,SeoDescription,SeoKeywords,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,AccountId,IsActive")] TbBlog tbBlog)
        {
            if (id != tbBlog.BlogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbBlog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbBlogExists(tbBlog.BlogId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.TbCategories, "CategoryId", "CategoryId", tbBlog.CategoryId);
            return View(tbBlog);
        }

        // GET: Admin/Blog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbBlog = await _context.TbBlogs
                .Include(t => t.Category)
                .FirstOrDefaultAsync(m => m.BlogId == id);
            if (tbBlog == null)
            {
                return NotFound();
            }

            return View(tbBlog);
        }

        // POST: Admin/Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbBlog = await _context.TbBlogs.FindAsync(id);
            if (tbBlog != null)
            {
                _context.TbBlogs.Remove(tbBlog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbBlogExists(int id)
        {
            return _context.TbBlogs.Any(e => e.BlogId == id);
        }
    }
}
