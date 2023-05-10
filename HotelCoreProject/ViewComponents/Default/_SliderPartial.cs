using Microsoft.AspNetCore.Mvc;

namespace HotelCoreProject.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
