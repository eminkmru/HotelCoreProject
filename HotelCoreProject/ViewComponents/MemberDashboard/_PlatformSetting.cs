using Microsoft.AspNetCore.Mvc;

namespace HotelCoreProject.ViewComponents.MemberDashboard
{
    public class _PlatformSetting : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
