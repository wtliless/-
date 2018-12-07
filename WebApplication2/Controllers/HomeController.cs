using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();

            return RedirectToAction("About", "Home");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            Test1 test1 = new Test1();
            test1.Testdtr();
            Test1.Test();
            instance instance = new instance();
            instance.tests();

            return View();
        }
    }


    public abstract class abstractTest
    {
        public abstract void test();

        public void tests()
        {

        }
    }

    public class instance : abstractTest
    {
        public override void test()
        {

            throw new NotImplementedException();
        }

    }

    public static class Test
    {
        public static void TestVoid()
        {

        }
    }

    public class Test1
    {
        public static void Test()
        {

        }

        public string Testdtr()
        {
            return null;
        }
    }
}