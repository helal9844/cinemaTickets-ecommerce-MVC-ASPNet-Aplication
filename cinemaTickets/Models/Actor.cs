namespace cinemaTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string ProfilePic { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string BIO { get; set; } = "";

        public List<ActorMovie>? ActorMovies { get; set; }

        
    }
}
