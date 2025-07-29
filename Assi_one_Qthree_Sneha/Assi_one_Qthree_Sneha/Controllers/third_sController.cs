using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_one_Qthree_Sneha.Controllers
{
    public class third_sController : Controller
    {
        // GET: third_s
        public ActionResult Index()
        {
            return View();
        }
        public String Test2()
        {
            return @"<h3>Stationary Details</h3>
                    <table border=1>
                        <tr>
                            <th>no</th>
                            <th>name</th>
                            <th>price</th>
                        </tr>
                        <tr>
                            <td>1</td>
                            <td>pencil</td>
                            <td>20</td>
                       </tr>
                       <tr>
                            <td>2</td>
                            <td>scale</td>
                            <td>30</td>
                       </tr>
                        <tr>
                            <td>3</td>
                            <td>eraser</td>
                            <td>25</td>
                       </tr>
                      </table> ";
        }
    }
}