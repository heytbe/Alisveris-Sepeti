using Microsoft.AspNetCore.Mvc;

namespace AlısverisSepetiMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
