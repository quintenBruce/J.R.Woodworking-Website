using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {




        //[Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
