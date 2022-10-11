using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Success() => View();

        public IActionResult Console()
        {
            var options = StripeService.CreateOptions();
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);

            return new StatusCodeResult(303);
        }

        public IActionResult DiningTable()
        {
            return View();
        }

        public IActionResult Desk()
        {
            return View();
        }

        public IActionResult CoffeeEndTable()
        {
            return View();
        }

        public IActionResult Barndoor()
        {
            return View();
        }

        public IActionResult Ladder()
        {
            return View();
        }

        public ActionResult Create()
        {

            var options = StripeService.CreateOptions();
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            
            return new StatusCodeResult(303);
        }
    }
}