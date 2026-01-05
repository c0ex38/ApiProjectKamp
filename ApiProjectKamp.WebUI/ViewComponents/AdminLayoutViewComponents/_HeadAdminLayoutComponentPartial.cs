using Microsoft.AspNetCore.Mvc;

namespace ApiProjectKamp.WebUI.ViewComponents
{
    public class _HeadAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}