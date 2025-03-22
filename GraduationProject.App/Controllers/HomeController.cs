using GraduationProject.App.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Predator.App.Repositories;
using System.Diagnostics;

namespace Predator.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository _userRepository;
        public IActionResult Index()
        {
            string jsonUser = HttpContext.Session.GetString("SessionUser");

            User serializedUser = JsonConvert.DeserializeObject<User>(jsonUser);

            return View("index", serializedUser);
        }

        public IActionResult CreateLecture()
        {
            return RedirectToAction("CreateLecture", "User");
        }

        public IActionResult Login()
        {
            return RedirectToAction("Login", "User");
        }

        public IActionResult Regiser()
        {
            return RedirectToAction("Register" , "User");
        }

        public IActionResult Overview()
        {
            return RedirectToAction("Overview", "User");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("SessionUser");

            return RedirectToAction("index", "Home");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
