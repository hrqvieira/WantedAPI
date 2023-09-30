using HTTPCLIENT.Models;
using Microsoft.EntityFrameworkCore;


namespace HTTPCLIENT
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Wanted> Wanteds { get; set; }
    }
}
