﻿// <auto-generated />
using BtkAkademi.DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BtkAkademi.DataAccess.Migrations
{
    [DbContext(typeof(BtkContext))]
    [Migration("20240511224411_i")]
    partial class i
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BtkAkademi.Domain.Entites.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 375m,
                            Title = "Orhan"
                        },
                        new
                        {
                            Id = 2,
                            Price = 275m,
                            Title = "Kardi"
                        },
                        new
                        {
                            Id = 3,
                            Price = 175m,
                            Title = "Karaca"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
