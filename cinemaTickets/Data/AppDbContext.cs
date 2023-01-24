using cinemaTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace cinemaTickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>()
                .HasKey(p => new
                {
                    p.ActorId,
                    p.MovieId
                });

            modelBuilder.Entity<ActorMovie>()
                .HasOne(p => p.Movie)
                .WithMany(p => p.ActorMovies)
                .HasForeignKey(p => p.MovieId);

            modelBuilder.Entity<ActorMovie>()
                .HasOne(p => p.Actor)
                .WithMany(p => p.ActorMovies)
                .HasForeignKey(p => p.ActorId);
            modelBuilder.Entity<Movie>()
                .Property(e => e.Category)
                .HasConversion(
                     v => v.ToString(),
                     v => (MovieCategory)Enum.Parse(typeof(MovieCategory), v??""));


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
