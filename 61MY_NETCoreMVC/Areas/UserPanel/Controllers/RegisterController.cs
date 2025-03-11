using _61MY_NETCoreMVC.Areas.UserPanel.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _61MY_NETCoreMVC.Areas.UserPanel.Controllers
{
    [AllowAnonymous]
    [Area("UserPanel")]
    [Route("UserPanel/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                WriterUser writerUser = new WriterUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Mail,
                    UserName = p.Username,
                    ImageUrl = p.ImageUrl
                };

                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(writerUser, p.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "LogIn");
                    }
                    else
                    {
                        foreach (var x in result.Errors)
                        {
                            ModelState.AddModelError("", x.Description);
                        }
                    }
                }
            }
            return View();
        }
    }
}
