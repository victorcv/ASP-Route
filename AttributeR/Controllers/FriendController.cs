using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeR.Controllers
{
    [RoutePrefix("friend")]
    public class FriendController : Controller
    {
        // GET: /Friend
        [Route("index")]
        public ActionResult Index()
        {
            var message = "FriendController.Index()";
            return Content(message);
        }

        // GET: /Friend/View/John
        [Route("view/{name:startsWith(jo)}")]
        public ActionResult View(string name)
        {
            var message = string.Format("FriendController.View('{0}')", name);
            return Content(message);
        }

        // GET: /Friend/Edit/23
        [Route("edit/{id:int:min(0):max(99999999)}")]
        public ActionResult Edit(int id)
        {
            var message = string.Format("FriendsController.Edit({0})", id);
            return Content(message);
        }
    }
}