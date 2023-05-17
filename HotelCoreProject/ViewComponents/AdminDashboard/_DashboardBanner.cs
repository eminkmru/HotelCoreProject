using Microsoft.AspNetCore.Mvc;

namespace HotelCoreProject.ViewComponents.AdminDashboard
{
    public class _DashboardBanner: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
