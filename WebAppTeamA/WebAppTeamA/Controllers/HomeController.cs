using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppTeamA.Models;
using WebAppTeamA.Services;

namespace WebAppTeamA.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        public JsonFileSessionService FileSessionService;
        public IEnumerable<Session> MySessions { get; private set; }

        public HomeController(ILogger<HomeController> logger,
                                JsonFileSessionService sessionService)
        {
            _logger = logger;
            FileSessionService = sessionService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sessions()
        {
            
            MySessions = FileSessionService.GetSessions();
            return View(MySessions);
        }

        public IActionResult SessionDetails(int id)
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