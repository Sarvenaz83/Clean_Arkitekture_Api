using Domain.Models.Animal.BirdModel;
using Domain.Models.Animal.CatModel;
using Domain.Models.Animal.DogModel;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        //Dogs in mockDatabase
        public List<Dog> Dogs
        {
            get { return allDogs; }
            set { allDogs = value; }
        }

        private static List<Dog> allDogs = new()
        {
            new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Björn"},
            new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Patrik"},
            new Dog { AnimalId = Guid.NewGuid(), AnimalName = "Alfred"},
            new Dog { AnimalId = new Guid("12345678-1234-5678-1234-567812345678"), AnimalName = "TestDogForUnitTests"}
        };

        //Cats in mockDatabase
        public List<Cat> Cats
        {
            get { return allCats; }
            set { allCats = value; }
        }

        private static List<Cat> allCats = new()
        {
            new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Simba", LikesToPlay = true },
            new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Sezar", LikesToPlay = false },
            new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Micky", LikesToPlay= false },
            new Cat { AnimalId = Guid.NewGuid(), AnimalName = "Mini", LikesToPlay = true},
            new Cat { AnimalId = new Guid("09876543-1234-0987-6543-098765432109"), AnimalName = "TestCatForUnitTests"}
        };

        //Birds in mockDatabase
        public List<Bird> Birds
        {
            get { return allBirds; }
            set { allBirds = value; }
        }

        private static List<Bird> allBirds = new()
        {
            new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Doodoo", CanFly = true },
            new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Didi", CanFly = false },
            new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Dada", CanFly = true },
            new Bird { AnimalId = Guid.NewGuid(), AnimalName = "Booboo", CanFly = false },
            new Bird { AnimalId = new Guid("98765432-6543-6789-9867-987654567890"), AnimalName ="TestBirdForUnitTests"}

        };

    }
}
