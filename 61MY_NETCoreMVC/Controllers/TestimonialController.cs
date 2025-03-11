using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Yeni Refrans Ekleme";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar";
            ViewBag.v4 = "/Testimonial/Index";

            var values = testimonialManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            ViewBag.v1 = "Referanslar";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar";
            ViewBag.v4 = "/Testimonial/Index";
            return View();           
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            testimonialManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = testimonialManager.TGetById(id);
            testimonialManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            ViewBag.v1 = "Referans Güncelleme";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar";
            ViewBag.v4 = "/Testimonial/Index";
            var values = testimonialManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
