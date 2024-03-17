using System.Linq;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var blog = c.Blogs.ToList();
            return View(blog);
        }
        [HttpGet]
        public ActionResult BlogEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var deger = c.Blogs.Find(id);
            c.Blogs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BlogGuncelle(int id)
        {
            var blog = c.Blogs.Find(id);
            return View(blog);
        }
        [HttpPost]
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.Id);
            blg.Baslik = b.Baslik;
            blg.Aciklama = b.Aciklama;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Yorumlar()
        {
            var yorum = c.Yorumlars.ToList();
            return View(yorum);
        }
        public ActionResult YorumSil(int id)
        {
            var yorum = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(yorum);
            c.SaveChanges();
            return RedirectToAction("Yorumlar");
        }


        public ActionResult Hakkimizda()
        {
            var hakkimda = c.Hakkimizdas.ToList();
            return View(hakkimda);
        }
        public ActionResult HakkimizdaSil(int id)
        {
            var hakkimdaSil = c.Hakkimizdas.Find(id);
            c.Hakkimizdas.Remove(hakkimdaSil);
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }

        public ActionResult HakkimizdaEkle()
        {

            return View();
        }
        [HttpPost]
         public ActionResult HakkimizdaEkle(Hakkimizda h)
        {
            c.Hakkimizdas.Add(h);
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }

        [HttpGet]
        public ActionResult HakkimizdaGuncelle(int id)
        {
            var HakkimdaBul = c.Hakkimizdas.Find(id);
            return View(HakkimdaBul);
        }
        [HttpPost]
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var hak = c.Hakkimizdas.Find(h.ID);
            hak.Aciklama =h.Aciklama;
            hak.FotoUrl =h.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }


        public ActionResult Iletisim()
        {
            var mesaj = c.Iletisims.ToList();
            return View(mesaj);
        }
        public ActionResult MesajSil(int id)
        {
            var mesajbul = c.Iletisims.Find(id);
            c.Iletisims.Remove(mesajbul);
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }

        public ActionResult Adres()
        {
            var adr = c.AdresBlogs.ToList();
            return View(adr);
        }
        public ActionResult AdresSil(int id)
        {
            var adresSil = c.AdresBlogs.Find(id);
            c.AdresBlogs.Remove(adresSil);
            c.SaveChanges();
            return RedirectToAction("Adres");
        }

        public ActionResult AdresEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdresEkle(AdresBlog a)
        {
            c.AdresBlogs.Add(a);
            c.SaveChanges();
            return RedirectToAction("Adres");
        }

        [HttpGet]
        public ActionResult AdresGuncelle(int id)
        {
            var adresBul = c.AdresBlogs.Find(id);
            return View(adresBul);
        }
        [HttpPost]
        public ActionResult AdresGuncelle(AdresBlog a)
        {
            var adres = c.AdresBlogs.Find(a.ID);
          adres.Adres=a.Adres;
            adres.Aciklama=a.Aciklama;
            adres.Baslik=a.Baslik;
            adres.Konum=a.Konum;    
            adres.Telefon=a.Telefon;
            adres.Mail=a.Mail;
            c.SaveChanges();
            return RedirectToAction("Adres");
        }



    }
}