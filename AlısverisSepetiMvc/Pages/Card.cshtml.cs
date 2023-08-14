using AlısverisSepetiMvc.Context;
using AlısverisSepetiMvc.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlısverisSepetiMvc.Pages
{
    public class CardModel : PageModel
    {
        private readonly AppDbContext _context;
        public Card _card;

        public CardModel(AppDbContext context, Card card)
        {
            _context = context;
            _card = card;
        }

        public void OnGet()
        {
           // _card = HttpContext.Session.GetJson<Card>("card") ?? new Card();
        }

        public async Task<IActionResult> OnPost(int id,int productnumber = 1)
        {
            var product = await _context.Products.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            if(product is not null)
            {
               // _card = HttpContext.Session.GetJson<Card>("card") ?? new Card();
                _card.AddItem(product,productnumber);
               // HttpContext.Session.SetJson<Card>("card", _card);
            }

            return Page();
        }

        public IActionResult OnPostRemove(int id)
        {
            _card.RemoveItem(_card.CardLines.First(x => x.Product.Id.Equals(id)).Product);
            return Page();
        }
    }
}
