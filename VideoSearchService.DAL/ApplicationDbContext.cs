using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VideoSearchService.Data.Models;

namespace VideoSearchService.DAL
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Actor> Actors { get; set; }
        DbSet<Profession> Professions { get; set; }
        DbSet<Rating> Ratings { get; set; }
        DbSet<Genre> Genres { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
