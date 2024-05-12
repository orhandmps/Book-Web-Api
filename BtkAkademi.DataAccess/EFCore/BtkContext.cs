using BtkAkademi.DataAccess.Mapper;
using BtkAkademi.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademi.DataAccess.EFCore
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
