using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_three_Qthree_Sneha.Controllers
{
    public class table_sController : Controller
    {
        // GET: table_s
        public ActionResult Index()
        {
           

            return View();
            


        }
        public ActionResult oddnum()
        {
            ViewBag.Value = 700;

            return View();



        }
    }
}