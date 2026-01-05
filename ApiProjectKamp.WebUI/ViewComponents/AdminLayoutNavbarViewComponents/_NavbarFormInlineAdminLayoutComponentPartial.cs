using Microsoft.AspNetCore.Mvc;

namespace ApiProjectKamp.WebUI.ViewComponents.AdminLayoutNavbarViewComponents
{
    public class _NavbarFormInlineAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}