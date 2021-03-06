﻿using System.Web;
using System.Web.Mvc;

namespace MovieWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            filters.Add(new AuthorizeAttribute()); // Enable Auth restriction

            filters.Add(new RequireHttpsAttribute()); // Set https only 
        }
    }
}
