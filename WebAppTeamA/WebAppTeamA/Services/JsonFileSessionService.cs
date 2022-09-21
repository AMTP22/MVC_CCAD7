using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using WebAppTeamA.Models;

namespace WebAppTeamA.Services
{
    public class JsonFileSessionService
    {
        public List<Conference> Conferences { get; set; }
        //public JsonFileSessionService(IWebHostEnvironment webHostEnvironment)
        //{
        //    WebHostEnvironment = webHostEnvironment;
        //}

        //public IWebHostEnvironment WebHostEnvironment { get; }

        //private string JsonFileName
        //{
        //    get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "sessions.json"); }
        //}

        public void ReserveSeat(int id)
        {
            //this.Conferences[id].Seats--;
        }

        public void Initialize()
        {
            Conferences = new List<Conference>();
            using (StreamReader confInfo = new StreamReader("Data/conferences.json"))
            {
                string rawConfData = confInfo.ReadToEnd();
                Conferences = JsonConvert.DeserializeObject<List<Conference>>(rawConfData);
            }
        }

        //public IEnumerable<Session> GetSessions()
        //{
        //    using (var jsonFileReader = File.OpenText(JsonFileName))
        //    {
        //        return System.Text.Json.JsonSerializer.Deserialize<Session[]>(jsonFileReader.ReadToEnd(),
        //            new JsonSerializerOptions
        //            {
        //                PropertyNameCaseInsensitive = true
        //            });
        //    }
        //}
    }
}
