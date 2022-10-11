using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;
using System.Drawing;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Success() => RedirectToAction("Success", "Shop");

        public IActionResult Console(string Size, string Stain)
        {
            var consolePrice = Size == "45" ? "price_1Lr4FtG76BfK0JrSxVE4RPEp" : "price_1Lr4FtG76BfK0JrSpEWblIuv";
            var options = StripeService.CreateOptions(consolePrice, Stain);
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);

            return new StatusCodeResult(303);
        }

        public IActionResult DiningTable(string Stain)
        {
            
            var options = StripeService.CreateOptions("price_1Lr41yG76BfK0JrSVbySRp97", Stain);
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);

            return new StatusCodeResult(303);
        }

        public IActionResult Desk(string Size, string Stain)
        {
            var consolePrice = "";
            if (Size == "4")
                consolePrice = "price_1Lr4KiG76BfK0JrSkFGSgIQ5";
            else if (Size == "5x22")
                consolePrice = "price_1Lr4KiG76BfK0JrSrZLCmejC";
            else
                consolePrice = "price_1Lr4KiG76BfK0JrSXL4boxnB";

            var options = StripeService.CreateOptions(consolePrice, Stain);
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);

            return new StatusCodeResult(303);
        }

        public IActionResult CoffeeEndTable(string Stain)
        {
            var options = StripeService.CreateOptions("price_1Lr4EBG76BfK0JrSR1C5ZyXZ", Stain);
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);

            return new StatusCodeResult(303);
        }

        public IActionResult Barndoor(string Size, string Stain)
        {
            var options = StripeService.CreateOptions("price_1Lr4CMG76BfK0JrSlGzCmeIy", Stain);
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);

            return new StatusCodeResult(303);
        }

        public IActionResult Ladder(string Size, string Stain)
        {
            var consolePrice = Size == "5" ? "price_1Lr4LxG76BfK0JrSEP5Jg5nH" : "price_1Lr4LxG76BfK0JrSbp6PuynJ";
            var options = StripeService.CreateOptions(consolePrice, Stain);
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);

            return new StatusCodeResult(303);
        }

        
    }
}