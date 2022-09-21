namespace WebAppTeamA.Models
{
    public class Conference
	{

		public int _id;
		public string _location;
		public string _speaker;
		public string _photoUrl;
		public string _title;
		public string _email;
		public int _track;
        //"ID": "100",
		//"Location": "Denver, CO",
		//"Speaker": "Boswell Darnce",
		//"photo": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRs73q9GUPD12-vnOrM24AtxzXO2NQFTEbtEw&usqp=CAU",
		//"Title": "Omni Automation and You",
		//"Email": "boswell.darnce@wbytz.com",
		//"Track": "1"
		public Conference(int id, string location, string speaker, string photo, string title, string email, int track)
		{
			_id = id;
			_location = location;
			_speaker = speaker;
			_photoUrl = photo;
			_title = title;
			_email = email;
			_track = track;
		}

		
    }
}
