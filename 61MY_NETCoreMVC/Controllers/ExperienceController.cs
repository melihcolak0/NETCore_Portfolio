using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listeleme";
            ViewBag.v2 = "Deneyimlerim";
            ViewBag.v3 = "Deneyim Listeleme";
            ViewBag.v4 = "/Experience/Index";
            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Yeni Deneyim Ekleme";
            ViewBag.v2 = "Deneyimlerim";
            ViewBag.v3 = "Yeni Deneyim Ekleme";
            ViewBag.v4 = "/Experience/Index";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {            
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = experienceManager.TGetById(id);
            experienceManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.v1 = "Deneyim Güncelleme";
            ViewBag.v2 = "Deneyimlerim";
            ViewBag.v3 = "Deneyim Güncelleme";
            ViewBag.v4 = "/Experience/Index";
            var values = experienceManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
