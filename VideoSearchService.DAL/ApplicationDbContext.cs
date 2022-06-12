using Microsoft.EntityFrameworkCore;
using VideoSearchService.Data.Models;

namespace VideoSearchService.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ActorProfession> ActorProfessions { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorProfession>()
                .HasKey(ap => new { ap.ActorId, ap.ProfessionId });
            modelBuilder.Entity<ActorProfession>()
                .HasOne(ap => ap.Actor)
                .WithMany(p => p.ActorProfessions)
                .HasForeignKey(p => p.ProfessionId);
            modelBuilder.Entity<ActorProfession>()
                .HasOne(ap => ap.Profession)
                .WithMany(p => p.ActorProfessions)
                .HasForeignKey(p => p.ActorId);

            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new { mg.MovieId, mg.GenreId});
            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(g => g.GenreId);
            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(g => g.MovieId);

            modelBuilder.Entity<MovieActor>()
                .HasKey(ma => new { ma.MovieId, ma.ActorId });
            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Actor)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(a => a.MovieId);
            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Movie)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(a => a.ActorId);

            modelBuilder.Seed();
        }
    }
}
