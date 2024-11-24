using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
