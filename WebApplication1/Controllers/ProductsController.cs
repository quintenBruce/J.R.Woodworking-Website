using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        List<Products> list = new List<Products>() 
        {
            new Products(1, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825734/Products/Customer%20Views/Furniture/received_2966800056931119_aq6tij.jpg", "Desk", true, new Category("Office", "Living")),
            new Products(2, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-875890188_toanbw.jpg", "Desk", true, new Category("Office", "Living")),
            new Products(3, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-358724924_xgsyjp.jpg", "Console", true, new Category("Living")), 
            new Products(4, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-1609483947_hrlhjz.jpg", "Shelf", true, new Category("Office")),
            new Products(5, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-659061344_ampglp.jpg", "Shelf", true, new Category("Office", "Living")),
            new Products(6, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-1641100658_vvseel.jpg", "Shelf", true, new Category("Office", "Living")),
            new Products(8, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825730/Products/Customer%20Views/Furniture/Snapchat-1588502498_unqn4f.jpg", "Bench", true, new Category("Dining", "Living")),
            new Products(9, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825730/Products/Customer%20Views/Furniture/Snapchat-1603825154_sgb3q0.jpg", "Barndoor", true, new Category("Bed", "Living")),
            new Products(10, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825730/Products/Customer%20Views/Furniture/Snapchat-1205481118_gg6pou.jpg", "Door", true, new Category("Office", "Bed")),
            new Products(11, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825730/Products/Customer%20Views/Furniture/Screenshot_20211112-224716_Facebook_ub1uat.jpg", "Barndoor", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20210806-121010_Facebook_zab6jt.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20211112-224547_Facebook_hrjtcw.jpg", "Console", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20211107-213738_Facebook_qpvzfl.jpg", "Bookshelf", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20211107-213733_Facebook_dagou1.jpg", "Bookshelf", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20211017-231803_Messenger_vt9ony.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20210422-111710_Facebook_r8wjoq.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20210701-083017_Facebook_1_tn2n3r.jpg", "Bar", true, new Category("Dining", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825728/Products/Customer%20Views/Furniture/Screenshot_20210414-193043_Messenger_trlbjb.jpg", "End Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825728/Products/Customer%20Views/Furniture/Screenshot_20210414-193037_Messenger_dtzpye.jpg", "End Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825727/Products/Customer%20Views/Furniture/Screenshot_20210317-103654_Facebook_d5yi47.jpg", "Bar", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825727/Products/Customer%20Views/Furniture/received_930117911077888_anmgyg.jpg", "Console", true, new Category("Dining", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825726/Products/Customer%20Views/Furniture/Screenshot_20210215-205945_Facebook_rldhus.jpg", "Bar", true, new Category("Dining", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825725/Products/Customer%20Views/Furniture/received_811096049758277_dmny0n.jpg", "Hamper", true, new Category("Kitchen", "Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825724/Products/Customer%20Views/Furniture/received_778245506184408_ojitpz.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825724/Products/Customer%20Views/Furniture/received_808387730034072_xipcqt.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825724/Products/Customer%20Views/Furniture/received_723326661717722_bxbb6g.jpg", "Wine Bar", true, new Category("Dining", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825723/Products/Customer%20Views/Furniture/received_702820840653236_ip3hli.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825723/Products/Customer%20Views/Furniture/received_641470113487360_twojup.jpg", "Barndoor", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825722/Products/Customer%20Views/Furniture/received_467696121746135_farlgx.jpg", "Bar", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825722/Products/Customer%20Views/Furniture/received_483713766799334_l451u6.jpg", "Bar", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825721/Products/Customer%20Views/Furniture/received_466020218433870_he90a7.jpg", "Bar", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825721/Products/Customer%20Views/Furniture/received_3697372226965282_iubnay.jpg", "Barndoor", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825721/Products/Customer%20Views/Furniture/received_357549356249462_dqqmqm.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825721/Products/Customer%20Views/Furniture/received_369805604602631_njyluv.jpg", "Bed", true, new Category("Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825720/Products/Customer%20Views/Furniture/received_395886785333740_kvhplh.jpg", "Desk", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825720/Products/Customer%20Views/Furniture/received_381348330488508_c1ufbb.jpg", "Dresser", true, new Category("Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825719/Products/Customer%20Views/Furniture/received_3614032512007088_c1boqu.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825718/Products/Customer%20Views/Furniture/received_1660024184385172_knz3tz.jpg", "Desk", true, new Category("Office"))


        };

        public IActionResult ProductsIndex()
        {
            return View(list);
        }

        public IActionResult LivingRoom()
        {
            
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Living")).ToList();
            return View(list_);
        }

        public IActionResult BedRoom()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Bed")).ToList();
            return View(list_);
        }

        public IActionResult BathRoom()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Bath")).ToList();
            return View(list_);
        }

        public IActionResult DiningRoom()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Dining")).ToList();
            return View(list_);
        }

        public IActionResult Office()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Office")).ToList();
            return View(list_);
        }

        public IActionResult Outdoors()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Outdoors")).ToList();
            return View(list_);
        }




    }
}
