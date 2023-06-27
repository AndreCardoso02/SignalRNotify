using Microsoft.AspNetCore.Mvc;

namespace SignalRNotify.Controllers
{
    public class AccountController1 : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
