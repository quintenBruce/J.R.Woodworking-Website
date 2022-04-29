using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PoliciesController : Controller
    {
        public IActionResult PoliciesIndex()
        {
            return View();
        }
    }
}
