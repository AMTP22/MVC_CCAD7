using Microsoft.AspNetCore.Mvc;
using WebAppTeamA.Models;
using Newtonsoft.Json;

namespace WebAppTeamA.Controllers
{
    public class ConferenceController : Controller
    {
        public List<Conference> ConfData()
        {
            List<Conference> conferences = new List<Conference>();
            using (StreamReader confInfo = new StreamReader("Data/conferences.json"))
            {
                string rawConfData = confInfo.ReadToEnd();
                
                conferences = JsonConvert.DeserializeObject<List<Conference>>(rawConfData);
            }
            return conferences;
        }
        public IActionResult Index()
        {
            List<Conference> conferences = ConfData();
            return View("Index", conferences);
        }

        public IActionResult Details(int id)
        {
            Conference detailConfInfo = ConfData().Where(c => c._id.Equals(id)).FirstOrDefault();
            return View("details", detailConfInfo);
        }
    }
}
