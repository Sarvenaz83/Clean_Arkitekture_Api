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
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Bird1", CanFly = true, Color = "Red" },
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Bird2", CanFly = false, Color = "Blue" },
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Bird3", CanFly = true, Color = "Green" },
                new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Bird4", CanFly = false, Color = "Yellow" }
                );

            modelBuilder.Entity<Cat>().HasData(
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Cat1", LikesToPlay = true, Breed = "Breed1", Weight = 1 },
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Cat2", LikesToPlay = false, Breed = "Breed2", Weight = 2 },
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Cat3", LikesToPlay = true, Breed = "Breed3", Weight = 3 },
                new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Cat4", LikesToPlay = false, Breed = "Breed4", Weight = 4 }

                );
            modelBuilder.Entity<Dog>().HasData(
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Dog1", Breed = "Breed1", Weight = 1 },
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Dog2", Breed = "Breed2", Weight = 2 },
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Dog3", Breed = "Breed3", Weight = 3 },
                new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Dog4", Breed = "Breed4", Weight = 4 }
                                                                                                      );
        }
    }
}
