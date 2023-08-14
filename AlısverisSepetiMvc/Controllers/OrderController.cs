using AlısverisSepetiMvc.Context;
using AlısverisSepetiMvc.Models;
using AlısverisSepetiMvc.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AlısverisSepetiMvc.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly Card _card;

        public OrderController(AppDbContext context, Card card)
        {
            _context = context;
            _card = card;
        }

        public ViewResult CheckOut() => View(new Order()); 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckOut([FromForm]Order order)
        {
            if(_card.CardLines.Count() == 0)
            {
                ModelState.AddModelError("","Sepet Boş Şipariş Veremezsiniz");
            }

            if(ModelState.IsValid)
            {
                order.Lines = _card.CardLines.ToArray();
                _context.AttachRange(order.Lines.Select(a => a.Product));
                if(order.OrderId == 0)
                {
                    _context.Orders.Add(order);
                }
                _context.SaveChanges();

                _card.Clear();
                return RedirectToPage("/complate");
            }
            else
            {
                return View();
            }


        }
    }
}
