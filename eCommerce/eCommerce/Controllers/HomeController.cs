using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class HomeController : BaseController
    { 
        public ActionResult Index()
        {
            ViewBag.Message = "You can buy things from me. You will buy things from me.";
           //display all products to the view
            return View(db.Products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "we sell electronics.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact us here";

            return View();
        }
    }
}
