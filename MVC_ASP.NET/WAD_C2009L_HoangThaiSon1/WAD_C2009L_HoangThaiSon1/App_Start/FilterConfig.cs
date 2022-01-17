using System.Web;
using System.Web.Mvc;

namespace WAD_C2009L_HoangThaiSon1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
