using Lesson10.Models;
using System.Web.Mvc;

namespace Lesson10.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateBooking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBooking(User user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View("Completed");
        }
    }
}