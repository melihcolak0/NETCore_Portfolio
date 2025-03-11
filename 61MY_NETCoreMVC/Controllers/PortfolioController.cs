using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Portföy Listeleme";
            ViewBag.v2 = "Portföy";
            ViewBag.v3 = "Portföy Listeleme";
            ViewBag.v4 = "/Portfolio/Index";
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Yeni Proje Ekleme";
            ViewBag.v2 = "Portföy";
            ViewBag.v3 = "Yeni Proje Ekleme";
            ViewBag.v4 = "/Portfolio/Index";
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            ViewBag.v1 = "Yeni Proje Ekleme";
            ViewBag.v2 = "Portföy";
            ViewBag.v3 = "Yeni Proje Ekleme";
            ViewBag.v4 = "/Portfolio/Index";

            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult validationResult = validator.Validate(portfolio);

            if(validationResult.IsValid)
            {
                portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var x in validationResult.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }               
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = portfolioManager.TGetById(id);
            portfolioManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.v1 = "Proje Güncelleme";
            ViewBag.v2 = "Portföy";
            ViewBag.v3 = "Proje Güncelleme";
            ViewBag.v4 = "/Portfolio/Index";
            var values = portfolioManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            ViewBag.v1 = "Proje Güncelleme";
            ViewBag.v2 = "Portföy";
            ViewBag.v3 = "Proje Güncelleme";
            ViewBag.v4 = "/Portfolio/Index";

            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult validationResult = validator.Validate(portfolio);

            if (validationResult.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in validationResult.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }            
        }
    }
}
