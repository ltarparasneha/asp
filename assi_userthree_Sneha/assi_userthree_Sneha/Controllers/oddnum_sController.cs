using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_userthree_Sneha.Controllers
{
    public class oddnum_sController : Controller
    {
        // GET: oddnum_s
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult oddnum(int? uservalue)
        {
            ViewBag.Value = uservalue ?? 0;

            return View();



        }
    }
}