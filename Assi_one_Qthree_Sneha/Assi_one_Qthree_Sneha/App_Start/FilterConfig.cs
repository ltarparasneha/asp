﻿using System.Web;
using System.Web.Mvc;

namespace Assi_one_Qthree_Sneha
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
