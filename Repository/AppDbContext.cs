
using Microsoft.EntityFrameworkCore;
using TestAppWeb.Model;

namespace WebAppRazorPages.Controller
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Marlboro> Cigarett { get; set; }

    }
}