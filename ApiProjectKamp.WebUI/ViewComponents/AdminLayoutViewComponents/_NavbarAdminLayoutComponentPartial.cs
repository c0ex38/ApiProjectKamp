using Microsoft.AspNetCore.Mvc;

namespace ApiProjectKamp.WebUI.ViewComponents
{
    public class _NavbarAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}