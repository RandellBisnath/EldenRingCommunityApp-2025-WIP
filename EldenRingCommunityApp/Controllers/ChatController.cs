using Microsoft.AspNetCore.Mvc;

namespace EldenRingCommunityApp.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Chatroom()
        {
            return View();
        }
    }
}
