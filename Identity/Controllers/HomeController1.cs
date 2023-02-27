using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class HomeController1 : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View((object)"Hello");
        }
    }
}
