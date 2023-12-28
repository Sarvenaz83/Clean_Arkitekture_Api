using Domain.Models.Animal.BirdModel;
using Domain.Models.Animal.CatModel;
using Domain.Models.Animal.DogModel;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.DatabaseSeedAnimal
{
    public class AnimalSeeder
    {
        public static void SeedAnimals(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bird>().HasData(
                new Bird { Id = Guid.NewGuid(), Name = "Bird1", CanFly = true, Color = "Red" },
                new Bird { Id = Guid.NewGuid(), Name = "Bird2", CanFly = false, Color = "Blue" },
                new Bird { Id = Guid.NewGuid(), Name = "Bird3", CanFly = true, Color = "Green" },
                new Bird { Id = Guid.NewGuid(), Name = "Bird4", CanFly = false, Color = "Yellow" }
                );

            modelBuilder.Entity<Cat>().HasData(
                new Cat { Id = Guid.NewGuid(), Name = "Cat1", LikesToPlay = true, Breed = "Breed1", Weight = 1 },
                new Cat { Id = Guid.NewGuid(), Name = "Cat2", LikesToPlay = false, Breed = "Breed2", Weight = 2 },
                new Cat { Id = Guid.NewGuid(), Name = "Cat3", LikesToPlay = true, Breed = "Breed3", Weight = 3 },
                new Cat { Id = Guid.NewGuid(), Name = "Cat4", LikesToPlay = false, Breed = "Breed4", Weight = 4 }

                );
            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Dog1", Breed = "Breed1", Weight = 1 },
                new Dog { Id = Guid.NewGuid(), Name = "Dog2", Breed = "Breed2", Weight = 2 },
                new Dog { Id = Guid.NewGuid(), Name = "Dog3", Breed = "Breed3", Weight = 3 },
                new Dog { Id = Guid.NewGuid(), Name = "Dog4", Breed = "Breed4", Weight = 4 }
                                                                                                      );
        }
    }
}
