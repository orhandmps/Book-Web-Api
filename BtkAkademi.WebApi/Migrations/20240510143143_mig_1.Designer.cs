﻿// <auto-generated />
using BtkAkademi.WebApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BtkAkademi.WebApi.Migrations
{
    [DbContext(typeof(BtkContext))]
    [Migration("20240510143143_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BtkAkademi.WebApi.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TITLE");

                    b.HasKey("Id");

                    b.ToTable("TBL_BOOKS", (string)null);

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
