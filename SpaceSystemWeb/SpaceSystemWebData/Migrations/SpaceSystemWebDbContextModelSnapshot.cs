﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceSystemWebData;

#nullable disable

namespace SpaceSystemWebData.Migrations
{
    [DbContext(typeof(SpaceSystemWebDbContext))]
    partial class SpaceSystemWebDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SpaceSystemWebModels.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BoughtId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("GravitationalPull")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int>("Moons")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrbitInDays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BoughtId = 0,
                            CustomerId = 0,
                            GravitationalPull = 3.7m,
                            Moons = 0,
                            Name = "Mercury",
                            OrbitInDays = 88
                        },
                        new
                        {
                            Id = 2,
                            BoughtId = 0,
                            CustomerId = 0,
                            GravitationalPull = 8.9m,
                            Moons = 0,
                            Name = "Venus",
                            OrbitInDays = 225
                        },
                        new
                        {
                            Id = 3,
                            BoughtId = 0,
                            CustomerId = 0,
                            GravitationalPull = 9.8m,
                            Moons = 1,
                            Name = "Earth",
                            OrbitInDays = 365
                        },
                        new
                        {
                            Id = 4,
                            BoughtId = 0,
                            CustomerId = 0,
                            GravitationalPull = 3.7m,
                            Moons = 2,
                            Name = "Mars",
                            OrbitInDays = 687
                        },
                        new
                        {
                            Id = 5,
                            BoughtId = 0,
                            CustomerId = 0,
                            GravitationalPull = 23.1m,
                            Moons = 57,
                            Name = "Jupiter",
                            OrbitInDays = 4333
                        },
                        new
                        {
                            Id = 6,
                            BoughtId = 0,
                            CustomerId = 0,
                            GravitationalPull = 9m,
                            Moons = 63,
                            Name = "Saturn",
                            OrbitInDays = 10759
                        },
                        new
                        {
                            Id = 7,
                            BoughtId = 0,
                            CustomerId = 0,
                            GravitationalPull = 8.7m,
                            Moons = 27,
                            Name = "Uranus",
                            OrbitInDays = 30687
                        },
                        new
                        {
                            Id = 8,
                            BoughtId = 0,
                            CustomerId = 0,
                            GravitationalPull = 11m,
                            Moons = 14,
                            Name = "Neptune",
                            OrbitInDays = 60190
                        });
                });

            modelBuilder.Entity("SpaceSystemWebModels.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BoughtId")
                        .HasColumnType("int");

                    b.Property<decimal>("Brightness")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BoughtId = 0,
                            Brightness = -26.74m,
                            CustomerId = 0,
                            Name = "Sun",
                            Temperature = 5778
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
