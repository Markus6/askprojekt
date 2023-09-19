﻿// <auto-generated />
using ASKProjekt.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASKProjekt.Server.Migrations
{
    [DbContext(typeof(GlosorDbContext))]
    partial class GlosorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASKProjekt.Shared.Models.GlosaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Language1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Glosor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Language1 = "Hej",
                            Language2 = "Hello"
                        },
                        new
                        {
                            Id = 2,
                            Language1 = "Hejdå",
                            Language2 = "Goodbye"
                        },
                        new
                        {
                            Id = 3,
                            Language1 = "Komma ihåg",
                            Language2 = "Remember"
                        },
                        new
                        {
                            Id = 4,
                            Language1 = "Idag",
                            Language2 = "Today"
                        },
                        new
                        {
                            Id = 5,
                            Language1 = "Imorgon",
                            Language2 = "Tomorrow"
                        },
                        new
                        {
                            Id = 6,
                            Language1 = "Igår",
                            Language2 = "Yesterday"
                        },
                        new
                        {
                            Id = 7,
                            Language1 = "Springa",
                            Language2 = "Run"
                        },
                        new
                        {
                            Id = 8,
                            Language1 = "Gå",
                            Language2 = "Walk"
                        },
                        new
                        {
                            Id = 9,
                            Language1 = "Moln",
                            Language2 = "Cloud"
                        },
                        new
                        {
                            Id = 10,
                            Language1 = "Sol",
                            Language2 = "Sun"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
