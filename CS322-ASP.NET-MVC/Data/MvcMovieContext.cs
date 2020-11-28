using CS322_ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;


namespace CS322_ASP.NET_MVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
