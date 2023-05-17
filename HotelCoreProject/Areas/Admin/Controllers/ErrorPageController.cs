using Microsoft.AspNetCore.Mvc;

namespace HotelCoreProject.Areas.Admin.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
