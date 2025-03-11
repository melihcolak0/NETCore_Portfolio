using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Yeteneklerim'in Listelenmesi";
            ViewBag.v2 = "Yeteneklerim";
            ViewBag.v3 = "Yeteneklerim'in Listelenmesi";
            ViewBag.v4 = "/Skill/Index";
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Yeni Yetenek Ekleme";
            ViewBag.v2 = "Yeteneklerim";
            ViewBag.v3 = "Yeni Yetenek Ekleme";
            ViewBag.v4 = "/Skill/Index";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = skillManager.TGetById(id);
            skillManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            ViewBag.v1 = "Yetenek Güncelleme";
            ViewBag.v2 = "Yeteneklerim";
            ViewBag.v3 = "Yetenek Güncelleme";
            ViewBag.v4 = "/Skill/Index";
            var values = skillManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
