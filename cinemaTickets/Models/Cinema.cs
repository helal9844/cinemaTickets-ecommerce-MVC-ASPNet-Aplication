namespace cinemaTickets.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Logo { get; set; } = "";
        public string CinemaName { get; set; } = "";
        public string CinemaDescription { get; set; } = "";
        public string Location { get; set; } = ""; 

        public List<Movie> Movies { get; set; }

        
    }
}
