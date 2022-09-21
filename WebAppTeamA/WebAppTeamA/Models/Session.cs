using System.Text.Json;

namespace WebAppTeamA.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string KeySpeaker { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public int Seats { get; set; }
        //public List<Speakers>[] Speakers { get; set; }



        public override string ToString()
        {
           return JsonSerializer.Serialize<Session>(this);
        }
    }

    
}
