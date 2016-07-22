using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeR.Controllers
{   [RoutePrefix("product")]
    public class ProductController : Controller
    {
        // GET: Product/All
        [Route("~/")]
        public ActionResult Index()
        {
            var message = "ProductController.Index()";
            return Content(message);
        }

        // GET: Product/Sony-Vaio
        [Route("{id}")]
        public ActionResult View(string id)
        {
            var message = string.Format("ProductController.View('{0}')", id);
            return Content(message);
        }

        //GET: /Products/Category/Ultrabooks
        [Route("category/{category:endsWith(ers)}")]
        public ActionResult ByCategory(string category)
        {
            var message = string.Format("ProductsController.ByCategory('{0}')", category);
            return Content(message);
        }
    }
}