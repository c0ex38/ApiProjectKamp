using Microsoft.AspNetCore.Mvc;

namespace ApiProjectKamp.WebUI.ViewComponents
{
    public class _FeatureDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}