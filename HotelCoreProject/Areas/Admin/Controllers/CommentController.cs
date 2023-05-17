using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace HotelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentSercive _commentSercive;

        public CommentController(ICommentSercive commentSercive)
        {
            _commentSercive = commentSercive;
        }

        public IActionResult Index()
        {
            var values = _commentSercive.TGetListCommentWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values = _commentSercive.TGetById(id);
            _commentSercive.TDelete(values);
            return RedirectToAction("Comment","Admin");
        }
    }
}
