﻿using System.Web;
using System.Web.Mvc;

namespace Parcijalni_Ispit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
