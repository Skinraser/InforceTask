using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class UrlsDBContext : DbContext
    {
        public UrlsDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Url> Urls { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}