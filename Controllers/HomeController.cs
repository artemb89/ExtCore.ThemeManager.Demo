using Microsoft.AspNetCore.Mvc;
namespace ExtCore.ThemeManager.Demo.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public HomeController()
        {          
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
