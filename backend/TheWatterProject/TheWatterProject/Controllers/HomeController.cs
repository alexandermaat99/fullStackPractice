using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheWatterProject.Models;

namespace TheWatterProject.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
