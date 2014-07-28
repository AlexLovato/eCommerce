using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class ShopController : BaseController
    {
   
        //
        // GET: /Shop/
        
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult ByProduct(int id)
        {
            Models.Product detail = db.Products.Find(id);
            return View(detail);
        }

    }
}
