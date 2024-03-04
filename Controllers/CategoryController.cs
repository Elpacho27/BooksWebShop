using BooksWebShop.Data;
using BooksWebShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksWebShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categorylist = _context.Categories.ToList();
            return View(categorylist);
        }
    }
}
