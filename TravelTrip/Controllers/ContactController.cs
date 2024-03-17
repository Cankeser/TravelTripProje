using System.Linq;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context c = new Context();

        public ActionResult Index()
        {
            var adres = c.AdresBlogs.FirstOrDefault();
            return View(adres);
        }

        [HttpPost]
        public ActionResult Mesaj(Iletisim i)
        { 

            c.Iletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
