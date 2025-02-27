using Microsoft.AspNetCore.Mvc;

namespace Sube1.HelloMVC.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult Index()//Action
        {
            return View();//TODO:Farklı isimli View örneği
        }

        public string OgrenciDetay(int ogrenciid)
        {
            string ogr;
            if (ogrenciid == 1)
            {
                ogr = "Ali Veli ";
            }
            else if (ogrenciid == 2)
            {
                ogr = "Ahmet Mehmet ";
            }
            else
            {
                ogr = "Öğrenci Bulunamadı";
            }
            return ogr;
        }
    }
}

//QueryString: Action'ın aldığı parametre id'den farklıysa ? kullanılarak parametreye değer gönderilebilir.

//wwwroot:Web uygalamasının kök dizinidir ve uygulamada kullanılan static dosyalar bu klasörde bulunur.
