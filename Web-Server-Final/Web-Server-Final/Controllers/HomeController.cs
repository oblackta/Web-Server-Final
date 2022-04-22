using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_Server_Final.Models;

namespace Web_Server_Final.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Team> teams { get; set; }

        public HomeController(WebServerFinalContext ctx)
        {
            teams = new Repository<Team>(ctx);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }

        public IActionResult DiffSports()
        {
            return View();
        }

        public IActionResult SportHistory()
        {
            return View();
        }

        public IActionResult SportSchedules()
        {
            return View();
        }

        public IActionResult Teams()
        {
            var options = new QueryOptions<Team>
            {
                OrderBy = t => t.TeamId
            };
            ViewBag.Teams = teams.List(options);
            return View(teams.List(options));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
