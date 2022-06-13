using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VideoSearchService.Data.Models;

namespace VideoSearchService.DAL
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie {
                    Id = 1, 
                    Title = "Thor: Ragnarok", 
                    AgeLimit = 16, 
                    Duration = 125, 
                    Year = "2017", 
                    Description = "Deprived of his mighty hammer Mjolnir, Thor must escape the other side of the " +
                    "universe to save his home, Asgard, from Hela, the goddess of death."
                },
                new Movie 
                { 
                    Id = 2, 
                    Title = "Avengers: Endgame", 
                    AgeLimit = 16, 
                    Duration = 174, 
                    Year = "2019", 
                    Description = "After Thanos, an intergalactic warlord, disintegrates half of the universe, " +
                    "the Avengers must reunite and assemble again to reinvigorate their trounced allies and restore " +
                    "balance." 
                },
                new Movie 
                { 
                    Id = 3, 
                    Title = "Spider-Man: No Way Home", 
                    AgeLimit = 12, 
                    Duration = 195, 
                    Year = "2021", 
                    Description = "Peter Parker seeks Doctor Strange's help to make people forget about Spiderman's " +
                    "identity. However, when the spell he casts gets corrupted, several unwanted guests enter their " +
                    "universe." 
                },
                new Movie 
                { 
                    Id = 4, 
                    Title = "Uncharted", 
                    AgeLimit = 12, 
                    Duration = 200, 
                    Year = "2022", 
                    Description = "Victor Sullivan recruits Nathan Drake to help him find the lost fortune of Ferdinand " +
                    "Magellan. However, they face competition from Santiago Moncada, who believes that the treasure " +
                    "belongs to him."
                },
                new Movie 
                { 
                    Id = 5, 
                    Title = "Captain America: Civil War", 
                    AgeLimit = 16, 
                    Duration = 142, 
                    Year = "2016", 
                    Description = "Friction arises between the Avengers when one group supports the government's decision " +
                    "to implement a law to control their powers while the other opposes it." 
                },
                new Movie 
                { 
                    Id = 6, 
                    Title = "Sherlock Holmes", 
                    AgeLimit = 12, 
                    Duration = 123, 
                    Year = "2009", 
                    Description = "Sherlock Holmes is a 2009 period mystery action film based on the character of the same " +
                    "name created by Sir Arthur Conan Doyle. " 
                },
                new Movie 
                { 
                    Id = 7,
                    Title = "Dolittle", 
                    AgeLimit = 12, 
                    Duration = 101, 
                    Year = "2020", 
                    Description = "A physician, who can speak with animals, is summoned by the queen to find a cure for her " +
                    "life-threatening disease. Soon, he embarks on a journey with his furry friends in search of a healing tree." 
                },
                new Movie 
                { 
                    Id = 8, 
                    Title = "Doctor Strange in the Multiverse of Madness", 
                    AgeLimit = 12, 
                    Duration = 187, 
                    Year = "2022", 
                    Description = "Dr Stephen Strange casts a forbidden spell that opens a portal to the multiverse. However, " +
                    "a threat emerges that may be too big for his team to handle." 
                },
                new Movie 
                { 
                    Id = 9, 
                    Title = "The Mauritanian", 
                    AgeLimit = 16, 
                    Duration = 129, 
                    Year = "2021", 
                    Description = "A defence attorney, her associate, and a military prosecutor uncover a far-reaching conspiracy " +
                    "while investigating the case of a suspected 9/11 terrorist imprisoned at Guantanamo Bay, Cuba, for six years." 
                },
                new Movie 
                { 
                    Id = 10, 
                    Title = "The Hobbit: The Battle of the Five Armies", 
                    AgeLimit = 16, 
                    Duration = 138, 
                    Year = "2014", 
                    Description = "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects " +
                    "the Lonely Mountain after a conflict arises." 
                },
                new Movie 
                { 
                    Id = 11, 
                    Title = "Snowpiercer", 
                    AgeLimit = 14, 
                    Duration = 125, 
                    Year = "2013", 
                    Description = "Set more than seven years after the world has become a frozen wasteland, this series centres " +
                    "on the remaining people, who inhabit a gigantic, perpetually-moving train that circles the globe." 
                }
            };

            List<Actor> actors = new List<Actor>
            {
                new Actor 
                { 
                    Id = 1, 
                    FirstName = "Robert", 
                    LastName = "Downey Jr.", 
                    Description = "Robert John Downey Jr. is an American actor and producer. His career has been " +
                    "characterized by critical and popular success in his youth, followed by a period of substance " +
                    "abuse and legal troubles, before a resurgence of commercial success later in his career."
                },
                new Actor 
                { 
                    Id = 2, 
                    FirstName = "Chris", 
                    LastName = "Hemsworth", 
                    Description = "Christopher Hemsworth AM is an Australian actor. He rose to prominence playing Kim " +
                    "Hyde in the Australian television series Home and Away before beginning a film career in Hollywood." 
                },
                new Actor 
                { 
                    Id = 3, 
                    FirstName = "Mark", 
                    LastName = "Ruffalo", 
                    Description = "Mark Alan Ruffalo is an American actor. He began acting in the early 1990s and first " +
                    "gained recognition for his work in Kenneth Lonergan's play This Is Our Youth and drama film You Can " +
                    "Count On Me." 
                },
                new Actor 
                {
                    Id = 4, 
                    FirstName = "Chris", 
                    LastName = "Evans", 
                    Description = "Christopher Robert Evans is an American actor. He began his career with roles in " +
                    "television series, such as in Opposite Sex in 2000." 
                },
                new Actor 
                { 
                    Id = 5, 
                    FirstName = "Benedict", 
                    LastName = "Cumberbatch", 
                    Description = "Benedict Timothy Carlton Cumberbatch CBE is an English actor. Known for his work " +
                    "on screen and stage, he has received various accolades, including a British Academy Television Award," +
                    " a Primetime Emmy" 
                },
                new Actor 
                { 
                    Id = 6, 
                    FirstName = "Tom", 
                    LastName = "Holland", 
                    Description = "Thomas Stanley Holland is an English actor. His accolades include a British Academy " +
                    "Film Award, three Saturn Awards, a Guinness World Record and an appearance on the Forbes 30 Under " +
                    "30 Europe list. Some publications have called him one of the most popular actors of his generation." 
                }
            };

            List<Profession> professions = new List<Profession> 
            {
                new Profession { Id = 1, Name = "Actor" },
                new Profession { Id = 2, Name = "Producer" },
                new Profession { Id = 3, Name = "Director" },
                new Profession { Id = 4, Name = "Screenwriter" }
            };

            List<Genre> genres = new List<Genre> 
            {
                new Genre { Id = 1, Name = "Adventure" },
                new Genre { Id = 2, Name = "Action movie" },
                new Genre { Id = 3, Name = "Thriller" },
                new Genre { Id = 4, Name = "Comedy" },
                new Genre { Id = 5, Name = "Fantastic" },
                new Genre { Id = 6, Name = "Fantasy" },
                new Genre { Id = 7, Name = "Detective" },
                new Genre { Id = 8, Name = "Family" },
                new Genre { Id = 9, Name = "Horror" },
                new Genre { Id = 10, Name = "Drama" }
            };

            List<Rating> ratings = new List<Rating> 
            {
                new Rating { Id = 1, Name = "IMDB", Mark = 8.2, MovieId = 1 },
                new Rating { Id = 2, Name = "MGG", Mark = 7.4, MovieId = 1 },
                new Rating { Id = 3, Name = "IMDB", Mark = 7.0, MovieId = 2 },
                new Rating { Id = 4, Name = "Metacritic", Mark = 5.6, MovieId = 2 },
                new Rating { Id = 5, Name = "Netflix", Mark = 6.3, MovieId = 2 },
                new Rating { Id = 6, Name = "IMDB", Mark = 4.4, MovieId = 3 },
                new Rating { Id = 7, Name = "MGG", Mark = 8.5, MovieId = 2 },
                new Rating { Id = 8, Name = "IMDB", Mark = 9.1, MovieId = 4 },
                new Rating { Id = 9, Name = "IMDB", Mark = 8.2, MovieId = 5 },
                new Rating { Id = 10, Name = "IMDB", Mark = 5.6, MovieId = 6 },
                new Rating { Id = 11, Name = "Metacritic", Mark = 4.3, MovieId = 9 },
                new Rating { Id = 12, Name = "MGG", Mark = 9.6, MovieId = 10 },
                new Rating { Id = 13, Name = "Metacritic", Mark = 6.8, MovieId = 11 },
                new Rating { Id = 14, Name = "Netflix", Mark = 8.1, MovieId = 9 },
                new Rating { Id = 15, Name = "IMDB", Mark = 4.5, MovieId = 7 },
                new Rating { Id = 16, Name = "Metacritic", Mark = 5.2, MovieId = 10 },
                new Rating { Id = 17, Name = "IMDB", Mark = 8.2, MovieId = 8 },
                new Rating { Id = 18, Name = "MGG", Mark = 7.5, MovieId = 3 },
            };

            List<ActorProfession> actorProfessions = new List<ActorProfession>
            {
                new ActorProfession { ActorId = 1, ProfessionId = 1 },
                new ActorProfession { ActorId = 1, ProfessionId = 2 },
                new ActorProfession { ActorId = 1, ProfessionId = 4 },
                new ActorProfession { ActorId = 2, ProfessionId = 1 },
                new ActorProfession { ActorId = 3, ProfessionId = 1 },
                new ActorProfession { ActorId = 3, ProfessionId = 2 },
                new ActorProfession { ActorId = 3, ProfessionId = 3 },
                new ActorProfession { ActorId = 3, ProfessionId = 4 },
                new ActorProfession { ActorId = 4, ProfessionId = 1 },
                new ActorProfession { ActorId = 4, ProfessionId = 2 },
                new ActorProfession { ActorId = 4, ProfessionId = 3 },
                new ActorProfession { ActorId = 5, ProfessionId = 1 },
                new ActorProfession { ActorId = 6, ProfessionId = 1 },
                new ActorProfession { ActorId = 6, ProfessionId = 3 },
            };

            List<MovieGenre> movieGenres = new List<MovieGenre>
            {
                new MovieGenre { MovieId = 1, GenreId = 1 },
                new MovieGenre { MovieId = 1, GenreId = 2 },
                new MovieGenre { MovieId = 1, GenreId = 4 },
                new MovieGenre { MovieId = 1, GenreId = 5 },
                new MovieGenre { MovieId = 1, GenreId = 6 },
                new MovieGenre { MovieId = 2, GenreId = 2 },
                new MovieGenre { MovieId = 2, GenreId = 5 },
                new MovieGenre { MovieId = 3, GenreId = 1 },
                new MovieGenre { MovieId = 3, GenreId = 2 },
                new MovieGenre { MovieId = 3, GenreId = 5 },
                new MovieGenre { MovieId = 4, GenreId = 1 },
                new MovieGenre { MovieId = 4, GenreId = 2 },
                new MovieGenre { MovieId = 5, GenreId = 2 },
                new MovieGenre { MovieId = 5, GenreId = 5 },
                new MovieGenre { MovieId = 6, GenreId = 3 },
                new MovieGenre { MovieId = 6, GenreId = 7 },
                new MovieGenre { MovieId = 7, GenreId = 4 },
                new MovieGenre { MovieId = 7, GenreId = 6 },
                new MovieGenre { MovieId = 7, GenreId = 8 },
                new MovieGenre { MovieId = 8, GenreId = 1 },
                new MovieGenre { MovieId = 8, GenreId = 2 },
                new MovieGenre { MovieId = 8, GenreId = 5 },
                new MovieGenre { MovieId = 8, GenreId = 6 },
                new MovieGenre { MovieId = 8, GenreId = 9 },
                new MovieGenre { MovieId = 9, GenreId = 3 },
                new MovieGenre { MovieId = 9, GenreId = 10 },
                new MovieGenre { MovieId = 10, GenreId = 1 },
                new MovieGenre { MovieId = 10, GenreId = 6 },
                new MovieGenre { MovieId = 11, GenreId = 2 },
                new MovieGenre { MovieId = 11, GenreId = 5 },
                new MovieGenre { MovieId = 11, GenreId = 10 }
            };

            List<MovieActor> movieActors = new List<MovieActor>
            {
                new MovieActor { MovieId = 1, ActorId = 2 },
                new MovieActor { MovieId = 1, ActorId = 3 },
                new MovieActor { MovieId = 1, ActorId = 5 },
                new MovieActor { MovieId = 2, ActorId = 1 },
                new MovieActor { MovieId = 2, ActorId = 2 },
                new MovieActor { MovieId = 2, ActorId = 3 },
                new MovieActor { MovieId = 2, ActorId = 4 },
                new MovieActor { MovieId = 2, ActorId = 5 },
                new MovieActor { MovieId = 3, ActorId = 5 },
                new MovieActor { MovieId = 3, ActorId = 6 },
                new MovieActor { MovieId = 4, ActorId = 6 },
                new MovieActor { MovieId = 5, ActorId = 1 },
                new MovieActor { MovieId = 5, ActorId = 4 },
                new MovieActor { MovieId = 5, ActorId = 6 },
                new MovieActor { MovieId = 6, ActorId = 1 },
                new MovieActor { MovieId = 7, ActorId = 1 },
                new MovieActor { MovieId = 8, ActorId = 5 },
                new MovieActor { MovieId = 8, ActorId = 6 },
                new MovieActor { MovieId = 9, ActorId = 5 },
                new MovieActor { MovieId = 10, ActorId = 5 },
                new MovieActor { MovieId = 11, ActorId = 4 },
            };

            modelBuilder.Entity<Actor>().HasData(actors);
            modelBuilder.Entity<Genre>().HasData(genres);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Profession>().HasData(professions);
            modelBuilder.Entity<Rating>().HasData(ratings);
            modelBuilder.Entity<ActorProfession>().HasData(actorProfessions);
            modelBuilder.Entity<MovieGenre>().HasData(movieGenres);
            modelBuilder.Entity<MovieActor>().HasData(movieActors);
        }
    }
}