using Microsoft.AspNetCore.Mvc;

namespace HotelCoreProject.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
