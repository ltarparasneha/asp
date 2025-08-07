using System.Web;
using System.Web.Mvc;

namespace assi_userthree_Sneha
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
