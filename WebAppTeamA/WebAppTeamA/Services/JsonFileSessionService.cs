using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using WebAppTeamA.Models;

namespace WebAppTeamA.Services
{
    public class JsonFileSessionService
    {
        public IEnumerable<Session> Sessions { get; set; }
        
        public List<Conference> Conferences { get; set; }
        //public JsonFileSessionService(IWebHostEnvironment webHostEnvironment)
        //{
        //    WebHostEnvironment = webHostEnvironment;
        //}

        //public IWebHostEnvironment WebHostEnvironment { get; }

        public void InitializeSessions()
        {
            Sessions = GetSessions();
        }

        public IEnumerable<Session> GetSessions()
        {
            using (var jsonFileReader = File.OpenText("wwwroot/data/sessions.json"))
            {
                return JsonSerializer.Deserialize<Session[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
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
