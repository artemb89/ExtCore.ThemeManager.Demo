using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
namespace ExtCore.ThemeManager.Demo.Controllers
{
    
    public class HomeController : Controller
    {
        private IConfiguration configuration;
        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("/ChoseTheme")]
        public IActionResult Index()
        {            
            return View();
        }
        [HttpPost]
        [Route("/ChoseTheme")]
        public IActionResult Index(string themeName)
        {
            configuration["ThemeManager:Theme"] = themeName;
            return View();
        }
        [Route("/")]
        public IActionResult SomePage()
        {
            return View();
        }
    }
}
