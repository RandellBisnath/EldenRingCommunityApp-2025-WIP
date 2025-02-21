using Microsoft.AspNetCore.Mvc;

namespace EldenRingCommunityApp.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult News()
        {
            return View();
        }
    }
}
