using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Sosyal Medya";
            ViewBag.v2 = "Sosyal Medya";
            ViewBag.v3 = "Sosyal Medya";
            ViewBag.v4 = "/SocialMedia/Index";

            var values = socialMediaManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            ViewBag.v1 = "Yeni Sosyal Medya Ekleme";
            ViewBag.v2 = "Sosyal Medya";
            ViewBag.v3 = "Sosyal Medya";
            ViewBag.v4 = "/SocialMedia/Index";

            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.Status = true;
            socialMediaManager.TAdd(p);
            return RedirectToAction("Index");
        }
                
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = socialMediaManager.TGetById(id);
            socialMediaManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            ViewBag.v1 = "Sosyal Medya Güncelleme";
            ViewBag.v2 = "Sosyal Medya";
            ViewBag.v3 = "Sosyal Medya";
            ViewBag.v4 = "/SocialMedia/Index";

            var value = socialMediaManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia p)
        {
            socialMediaManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
