using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAT_TEAM.Models;
using DATteam.Models;

namespace DAT_TEAM.Controllers
{
    public class HomeController : Controller
    {
        private static DATContext db = DATContext.getInstance();
        public static String prijavljen = "";

        public IActionResult Index()
        {
            return View();
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
            return View("../Proizvods/Index");
        }

        [HttpPost]
        public IActionResult PrijavaOnClick(string username, string password)
        {
            var trOsoba = db.Osoba.Where((Osoba osoba) => osoba.username.Equals(username));

            if (trOsoba.Count() != 0) {
                Osoba osoba = db.premaUsername(username);
                if (osoba.password.Equals(password))
                {
                    return View("../Proizvods/Index");
                }

                else return View("../Proizvods/Index");
            }


            return View("../Proizvods/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
