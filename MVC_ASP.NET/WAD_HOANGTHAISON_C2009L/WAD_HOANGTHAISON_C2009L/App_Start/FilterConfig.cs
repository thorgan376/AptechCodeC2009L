﻿using System.Web;
using System.Web.Mvc;

namespace WAD_HOANGTHAISON_C2009L
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
