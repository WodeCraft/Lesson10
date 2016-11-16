using Lesson10.Models;
using System.Web.Mvc;

namespace Lesson10.Controllers
{
    public class InterviewController : Controller
    {
        // GET: Interview
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateInterview()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateInterview(Interviewee interviewee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View("Completed", interviewee);
        }
    }
}