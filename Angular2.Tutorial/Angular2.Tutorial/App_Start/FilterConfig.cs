﻿using System.Web;
using System.Web.Mvc;

namespace Angular2.Tutorial
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}