using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_tree_Qone_Sneha.Controllers
{
    public class one_sController : Controller
    {
        // GET: one_s
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            ViewBag.value = 5;

            return View();
        }
    }
}