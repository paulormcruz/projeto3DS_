using Microsoft.AspNetCore.Mvc;
using projeto3DS.Models;
using System.Diagnostics;

namespace projeto3DS.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
