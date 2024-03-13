using Microsoft.AspNetCore.Mvc;

namespace MyProjectWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutFooterPartialComponent:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{ 
			return View(); 
		}
	}
}
