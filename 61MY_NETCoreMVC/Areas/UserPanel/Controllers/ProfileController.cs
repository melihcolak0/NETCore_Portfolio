using _61MY_NETCoreMVC.Areas.UserPanel.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace _61MY_NETCoreMVC.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Route("UserPanel/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserProfileEditViewModel model = new UserProfileEditViewModel();
            model.Name = value.Name;
            model.Surname = value.Surname;
            model.ImageUrl = value.ImageUrl;
            return View(model);
        }

        [HttpPost]        
        public async Task<IActionResult> Index(UserProfileEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if(p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/UserProfileImage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }

            user.Name = p.Name;
            user.Surname = p.Surname;

            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);

            var result = await _userManager.UpdateAsync(user);

            if(result.Succeeded)
            {
                return RedirectToAction("Index", "LogIn");
            }

            return View();
        }
    }
}
