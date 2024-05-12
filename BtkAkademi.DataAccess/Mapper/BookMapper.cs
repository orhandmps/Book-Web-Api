using BtkAkademi.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BtkAkademi.DataAccess.Mapper
{
    public class BookMapper : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //builder.ToTable("TBL_BOOKS").HasKey(t => t.Id);
            //builder.Property(t => t.Title).HasColumnName("TITLE").IsRequired().HasMaxLength(250);

            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "Orhan",
                    Price = 375
                },
                new Book
                {
                    Id = 2,
                    Title = "Kardi",
                    Price = 275
                },
                new Book
                {
                    Id = 3,
                    Title = "Karaca",
                    Price = 175
                }
                );
        }
    }
}
