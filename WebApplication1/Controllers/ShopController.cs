using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;

public class StripeOptions
{
    public string option { get; set; }
}

namespace WebApplication1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Success() => View();
    }
}