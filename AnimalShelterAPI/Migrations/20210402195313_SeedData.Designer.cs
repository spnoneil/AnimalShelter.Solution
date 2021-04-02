﻿// <auto-generated />
using System;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20210402195313_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = 1,
                            Breed = "American Shorthair",
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Prof. Stankpawz"
                        },
                        new
                        {
                            CatId = 2,
                            Age = 5,
                            Breed = "Abyssian",
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = "Princess P"
                        },
                        new
                        {
                            CatId = 3,
                            Age = 8,
                            Breed = "Persian",
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = "Floofybooty"
                        },
                        new
                        {
                            CatId = 4,
                            Age = 3,
                            Breed = "Manx",
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Sir Ratdeath"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = 10,
                            Breed = "Labrador",
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Destructo"
                        },
                        new
                        {
                            DogId = 2,
                            Age = 2,
                            Breed = "Scottish Terrier",
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = "Devin The Dog"
                        },
                        new
                        {
                            DogId = 3,
                            Age = 3,
                            Breed = "Chi-weenie",
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Rolf"
                        },
                        new
                        {
                            DogId = 4,
                            Age = 2,
                            Breed = "Shih-tzu",
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Beavis"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.OtherAnimal", b =>
                {
                    b.Property<int>("OtherAnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("OtherAnimalId");

                    b.ToTable("OtherAnimals");

                    b.HasData(
                        new
                        {
                            OtherAnimalId = 1,
                            Age = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "hard to tell",
                            Name = "Billy the Squid",
                            Type = "Octopus"
                        },
                        new
                        {
                            OtherAnimalId = 2,
                            Age = 1,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "SQUAAARK!",
                            Type = "Parrot or something"
                        },
                        new
                        {
                            OtherAnimalId = 3,
                            Age = 1,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = ".NET",
                            Type = "Tarantula"
                        },
                        new
                        {
                            OtherAnimalId = 4,
                            Age = 1000,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "previously male",
                            Name = "Resident Steve-il",
                            Type = "Zombie"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
