using System.Linq;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.deger1 = c.Blogs.ToList();
            by.deger2 = c.Blogs.OrderByDescending(x => x.Tarih).Take(4).ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            by.deger1 = c.Blogs.Where(x => x.Id == id).ToList();
            by.deger3 = c.Yorumlars.Where(y=>y.BlogId==id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap( int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();

            return PartialView();
        }

    }
}