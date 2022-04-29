using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Catalog()
        {
            return View();
        }
    }
}
