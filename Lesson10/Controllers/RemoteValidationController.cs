using Lesson10.Infrastructure;
using System.Web.Mvc;

namespace Lesson10.Controllers
{
    public class RemoteValidationController : Controller
    {
        // GET: RemoteValidation
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult UniqueUserName(string userName)
        {
            bool isUnique = UserRepository.UsernameIsUnique(userName);
            if (isUnique)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(string.Format("The username '{0}' is allready taken.", userName), JsonRequestBehavior.AllowGet);
            }
        }
    }
}