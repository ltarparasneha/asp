using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_three_Qtwo_Sneha.Controllers
{
    public class atith_sController : Controller
    {
        // GET: atith_s
        public ActionResult Index()
        {
           
            ViewBag.valueA = 25;
            ViewBag.valueB = 25;
            return View();
        }
    }
}