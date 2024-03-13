using Microsoft.AspNetCore.Mvc;

namespace MyProjectWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
    
}
