using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Views.Home
{
    public class RegisterAreaTest: AreaRegistration
    {
        public override string AreaName => "Home";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Global_default",
                "uyuyuyuyu{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}