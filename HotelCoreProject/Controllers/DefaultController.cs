using Microsoft.AspNetCore.Mvc;

namespace HotelCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
