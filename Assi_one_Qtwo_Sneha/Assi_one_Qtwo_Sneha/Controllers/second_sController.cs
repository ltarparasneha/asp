using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_one_Qtwo_Sneha.Controllers
{
    public class second_sController : Controller
    {
        // GET: second_s
        public ActionResult Index()
        {
            return View();
        }
        public String Test1()
        {
            return @"<h3>Student Details</h3>
                    <table border=1>
                        <tr>
                            <th>no</th>
                            <th>name</th>
                            <th>city</th>
                        </tr>
                        <tr>
                            <td>1</td>
                            <td>sneha</td>
                            <td>rajkot</td>
                       </tr>
                       <tr>
                            <td>2</td>
                            <td>abc</td>
                            <td>rajkot</td>
                       </tr>
                      </table> ";
        }
    }
}