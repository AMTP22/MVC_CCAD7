namespace WebAppTeamA.Models
{
    public class SessionRepo
    {
        private List<Session> sessions = new List<Session>()
        {
            new Session { Id = 1, Title = "Contoso Denver", Seats = 100},
            new Session { Id = 2, Title = "Contoso Austin", Seats = 100},
            new Session { Id = 3, Title = "Contoso Seattle", Seats = 100},
            new Session { Id = 4, Title = "Contoso New Yor", Seats = 100 }
        };

        public List<Session> GetSessions()
        {
            return sessions;
        }

        public Session GetSession(int id)
        {
            return sessions.FirstOrDefault(s => s.Id == id);
        }
    }
}
