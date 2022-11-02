using Microsoft.AspNetCore.Mvc;

namespace Gr44MVCEmpty.Controllers
{
    public class DarthVaderController : Controller
    {

        [HttpGet]
        public IActionResult TestForFever(double temp)
        {

            if (temp != 0)
            {
                ViewBag.Msg = Models.DarthVader.TestFever(temp);
                return View();
            }
            else { 
                ViewBag.Msg= "Please enter your temperature and then hit Submit";
                return View(); 
            }
              
        }
        
        [HttpGet]
   
        public IActionResult TestFever()
        {
            return View();
        }
    }
}
