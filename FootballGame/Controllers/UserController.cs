using Microsoft.AspNetCore.Mvc;

namespace FootballGame.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
