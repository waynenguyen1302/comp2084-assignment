using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Stripe.Checkout;

namespace Assignment.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;

        public ShopController(ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET Shop/Index
        public IActionResult Index()
        {
            var menus = _context.Menus
                .OrderBy(c => c.Name)
                .ToList();

            return View(menus);
        }

        // GET Shop/Category?Id=123
        public IActionResult Menu(int Id)
        {
            var menu = _context.Menus.Find(Id);

            if (menu == null)
            {
                return NotFound();
            }

            ViewData["MenuName"] = menu.Name;

            var dishes = _context.Dishes
                .Where(d => d.MenuId == Id)
                .Include(d => d.Menu)
                .ToList();

            return View(dishes);
        }
    }
}
