﻿using System.Web;
using System.Web.Mvc;

namespace allpax_sale_miner_mdbootstrap2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
