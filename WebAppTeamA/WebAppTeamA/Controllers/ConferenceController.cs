using Microsoft.AspNetCore.Mvc;
using WebAppTeamA.Models;
using Newtonsoft.Json;
using WebAppTeamA.Services;

namespace WebAppTeamA.Controllers
{
    public class ConferenceController : Controller
    {
        private JsonFileSessionService _service;
        

        public ConferenceController(JsonFileSessionService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            List<Conference> conferences = _service.Conferences;
            return View("Index", conferences);
        }

        public IActionResult Details(int id)
        {
            Conference detailConfInfo = _service.Conferences.Where(c => c._id.Equals(id)).FirstOrDefault();
            return View("details", detailConfInfo);
        }
    }
}
