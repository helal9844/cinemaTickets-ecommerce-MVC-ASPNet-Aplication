using cinemaTickets.Models;

namespace cinemaTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicesScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicesScope.ServiceProvider.GetService<AppDbContext>();
                if (context != null)
                {
                    context.Database.EnsureCreated();
                    //Cinemas
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>()
                        {
                            new Cinema()
                            {
                                CinemaName = "Cinema1",
                                CinemaDescription ="Description......",
                                Logo = "wwwroot/images/1.jfif",
                                Location = "LA"

                            },
                            new Cinema()
                            {
                                CinemaName = "Cinema2",
                                CinemaDescription ="Description......",
                                Logo = "wwwroot/images/2.jfif",
                                Location = "Alex"

                            },
                            new Cinema()
                            {
                                CinemaName = "Cinema3",
                                CinemaDescription ="Description......",
                                Logo = "wwwroot/images/3.jfif",
                                Location = "Cairo"

                            },
                            new Cinema()
                            {
                                CinemaName = "Cinema4",
                                CinemaDescription ="Description......",
                                Logo = "wwwroot/images/4.jfif",
                                Location = "Dubi"

                            },
                            new Cinema()
                            {
                                CinemaName = "Cinema5",
                                CinemaDescription ="Description......",
                                Logo = "wwwroot/images/5.jfif",
                                Location = "Port"

                            }

                        });
                        context.SaveChanges();
                    }
                    //Actors
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                        {
                            new Actor()
                            {
                                FirstName = "Actor1",
                                LastName =  "Actor1",
                                BIO = "Description......",
                                ProfilePic = "wwwroot/images/1.jfif",
                                Age = 33

                            },
                            new Actor()
                            {
                                FirstName = "Actor2",
                                LastName =  "Actor2",
                                BIO = "Description......",
                                ProfilePic = "wwwroot/images/2.jfif",
                                Age = 43

                            },
                            new Actor()
                            {
                                FirstName = "Actor3",
                                LastName =  "Actor3",
                                BIO = "Description......",
                                ProfilePic = "wwwroot/images/3.jfif",
                                Age = 35

                            },
                            new Actor()
                            {
                                FirstName = "Actor4",
                                LastName =  "Actor4",
                                BIO = "Description......",
                                ProfilePic = "wwwroot/images/4.jfif",
                                Age = 22

                            },
                            new Actor()
                            {
                                FirstName = "Actor5",
                                LastName =  "Actor5",
                                BIO = "Description......",
                                ProfilePic = "wwwroot/images/5.jfif",
                                Age = 50

                            }

                        });
                        context.SaveChanges();
                    }
                    //producer
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                        {
                            new Producer()
                            {
                                FirstName = "Producer 1",
                                LastName = "Producer 1",
                                Age = 50,
                                BIO = "Description....",
                                ProfilePic = "wwwroot/images/1.jfif"
                            },new Producer()
                            {
                                FirstName = "Producer 2",
                                LastName = "Producer 2",
                                Age = 55,
                                BIO = "Description....",
                                ProfilePic = "wwwroot/images/2.jfif"
                            },new Producer()
                            {
                                FirstName = "Producer 3",
                                LastName = "Producer 3",
                                Age = 40,
                                BIO = "Description....",
                                ProfilePic = "wwwroot/images/3.jfif"
                            },new Producer()
                            {
                                FirstName = "Producer 4",
                                LastName = "Producer 4",
                                Age = 35,
                                BIO = "Description....",
                                ProfilePic = "wwwroot/images/4.jfif"
                            },new Producer()
                            {
                                FirstName = "Producer 5",
                                LastName = "Producer 5",
                                Age = 45,
                                BIO = "Description....",
                                ProfilePic = "wwwroot/images/5.jfif"
                            },
                        });
                        context.SaveChanges();
                    }
                    //Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                        {
                            new Movie()
                            {
                                Name = "Life",
                                Description = "This is the Life movie description",
                                Price = 39.50,
                                Image = "wwwroot/images/1.jfif",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(10),
                                CinemaId = 3,
                                ProducerId = 3,
                                Category = MovieCategory.Documentary
                            },
                            new Movie()
                            {
                                Name = "The Shawshank Redemption",
                                Description = "This is the Shawshank Redemption description",
                                Price = 29.50,
                                Image = "wwwroot/images/2.jfif",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(3),
                                CinemaId = 1,
                                ProducerId = 1,
                                Category = MovieCategory.Action
                            },
                            new Movie()
                            {
                                Name = "Ghost",
                                Description = "This is the Ghost movie description",
                                Price = 39.50,
                                Image = "wwwroot/images/3.jfif",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(7),
                                CinemaId = 4,
                                ProducerId = 4,
                                Category = MovieCategory.Horror
                            },
                            new Movie()
                            {
                                Name = "Race",
                                Description = "This is the Race movie description",
                                Price = 39.50,
                                Image = "wwwroot/images/4.jfif",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(-5),
                                CinemaId = 1,
                                ProducerId = 2,
                                Category = MovieCategory.Documentary
                            },
                            new Movie()
                            {
                                Name = "Scoob",
                                Description = "This is the Scoob movie description",
                                Price = 39.50,
                                Image = "wwwroot/images/5.jfif",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(-2),
                                CinemaId = 1,
                                ProducerId = 3,
                                Category = MovieCategory.Cartoon
                            },
                            new Movie()
                            {
                                Name = "Cold Soles",
                                Description = "This is the Cold Soles movie description",
                                Price = 39.50,
                                Image = "http://dotnethow.net/images/movies/movie-8.jpeg",
                                StartDate = DateTime.Now.AddDays(3),
                                EndDate = DateTime.Now.AddDays(20),
                                CinemaId = 1,
                                ProducerId = 5,
                                Category = MovieCategory.Drama
                            },
                            new Movie()
                            {
                                Name = "Cold Soles 2",
                                Description = "This is the Cold Soles movie description",
                                Price = 39.50,
                                Image = "http://dotnethow.net/images/movies/movie-8.jpeg",
                                StartDate = DateTime.Now.AddDays(3),
                                EndDate = DateTime.Now.AddDays(20),
                                CinemaId = 1,
                                ProducerId = 5,
                                Category = MovieCategory.Drama
                            }

                            });
                        context.SaveChanges();

                    }
                    //Actors & Movies
                    if (!context.ActorMovies.Any())
                    {
                        context.ActorMovies.AddRange(new List<ActorMovie>()
                        {
                            new ActorMovie()
                            {
                                ActorId = 1,
                                MovieId = 1
                            },
                            new ActorMovie()
                            {
                                ActorId = 3,
                                MovieId = 1
                            },

                             new ActorMovie()
                            {
                                ActorId = 1,
                                MovieId = 2
                            },
                             new ActorMovie()
                            {
                                ActorId = 4,
                                MovieId = 2
                            },

                            new ActorMovie()
                            {
                                ActorId = 1,
                                MovieId = 3
                            },
                            new ActorMovie()
                            {
                                ActorId = 2,
                                MovieId = 3
                            },
                            new ActorMovie()
                            {
                                ActorId = 5,
                                MovieId = 3
                            },


                            new ActorMovie()
                            {
                                ActorId = 2,
                                MovieId = 4
                            },
                            new ActorMovie()
                            {
                                ActorId = 3,
                                MovieId = 4
                            },
                            new ActorMovie()
                            {
                                ActorId = 4,
                                MovieId = 4
                            },


                            new ActorMovie()
                            {
                                ActorId = 2,
                                MovieId = 5
                            },
                            new ActorMovie()
                            {
                                ActorId = 3,
                                MovieId = 5
                            },
                            new ActorMovie()
                            {
                                ActorId = 4,
                                MovieId = 5
                            },
                            new ActorMovie()
                            {
                                ActorId = 5,
                                MovieId = 5
                            },


                            new ActorMovie()
                            {
                                ActorId = 3,
                                MovieId = 6
                            },
                            new ActorMovie()
                            {
                                ActorId = 4,
                                MovieId = 6
                            },
                            new ActorMovie()
                            {
                                ActorId = 5,
                                MovieId = 6
                            },
                        });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
