using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _61MY_NETCoreMVC.Areas.UserPanel.ViewComponents
{
    public class NavBarProfile : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public NavBarProfile(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = value.ImageUrl;
            return View();
        }
    }
}
