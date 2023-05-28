using Microsoft.AspNetCore.Mvc;

namespace CPWebAPI.Controllers
{
    public class ZipCodes : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
