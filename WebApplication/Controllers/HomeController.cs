using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationForMVC.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult ViewResult(string sss)
        {
            return null;
        }

        public ActionResult Index()
        {
            //return View();
            var test1 = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

            var test = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
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
            instance.Tests();

            return View();
        }
    }


    public abstract class AbstractTest
    {
        public abstract void Test();

        public void Tests()
        {

        }

        public static void Ss()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class instance : AbstractTest
    {
        public override void Test()
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

        Singer Singer = Singer.SingerInstance();
    }

    public class Singer
    {
        public static Singer SingerInstance()
        {
            return null;
        }

        private Singer()
        {

        }

        public void SIngerTest()
        {

        }
    }
}