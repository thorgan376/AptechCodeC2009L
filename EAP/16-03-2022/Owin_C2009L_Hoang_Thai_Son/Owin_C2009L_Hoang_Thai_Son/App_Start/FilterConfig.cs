using System.Web;
using System.Web.Mvc;

namespace Owin_C2009L_Hoang_Thai_Son
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
