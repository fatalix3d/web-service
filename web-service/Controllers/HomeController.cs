using Microsoft.AspNetCore.Mvc;

namespace web_service.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return RedirectToRoute("default", new { controller = "Auth", action = "index" });
        }
    }
}
