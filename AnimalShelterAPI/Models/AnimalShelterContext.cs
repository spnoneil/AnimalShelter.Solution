using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }

    public DbSet<OtherAnimal> OtherAnimals { get; set; }
    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
            .HasData(
              new Cat { CatId = 1, Name = "Prof. Stankpawz", Breed = "American Shorthair", Age = 1, Gender = "Male" },
              new Cat { CatId = 2, Name = "Princess P", Breed = "Abyssian", Age = 5, Gender = "Female" },
              new Cat { CatId = 3, Name = "Floofybooty", Breed = "Persian", Age = 8, Gender = "Female" },
              new Cat { CatId = 4, Name = "Sir Ratdeath", Breed = "Manx", Age = 3, Gender = "Male" }
            );
      builder.Entity<Dog>()
            .HasData(
              new Dog { DogId = 1, Name = "Destructo", Breed = "Labrador", Age = 10, Gender = "Male" },
              new Dog { DogId = 2, Name = "Devin The Dog", Breed = "Scottish Terrier", Age = 2, Gender = "Female" },
              new Dog { DogId = 3, Name = "Rolf", Breed = "Chi-weenie", Age = 3, Gender = "Male" },
              new Dog { DogId = 4, Name = "Beavis", Breed = "Shih-tzu", Age = 2, Gender = "Male" }
            );
      builder.Entity<OtherAnimal>()
            .HasData(
              new OtherAnimal { OtherAnimalId = 1, Name = "Billy the Squid", Type = "Octopus", Age = 4, Gender = "hard to tell" },
              new OtherAnimal { OtherAnimalId = 2, Name = "SQUAAARK!", Type = "Parrot or something", Age = 1, Gender = "Male" },
              new OtherAnimal { OtherAnimalId = 3, Name = ".NET", Type = "Tarantula", Age = 1, Gender = "Female" },
              new OtherAnimal { OtherAnimalId = 4, Name = "Resident Steve-il", Type = "Zombie", Age = 1000, Gender = "previously male" }
            );
    }
  }
}