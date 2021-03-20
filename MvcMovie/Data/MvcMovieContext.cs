using System;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseNpgsql("Host=localhost;Database=tiffka;Username=tiffka;");
             optionsBuilder.LogTo(Console.WriteLine);
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
