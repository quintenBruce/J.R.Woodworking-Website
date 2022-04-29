using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class QuoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
