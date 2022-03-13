using System.Web;
using System.Web.Mvc;

namespace EAP_Music_NguyenVanANew
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
