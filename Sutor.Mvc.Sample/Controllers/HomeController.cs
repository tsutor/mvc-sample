using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sutor.Mvc.Sample.Web.Models;

namespace Sutor.Mvc.Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();

            //Redirect to test page
            return RedirectToAction("Index", "User");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
