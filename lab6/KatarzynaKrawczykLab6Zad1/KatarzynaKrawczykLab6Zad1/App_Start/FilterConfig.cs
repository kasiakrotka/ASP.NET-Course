﻿using System.Web;
using System.Web.Mvc;

namespace KatarzynaKrawczykLab6Zad1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
