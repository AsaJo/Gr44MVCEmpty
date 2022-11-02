using Microsoft.AspNetCore.Mvc;

namespace Gr44MVCEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
