using AlısverisSepetiMvc.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlısverisSepetiMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var order = _context.Orders.Include(x => x.Lines).ThenInclude(x => x.Product).ToList();
            return View(order);
        }
    }
}
