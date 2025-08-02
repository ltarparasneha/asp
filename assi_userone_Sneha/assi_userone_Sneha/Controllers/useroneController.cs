using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_userone_Sneha.Controllers
{
    public class useroneController : Controller
    {
        // GET: userone
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test(int? uservalue)
        {
            ViewBag.value =uservalue??0;

            return View();
        }
    }
}