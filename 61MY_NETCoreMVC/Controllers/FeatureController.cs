using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Öne Çıkan Düzenleme";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkan Düzenleme";
            ViewBag.v4 = "/Feature/Index";
            var value = featureManager.TGetById(2);
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            ViewBag.v1 = "Öne Çıkan Düzenleme";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkan Düzenleme";
            ViewBag.v4 = "/Feature/Index";

            featureManager.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }        
    }
}
