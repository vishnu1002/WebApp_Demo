using Microsoft.AspNetCore.Mvc;

namespace WebApp_Demo.Controllers
{
    public class TreeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
