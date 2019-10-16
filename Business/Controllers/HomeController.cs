using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    public class HomeController : Controller
    {
        //path: /
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

    }
}