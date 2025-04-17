using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sube1.HelloMVC.Models;
using Sube1.HelloMVC.Models.ViewModels;

namespace Sube1.HelloMVC.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult Index()//Action
        {
            return View("AnaSayfa");
        }

        public ViewResult OgrenciDetay(int id)
        {
            //Ogrenci ogr = null;
            //Ogretmen ogrt = null;
            //if (id == 1)
            //{
            //    ogr = new Ogrenci { Ogrenciid = 1, Ad = "Ali", Soyad = "Veli" };
            //    ogrt = new Ogretmen { Ad = "Osman", Soyad = "Yılmaz", Ogretmenid = 1 };
            //}
            //else if (id == 2)
            //{
            //    ogr = new Ogrenci { Ogrenciid = 2, Ad = "Ahmet", Soyad = "Mehmet" };
            //    ogrt = new Ogretmen { Ad = "Hakan", Soyad = "Demir", Ogretmenid = 2 };
            //}
            //ViewData["ogrenci"] = ogr;
            //ViewBag.student = ogr;

            //var dto = new OgrenciDetayDTO { Ogrenci = ogr, Ogretmen = ogrt };

            return View();
        }

        public IActionResult StudentDetail(int id)
        {
            using (var ctx = new OkulDbContext())
            {
                return View(ctx.Ogrenciler.Find(id));
            }
        }

        [HttpPost]
        public IActionResult StudentDetail(Ogrenci ogr)
        {
            using (var ctx=new OkulDbContext())
            {
                ctx.Entry(ogr).State=EntityState.Modified;
                ctx.SaveChanges();
            }
            return RedirectToAction("OgrenciListe");
        }

        public ViewResult OgrenciListe()
        {
            //Ogrenci ogr = new Ogrenci { Ogrenciid = 1, Ad = "Ali", Soyad = "Veli" };
            //Ogrenci ogr1 = new Ogrenci { Ogrenciid = 2, Ad = "Ahmet", Soyad = "Mehmet" };

            //List<Ogrenci> lst= new List<Ogrenci>();
            //lst.Add(ogr);
            //lst.Add(ogr1);

            //var lst = new List<Ogrenci>()
            //{
            //    new Ogrenci { Ogrenciid = 1, Ad = "Ali", Soyad = "Veli" },
            //    new Ogrenci { Ogrenciid = 2, Ad = "Ahmet", Soyad = "Mehmet" }
            //};

            using (var ctx = new OkulDbContext())
            {
                var lst = ctx.Ogrenciler.ToList();
                return View(lst);
            }
        }


        [HttpGet]
        public ViewResult OgrenciEkle()
        {
            return View();
        }

        //[HttpPost]
        //public ViewResult OgrenciEkle(IFormCollection fc)
        //{
        //    //Öğrenci Ekleme İşlemleri
        //    var ogr = new Ogrenci();
        //    ogr.Ad = fc["Ad"].ToString();
        //    ogr.Soyad = fc["Soyad"].ToString();
        //    return View();
        //}

        [HttpPost]
        public ViewResult OgrenciEkle(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Add(ogr);
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    TempData["sonuc"] = true;
                }
                else
                {
                    TempData["sonuc"] = false;
                }
            }
            return View();
        }
    }
}


//QueryString: Action'ın aldığı parametre id'den farklıysa ? kullanılarak parametreye değer gönderilebilir.

//wwwroot:Web uygalamasının kök dizinidir ve uygulamada kullanılan static dosyalar bu klasörde bulunur.

//Controller->View Veri Taşıma
//1-ViewData: Dictionary(Collection) Key-Value Pair
//Key: Tekil olmalıdır ve string veri tipindedir.
//Value: Object veri tipindedir

//2-ViewBag: Dynamic bir yapıdır. Dynamic yapılar içinde tutulan değerlerin veri tipleri Runtime Sırasında belirlenir.
//ViewBag verileri saklamak için ViewData koleksiyonunu kullanır. Key-Value.
//3-Model
//4-TempData

//ViewModel: Bir View'e birden fazla model taşımak için kullanılır.
//DTO: Data Transfer Object

