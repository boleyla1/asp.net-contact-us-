using first_asp.net_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace first_asp.net_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult message() {
        return View(new List<message> (database.database.messages));
        }
        [HttpPost]
        public IActionResult sendmessage(message Message) 
        {

            database.database.messages.Add(Message);
            return Redirect("/home/message");
        }
    }
}
