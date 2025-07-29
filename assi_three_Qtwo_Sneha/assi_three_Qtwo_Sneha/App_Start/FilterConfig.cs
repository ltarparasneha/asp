using System.Web;
using System.Web.Mvc;

namespace assi_three_Qtwo_Sneha
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
