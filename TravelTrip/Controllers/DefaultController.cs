using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c=new Context();

        public ActionResult Index()
        {
                var slide=c.Blogs.Take(4).ToList();
            return View(slide);
        }
        public ActionResult About()
        {
            var hakkimizda=c.Hakkimizdas.FirstOrDefault();
            return View(hakkimizda);
        }
        public PartialViewResult Partial1()
        {
            var deger=c.Blogs.OrderByDescending(x=>x.Id).Take(2).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial2()
        {
            var deger2=c.Blogs.OrderByDescending(x=>x.Id).Skip(2).Take(1).ToList();
            return PartialView(deger2);
        }
        
        public PartialViewResult Partial3()
        {
            var deger3=c.Blogs.Take(10).ToList();
            return PartialView(deger3);
        }
        public PartialViewResult Partial4()
        {
            var deger4=c.Blogs.OrderByDescending(x=>x.Id).Take(3).ToList();
            return PartialView(deger4);
        }
        public PartialViewResult Partial5()
        {
            var deger5 = c.Blogs.Take(3).ToList();
            return PartialView(deger5);
        }

    }
}