using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03122023_MVCGiris2.Controllers
{
    public class HomeController : Controller
    {
        /* 
         * Veri Aktarımı
         * -------------------
         * MVC projelerinde Controller yapısı içerisinden View yapısındaki UI sayfasına küçük boyutlu verileri aktarmak isteyebilirsiniz.Bu gibi durumlarda ViewData,ViewBag ve TempData yapıları devreye girer
         * 
         * ViewBag ve ViewData Aynı Mantıkta Çalışmaktadır.Controller içerisindeki bir veriyi (string , object , collection, vb...) kendi view sayfalarına taşıyabilirler
         * 
         * Kullanım şekilleri farklı , işleyiş yapıları aynı olsa da ViewBag yapısı MVC3 ve sonrasında kullanılmaktadır.ViewData ise tüm versiyonlarda sorunsuz bir şekilde çalışır
         * 
         * TempData ise aynı mantıkla çalışmakla birlikte sadece kendi view sayfasına değil , sayfalar arasında veri transferi yapmak içinde kullanılır
         * 
         * ViewData Syntax
         * ---------------
         * ViewData[<name>]=<value>;
         * 
         * ViewBag Syntax
         * -----------------
         * ViewBag.<name>=<value>;
         * 
         * TempData Syntax;
         * -------------------
         * TempData[<name>]=<value>;
        */
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Mesaj1"] = "MVC Derslerine Hoşgeldiniz. (ViewData)";
            ViewBag.Mesaj2 = "Mvc Derslerine Hoşgeldiniz.(ViewBag)";
            TempData["Mesaj3"] = "MVC Derslerine Hoşgeldiniz. (TempData)";

            /*Controller yapısı içerisinde farklık bir sayfaya yönlendirme yapmak için RedirectToActiyon(<actionName>); metodunu kullanabilirsinz */
            return RedirectToAction("Sayfa2");

            //return View();
        }
        public ActionResult Sayfa2()
        {
            return View();
        }
    }
}