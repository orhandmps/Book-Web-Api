using BtkAkademi.WebApi.Models;
using BtkAkademi.WebApi.Repositories.Mapper;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademi.WebApi.Repositories
{
    public class BtkContext : DbContext
    {
        public BtkContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMapper());
        }

        public DbSet<Book> Books { get; set; }
    }
}
