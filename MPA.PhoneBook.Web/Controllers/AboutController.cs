using System.Web.Mvc;

namespace MPA.PhoneBook.Web.Controllers
{
    public class AboutController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}