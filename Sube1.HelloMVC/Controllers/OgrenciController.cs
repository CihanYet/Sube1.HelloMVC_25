using Microsoft.AspNetCore.Mvc;
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

        public ViewResult OgrenciDetay()
        {
            //Ogrenci ogr = null;
            //if (id == 1)
            //{
            //    ogr = new Ogrenci { Ogrenciid = 1, Ad = "Ali", Soyad = "Veli" };
            //}
            //else if (id == 2)
            //{
            //    ogr = new Ogrenci { Ogrenciid = 2, Ad = "Ahmet", Soyad = "Mehmet" };
            //}           
            //ViewData["ogrenci"] = ogr;
            //ViewBag.student = ogr;
            var ogr= new Ogrenci { Ogrenciid = 1, Ad = "Ali", Soyad = "Veli" };
            var ogretmen = new Ogretmen { Ogretmenid = 1, Ad = "Cihan", Soyad = "Yetişken" };

            var dto = new OgrenciDetayDTO { Ogrenci = ogr, Ogretmen = ogretmen };

            return View(dto);
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

