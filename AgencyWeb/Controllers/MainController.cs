using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
