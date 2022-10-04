using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stripe;
using Stripe.Checkout;





//namespace WebApplication1.Controllers
//{
//    public class ShopController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}











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
        

        [HttpPost]
        public ActionResult Create()
        {
         
            var options = new SessionCreateOptions
            {
                ConsentCollection = new SessionConsentCollectionOptions { TermsOfService = "required" },
                PhoneNumberCollection = new SessionPhoneNumberCollectionOptions
                {
                    Enabled = true,
                },

                AllowPromotionCodes = true,
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                    // Provide the exact Price ID (for example, pr_1234) of the product you want to sell
                    Price = "price_1LofAtG76BfK0JrSY31CteAd",
                    Quantity = 1,
                  },
                },
                Mode = "payment",
                SuccessUrl = "https://localhost:44355/Shop/Success",
                CancelUrl = "https://localhost:44355/Shop",
                
                ShippingAddressCollection = new SessionShippingAddressCollectionOptions
                {
                    AllowedCountries = new List<string>
          {
            "US"
            
          },
                },
                ShippingOptions = new List<SessionShippingOptionOptions>
        {
          new SessionShippingOptionOptions
          {
            ShippingRateData = new SessionShippingOptionShippingRateDataOptions
            {
              Type = "fixed_amount",
              FixedAmount = new SessionShippingOptionShippingRateDataFixedAmountOptions
              {
                Amount = 0,
                Currency = "usd",
              },
              DisplayName = "Pickup Lubbock, Tx",
              // Delivers between 5-7 business days
              DeliveryEstimate = new SessionShippingOptionShippingRateDataDeliveryEstimateOptions
              {
                Minimum = new SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions
                {
                  Unit = "week",
                  Value = 5,
                },
                Maximum = new SessionShippingOptionShippingRateDataDeliveryEstimateMaximumOptions
                {
                  Unit = "week",
                  Value = 7,
                },
              },
            }
          },
          new SessionShippingOptionOptions
          {
            ShippingRateData = new SessionShippingOptionShippingRateDataOptions
            {
              Type = "fixed_amount",
              FixedAmount = new SessionShippingOptionShippingRateDataFixedAmountOptions
              {
                Amount = 4000,
                Currency = "usd",
              },
              DisplayName = "Delivery in Lubbock, TX",
              // Delivers in exactly 1 business day
              DeliveryEstimate = new SessionShippingOptionShippingRateDataDeliveryEstimateOptions
              {
                Minimum = new SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions
                {
                  Unit = "week",
                  Value = 5,
                },
                Maximum = new SessionShippingOptionShippingRateDataDeliveryEstimateMaximumOptions
                {
                  Unit = "week",
                  Value = 7,
                },
              },
            }
          },
        }

            };
            StripeConfiguration.ApiKey = "sk_test_51Lof70G76BfK0JrSmaoAzcMXsdGXzDBV2PAUDJ2r8bxBkwYh7qo06acrn18wGeKaTdCva1WEzRMdTN3t0mvUXdNa00317t4GP1";

           
            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url); 
            return new StatusCodeResult(303);
            }
    }
}