using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_usertwo_Sneha.Controllers
{
    public class arith_sController : Controller
    {
        // GET: arith_s
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Arith(int? valueA, int? valueB)
        {

            ViewBag.valueA = valueA ?? 0;
            ViewBag.valueB = valueB ?? 0;
            ViewBag.Result = valueA + valueB;
            return View();
        }
    }
}